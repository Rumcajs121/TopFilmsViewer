namespace DomainLayer;

public class Trailer
{
    public int Id { get; set; }
    public string Uri { get; set; }
    public int MovieId { get; set; }
    public Movie Movie { get; set; }

}
