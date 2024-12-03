using Kata.Domain.Entities;

namespace Kata.Domain.Repositories
{
    public interface IClanRepository
    {
        Task<IEnumerable<Clan>> GetAllClansAsync();

        Task<Clan?> GetClanByNameAsync(string name);

        Task<Clan?> GetArmyByNameClanAsync(string name);

        Task AddArmyAsync(string nameClan, Army army);

        Task UpdateArmyAsync(string nameClan, string armyName, Army army);

        Task DeleteArmyAsync(string nameClan, string armyName);
    }
}