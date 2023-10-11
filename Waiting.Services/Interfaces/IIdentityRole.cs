using Waiting.Data.Models;

namespace Waiting.Service.Interfaces
{
    public interface IIdentityRole
    {
        Task<IEnumerable<IdentityRole>> GetAllPermissionsAsync();
        Task<IdentityRole> GetPermissionByIdAsync(int id);
        Task AddPermissionAsync(IdentityRole permission);
        Task UpdatePermissionAsync(IdentityRole permission);
        Task DeletePermissionAsync(int id);
    }
}
