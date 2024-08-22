using Kubernox.Domain.Entities;
using Kubernox.Domain.Interfaces;
using Kubernox.Infrastructure.Contexts;

using Microsoft.EntityFrameworkCore;

namespace Kubernox.Infrastructure.Repositories
{
    public class SshKeyRepository(
        ApplicationWriteDbContext applicationWriteDbContext,
        ApplicationReadDbContext applicationReadDbContext)
        : ISshKeyRepository
    {
        public void InsertAsync(SshKey entity)
        {
            applicationWriteDbContext.SshKeys.Add(entity);
        }

        public Task<List<SshKey>> QueryAllAsync()
        {
            return applicationReadDbContext.SshKeys.ToListAsync();
        }

        public Task<SshKey?> QueryOnByIdAsync(Guid id)
        {
            return applicationReadDbContext.SshKeys.FirstOrDefaultAsync(s => s.Id == id);
        }

        public void UpdateAsync(SshKey entity)
        {
            applicationWriteDbContext.SshKeys.Update(entity);
        }
    }
}
