using News24.Business.DTOs.Newses;

namespace News24.Business.Services.LatestNewsService;
public interface ILatestNewsService
{
    public Task<IEnumerable<NewsDTO>> GetLatestNews();
}
