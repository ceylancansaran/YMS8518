using GuestBook.Data.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GuestBook.Data.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
        : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 1,
                Username = "admin",
                Password = "123456"
            });
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<GuestNote> GuestNotes { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
