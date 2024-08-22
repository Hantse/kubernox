using Kubernox.Domain.Entities;
using Kubernox.Domain.Interfaces;
using Kubernox.Infrastructure.Contexts;

namespace Kubernox.Infrastructure.Repositories
{
    public class HostRepository(
        ApplicationWriteDbContext applicationWriteDbContext,
        ApplicationReadDbContext applicationReadDbContext)
        : IHostRepository
    {
        public void InsertAsync(Host entity)
        {
            throw new NotImplementedException();
        }

        public Task<List<Host>> QueryAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Host?> QueryOnByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public void UpdateAsync(Host entity)
        {
            throw new NotImplementedException();
        }
    }
}
