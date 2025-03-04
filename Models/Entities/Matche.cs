using AutoSystem_KingMe.Helper;
using AutoSystem_KingMe.Models.Entities.Common;
using AutoSystem_KingMe.Models.Entities.Common.Attributes;
using KingMeServer;

namespace AutoSystem_KingMe.Models.Entity
{
    public class Matche : EntityBase
    {
        [Position(0)]
        public string Id { get; set; }
        
        [Position(1)]
        public string Name { get; set; }
        
        [Position(2)]
        public string CreationDate { get; set; }
        
        [Position(3)]
        public string Status { get; set; }

        public static List<Matche> GetMatches(string? status = "T")
        {
            var response = Jogo.ListarPartidas(status);
            return response.HandleReponse<Matche>();
        }
    }
}
