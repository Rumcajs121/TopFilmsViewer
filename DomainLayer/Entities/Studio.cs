namespace DomainLayer;

public class Studio
{
    public int Id { get; set; }
    public Guid GuidNormalized { get; set; }
    public string LogoUri { get; set; }
    public string StudioName { get; set; }
    public List<Movie> Movies{ get; set; }=new List<Movie>();
    
}
