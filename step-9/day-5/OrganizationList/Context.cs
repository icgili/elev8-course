using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrganizationList
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public DbSet<Models.Organization> Organizations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Organization>(entity =>
            {
                entity.ToTable("organizations");

                entity.Property(e => e.Index)
                    .HasColumnName("index");

                entity.Property(e => e.OrganizationId)
                    .HasColumnName("organization_id");

                entity.Property(e => e.Name)
                    .HasColumnName("name");

                entity.Property(e => e.Website)
                    .HasColumnName("website");

                entity.Property(e => e.Country)
                    .HasColumnName("country");

                entity.Property(e => e.Description)
                    .HasColumnName("description");

                entity.Property(e => e.Founded)
                    .HasColumnName("founded");

                entity.Property(e => e.Industry)
                    .HasColumnName("industry");

                entity.Property(e => e.NumberOfEmployees)
                    .HasColumnName("number_of_employees");
            });
        }
    }
}
