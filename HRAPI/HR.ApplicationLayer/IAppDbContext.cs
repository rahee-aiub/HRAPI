using HR.Domain.Models;
using HR.Domain.Models.Recruitment;
using HR.Domain.Models.Setup;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.ApplicationLayer;

public interface IAppDbContext
{
    DbSet<Category> Categorys { get; }
    DbSet<EmployeeSetup> EmployeeSetups { get;  }
    DbSet<Department> Departments { get;  }
    DbSet<Company> Companys { get;  }
    DbSet<Designation> Designations { get;  }
    DbSet<LoginUser> LoginUsers { get;  }
    DbSet<RecruitmentCircular> RecruitmentCirculars { get;  }
    DbSet<CandidateApplication> CandidateApplications { get;  }
    DbSet<ShortlistedCandidate> ShortlistedCandidates { get;  }

    Task<int> SaveChangesAsync();

}
