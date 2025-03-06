using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoSystem_KingMe.Helper;
using AutoSystem_KingMe.Models.Entities.Common;
using AutoSystem_KingMe.Models.Entities.Common.Attributes;
using KingMeServer;

namespace AutoSystem_KingMe.Models.Entities
{
    public class Player : EntityBase
    {
        [Position(0)]
        public string Id { get; set; }

        [Position(1)]
        public string Name { get; set; }

        [Position(2)]
        public string Score { get; set; }

        public static List<Player> GetPlayers(string matchId) 
        {
            var response = Jogo.ListarJogadores(Convert.ToInt32(matchId));
            return response.HandleReponse<Player>();
        }

    }
}
    