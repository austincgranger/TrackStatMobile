using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace TrackStatMobile.Services
{
    public interface IUser<User>
    {
        Task<bool> AddUserAsync(User item);
        Task<bool> UpdateUserAsync(User item);
        Task<bool> DeleteUserAsync(string id);
        Task<User> GetUserAsync(string id);
        Task<IEnumerable<User>> GetAllUsersAsync(bool forceRefresh = false);
    }
}
