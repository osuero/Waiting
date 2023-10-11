using Waiting.Data.Models;

namespace Waiting.Service.Interfaces
{
    public interface IRoleService
    {
        Task<IEnumerable<IdentityRole>> GetAllRolesAsync();
        Task<IdentityRole> GetRoleByIdAsync(string id);  // La ID de IdentityRole es una string.
        Task CreateRoleAsync(IdentityRole role);
        Task UpdateRoleAsync(IdentityRole role);
        Task DeleteRoleAsync(string id);
    }
}
