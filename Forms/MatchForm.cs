using AutoSystem_KingMe.Models;
using AutoSystem_KingMe.Services;
using KingMeServer;

namespace AutoSystem_KingMe.Forms
{
	public partial class MatchForm : Form
	{
		private readonly PlayerOnGameEntity _playerOnGame;
		private readonly string _matchId;

		public List<PlayerEntity> Players { get; set; }

		public MatchForm(PlayerOnGameEntity player, string matchId)
		{
			_playerOnGame = player;
			_matchId = matchId;

			InitializeComponent();
		}

		private void btnStartGame_Click(object sender, EventArgs e)
		{
			string gameResponse = MatchService.StartGame(_playerOnGame);
			if (gameResponse.StartsWith("ERRO:"))
			{
				lblGetMatchesResponse.Text = gameResponse;
			}
			else
			{
				var getPlayersResponse = PlayerService.GetPlayers(_matchId);
				Players = getPlayersResponse.Entities;

				var playerTurn = Players.FirstOrDefault(x => x.Id == gameResponse);
				lblPlayerTurn.Text = $"Vez do jogador: {playerTurn.Name}";
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
