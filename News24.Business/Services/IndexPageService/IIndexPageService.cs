using News24.DTOs.Newses;

namespace News24.Business.Services.IndexPageService;
public interface IIndexPageService
{
    public Task<IEnumerable<NewsDTO>> GetLatestNews();
    public Task<IEnumerable<NewsDTO>> GetSliderItems();
    public Task<IEnumerable<NewsDTO>> GetImgs();
}
