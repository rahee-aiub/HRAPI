using HR.ApplicationLayer;
using HR.Domain.Interface;
using HR.Infastructure.Data;
using HR.Infastructure.Repository;

namespace Microsoft.Extensions.DependencyInjection;

public static class DependencyInjection
{
    public static IServiceCollection InfrastructureServices(this IServiceCollection services)
    {
        services.AddScoped<IAppDbContext>(provider => provider.GetRequiredService<AppDbContext>());
        services.AddScoped<ICategoryRepository, CategoryRepository>();
        services.AddScoped<ILoginUserRepository, LoginUserRepository>();
        services.AddScoped<IDepartmentRepository, DepartmentRepository>();
        services.AddScoped<ICompanyRepository, CompanyRepository>();
        services.AddScoped<IDesignationRepository, DesignationRepository>();
        services.AddScoped<IEmployeeSetupRepository, EmployeeSetupRepository>();
        services.AddScoped<IRecruitmentCircularRepository, RecruitmentCircularRepository>();
        services.AddScoped<ICandidateApplicationRepository, CandidateApplicationRepository>();

        return services;
    }
}
