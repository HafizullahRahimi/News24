using AutoMapper;
using News24.Business.Repository.IRepository;
using News24.DTOs.Newses;

namespace News24.Business.Services.NewsDetail;
public class NewsDetailService : INewsDetailService
{
    private readonly INewsRepository _newsRepository;
    private readonly IMapper _mapper;

    public NewsDetailService(INewsRepository NewsRepository, IMapper mapper)
    {

        _newsRepository = NewsRepository;
        _mapper = mapper;
    }

    public async Task<DisplayNewsDTO> GetNewsById(int newsId)
    {
        var news = await _newsRepository.GetNewsById(newsId);
        var result = _mapper.Map<NewsDTO, DisplayNewsDTO>(news);
        return result;
    }
}