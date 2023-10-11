using Waiting.Data.Models;
using Waiting.Infraestructure.Interfaces;
using Waiting.Service.Interfaces;

namespace Waiting.Service.Services
{
    public  class TenantService : ITenantService
    {
        private readonly IRepository<Tenant> _tenantRepository;

        public TenantService(IRepository<Tenant> tenantRepository)
        {
            _tenantRepository = tenantRepository;
        }

        public async Task<IEnumerable<Tenant>> GetAllTenantsAsync()
        {
            return await _tenantRepository.GetAllAsync();
        }

        public async Task<Tenant> GetTenantByIdAsync(int id)
        {
            return await _tenantRepository.GetByIdAsync(id);
        }

        public async Task AddTenantAsync(Tenant tenant)
        {
            if (tenant == null)
                throw new ArgumentNullException(nameof(tenant));

            await _tenantRepository.AddAsync(tenant);
        }

        public async Task UpdateTenantAsync(Tenant tenant)
        {
            if (tenant == null)
                throw new ArgumentNullException(nameof(tenant));

            await _tenantRepository.UpdateAsync(tenant);
        }

        public async Task DeleteTenantAsync(int id)
        {
            var tenant = await _tenantRepository.GetByIdAsync(id);
            if (tenant == null)
                throw new KeyNotFoundException("Tenant not found");

            await _tenantRepository.DeleteAsync(tenant);
        }
    }
}
