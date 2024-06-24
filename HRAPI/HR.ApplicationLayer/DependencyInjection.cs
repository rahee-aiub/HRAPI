using HR.ApplicationLayer.IServices;
using HR.ApplicationLayer.Services;
using System.Reflection;

namespace Microsoft.Extensions.DependencyInjection;

public static class DependencyInjection
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services)
    {

        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddScoped<ICategoryService, CategoryService>();
        services.AddScoped<ICategoryService, CategoryService>();
        services.AddScoped<ILoginUserService, LoginUserService>();
        services.AddScoped<IDepartmentService, DepartmentService>();
        services.AddScoped<ICompanyService, CompanyService>();
        services.AddScoped<IDesignationService, DesignationService>();
        services.AddScoped<IEmployeeService, EmployeeSetupService>();
        services.AddScoped<IRecruitmentCircularService, RecruitmentCircularService>();
        services.AddScoped<ICandidateApplicationService, CandidateApplicationService>();


        return services;
    }
}
