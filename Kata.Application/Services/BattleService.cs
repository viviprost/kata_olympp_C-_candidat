using Kata.Domain.Entities;
using Kata.Domain.Interfaces;
using Kata.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kata.Application.Services
{
    public class BattleService : IBattleService
    {
        private readonly IBattleRepository _battleRepository;
        private readonly IClanRepository _clanRepository;
        public BattleService(IBattleRepository battleRepository, IClanRepository clanRepository)
        {
            _battleRepository = battleRepository;
            _clanRepository = clanRepository;
        }
        /// <summary>
        /// Generates a battle between the armies of  the first and the last Clan
        /// Returns a battle report after saving it for historisation 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Task<BattleReport> Battle()
        {
            throw new NotImplementedException();
        }
    }
}
