namespace ApplicationLayer;

public class MainPageMovieDto
{
    public required string Title { get; set; }
    public required string? Director { get; set; }
    public required string?  MiniaturePhoto { get; set; }
    public string? Genre { get; set; }
    public string? Studio { get; set; }
}
