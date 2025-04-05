using AutoSystem_KingMe.Models.Common;
using AutoSystem_KingMe.Models.Common.Attributes;

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

        public override string ToString() =>
            $"ID: {Id} | Nome: {Name} | Pontos: {Score}";
    }

    public class PlayerOnGameEntity : PlayerEntity
    {
        [Position(0)]
        public string Id { get; set; }

        [Position(1)]
        public string Password { get; set; }

		[Position(2)]
		public string Status { get; set; }
	}
}
