using Kubernox.Domain.Entities;
using Kubernox.Domain.Interfaces;
using Kubernox.Infrastructure.Contexts;

using Microsoft.EntityFrameworkCore;

namespace Kubernox.Infrastructure.Repositories
{
    public class UserRepository(
        ApplicationWriteDbContext applicationWriteDbContext,
        ApplicationReadDbContext applicationReadDbContext)
        : IUserRepository
    {
        public void InsertAsync(User entity)
        {
            applicationWriteDbContext.Users.Add(entity);
        }

        public Task<List<User>> QueryAllAsync()
        {
            return applicationReadDbContext.Users.ToListAsync();
        }

        public Task<User?> QueryOnByIdAsync(Guid id)
        {
            return applicationReadDbContext.Users.FirstOrDefaultAsync(s => s.Id == id);
        }

        public void UpdateAsync(User entity)
        {
            applicationWriteDbContext.Users.Update(entity);
        }
    }
}
