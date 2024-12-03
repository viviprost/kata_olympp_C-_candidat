using Kata.Domain.Entities;
using Kata.Domain.Interfaces;
using Kata.Domain.Repositories;

namespace Kata.Application.Services
{
    public class ClanService : IClanService
    {
        private readonly IClanRepository _clanRepository;

        public ClanService(IClanRepository clanRepository)
        {
            _clanRepository = clanRepository;
        }

        /// <summary>
        /// List all Clan and their armies
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<IEnumerable<Clan>> GetAllClansAsync()
        {
            return await _clanRepository.GetAllClansAsync();
        }

        /// <summary>
        /// Get the details of a clan
        /// </summary>
        /// <param name="name">Name of the Clan</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<Clan?> GetClanByNameAsync(string name)
        {
            return await _clanRepository.GetClanByNameAsync(name);
        }

        /// <summary>
        /// Add an army to an existing Clan
        /// </summary>
        /// <param name="nameClan">Name of the clan</param>
        /// <param name="army">Army to add into the clan</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<int> AddArmyAsync(string nameClan, Army army)
        {
            await _clanRepository.AddArmyAsync(nameClan, army);
            return 0;
        }

        /// <summary>
        /// Remove an army from a clan
        /// </summary>
        /// <param name="nameClan">name of the clan</param>
        /// <param name="armyClan">name of the army</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<int> RemoveArmyAsync(string nameClan, string armyClan)
        {
            await _clanRepository.DeleteArmyAsync(nameClan, armyClan);
            return 0;
        }

        /// <summary>
        /// Update an army from a clan
        /// </summary>
        /// <param name="nameClan">name of the clan</param>
        /// <param name="armyClan">name of the army</param>
        /// <param name="army">updated army</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public async Task<int> UpdateArmyAsync(string nameClan, string armyClan, Army army)
        {
            await _clanRepository.UpdateArmyAsync(nameClan, armyClan, army);
            return 0;
        }
    }
}