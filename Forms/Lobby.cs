using AutoSystem_KingMe.Models;
using AutoSystem_KingMe.Services;
using KingMeServer;
using MatchForm = AutoSystem_KingMe.Forms.Match;

namespace AutoSystem_KingMe
{
    public partial class Lobby : Form
	{
		public Lobby()
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
            string nameGroup = "Arqueiros de Agincourt";

			string gameResponse = MatchEntity.CreateMatch(name, password, nameGroup);
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
				gameResponse.Entities
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

			int idMatch;
			string namePlayer = txtBox_PlayerName.Text;
			string passwordMatch = txtBox_PasswordMatch.Text;

			if (!int.TryParse(txtBox_IdMatch.Text, out idMatch))
			{
				lblWarningError.Text = "ERRO: ID da partida está incorreto.";
			}
			else
			{
				string tempResponse = MatchEntity.EnterMatch(idMatch, namePlayer, passwordMatch);

				if (!tempResponse.StartsWith("ERRO"))
				{
					string[] enterMatchPlayer = tempResponse.Split(',');

					string idPlayer = enterMatchPlayer[0].Trim();
					string passwordPlayer = enterMatchPlayer[1].Trim();

					lblIdPlayer.Text = $"ID do Jogador: {idPlayer}"; lblPasswordPlayer.Text = $"Senha do Jogador: {passwordPlayer}";


					this.Hide();
					var matchForm = new MatchForm();
					matchForm.ShowDialog();

					this.Close();
                }
                else
				{
					string[] error = tempResponse.Split(':');
					lblWarningError.Text = $"{error[0]}:{error[1]}";
				}
			}

			
		}
	}
}
