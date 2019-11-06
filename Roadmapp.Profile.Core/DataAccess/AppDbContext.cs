using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using Roadmapp.Profile.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Roadmapp.Profile.Core.DataAccess
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<UserProfile> Profile { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
