using ApplicationLayer;
using AutoMapper;
using DomainLayer;
using Microsoft.EntityFrameworkCore;

namespace InfrastructureLayer;

public class TopFilmsViewerRepository : ITopFilmsViewer
{
    private readonly TopFilmsDbContext _dbContext;
    private readonly IMapper _mapper;

    public TopFilmsViewerRepository(TopFilmsDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    public async Task<List<MainPageMovieDto>> GetAllMovies()
    {
        var movies = await _dbContext.Movies
        .Include(m => m.Genres)
        .Include(m => m.Studios)
        .Include(m => m.Photos)
        .ToListAsync();
        return _mapper.Map<List<Movie>,List<MainPageMovieDto>>(movies);
    }
}
