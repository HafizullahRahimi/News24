﻿using AutoMapper;
using Microsoft.EntityFrameworkCore;
using News24.Business.Common.Paging;
using News24.Business.DTOs.Newses;
using News24.Data.Context;
using News24.Data.Entities;

namespace News24.Business.Repositories.NewsRepository;
public class NewsRepository : INewsRepository
{
    private readonly IDbContextFactory<ApplicationDbContext> _contextFactory;
    private readonly IMapper _mapper;

    public NewsRepository(IDbContextFactory<ApplicationDbContext> contextFactory, IMapper mapper)
    {
        _contextFactory = contextFactory;
        _mapper = mapper;
    }


    public async Task<NewsDTO> CreateNews(NewsDTO newsDTO)
    {
        using var ctx = await _contextFactory.CreateDbContextAsync();
        var news = _mapper.Map<NewsDTO, News>(newsDTO);
        news.CreatedBy = "";
        news.CreateDate = DateTime.Now;
        var addedNews = await ctx.Newses.AddAsync(news);
        await ctx.SaveChangesAsync();
        return _mapper.Map<News, NewsDTO>(addedNews.Entity);
    }

    public async Task<NewsDTO> UpdateNews(int newsId, NewsDTO newsDTO)
    {
        using var ctx = _contextFactory.CreateDbContext();
        try
        {
            if (newsId == newsDTO.NewsId)
            {
                var newsDetail = await ctx.Newses.FindAsync(newsId);
                var news = _mapper.Map<NewsDTO, News>(newsDTO, newsDetail);
                news.EditedBy = "";
                ctx.Newses.Update(news);
                await ctx.SaveChangesAsync();
                return _mapper.Map<News, NewsDTO>(news);
            }
            else
            {
                return null;
            }
        }
        catch (Exception e)
        {
            return null;
        }
    }

    public async Task<NewsDTO> GetNewsById(int newsId)
    {
        using var ctx = _contextFactory.CreateDbContext();
        try
        {
            var news = _mapper.Map<News, NewsDTO>(await ctx.Newses.SingleOrDefaultAsync(s => s.NewsId == newsId));
            return news;
        }
        catch (Exception e)
        {
            return null;
        }
    }

    public async Task<IEnumerable<NewsDTO>> GetAllNewses()
    {
        using var ctx = _contextFactory.CreateDbContext();
        try
        {
            var newsDTOs = _mapper.Map<IEnumerable<News>, IEnumerable<NewsDTO>>(await ctx.Newses.ToListAsync());
            return newsDTOs;
        }
        catch (Exception e)
        {
            return null;
        }
    }

    public async Task<IEnumerable<NewsDTO>> GetAllNewsesByCount(int count)
    {
        using var ctx = _contextFactory.CreateDbContext();
        try
        {
            var data = await ctx
                .Newses
                .OrderByDescending(s => s.CreateDate)
                .Take(count)
                .ToListAsync();
            IEnumerable<NewsDTO> newsDTOs = _mapper.Map<IEnumerable<News>, IEnumerable<NewsDTO>>(data);
            return newsDTOs;
        }
        catch (Exception e)
        {
            return null;
        }
    }

    public async Task<NewsDTO> IsNewsExistsByTitle(string title, int newsId)
    {
        using var ctx = _contextFactory.CreateDbContext();
       return _mapper.Map<News, NewsDTO>(await ctx.Newses.FirstOrDefaultAsync(s => s.Title == title && s.NewsId != newsId));
    }

    public async Task<int> RemoveNews(int newsId)
    {
        using var ctx = _contextFactory.CreateDbContext();
        var news = await ctx.Newses.FindAsync(newsId);
        if (news != null)
        {
            ctx.Newses.Remove(news);
            await ctx.SaveChangesAsync();

            return news.NewsId;
        }

        return 0;
    }

    public async Task<int> RemoveNews(NewsDTO news) =>
        await RemoveNews(news.NewsId);

    public async Task<FilterNewsesDTO> FilterNewses(FilterNewsesDTO filter)
    {
        using var ctx = _contextFactory.CreateDbContext();
        var query = ctx.Newses.AsQueryable();

        if (!string.IsNullOrEmpty(filter.Title))
        {
            query = query.Where(s => EF.Functions.Like(s.Title, $"%{filter.Title}%"));
        }

        var allEntitiesCount = await query.CountAsync();

        var pager = Pager.Build(filter.Page, filter.Take, allEntitiesCount, filter.HowManyShowAfterBefore);

        var newses = await query.Paging(pager).ToListAsync();

        filter.Newses = _mapper.Map<List<News>, List<NewsDTO>>(newses);

        return filter.SetPaging(pager);
    }
}
