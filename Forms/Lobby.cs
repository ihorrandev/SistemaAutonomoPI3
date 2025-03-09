using AutoSystem_KingMe.Models.Entities;
using AutoSystem_KingMe.Models.Entity;
using KingMeServer;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using MatchEntity = AutoSystem_KingMe.Models.Entity.Match;
using PlayerEntity = AutoSystem_KingMe.Models.Entities.Player;


namespace AutoSystem_KingMe
{
	public partial class Lobby : Form
	{
		public static string globalMatchId;
		public Lobby()
		{
			InitializeComponent();
			lbVersion.Text = $"{lbVersion.Text} {Jogo.versao}";
		}


		private void btnGetMatchs_Click(object sender, EventArgs e)
		{
			lboMatchs.Items.Clear();
			string? statusSelected = cboMatchsStatus.SelectedItem?.ToString()?.Substring(0, 1);
			var matchs = MatchEntity.GetMatchs(statusSelected);

			foreach (var match in matchs)
			{
				string statusDescription = match.Status switch
				{
					"A" => "A - Aberta",
					"J" => "J - Em Jogo",
					"E" => "E - Encerrada",
					_ => string.Empty,
				};

				lboMatchs.Items.Add($"{match.Id} - {match.Name} | {statusDescription} | {match.CreationDate}");
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
			string nameGroup = txtBox_nomeGrupo.Text;

			string tempResponse = MatchEntity.CreateMatch(name, password, nameGroup);
			if (!tempResponse.StartsWith("ERRO"))
			{
				globalMatchId = tempResponse;
				lblCreationMatchResponse.Text = $"ID da Partida: {globalMatchId}";
			}
			else
			{
				lblCreationMatchResponse.Text = $"{tempResponse}";

			}
		}

		private void btnListPlayers_Click(object sender, EventArgs e)
		{
			lboPlayers.Items.Clear();
			string matchId = txtBox_idPartida.Text;
			List<Player> players = Player.GetPlayers(matchId);

			if (players == null || players.Count == 1)
			{
				lblListPlayerResponse.Text = $"Partida sem jogadores!";

			}
			else if (players[0].Name.StartsWith("ERRO"))
			{
				lblListPlayerResponse.Text = $"{players}";
			}
			else
			{
				lblListPlayerResponse.Text = string.Empty;
				foreach (var player in players)
				{
					if (player.Id != "")
					{
						lboPlayers.Items.Add($"ID: {player.Id} | Nome: {player.Name} | Pontos: {player.Score}");
					}
				}
			}

		}

		private void btnEnterMatch_Click(object sender, EventArgs e)
		{
			lblWarningError.Text = "";

			string namePlayer = txtBox_PlayerName.Text;
			int idMatch;
			string passwordMatch = txtBox_PasswordMatch.Text;

			if (!int.TryParse(txtBox_IdMatch.Text, out idMatch))
			{
				lblWarningError.Text = "ERRO: ID da partida está incorreto";
			}
			else
			{
				string tempResponse = MatchEntity.EnterMatch(idMatch, namePlayer, passwordMatch);

				if (!tempResponse.StartsWith("ERRO"))
				{
					string[] enterMatchPlayer = tempResponse.Split(',');

					string idPlayer = enterMatchPlayer[0].Trim();
					string passwordPlayer = enterMatchPlayer[1].Trim();

					lblIdPlayer.Text = idPlayer; lblPasswordPlayer.Text = passwordPlayer;
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
