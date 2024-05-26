using ApplicationLayer;

namespace DomainLayer;

public interface ITopFilmsViewer
{
    Task<List<MainPageMovieDto>> GetAllMovies();
}
