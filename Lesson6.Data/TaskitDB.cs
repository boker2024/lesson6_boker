using Lesson6.Core.Enities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6.Data
{
    public class TaskitDB : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Taskit;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False").LogTo(Console.WriteLine, LogLevel.Information);

        }
        public DbSet<Project> Projects { get; set; }
        public DbSet<MyTask> Tasks { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
