using AutoMapper;
using News24.Business.Common.Extension;
using News24.Business.DTOs.Newses;
using News24.Data.Entities;


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