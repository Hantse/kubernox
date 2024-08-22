using Kubernox.Domain.Entities;

using Microsoft.EntityFrameworkCore;

namespace Kubernox.Infrastructure.Contexts
{
    public class ApplicationWriteDbContext : DbContext
    {
        public DbSet<SshKey> SshKeys { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
