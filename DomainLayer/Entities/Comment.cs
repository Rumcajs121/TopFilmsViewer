using System.ComponentModel.DataAnnotations.Schema;

namespace DomainLayer;

public class Comment:UniqueId
{
    public required Guid CommentId { get; set; }
    public required string Opinion { get; set; }
    public required string DateCreated { get; set; }
    public int Note { get; set; }

    public int MovieId { get; set; }
    public virtual required Movie Movie  { get; set; }
    public int UserId { get; set; }
    public virtual required User Users { get; set; }
}
