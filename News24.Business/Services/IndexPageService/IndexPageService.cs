using News24.Business.DTOs.Newses;
using News24.Business.Repositories.NewsRepository;

namespace News24.Business.Services.IndexPageService;
public class IndexPageService : IIndexPageService
{
    private readonly INewsRepository _newsRepository;
    public IndexPageService(INewsRepository NewsRepository) => _newsRepository = NewsRepository;

    public async Task<IEnumerable<NewsDTO>> GetSliderItems() => await _newsRepository.GetAllNewsesByCount(2);

    public async Task<IEnumerable<NewsDTO>> GetImgs() => await _newsRepository.GetAllNewsesByCount(5);

    public async Task<IEnumerable<NewsDTO>> GetLatestNews() => await _newsRepository.GetAllNewsesByCount(8);
}
