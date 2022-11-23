using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MySqlApp.Entities;

namespace MySqlApp
{
    public class GoogleDB: DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<TimeLog> Timelogs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"DataSource=C:\Users\Азамат\Desktop\Microsoft.db");
        }
    }
}
