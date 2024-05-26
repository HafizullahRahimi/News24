﻿using News24.Business.DTOs.Newses;
using News24.Business.Repositories.NewsRepository;

namespace News24.Business.Services.MainSliderService;
public class MainSliderService : IMainSliderService
{
    private readonly INewsRepository _newsRepository;
    public MainSliderService(INewsRepository NewsRepository) => _newsRepository = NewsRepository;
    public async Task<IEnumerable<NewsDTO>> GetSliderItems() => await _newsRepository.GetAllNewsesByCount(2);

}