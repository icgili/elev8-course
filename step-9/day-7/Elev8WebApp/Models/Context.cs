using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elev8WebApp.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeSalaryInfo> EmployeeSalary { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("employees");

                entity.Property(e => e.Id)
                    .HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasColumnName("name");

                entity.Property(e => e.DateOfEmployment)
                    .HasColumnName("date_of_employment");
            });

            modelBuilder.Entity<EmployeeSalaryInfo>(entity =>
            {
                entity.ToTable("employee_salaries");

                entity.Property(e => e.Id)
                    .HasColumnName("id");

                entity.Property(e => e.Salary)
                    .HasColumnName("salary");

                entity.Property(e => e.Deductions)
                    .HasColumnName("deductions");

                entity.HasOne(e => e.Employee)
                    .WithOne(e => e.SalaryInfo)
                    .HasForeignKey<EmployeeSalaryInfo>(e => e.Id)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("employee_salary_fk");
            });
        }
    }
}
