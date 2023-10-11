using Waiting.Infraestructure.Interfaces;
using Waiting.Service.Interfaces;

namespace Waiting.Service.Services
{
    public class IdentityRole : IIdentityRole
    {
        private readonly IRepository<IdentityRole> _userRepository;

        public IdentityRole(IRepository<IdentityRole> userRepository)
        {
            _userRepository = userRepository;
        }


        public Task<IEnumerable<IdentityRole>> GetAllPermissionsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IdentityRole> GetPermissionByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task AddPermissionAsync(IdentityRole permission)
        {
            throw new NotImplementedException();
        }

        public Task UpdatePermissionAsync(IdentityRole permission)
        {
            throw new NotImplementedException();
        }

        public Task DeletePermissionAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
