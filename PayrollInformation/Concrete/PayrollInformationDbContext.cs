using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PayrollInformation.Entities;

namespace PayrollInformation.Concrete
{
    class PayrollInformationDbContext : DbContext
    {
        public PayrollInformationDbContext() : base("PayrollInformationDbContext")
        {

        }
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    throw new UnintentionalCodeFirstException();
        //}
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Employee>().ToTable("Employees");
            modelBuilder.Entity<Role>().ToTable("Roles");
            modelBuilder.Entity<Currency>().ToTable("Currencies");
            modelBuilder.Entity<Salary>().ToTable("Salaries");
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Salary> Salaries { get; set; }
        public DbSet<Currency> Currencies { get; set; }

    }
}
