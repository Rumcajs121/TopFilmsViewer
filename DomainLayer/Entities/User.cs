namespace DomainLayer;

public class User
{
    public int Id { get; set; }
    public string Email { get; set; }
    public string HashPassword{ get; set; }
    public string Login { get; set; }
    public string  Country { get; set; }
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string Role { get; set; }
    public List<Comment> Comments { get; set; }=new List<Comment>();

}
