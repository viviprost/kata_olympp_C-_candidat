namespace Kata.Domain.Entities
{
    public class Clan
    {
        public int ClanId { get; set; }

        public string Name { get; set; }

        public ICollection<Army> Armies { get; set; } = new List<Army>();
    }
}