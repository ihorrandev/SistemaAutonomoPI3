using AutoSystem_KingMe.Models;
using AutoSystem_KingMe.Services;
using KingMeServer;
using System.Numerics;

namespace AutoSystem_KingMe.Forms
{
    public partial class MatchForm : Form
    {
        private readonly PlayerOnGameEntity _playerOnGame;
        private readonly string _matchId;

        public List<PlayerEntity> Players { get; set; }
        public List<CheckTimeEntity> CheckTime { get; set; }

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

        private void btn_PutCharacter_Click_1(object sender, EventArgs e)
        {
            string sector = txtBox_SelectSector.Text;
            if(sector == "") { lbl_ReturnPutCharacter.Text = "ERRO: campo de setor está vazio"; }

            string character = txtBox_SelectCharacter.Text;

            string gameResponse = MatchService.PutCharacter(_playerOnGame, sector, character);
            string returnLabel = string.Empty;

            if (gameResponse.StartsWith("ERRO")) returnLabel = $"{gameResponse}";

            lbl_ReturnPutCharacter.Text = returnLabel;
        }

        private void btn_CheckTime_Click(object sender, EventArgs e)
        {
            var checkTimeResponse = MatchService.CheckTime(_matchId);
            CheckTime = checkTimeResponse.Entities;

            var getPlayersResponse = PlayerService.GetPlayers(_matchId);
            Players = getPlayersResponse.Entities;

            var checkPlayerTurn = Players.FirstOrDefault(x => x.Id == CheckTime.First().Id);

            lbl_ReturnIDPlayer.Text = $"ID: {checkPlayerTurn.Id}";
            lbl__ReturnNamePlayer.Text = $"Nome: {checkPlayerTurn.Name}";
        }

        private void btnBackToLobby_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool esconder = false;
        private void button1_Click(object sender, EventArgs e)
        {
            if (esconder)
            {
                lblFavorites.Text = "Lista de favoritos: ";
                button1.Text = "Mostrar lista de favoritos";
                esconder = false;
            }
            else
            {
                int playerId = Convert.ToInt32(_playerOnGame.Id);
                string favorites = PlayerService.GetFavorites(playerId, _playerOnGame.Password);
                lblFavorites.Text = "Lista de favoritos: " + favorites;
                button1.Text = "Esconder lista de favoritos";
                esconder = true;
            }
        }

    }
}
