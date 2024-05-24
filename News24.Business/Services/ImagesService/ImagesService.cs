using News24.Business.DTOs.Newses;
using News24.Business.Repositories.NewsRepository;

namespace News24.Business.Services.ImagesService;
public class ImagesService : IImagesService
{
    private readonly INewsRepository _newsRepository;
    public ImagesService(INewsRepository NewsRepository) => _newsRepository = NewsRepository;
    public async Task<IEnumerable<NewsDTO>> GetImgs() => await _newsRepository.GetAllNewsesByCount(5);

}
