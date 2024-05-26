namespace DomainLayer;

public class User:UniqueId
{
    public required string Email { get; set; }
    public required string HashPassword{ get; set; }
    public required string Login { get; set; }
    public string?  Country { get; set; }
    public string? LastName { get; set; }
    public string? FirstName { get; set; }
    public string? Role { get; set; }
    public virtual ICollection<Comment> Comments { get; set; }=[];

}
