namespace DomainLayer;

public class Studio:UniqueId
{
    public required Guid GuidNormalized { get; set; }
    public string? LogoUri { get; set; }
    public required string StudioName { get; set; }
    public virtual ICollection<Movie> Movies{ get; set; }=new List<Movie>();
    
}
