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
                return new GameResponse<PlayerEntity>() { ErrorMessage = "PlayerId da partida inválido." };

            var response = Jogo.ListarJogadores(matchId);
            return response.HandleReponse<PlayerEntity>();
        }

		private static Dictionary<string, List<PersonagemPosicao>> _posicoesPorPartida = new();
		public static void DefinirPosicao(string matchId, string letra, int setor)
		{
			if (!_posicoesPorPartida.ContainsKey(matchId))
				_posicoesPorPartida[matchId] = new List<PersonagemPosicao>();

			_posicoesPorPartida[matchId].RemoveAll(p => p.Letra.ToUpper() == letra.ToUpper());

			_posicoesPorPartida[matchId].Add(new PersonagemPosicao
			{
				Letra = letra.ToUpper(),
				Setor = setor
			});
		}

		public static List<PersonagemPosicao> GetPosicoes(string matchId)
		{
			if (_posicoesPorPartida.ContainsKey(matchId))
				return _posicoesPorPartida[matchId];

			return new List<PersonagemPosicao>();
		}

		public static string GetFavorites(int idplayer, string passwordplayer) =>
			Jogo.ListarCartas(idplayer, passwordplayer);


	}
}
