using AutoSystem_KingMe.Models;
using AutoSystem_KingMe.Models.Common;
using AutoSystem_KingMe.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace AutoSystem_KingMe.Forms
{
    public partial class MatchForm : Form
    {
        private readonly PlayerOnGameEntity _playerOnGame;
        private readonly string _matchId;
        private static string mensagemCompartilhada;
        private List<string> imagensPosicionadas = new List<string>();
        private readonly string _estadoJogoPath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "Forms", "game_state.txt");
        public List<CheckTimeEntity> CheckTime { get; set; }
        public List<CharacterEntity> Personagens { get; set; }

        public List<PlayerEntity> Players { get; set; }

        private Dictionary<int, Point> setores = new Dictionary<int, Point>
        {
            { 0, new Point(298, 339) },
            { 1, new Point(512, 339) },
            { 2, new Point(713, 339) },
            { 3, new Point(908, 339) },
            { 4, new Point(908, 170) },
            { 5, new Point(709, 170) },
            { 10, new Point(917, 21) }
        };

        private Dictionary<int, List<PictureBox>> imagensPorSetor = new Dictionary<int, List<PictureBox>>();

        public MatchForm(PlayerOnGameEntity player, string matchId)
        {
            _playerOnGame = player;
            player.Status = "AGUARDANDO";
            _matchId = matchId;

            var getPlayersResponse = PlayerService.GetPlayers(_matchId);
            Players = getPlayersResponse.Entities;
            var playerName = Players.FirstOrDefault(x => x.Id == player.Id);

            InitializeComponent();
            lblJogador.Text = $"Jogador: {playerName.Name}";
            timer1.Start();
            this.FormClosing += new FormClosingEventHandler(MatchForm_FormClosing);
        }

        private void btnIniciarPartida_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_matchId))
            {
                btnIniciarPartida.Visible = false;
                lblIniciouPartida.Visible = true;
                lblIniciouPartida.Text = "Partida não pode ser inciada! Sem referência de ID";
            }
            else
            {
                string gameResponse = MatchService.StartGame(_playerOnGame);
                if (gameResponse.StartsWith("ERRO:"))
                {
                    lblStatusRodada.Text = gameResponse;
                }
                else
                {
                    lblIniciouPartida.Visible = true;
                    var getPlayersResponse = PlayerService.GetPlayers(_matchId);
                    Players = getPlayersResponse.Entities;

                    var playerTurn = Players.FirstOrDefault(x => x.Id == gameResponse);
                    mensagemCompartilhada = "Partida Iniciada! Vez do jogador: " + playerTurn.Name;
                    LimparEstadoJogo();
                }
            }
        }

        private bool esconder = false;
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
                int playerId = Convert.ToInt32(_playerOnGame.Id);
                string favorites = PlayerService.GetFavorites(playerId, _playerOnGame.Password);
                lblListaFavoritos.Text = "Lista de favoritos: " + favorites;
                btnVerFavoritos.Text = "Esconder lista de favoritos";
                esconder = true;
            }
        }

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

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            try
            {
                string status = MatchService.GetStatus(_playerOnGame.Status);

                if (status == "INICIADA")
                {
                    btnIniciarPartida.Visible = false;
                    lblIniciouPartida.Visible = true;
                    lblIniciouPartida.Text = mensagemCompartilhada;
                    lblTextAcoes.Visible = true;
                    pnlAcoes.Visible = true;
                    btnVerFavoritos.Visible = true;
                    MostrarTodasAsImagens();

                    AtualizarPosicoesDoArquivo();
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


        private void btnPosicionarPersonagem_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txbSetor.Text.Trim(), out int setor))
            {
                string letra = txbPersonagem.Text.Trim().ToUpper();

                var retorno = MatchService.PutCharacter(_playerOnGame, txbSetor.Text, letra);

                if (retorno.IsSuccess)
                {
                    lblMenssagemErro.Text = string.Empty;
                    PlayerService.DefinirPosicao(_matchId, letra, setor);
                    MoverPersonagem(setor, letra);
                }
                else lblMenssagemErro.Text = $"{retorno.ErrorMessage}";
            }
            else
            {
                MessageBox.Show("Setor inválido.");
            }
        }

        private PictureBox EncontrarPictureBox(string letra)
        {
            string nome = "pic" + letra.ToUpper();
            return Controls.Find(nome, true).FirstOrDefault() as PictureBox;
        }

        private void MoverPersonagem(int setor, string letra)
        {
            letra = letra.Trim().ToUpper();

            if (string.IsNullOrEmpty(letra))
            {
                return;
            }


            if (setor == 0 || setor == 10)
            {
                return;
            }

            PictureBox pic = EncontrarPictureBox(letra);
            if (pic == null)
            {
                return;
            }


            foreach (var lista in imagensPorSetor.Values)
            {
                lista.Remove(pic);
            }


            if (!imagensPorSetor.ContainsKey(setor))
                imagensPorSetor[setor] = new List<PictureBox>();


            if (imagensPorSetor[setor].Count >= 4)
            {
                return;
            }


            imagensPorSetor[setor].Add(pic);

            Point baseLocation = setores[setor];
            int offsetX = imagensPorSetor[setor].IndexOf(pic) * 50;

            pic.Location = new Point(baseLocation.X + offsetX, baseLocation.Y);
            pic.Visible = true;

            if (!imagensPosicionadas.Contains(letra))
                imagensPosicionadas.Add(letra);

            VerificarPersonagemRestante();
            SalvarEstadoJogo(letra, setor);
        }

        private void SalvarEstadoJogo(string letra, int setor)
        {
            try
            {
                string linha = $"{letra}:{setor}";
                File.AppendAllLines(_estadoJogoPath, new[] { linha });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar estado do jogo: {ex.Message}");
            }
        }


        private void VerificarPersonagemRestante()
        {
            List<string> todasAsLetras = new List<string> { "A", "B", "C", "D", "E", "G", "H", "T", "R", "Q", "M", "L", "K" };
            List<string> letrasRestantes = todasAsLetras.Except(imagensPosicionadas).ToList();

            if (letrasRestantes.Count == 1)
            {
                string ultimaLetra = letrasRestantes[0];

                PlayerService.DefinirPosicao(_matchId, ultimaLetra, 0);

                PictureBox pic = EncontrarPictureBox(ultimaLetra);
                if (pic != null)
                {
                    Point posZero = setores[0];
                    pic.Location = posZero;
                    pic.Visible = true;


                    if (!imagensPorSetor.ContainsKey(0))
                        imagensPorSetor[0] = new List<PictureBox>();

                    imagensPorSetor[0].Add(pic);
                    imagensPosicionadas.Add(ultimaLetra);
                }
            }
        }

        private readonly object lockAtualizacao = new object();
        private void AtualizarPosicoesDoArquivo()
        {
            lock (lockAtualizacao)
            {
                if (!File.Exists(_estadoJogoPath))
                    return;

                var linhas = File.ReadAllLines(_estadoJogoPath).Distinct();

                foreach (var linha in linhas)
                {
                    var partes = linha.Split(':');
                    if (partes.Length == 2 && int.TryParse(partes[1], out int setor))
                    {
                        string letra = partes[0].Trim().ToUpper();

                        if (!imagensPosicionadas.Contains(letra))
                        {
                            MoverPersonagem(setor, letra);
                        }
                    }
                }

            }
        }

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

        private void btnVerficarVez_Click(object sender, EventArgs e)
        {
            var checkTimeResponse = MatchService.CheckTime(_matchId);
            CheckTime = checkTimeResponse.Entities;

            var getPlayersResponse = PlayerService.GetPlayers(_matchId);
            Players = getPlayersResponse.Entities;

            var checkPlayerTurn = Players.FirstOrDefault(x => x.Id == CheckTime.First().Id);
            if (checkPlayerTurn != null)
            {
                lblVezJogador.Text = $"Vez do jogador {checkPlayerTurn.Name} - ID: {checkPlayerTurn.Id}";
            }
            
        }

        private void btnPromoverPersonagem_Click(object sender, EventArgs e)
        {
            string letra = txbPersonagem.Text.Trim().ToUpper();
            var retorno = MatchService.promotionCharacter(_playerOnGame, letra);
            Personagens = retorno.Entities;

            if (!retorno.IsSuccess) lblMenssagemErro.Text = $"{retorno.ErrorMessage}";
            else
            {
                foreach (var personagem in Personagens)
                {
                    string letraPersonagem = personagem.Character;
                    string setor = personagem.Sector;

                    if (letraPersonagem != null && setor != null)
                    {
                        PlayerService.DefinirPosicao(_matchId, letraPersonagem, int.Parse(setor));
                        MoverPersonagem(int.Parse(setor), letraPersonagem);
                    }
                }
            }
        }
    }
}
