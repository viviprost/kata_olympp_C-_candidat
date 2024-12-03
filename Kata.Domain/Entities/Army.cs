using System.Text.Json.Serialization;

namespace Kata.Domain.Entities
{
    public class Army
    {
        public int ArmyId { get; set; }

        public string Name { get; set; }

        public int ClanId { get; set; }

        [JsonIgnore]
        public Clan Clan { get; set; }

        public ICollection<Soldier> Soldiers { get; set; } = new List<Soldier>();
    }
}