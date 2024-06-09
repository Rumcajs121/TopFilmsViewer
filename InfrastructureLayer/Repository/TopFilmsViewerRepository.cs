using ApplicationLayer;
using AutoMapper;
using DomainLayer;
using Microsoft.EntityFrameworkCore;

namespace InfrastructureLayer.Repository;

public class TopFilmsViewerRepository : ITopFilmsViewer
{
    private readonly TopFilmsDbContext _dbContext;
    private readonly IMapper _mapper;

    public TopFilmsViewerRepository(TopFilmsDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    public Task<string> CreatePhotos(string uri, string nameMovie)
    {
        using (var transaction = _dbContext.Database.BeginTransaction())
        {
            try
            {
                Movie movie = _dbContext.Movies.FirstOrDefault(x => nameMovie == x.Title);
                AddPhotosDto photoDto = new AddPhotosDto()
                {
                    Uri = uri,
                    MovieId = movie.Id
                };
                Photo photo = _mapper.Map<Photo>(photoDto);
                _dbContext.Add<Photo>(photo);
                _dbContext.SaveChanges();
                transaction.Commit();
                return Task.FromResult(photo.Uri);
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw new Exception("Add image fail", ex);
            }
        }

    }

    public async Task<List<MainPageMovieDto>> GetAllMovies()
    {
        var movies = await _dbContext.Movies
        .Include(m => m.Genres)
        .Include(m => m.Studios)
        .Include(m => m.Photos)
        .ToListAsync();
        return _mapper.Map<List<Movie>, List<MainPageMovieDto>>(movies);
    }
}
