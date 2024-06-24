using HR.Domain.Interface;
using HR.Infastructure.Data;

namespace HR.Infastructure.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
     
        public UnitOfWork(AppDbContext context)
        {
            _context = context;
            CategoryRepository = new CategoryRepository(_context);
            LoginUserRepository = new LoginUserRepository(_context);
            DepartmentRepository = new DepartmentRepository(_context);
            CompanyRepository = new CompanyRepository(_context);
            DesignationRepository = new DesignationRepository(_context);
            EmployeeSetupRepository = new EmployeeSetupRepository(_context);
        }

        public ICategoryRepository CategoryRepository { get; }
        public ILoginUserRepository LoginUserRepository { get; }
        public IDepartmentRepository DepartmentRepository { get; }
        public ICompanyRepository CompanyRepository { get; }
        public IDesignationRepository DesignationRepository { get; }
        public IEmployeeSetupRepository EmployeeSetupRepository { get; }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
