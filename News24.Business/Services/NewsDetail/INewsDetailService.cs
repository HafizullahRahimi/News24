using News24.DTOs.Newses;

namespace News24.Business.Services.NewsDetail;
public interface INewsDetailService
{
    public Task<DisplayNewsDTO> GetNewsById(int newsId);
}