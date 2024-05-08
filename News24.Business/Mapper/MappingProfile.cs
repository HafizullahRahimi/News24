using AutoMapper;
using News24.Data.Entities.NewsEntities;
using News24.DTOs.Newses;

namespace News24.Business.Mapper;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<NewsDTO, News>();
        CreateMap<News, NewsDTO>();
    }
}