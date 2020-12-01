using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FinalTest.Models;

namespace FinalTest.Data
{
    public class relationContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Database=FinalDatabase;Trusted_Connection=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EnrollOrder>().HasKey(sc => new { sc.StudentId, sc.UniversityId });

            modelBuilder.Entity<EnrollOrder>()
                .HasOne<Student>(sc => sc.Student)
                .WithMany(s => s.EnrollOrders)
                .HasForeignKey(sc => sc.StudentId);

            modelBuilder.Entity<EnrollOrder>()
                .HasOne<University>(sc => sc.University)
                .WithMany(s => s.EnrollOrders)
                .HasForeignKey(sc => sc.UniversityId);
        }

        public relationContext(DbContextOptions<relationContext> options)
            : base(options)
        { }

        public DbSet<Student> Students { get; set; }
        public DbSet<University> Universities { get; set; }
        public DbSet<EnrollOrder> EnrollOrders { get; set; }


    }
}
