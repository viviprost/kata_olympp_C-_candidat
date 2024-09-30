using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kata.Domain.Entities;

namespace Kata.Domain.Interfaces
{
    public interface IClanService
    {
        Task<IEnumerable<Clan>> GetAllClansAsync();
        Task<Clan?> GetClanByNameAsync(string name);
        Task<int> AddArmyAsync(string nameClan,Army army);
        Task<int> UpdateArmyAsync(string nameClan, string armyClan, Army army);
        Task<int> RemoveArmyAsync(string nameClan, string armyClan);
    }
}
