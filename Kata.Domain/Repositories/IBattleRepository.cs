using Kata.Domain.Entities;

namespace Kata.Domain.Repositories
{
    public interface IBattleRepository
    {
        Task<BattleReport> SaveBattleReport();

        Task<IEnumerable<BattleReport>> GetAllBattlesReport();

        Task<BattleReport?> GetBattleReportById();
    }
}