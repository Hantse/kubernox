using Kubernox.Domain.Interfaces;
using Kubernox.Infrastructure.Contexts;

namespace Kubernox.Infrastructure.Repositories
{
    public class UnitOfWork(
        ApplicationWriteDbContext applicationWriteDbContext)
        : IUnitOfWork
    {
        public Task<int> CommitAsync()
        {
            throw new NotImplementedException();
        }
    }
}
