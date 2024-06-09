namespace ApplicationLayer;

public interface ITopFilmsViewer
{
    Task<List<MainPageMovieDto>> GetAllMovies();
    Task CreateMovie(CreateMovieDto movieDto);
//    Task< string> CreatePhotos(string uri, string nameMovie);
//    Task<int>CreateGenre(string genreMovie);
//     Task<int>CreateStudio(AddStudioDto studioDto);
}

