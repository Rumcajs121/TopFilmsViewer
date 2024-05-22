namespace DomainLayer;

public class Movie
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Director { get; set; }
    public DateTime ReleaseDate { get; set; }
    public List<Photo> Photos { get; set; }=new List<Photo>();
    
    public List<Comment> Comments{ get; set; }=new List<Comment>();
    public Trailer Trailer { get; set; }
    public int GenreId { get; set; }
    public Genre Genres { get; set; }

    public int StudioId { get; set; }
    public Studio Studios { get; set; }


}
