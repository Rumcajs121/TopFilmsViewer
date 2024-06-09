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

    public async Task CreateMovie(CreateMovieDto movieDto)
    {
        var movie=_mapper.Map<Movie>(movieDto);
        await _dbContext.AddAsync<Movie>(movie);
        await _dbContext.SaveChangesAsync();
    }
    #region Create
    // public Task<int> CreateGenre(string genreMovie)
    // {
    //     using (var transaction = _dbContext.Database.BeginTransaction())
    //     {
    //         try
    //         {
    //             AddGenreDto newGenre = new AddGenreDto()
    //             {
    //                 Name = genreMovie,
    //                 GuidGenre = Guid.NewGuid()
    //             };

    //             Genre genre = _mapper.Map<Genre>(newGenre);
    //             var dbGenre = _dbContext.Add<Genre>(genre);
    //             _dbContext.SaveChanges();
    //             transaction.Commit();
    //             return Task.FromResult(genre.Id);
    //         }
    //         catch (Exception ex)
    //         {
    //             transaction.Rollback();
    //             throw new Exception("Add genre fail", ex);
    //         }
    //     }
    // }

    // public Task<int> CreateStudio(AddStudioDto studioDto)
    // {
    //     using (var transaction = _dbContext.Database.BeginTransaction())
    //     {
    //         try
    //         {
    //             Studio newStudio = _mapper.Map<Studio>(studioDto);
    //             _dbContext.Add<Studio>(newStudio);
    //             _dbContext.SaveChanges();
    //             transaction.Commit();
    //             return Task.FromResult(newStudio.Id);

    //         }catch (Exception ex)
    //         {
    //             transaction.Rollback();
    //             throw new Exception("Add studio fail", ex);
    //         }
    //     }
    // }
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
