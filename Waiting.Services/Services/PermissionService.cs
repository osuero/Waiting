using Waiting.Data.Models;
using Waiting.Infraestructure.Interfaces;
using Waiting.Service.Interfaces;

namespace Waiting.Service.Services
{
    public class PermissionService : IPermissionService
    {
        private readonly IRepository<Permission> _permissionRepository;

        public PermissionService(IRepository<Permission> permissionRepository)
        {
            _permissionRepository = permissionRepository;
        }

        public async Task<IEnumerable<Permission>> GetAllPermissionsAsync()
        {
            return await _permissionRepository.GetAllAsync();
        }

        public async Task<Permission> GetPermissionByIdAsync(int id)
        {
            return await _permissionRepository.GetByIdAsync(id);
        }

        public async Task AddPermissionAsync(Permission permission)
        {
            if (permission == null)
                throw new ArgumentNullException(nameof(permission));

            await _permissionRepository.AddAsync(permission);
        }

        public async Task UpdatePermissionAsync(Permission permission)
        {
            if (permission == null)
                throw new ArgumentNullException(nameof(permission));

            await _permissionRepository.UpdateAsync(permission);
        }

        public async Task DeletePermissionAsync(int id)
        {
            var permission = await _permissionRepository.GetByIdAsync(id);
            if (permission == null)
                throw new KeyNotFoundException("Permission not found");

            await _permissionRepository.DeleteAsync(permission);
        }
    }
}
