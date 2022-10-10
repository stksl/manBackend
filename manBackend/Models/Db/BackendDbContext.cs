﻿using manBackend.Models.Auth;
using Microsoft.EntityFrameworkCore;

namespace manBackend.Models
{
    public class BackendDbContext : DbContext
    {
        public BackendDbContext(DbContextOptions<BackendDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasOne(i => i.Mail);
        }

        public DbSet<User> Users { get; set; }

    }
}
