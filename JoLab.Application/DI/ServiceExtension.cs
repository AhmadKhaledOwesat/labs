using JoLab.Application.Bll;
using JoLab.Application.Dal;
using JoLab.Application.Interfaces;
using JoLab.Application.Mapper;
using JoLab.Domain.Interfaces;
using JoLab.Infrastructure.EfContext;
using JoLab.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
namespace JoLab.Application.DI
{
    public static class ServiceExtension
    {
        public static void AddDcpMapper(this IServiceCollection serviceDescriptors)
        {
            serviceDescriptors.AddAutoMapper(typeof(JoLabMapper));
        }

        public static void AddEfDbContext(this IServiceCollection serviceDescriptors, IConfiguration configuration)
        {
            serviceDescriptors.AddDbContext<StudioContext>(options => options.UseLazyLoadingProxies().UseSqlServer(configuration.GetConnectionString("JoLab")));
        }

        public static void AddServices(this IServiceCollection serviceDescriptors)
        {
            serviceDescriptors.AddSingleton<IJoLabMapper, JoLabMapper>();
            serviceDescriptors.AddScoped<IUserBll, UserBll>();
            serviceDescriptors.AddScoped(provider =>
            {
                return new Lazy<IUserBll>(() => provider.GetRequiredService<IUserBll>());
            });
            serviceDescriptors.AddScoped<ISettingBll, SettingBll>();
            serviceDescriptors.AddScoped<IRoleBll, RoleBll>();
            serviceDescriptors.AddScoped<IPrivilegeBll, PrivilegeBll>();
            serviceDescriptors.AddScoped<IUserRoleBll, UserRoleBll>();
            serviceDescriptors.AddScoped<IRolePrivilegeBll, RolePrivilegeBll>();
            serviceDescriptors.AddScoped<IReportBll, ReportBll>();
            serviceDescriptors.AddScoped<IReportParameterBll, ReportParameterBll>();
            serviceDescriptors.AddScoped<IClientBll, ClientBll>();
            serviceDescriptors.AddScoped(typeof(IBaseBll<,,>), typeof(BaseBll<,,>));
            serviceDescriptors.AddScoped(typeof(IBaseDal<,,>), typeof(BaseDal<,,>));
            serviceDescriptors.AddScoped(typeof(IEfRepository<,>), typeof(EfRepository<,>));
        }
    }
}
