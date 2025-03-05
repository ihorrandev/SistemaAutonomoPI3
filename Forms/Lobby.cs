using AutoSystem_KingMe.Models.Entity;
using System.Text.RegularExpressions;
using MatchEntity = AutoSystem_KingMe.Models.Entity.Match;


namespace AutoSystem_KingMe
{
	public partial class Lobby : Form
	{
		public static string globalMatchId;
		public Lobby()
		{
			InitializeComponent();
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

			globalMatchId = MatchEntity.CreateMatch(name, password, nameGroup);
			if (!globalMatchId.StartsWith("ERRO"))
			{
				lblCreationMatchResponse.Text = $"ID da Partida: {globalMatchId}";
			}
			else
			{
				lblCreationMatchResponse.Text = $"{globalMatchId}";
			}
		}


	}
}
