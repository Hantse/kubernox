using Kubernox.Domain.Entities;

using Microsoft.EntityFrameworkCore;

namespace Kubernox.Infrastructure.Contexts
{
    public class ApplicationWriteDbContext : DbContext
    {
        public DbSet<Host> Hosts { get; set; }
        public DbSet<SshKey> SshKeys { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
