using AutoSystem_KingMe.Helper;
using AutoSystem_KingMe.Models;
using AutoSystem_KingMe.Models.Common;
using KingMeServer;

namespace AutoSystem_KingMe.Services
{
    public static class PlayerService
    {
        public static GameResponse<PlayerEntity> GetPlayers(string strMatchId)
        {
            if (!int.TryParse(strMatchId, out int matchId))
                return new GameResponse<PlayerEntity>() { ErrorMessage = "Id da partida inválido." };

            var response = Jogo.ListarJogadores(matchId);
            return response.HandleReponse<PlayerEntity>();
        }
    }
}
