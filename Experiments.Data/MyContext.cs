using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experiments.Data
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {
        }

        public DbSet<Person> People { get; set; }
        public DbSet<Address> Addresses { get; set; }
        //public DbSet<Shape> Shapes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Shape>().ToTable("Shape");

            modelBuilder.Entity<Address>()
                .Property(e => e.Country)
                .HasDefaultValue("USA");

            modelBuilder.Entity<Person>()
                .Property(e => e.CreatedOn)
                .HasDefaultValueSql("GETDATE()");

            //modelBuilder.Entity<Shape>()
            //    .HasDiscriminator<string>("ShapeType")
            //    .HasValue<Shape>("S")
            //    .HasValue<Cube>("C");
        }
    }
}
