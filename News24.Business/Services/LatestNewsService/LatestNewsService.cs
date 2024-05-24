using News24.Business.DTOs.Newses;
using News24.Business.Repositories.NewsRepository;

namespace News24.Business.Services.LatestNewsService;
public class LatestNewsService : ILatestNewsService
{
    private readonly INewsRepository _newsRepository;
    public LatestNewsService(INewsRepository NewsRepository) => _newsRepository = NewsRepository;
    public async Task<IEnumerable<NewsDTO>> GetLatestNews() => await _newsRepository.GetAllNewsesByCount(8);
}
