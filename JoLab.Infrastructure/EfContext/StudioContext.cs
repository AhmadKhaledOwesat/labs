using JoLab.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace JoLab.Infrastructure.EfContext
{ 
    public class StudioContext(DbContextOptions<StudioContext> dbContextOptions) : DbContext(dbContextOptions)
    {
        public DbSet<Users> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Privilege> Privilege { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<RolePrivilege> RolePrivilege { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<ReportParameter> ReportParameter { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<ClientFile> ClientFiles { get; set; }
        public DbSet<ClientIndicator> ClientIndicators { get; set; }
        public DbSet<ClientInsurance> ClientInsurances { get; set; }
        public DbSet<ClientTest> ClientTest { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Indicator> Indicators { get; set; }
        public DbSet<InsuranceCompany> InsuranceCompanies { get; set; }
        public DbSet<OrderMaster> OrderMasters { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Specialty> Specialties { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<TestNormalRange> TestNormalRanges { get; set; }
        public DbSet<TestInsurancePlan> TestInsurancePlans { get; set; }
        public DbSet<TubeType> TubeTypes { get; set; }

    }
}
