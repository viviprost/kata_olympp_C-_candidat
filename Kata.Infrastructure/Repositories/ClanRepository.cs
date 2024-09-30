using Kata.Domain.Entities;
using Kata.Domain.Repositories;
using Kata.Infrastructure.Data;

namespace Kata.Infrastructure.Repositories
{
    public class ClanRepository : IClanRepository
    {
        private readonly KataDBContext _context;
        public ClanRepository(KataDBContext context)
        {
            _context = context;
        }
        public Task<Clan?> GetArmyByNameClanAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task<Clan?> GetClanByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task AddArmyAsync(string nameClan, Army army)
        {
            throw new NotImplementedException();
        }
        public Task UpdateArmyAsync(string nameClan, string armyName, Army army)
        {
            throw new NotImplementedException();
        }
        public Task DeleteArmyAsync(string nameClan, string nameArmy)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Clan>> GetAllClansAsync()
        {
            throw new NotImplementedException();
        }

        

        
    }
}
