namespace DomainLayer;

public class Genre:UniqueId
{
    public Guid GuidGenre { get; set; }
    public required string  Name { get; set; }
    public ICollection<Movie> Movies { get; set; } = new List<Movie>();
    
}
