using DomainLayer;
namespace ApplicationLayer;

public interface ITopFilmsViewer
{
    Task<List<MainPageMovieDto>> GetAllMovies();
   Task< string> CreatePhotos(string uri, string nameMovie);
   Task<int>CreateGenre(string genreMovie);
   Task<int>CreateStudio(string uri, string studioName);
}

