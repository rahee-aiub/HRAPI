using HR.ApplicationLayer;
using HR.ApplicationLayer.Services;
using HR.Domain.Models;
using HR.Domain.Models.Recruitment;
using HR.Domain.Models.Setup;
using Microsoft.EntityFrameworkCore;

namespace HR.Infastructure.Data
{
    public class AppDbContext : DbContext, IAppDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Category> Categorys => Set<Category>();
        public DbSet<EmployeeSetup> EmployeeSetups => Set<EmployeeSetup>();
        public DbSet<Department> Departments => Set<Department>();
        public DbSet<Company> Companys => Set<Company>();
        public DbSet<Designation> Designations => Set<Designation>();
        public DbSet<LoginUser> LoginUsers => Set<LoginUser>();
        public DbSet<RecruitmentCircular> RecruitmentCirculars => Set<RecruitmentCircular>();
        public DbSet<CandidateApplication> CandidateApplications => Set<CandidateApplication>();
        public DbSet<ShortlistedCandidate> ShortlistedCandidates => Set<ShortlistedCandidate>();

       
        public  async Task<int> SaveChangesAsync()
        {
            foreach (var entry in ChangeTracker.Entries<BaseModel>().ToList())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreateBy ="admin";
                        entry.Entity.CreateDate = DateTime.Now;
                        break;

                    case EntityState.Modified:
                        entry.Entity.UpdateDate = DateTime.Now;
                        entry.Entity.UpdateBy = "admin";
                        break;
                }
            }
            return await base.SaveChangesAsync();
        }
        public async Task<int> SaveAsync()
        {
            foreach (var entry in ChangeTracker.Entries<BaseModel>().ToList())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreateDate = DateTime.Now;
                        entry.Entity.CreateBy = "admin";
                        break;

                    case EntityState.Modified:
                        entry.Entity.UpdateDate = DateTime.Now;
                        entry.Entity.UpdateBy = "admin";
                        break;
                }
            }
            return await SaveChangesAsync();
        }
        public int Save()
        {
            foreach (var entry in ChangeTracker.Entries<BaseModel>().ToList())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreateDate = DateTime.Now;
                        break;

                    case EntityState.Modified:
                        entry.Entity.UpdateDate = DateTime.Now;
                        break;
                }
            }
            return SaveChanges();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);
           
            base.OnModelCreating(modelBuilder);
        }
    }
}
