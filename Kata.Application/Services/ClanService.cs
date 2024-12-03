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
        public Task<IEnumerable<Clan>> GetAllClansAsync()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get the details of a clan
        /// </summary>
        /// <param name="name">Name of the Clan</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<Clan?> GetClanByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Add an army to an existing Clan
        /// </summary>
        /// <param name="nameClan">Name of the clan</param>
        /// <param name="army">Army to add into the clan</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<int> AddArmyAsync(string nameClan, Army army)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Remove an army from a clan
        /// </summary>
        /// <param name="nameClan">name of the clan</param>
        /// <param name="armyClan">name of the army</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<int> RemoveArmyAsync(string nameClan, string armyClan)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Update an army from a clan
        /// </summary>
        /// <param name="nameClan">name of the clan</param>
        /// <param name="armyClan">name of the army</param>
        /// <param name="army">updated army</param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<int> UpdateArmyAsync(string nameClan, string armyClan, Army army)
        {
            throw new NotImplementedException();
        }
    }
}