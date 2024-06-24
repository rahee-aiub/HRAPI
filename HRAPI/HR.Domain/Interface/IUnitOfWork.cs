using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Domain.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository CategoryRepository { get; }
        ILoginUserRepository LoginUserRepository { get; }
        IDepartmentRepository DepartmentRepository { get; }
        ICompanyRepository CompanyRepository { get; }
        IDesignationRepository DesignationRepository { get; }
        IEmployeeSetupRepository EmployeeSetupRepository { get; }

        Task<int> SaveChangesAsync();
    }
}
