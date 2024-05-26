namespace DomainLayer;

public class Movie : UniqueId
{
    public required string Title { get; set; }
    public required string Director { get; set; }
    public DateTime ReleaseDate { get; set; }
    public virtual ICollection<Photo> Photos { get; set; }=[];
    public virtual ICollection<Comment> Comments{ get; set; }=[];
    public virtual required Trailer Trailer { get; set; }
    public int GenreId { get; set; }
    public virtual required Genre Genres { get; set; }

    public int StudioId { get; set; }
    public virtual required Studio Studios { get; set; }

}
