using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TrackStatMobile.Services
{
    public interface IStats<Stats>
    {
        Task<bool> AddStatsAsync(Stats item);
        Task<bool> UpdateStatsAsync(Stats item);
        Task<bool> DeleteStatsAsync(string id);
        Task<Stats> GetStatsAsync(string id);
        Task<IEnumerable<Stats>> GetAllStatsAsync(bool forceRefresh = false);
    }
}
