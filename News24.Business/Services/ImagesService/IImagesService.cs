using News24.Business.DTOs.Newses;

namespace News24.Business.Services.ImagesService;
public interface IImagesService
{
    public Task<IEnumerable<NewsDTO>> GetImgs();
}
