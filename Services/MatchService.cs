using AutoSystem_KingMe.Helper;
using AutoSystem_KingMe.Models;
using AutoSystem_KingMe.Models.Common;
using KingMeServer;

namespace AutoSystem_KingMe.Services
{
    public static class MatchService
    {
        public static GameResponse<MatchEntity> GetMatches(string? status = "T") =>
            Jogo.ListarPartidas(status)
                .HandleReponse<MatchEntity>();

        public static string CreateMatch(string nameMatch, string passwordMatch, string nameGroup) =>
            Jogo.CriarPartida(nameMatch, passwordMatch, nameGroup);

        public static GameResponse<PlayerOnGameEntity> EnterMatch(string strIdMatch, string playerName, string passwordMatch)
        {
            if (!int.TryParse(strIdMatch, out int idMatch))
                return new GameResponse<PlayerOnGameEntity>() { ErrorMessage = "ID da partida está incorreto." };

            string gameResponse = Jogo.Entrar(idMatch, playerName, passwordMatch);
            return gameResponse.HandleReponse<PlayerOnGameEntity>();
        }

        public static string StartGame(PlayerOnGameEntity player) =>
            Jogo.Iniciar(int.Parse(player.Id), player.Password);

        public static string PutCharacter(PlayerOnGameEntity player, string sector, string character) =>
            Jogo.ColocarPersonagem(int.Parse(player.Id), player.Password, int.Parse(sector), character);

        public static GameResponse<CheckTimeEntity> CheckTime(string idMatch) =>
            Jogo.VerificarVez(int.Parse(idMatch))
                .HandleReponse<CheckTimeEntity>();
    }
}
