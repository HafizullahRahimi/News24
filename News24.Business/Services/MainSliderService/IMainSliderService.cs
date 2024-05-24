using News24.Business.DTOs.Newses;

namespace News24.Business.Services.MainSliderService;
public interface IMainSliderService
{
    public Task<IEnumerable<NewsDTO>> GetSliderItems();
}
