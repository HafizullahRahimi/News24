using Microsoft.Extensions.DependencyInjection;
using News24.Business.Repository.NewsRepository.NewsRepository;
using News24.Business.Services.IndexPageService;
using News24.Business.Services.NewsDetailService;

namespace News24.Business;
public static class BusinessConfig
{
    public static IServiceCollection AddBusinessConfig(this IServiceCollection services)
    {
        // Repositories
        services.AddScoped<INewsRepository, NewsRepository>();

        // Services
        services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        services.AddScoped<IIndexPageService, IndexPageService>();
        services.AddScoped<INewsDetailService, NewsDetailService>();

        return services;
    }
}
