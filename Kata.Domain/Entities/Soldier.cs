using System.Text.Json.Serialization;

namespace Kata.Domain.Entities
{
    public class Soldier
    {
        public int Id { get; set; }

        public int Life { get; set; }

        public int Attack { get; set; }

        public int Defense { get; set; }

        public int ArmyId { get; set; }

        [JsonIgnore]
        public Army Army { get; set; }

        public static Soldier GenerateRandomSoldier()
        {
            var random = new Random();

            return new Soldier
            {
                Life = random.Next(10),
                Defense = random.Next(10),
                Attack = random.Next(10)
            };
        }
    }
}