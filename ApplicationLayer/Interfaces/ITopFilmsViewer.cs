namespace ApplicationLayer;

public interface ITopFilmsViewer
{
    Task<List<MainPageMovieDto>> GetAllMovies();
<<<<<<< HEAD
   Task< string> CreatePhotos(string uri, string nameMovie);
   Task<int>CreateGenre(string genreMovie);
   Task<int>CreateStudio(string uri, string studioName);
=======
>>>>>>> parent of 7de393d (feat(Dto/AddPhotoMethod) I created one method with add new photo in the feature i propably use blob storage for save all photo and must refactoring this code . this method return string Uri for link and was use transaction for my database)
}

