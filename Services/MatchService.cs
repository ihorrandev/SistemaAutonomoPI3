using AutoSystem_KingMe.Helper;
using AutoSystem_KingMe.Models;
using AutoSystem_KingMe.Models.Common;
using KingMeServer;

namespace AutoSystem_KingMe.Services
{
    public static class MatchService
    {
		private static Dictionary<string, string> matchStatuses = new Dictionary<string, string>();
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

		public static string StartGame(PlayerOnGameEntity player)
		{
			string response = Jogo.Iniciar(int.Parse(player.Id), player.Password);
			if (response.StartsWith("ERRO:"))
			{
				matchStatuses[player.Status] = "ERRO";
				return response.Replace("ERRO:", "");
			}
			else
			{
				matchStatuses[player.Status] = "INICIADA";
				return response;
			}
		}

		public static string GetStatus(string statusKey)
		{
			if (string.IsNullOrEmpty(statusKey))
				return "AGUARDANDO";

			if (matchStatuses.ContainsKey(statusKey) && matchStatuses[statusKey] != null)
				return matchStatuses[statusKey];

			return "AGUARDANDO";
		}

		public static GameResponse<CharacterEntity> PutCharacter(PlayerOnGameEntity player, string sector, string character) =>
            Jogo.ColocarPersonagem(int.Parse(player.Id), player.Password, int.Parse(sector), character)
				.HandleReponse<CharacterEntity>();

        public static GameResponse<CheckTimeEntity> CheckTime(string idMatch) =>
            Jogo.VerificarVez(int.Parse(idMatch))
                .HandleReponse<CheckTimeEntity>();

		public static GameResponse<CharacterEntity> promotionCharacter(PlayerOnGameEntity player, string character) =>
			Jogo.Promover(int.Parse(player.Id), player.Password, character)
				.HandleReponse<CharacterEntity>();
		
    }
}
