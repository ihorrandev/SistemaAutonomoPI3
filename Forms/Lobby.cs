using AutoSystem_KingMe.Models.Entity;
using System.Text.RegularExpressions;

namespace AutoSystem_KingMe
{
	public partial class Lobby : Form
	{
		public Lobby()
		{
			InitializeComponent();
		}

		//Id da partida salvo globalmente
		private string globalMatchId;

		private void btnGetMatches_Click(object sender, EventArgs e)
		{
			lboMatches.Items.Clear();
			string? statusSelected = cboMatchesStatus.SelectedItem?.ToString()?.Substring(0, 1);
			var matches = Matche.GetMatches(statusSelected);

			foreach (var matche in matches)
			{
				string statusDescription = matche.Status switch
				{
					"A" => "A - Aberta",
					"J" => "J - Em Jogo",
					"E" => "E - Encerrada",
					_ => string.Empty,
				};

				lboMatches.Items.Add($"{matche.Id} - {matche.Name} | {statusDescription} | {matche.CreationDate}");
			}
		}

		private void Lobby_Load(object sender, EventArgs e)
		{
			cboMatchesStatus.SelectedIndex = 0;

		}

		private void createMatch_Click_1(object sender, EventArgs e)
		{
			string name = txtBox_nomePartida.Text;
			string password = txtBox_senhaPartida.Text; 
			string nameGroup = txtBox_nomeGrupo.Text;
			
			string globalMatchId = Matche.CreateMatch(name, password, nameGroup);
			if (!string.IsNullOrEmpty(globalMatchId))
			{
				label5.Text = $"ID da Partida: {globalMatchId}";
			}
			else
			{
				label5.Text = "Erro ao criar a partida!";
			}
		}

	}
}
