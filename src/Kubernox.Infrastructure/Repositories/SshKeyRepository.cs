using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Kubernox.Domain.Entities;
using Kubernox.Domain.Interfaces;
using Kubernox.Infrastructure.Contexts;

namespace Kubernox.Infrastructure.Repositories
{
    public class SshKeyRepository(
        ApplicationWriteDbContext applicationWriteDbContext,
        ApplicationReadDbContext applicationReadDbContext)
        : ISshKeyRepository
    {
        public void InsertAsync(SshKey entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SshKey> QueryAllAsync()
        {
            throw new NotImplementedException();
        }

        public SshKey QueryOnByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
