using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Context
{
    public class FollowPowContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=SELIM-BAYINDIR\BYNDR;Database=FollowPow;User Id=sa;Password=Perkon123456;Trusted_Connection=True;TrustServerCertificate=True");
        }
        public DbSet<Person> People { get; set; }
        public DbSet<Department> Departments { get; set; }

        public DbSet<Position> Positions { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<PermissionType> PermissionTypes { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Position>()
        //    .HasKey(p => p.PositionId);
        //    modelBuilder.Entity<Position>()
        //        .Property(p=>p.PositionName)


        //}

    }
}
