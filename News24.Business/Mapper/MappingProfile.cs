using AutoMapper;
using News24.Business.Extension;
using News24.Data.Entities;
using News24.DTOs.Newses;

namespace News24.Business.Mapper;
public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<NewsDTO, News>();
        CreateMap<News, NewsDTO>();

        CreateMap<News, DisplayNewsDTO>()
            .ForMember(d => d.CreateDate, n => n.MapFrom(src => src.CreateDate.ToShamsi()));        
        CreateMap<NewsDTO, DisplayNewsDTO>()
            .ForMember(d => d.CreateDate, n => n.MapFrom(src => src.CreateDate.ToShamsi()));
    }
}