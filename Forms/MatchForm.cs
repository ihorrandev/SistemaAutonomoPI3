using AutoSystem_KingMe.Models;
using AutoSystem_KingMe.Models.Common;
using AutoSystem_KingMe.Services;
using KingMeServer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace AutoSystem_KingMe.Forms
{
    public partial class MatchForm : Form
    {
        #region Campos privados
        private readonly string _matchId;
        private static string mensagemCompartilhada;
        private readonly string _estadoJogoPath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "Forms", "game_state.txt");
        private readonly object lockAtualizacao = new object();
        private Dictionary<int, int> contadorImagensPorSetor = new Dictionary<int, int>();
        string statusRodada;
        int? qtdNao = null;


        private List<string> imagensPosicionadas = new List<string>();
        private bool esconder = false;
        #endregion

        #region Propriedades públicas
        public readonly PlayerOnGameEntity PlayerOnGame;
        public List<CheckTimeEntity> CheckTime { get; set; }
        public List<CharacterEntity> Personagens { get; set; }
        public List<PlayerEntity> Players { get; set; }
        #endregion

        #region Estruturas auxiliares
        private Dictionary<int, Point> setores = new Dictionary<int, Point>
        {
            { 0, new Point(603, 661) }, { 1, new Point(603, 603) },
            { 2, new Point(603, 533) }, { 3, new Point(603, 461) },
            { 4, new Point(603, 395) }, { 5, new Point(603, 331) },
            { 10, new Point(699, 264) }
        };

        private Dictionary<int, List<PictureBox>> imagensPorSetor = new Dictionary<int, List<PictureBox>>();
        #endregion

        #region Construtor
        public MatchForm(PlayerOnGameEntity player, string matchId)
        {
            PlayerOnGame = player;
            PlayerOnGame.Status = "AGUARDANDO";
            _matchId = matchId;

            InitializeComponent();


            var getPlayersResponse = PlayerService.GetPlayers(_matchId);
            Players = getPlayersResponse.Entities;

            var playerName = Players.FirstOrDefault(x => x.Id == player.Id);
            lblJogador.Text = $"Jogador: {playerName.Name}";

            this.FormClosing += MatchForm_FormClosing;
            timer1.Start();
        }
        #endregion

        #region Botões principais

        private void btnIniciarPartida_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_matchId))
            {
                btnIniciarPartida.Visible = false;
                lblIniciouPartida.Visible = true;
                lblIniciouPartida.Text = "Partida não pode ser inciada! Sem referência de ID";
                return;
            }

            IniciarPartida();
        }
    
        public void IniciarPartida()
        {
            string gameResponse = MatchService.StartGame(PlayerOnGame);
            if (gameResponse.StartsWith("ERRO:"))
            {
                statusRodada = gameResponse;
                return;
            }

            lblIniciouPartida.Visible = true;
            btnIniciarPartida.Visible = false;

            var initGameResponse = PlayerService.GetPlayers(_matchId);
            if (initGameResponse.IsSuccess)
            {
                Players = initGameResponse.Entities;
                var playerTurn = Players.FirstOrDefault(x => x.Id == gameResponse);
                mensagemCompartilhada = "Partida Iniciada! Vez do jogador: " + playerTurn.Name;

                statusRodada = "Setup";
            }
        }

        private void btnVerFavoritos_Click(object sender, EventArgs e)
        {
            lblListaFavoritos.Visible = true;
            if (esconder)
            {
                lblListaFavoritos.Text = "Lista de favoritos: ";
                btnVerFavoritos.Text = "Favoritos";
                esconder = false;
            }
            else
            {
                int playerId = Convert.ToInt32(PlayerOnGame.Id);
                string favorites = PlayerService.GetFavorites(playerId, PlayerOnGame.Password);

                lblListaFavoritos.Text = "Lista de favoritos: " + favorites;
                btnVerFavoritos.Text = "Esconder lista de favoritos";
                esconder = true;
            }
        }

        private void btnVerificarVez_Click(object sender, EventArgs e)
        {
            CheckTime = MatchService.CheckTime(_matchId).Entities;
            Players = PlayerService.GetPlayers(_matchId).Entities;

            var checkPlayerTurn = Players.FirstOrDefault(x => x.Id == CheckTime.First().PlayerId);
            if (checkPlayerTurn != null)
                lblVezJogador.Text = $"Vez do jogador {checkPlayerTurn.Name} - ID: {checkPlayerTurn.Id}";
        }

        private void verificarVez()
        {
            CheckTime = MatchService.CheckTime(_matchId).Entities;
            Players = PlayerService.GetPlayers(_matchId).Entities;

            var checkPlayerTurn = Players.FirstOrDefault(x => x.Id == CheckTime.First().PlayerId);
            if (checkPlayerTurn != null)
                lblVezJogador.Text = $"Vez do jogador {checkPlayerTurn.Name} - ID: {checkPlayerTurn.Id}";
        }

        private void btnPosicionarPersonagem_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txbSetor.Text.Trim(), out int setor))
            {
                MessageBox.Show("Setor inválido.");
                return;
            }

            string letra = txbPersonagem.Text.Trim().ToUpper();
            PosicionarPersonagem(setor, letra);
        }

        public void PosicionarPersonagem(int setor, string letra)
        {
            var retorno = MatchService.PutCharacter(PlayerOnGame, setor.ToString(), letra);
            if (retorno.IsSuccess)
            {
                lblMenssagemErro.Text = string.Empty;

                if (retorno.Entities != null && retorno.Entities.Any())
                {
                    foreach (var personagem in retorno.Entities)
                    {
                        string sector = personagem.Sector;
                        string letraPersonagem = personagem.Character;
                        SalvarEstadoJogoComString(letraPersonagem, sector);
                        verificarVez();
                    }
                }
            }
            else
            {
                lblMenssagemErro.Text = retorno.ErrorMessage;
            }
        }


        private void btnPromoverPersonagem_Click(object sender, EventArgs e)
        {
            string letra = txbPersonagem.Text.Trim().ToUpper();
            var retorno = MatchService.promotionCharacter(PlayerOnGame, letra);
            Personagens = retorno.Entities;

            if (!retorno.IsSuccess)
            {
                lblMenssagemErro.Text = retorno.ErrorMessage;
                return;
            }

            statusRodada = "Setup";
            foreach (var personagem in Personagens)
            {
                string letraPersonagem = personagem.Character;
                string setor = personagem.Sector;

                if (letraPersonagem != null && setor != null)
                {
                    SalvarEstadoJogoComString(letraPersonagem, setor);
                    CarregarEstadoJogo();
                    verificarVez();
                }
            }
        }

        #endregion

        #region Lógica de Timer (status da partida)

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            try
            {
                string status = MatchService.GetStatus(PlayerOnGame.Status);

                if (status == "INICIADA")
                {
                    btnIniciarPartida.Visible = false;
                    lblIniciouPartida.Visible = true;
                    lblIniciouPartida.Text = mensagemCompartilhada;
                    lblTextAcoes.Visible = true;
                    pnlAcoes.Visible = true;
                    btnVerFavoritos.Visible = true;
                    lblQuantidadeNao.Visible = true;
                    lblStatusRodada.Text = statusRodada;
                    QuantidadeNaos();
                    lblQuantidadeNao.Text = Convert.ToString(qtdNao);

                    MostrarTodasAsImagens();
                    CarregarEstadoJogo();

                    var time = MatchService.CheckTime(_matchId).Entities.FirstOrDefault();
                    if (time is not null)
                    {
                        if (time.Phase == "V" && time.PlayerId == PlayerOnGame.Id)
                        {
                            lblVotacao.Visible = true;
                            pnlVotacao.Visible = true;
                        }
                    }

                }
                else if (status == "ERRO")
                {
                    btnIniciarPartida.Visible = false;
                    lblIniciouPartida.Visible = true;
                    lblIniciouPartida.Text = "Erro ao iniciar a partida.";
                }
            }
            finally
            {
                timer1.Start();
            }
        }

        #endregion

        #region Métodos auxiliares

        private void MostrarTodasAsImagens()
        {
            foreach (Control control in this.Controls)
            {
                if (control is PictureBox pic && pic.Name.StartsWith("pic"))
                {
                    pic.Visible = true;
                }
            }
        }

        private void SalvarEstadoJogoComString(string letraPersonagem, string setor)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(letraPersonagem) || string.IsNullOrWhiteSpace(setor))
                {
                    return;
                }

                var linhas = new List<string>();

                if (File.Exists(_estadoJogoPath))
                {
                    var existentes = File.ReadAllLines(_estadoJogoPath);
                    foreach (var linha in existentes)
                    {
                        var partes = linha.Split(':');
                        if (partes.Length == 2)
                        {
                            string letraExistente = partes[0].Trim().ToUpper();
                            if (letraExistente != letraPersonagem.Trim().ToUpper())
                            {
                                linhas.Add(linha);
                            }
                        }
                    }
                }

                linhas.Add($"{letraPersonagem.Trim().ToUpper()}:{setor}");
                File.WriteAllLines(_estadoJogoPath, linhas);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar estado do jogo: {ex.Message}");
            }
        }



        private void LimparEstadoJogo()
        {
            try
            {
                File.WriteAllText(_estadoJogoPath, string.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao limpar o estado do jogo: {ex.Message}");
            }
        }


        private PictureBox EncontrarPictureBox(string letra)
        {
            string nome = "pic" + letra.ToUpper();
            return Controls.Find(nome, true).FirstOrDefault() as PictureBox;
        }

        private void CarregarEstadoJogo()
        {
            try
            {
                if (!File.Exists(_estadoJogoPath))
                    return;

                var linhas = File.ReadAllLines(_estadoJogoPath);
                contadorImagensPorSetor.Clear();

                foreach (var linha in linhas)
                {
                    var partes = linha.Split(':');
                    if (partes.Length != 2) continue;

                    string letra = partes[0].Trim().ToUpper();
                    if (!int.TryParse(partes[1].Trim(), out int setor)) continue;
                    if (!setores.ContainsKey(setor)) continue;


                    if (!contadorImagensPorSetor.ContainsKey(setor))
                        contadorImagensPorSetor[setor] = 0;

                    int deslocamento = contadorImagensPorSetor[setor] * 30;
                    Point basePos = setores[setor];
                    Point novaPos = new Point(basePos.X + deslocamento, basePos.Y);

                    PictureBox pictureBox = EncontrarPictureBox(letra);
                    if (pictureBox != null)
                    {
                        pictureBox.Visible = true;
                        pictureBox.Location = novaPos;
                    }

                    contadorImagensPorSetor[setor]++;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar estado do jogo: {ex.Message}");
            }
        }

        private void QuantidadeNaos()
        {
            if (Players != null && qtdNao is null)
            {
                int quantidade = Players.Count;
                if (quantidade == 3)
                {
                    qtdNao = 4;
                }
                else if (quantidade == 4)
                {
                    qtdNao = 3;
                }
                else if (quantidade >= 5)
                {
                    qtdNao = 2;
                }
            }
        }


        #endregion

        #region Eventos do Formulário

        private void MatchForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Deseja realmente sair?", "Confirmação", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }

            File.WriteAllText(_estadoJogoPath, string.Empty);
            LimparEstadoJogo();
        }

        #endregion

        private void btnVotar_Click(object sender, EventArgs e)
        {
            bool aceito = rdoAceitarVotacao.Checked;
            string votacao = aceito ? "S" : "N";

            var votacaoResponse = Jogo.Votar(int.Parse(PlayerOnGame.Id), PlayerOnGame.Password, votacao);
            if (!votacaoResponse.StartsWith("ERRO"))
            {
                pnlVotacao.Visible = false;
                lblVotacao.Visible = false;

                if (!aceito) qtdNao--;
            }
        }

    }
}
