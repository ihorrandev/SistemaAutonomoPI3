using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoSystem_KingMe.Helper;
using AutoSystem_KingMe.Models.Common;
using AutoSystem_KingMe.Models.Entities.Common.Attributes;
using KingMeServer;

namespace AutoSystem_KingMe.Models
{
    public class PlayerEntity : EntityBase
    {
        [Position(0)]
        public string Id { get; set; }

        [Position(1)]
        public string Name { get; set; }

        [Position(2)]
        public string Score { get; set; }

        public static List<PlayerEntity> GetPlayers(string matchId)
        {
            var response = Jogo.ListarJogadores(Convert.ToInt32(matchId));
            return response.HandleReponse<PlayerEntity>();
        }

    }
}
