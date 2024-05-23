namespace DomainLayer;

public class Comment
{
    public int Id { get; set; }
    public Guid CommentId { get; set; }
    public string Opinion { get; set; }
    public DateTime DateCreated { get; set; }
    public int Note { get; set; }

    public int MovieId { get; set; }
    public Movie Movie  { get; set; }
    public int UserId { get; set; }
    public User Users { get; set; }
}
