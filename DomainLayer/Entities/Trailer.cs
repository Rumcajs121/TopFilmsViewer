namespace DomainLayer;

public class Trailer:UniqueId
{
    public required string Uri { get; set; }
    public int MovieId { get; set; }
    public virtual required Movie Movie { get; set; }

}
