namespace DomainLayer;

public class Movie : UniqueId
{
    public required string Title { get; set; }
    public required string Director { get; set; }
    public required string Description { get; set; }
    public required string ReleaseDate { get; set; }
    public virtual ICollection<Photo> Photos { get; set; }=[];
    public virtual ICollection<Comment> Comments{ get; set; }=[];
    public virtual Trailer? Trailer { get; set; }
    public required int GenreId { get; set; }
    public required Genre Genres { get; set; }

    public required int StudioId { get; set; }
    public required Studio Studios { get; set; }

}
