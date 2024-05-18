using News24.DTOs.Newses;

namespace News24.Business.Services.NewsDetailService;
public interface INewsDetailService
{
    public Task<DisplayNewsDTO> GetNewsById(int newsId);
}