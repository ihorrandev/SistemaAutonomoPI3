using AutoSystem_KingMe.Forms;
using AutoSystem_KingMe.Models;
using AutoSystem_KingMe.Models.Constants;
using AutoSystem_KingMe.Services;
using KingMeServer;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace AutoSystem_KingMe
{
    public partial class LobbyForm : Form
    {
        public LobbyForm()
        {
            InitializeComponent();
            lbVersion.Text = $"{lbVersion.Text} {Jogo.versao}";
        }

        private void btnGetMatchs_Click(object sender, EventArgs e)
        {
            lblGetMatchesResponse.Text = string.Empty;
            lboMatchs.Items.Clear();

            string? statusSelected = cboMatchsStatus.SelectedItem?.ToString()?.Substring(0, 1);
            var gameResponse = MatchService.GetMatches(statusSelected);

            if (gameResponse.IsSuccess)
            {
                gameResponse.Entities!
                    .ForEach(match => lboMatchs.Items.Add(match));
            }
            else
            {
                lblGetMatchesResponse.Text = gameResponse.ErrorMessage;
            }
        }

        private void Lobby_Load(object sender, EventArgs e)
        {
            cboMatchsStatus.SelectedIndex = 0;
        }

        private void btnCreateMatch_Click(object sender, EventArgs e)
        {
            string name = txtBox_nomePartida.Text;
            string password = txtBox_senhaPartida.Text;
            string nameGroup = "Arqueiros de Azincourt";

            string gameResponse = MatchService.CreateMatch(name, password, nameGroup);
            string labelText = string.Empty;

            if (!gameResponse.StartsWith("ERRO")) labelText = $"ID da Partida: {gameResponse}";
            else labelText = $"{gameResponse}";

            lblCreationMatchResponse.Text = labelText;
        }

        private void btnListPlayers_Click(object sender, EventArgs e)
        {
            lboPlayers.Items.Clear();

            string strMatchId = txtBox_idPartida.Text;
            var gameResponse = PlayerService.GetPlayers(strMatchId);

            if (!gameResponse.IsSuccess)
            {
                lblListPlayerResponse.Text = $"{gameResponse.ErrorMessage}";
                return;
            }

            if (gameResponse.Entities.Any())
            {
                gameResponse.Entities!
                    .ForEach(player => lboPlayers.Items.Add(player));
            }
            else
            {
                lblListPlayerResponse.Text = $"Partida sem jogadores!";
            }
        }

        private void btnEnterMatch_Click(object sender, EventArgs e)
        {
            lblWarningError.Text = string.Empty;
            lblIdPlayer.Text = string.Empty;
            lblPasswordPlayer.Text = string.Empty;

            string strIdMatch = txtBox_IdMatch.Text;
            string namePlayer = txtBox_PlayerName.Text;
            string passwordMatch = txtBox_PasswordMatch.Text;

            EnterOnMatch(strIdMatch, namePlayer, passwordMatch);
        }

        private MatchForm? EnterOnMatch(string matchId, string namePlayer, string passwordMatch)
        {
            var gameResponse = MatchService.EnterMatch(matchId, namePlayer, passwordMatch);
            if (gameResponse.IsSuccess)
            {
                var player = gameResponse.Entities.FirstOrDefault();
                lblIdPlayer.Text = $"ID do Jogador: {player.Id}"; lblPasswordPlayer.Text = $"Senha do Jogador: {player.Password}";

                var matchForm = new MatchForm(player, matchId);
                matchForm.Show();
                return matchForm;
            }
            else lblWarningError.Text = gameResponse.ErrorMessage;
            return default;
        }


        private void btnPartidaTeste_Click(object sender, EventArgs e)
        {
            string password = new Random().Next(1_000, 9_999).ToString();
            string matchName = Guid.NewGuid().ToString().Replace("-", string.Empty).Substring(0, 19);

            string matchId = MatchService.CreateMatch(matchName, password, "Grupo Teste");
            var matchKamikaze = EnterOnMatch(matchId, "Kamikaze", password);
            var matchPracinha = EnterOnMatch(matchId, "Pracinha", password);

            matchKamikaze.IniciarPartida();
            var persons = PersonConst.Names.Select(x => x.Key).ToList();
            
            var playerMatchQueue = new Queue<MatchForm>();
            playerMatchQueue.Enqueue(matchKamikaze);
            playerMatchQueue.Enqueue(matchPracinha);

            int setor = 4;
            for (int i = 0; i < persons.Count; i++)
            {
                var person = persons[i];
                var player = playerMatchQueue.Dequeue();
                playerMatchQueue.Enqueue(player);

                player.PosicionarPersonagem(setor, person);
                if ((i + 1) % 4 == 1) setor--;
            }

        }
    }
}
