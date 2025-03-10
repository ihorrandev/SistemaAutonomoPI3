using AutoSystem_KingMe.Models.Common;
using AutoSystem_KingMe.Models.Common.Attributes;
using KingMeServer;

namespace AutoSystem_KingMe.Models
{
    public class MatchEntity : EntityBase
    {
        [Position(0)]
        public string Id { get; set; }

        [Position(1)]
        public string Name { get; set; }

        [Position(2)]
        public string CreationDate { get; set; }

        [Position(3)]
        public string Status { get; set; }

        public override string ToString()
        {
            string statusDescription = Status switch
            {
                "A" => "A - Aberta",
                "J" => "J - Em Jogo",
                "E" => "E - Encerrada",
                _ => string.Empty,
            };

            return $"{Id} - {Name} | {statusDescription} | {CreationDate}";
        }   
    }
}
