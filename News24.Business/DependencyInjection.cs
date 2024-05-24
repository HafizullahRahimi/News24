using Microsoft.Extensions.DependencyInjection;
using News24.Business.Repositories.NewsRepository;
using News24.Business.Services;
using News24.Business.Services.ImagesService;
using News24.Business.Services.IndexPageService;
using News24.Business.Services.LatestNewsService;
using News24.Business.Services.MainSliderService;
using News24.Business.Services.NewsDetailService;

namespace News24.Business;
public static class DependencyInjection
{
    public static IServiceCollection AddBusiness(this IServiceCollection services)
    {
        // Repositories
        services.AddScoped<INewsRepository, NewsRepository>();

        // Services
        services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        services.AddScoped<IIndexPageService, IndexPageService>();
        services.AddScoped<INewsDetailService, NewsDetailService>();
        services.AddScoped<IImagesService, ImagesService>();
        services.AddScoped<IMainSliderService, MainSliderService>();
        services.AddScoped<ILatestNewsService, LatestNewsService>();

        return services;
    }
}
