using Kata.Domain.Entities;
using Kata.Domain.Repositories;
using Kata.Infrastructure.Data;

namespace Kata.Infrastructure.Repositories
{
    public class BattleRepository : IBattleRepository
    {
        private readonly KataDBContext _context;
        public BattleRepository (KataDBContext context)
        {
            _context = context;
        }
        public Task<IEnumerable<BattleReport>> GetAllBattlesReport()
        {
            throw new NotImplementedException();
        }

        public Task<BattleReport?> GetBattleReportById()
        {
            throw new NotImplementedException();
        }

        public Task<BattleReport> SaveBattleReport()
        {
            throw new NotImplementedException();
        }
    }
}
