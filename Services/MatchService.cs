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
       
    }
}
