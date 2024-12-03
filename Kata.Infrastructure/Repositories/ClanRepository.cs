using Kata.Domain.Entities;
using Kata.Domain.Repositories;
using Kata.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Kata.Infrastructure.Repositories
{
    public class ClanRepository : IClanRepository
    {
        private readonly KataDBContext _context;

        public ClanRepository(KataDBContext context)
        {
            _context = context;
        }

        public async Task<Clan?> GetArmyByNameClanAsync(string name)
        {
            return await _context.Clans
                .Include(x => x.Armies)
                .Where(x => x.Armies.Any(x => x.Name == name))
                .FirstOrDefaultAsync();
        }

        public async Task<Clan?> GetClanByNameAsync(string name)
        {
            return await _context.Clans
                .AsNoTracking()
                .Include(x => x.Armies)
                .ThenInclude(x => x.Soldiers)
                .FirstOrDefaultAsync(x => x.Name == name);
        }

        public async Task AddArmyAsync(string name, Army army)
        {
            var clan = await _context.Clans
                .Include(x => x.Armies)
                .ThenInclude(x => x.Soldiers)
                .FirstOrDefaultAsync(x => x.Name == name);

            ArgumentException.ThrowIfNullOrEmpty(nameof(clan));

            var random = new Random();

            clan.Armies.Add(new Army
            {
                Name = $"Test-{Guid.NewGuid()}",
                Soldiers = GenerateRandomSoldier(random.Next(10)).ToList()
            });

            _context.SaveChanges();
        }

        public async Task UpdateArmyAsync(string nameClan, string armyName, Army army)
        {
            var armyToUpdate = await GetFirstArmyBy(nameClan, armyName);

            ArgumentException.ThrowIfNullOrEmpty(nameof(armyToUpdate));

            armyToUpdate = army;

            await _context.SaveChangesAsync();
        }

        public async Task DeleteArmyAsync(string nameClan, string nameArmy)
        {
            var armyToDelete = await GetFirstArmyBy(nameClan, nameArmy);

            _context.Armies.Remove(armyToDelete);

            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Clan>> GetAllClansAsync()
        {
            return await _context.Clans
                .Include(x => x.Armies)
                .AsNoTracking()
                .ToListAsync();
        }

        /// <summary>
        /// Get first army filter by name.
        /// Throw exception if empty
        /// </summary>
        /// <param name="nameClan"></param>
        /// <param name="nameArmy"></param>
        /// <returns></returns>
        private async Task<Army> GetFirstArmyBy(string nameClan, string nameArmy)
        {
            return await _context.Armies
                .AsNoTracking()
                .Include(x => x.Clan)
                .Where(x => x.Name == nameArmy)
                .Where(x => x.Clan.Name == nameClan)
                .FirstAsync();
        }

        private IEnumerable<Soldier> GenerateRandomSoldier(int numberOfCopies)
        {
            for (int i = 0; i < numberOfCopies; i++)
                yield return Soldier.GenerateRandomSoldier();
        }
    }
}