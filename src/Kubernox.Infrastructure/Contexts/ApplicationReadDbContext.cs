﻿using Kubernox.Domain.Entities;

using Microsoft.EntityFrameworkCore;

namespace Kubernox.Infrastructure.Contexts
{
    public class ApplicationReadDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<SshKey> SshKeys { get; set; }
    }
}
