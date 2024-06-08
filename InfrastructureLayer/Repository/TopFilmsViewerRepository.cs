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
#region Create
    public Task<int> CreateGenre(string genreMovie)
    {
        using (var transaction = _dbContext.Database.BeginTransaction())
        {
            try
            {
                AddGenreDto newGenre = new AddGenreDto()
                {
                    Name = genreMovie,
                    GuidGenre = Guid.NewGuid()
                };

                Genre genre = _mapper.Map<Genre>(newGenre);
                var dbGenre = _dbContext.Add<Genre>(genre);
                _dbContext.SaveChanges();
                transaction.Commit();
                return Task.FromResult(genre.Id);
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw new Exception("Add genre fail", ex);
            }
        }
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

    public Task<int> CreateStudio(string uri, string studioName)
    {
        using (var transaction = _dbContext.Database.BeginTransaction())
        {
            try
            {
                AddStudioDto studioDto = new AddStudioDto()
                {
                    LogoUri = uri,
                    StudioName = studioName,
                    GuidNormalized = Guid.NewGuid()
                };
                Studio newStudio = _mapper.Map<Studio>(studioDto);
                _dbContext.Add<Studio>(newStudio);
                _dbContext.SaveChanges();
                transaction.Commit();
                return Task.FromResult(newStudio.Id);

            }catch (Exception ex)
            {
                transaction.Rollback();
                throw new Exception("Add studio fail", ex);
            }
        }
    }
    #endregion
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
