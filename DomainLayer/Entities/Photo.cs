﻿

namespace DomainLayer;

public class Photo :UniqueId
{
    public required string Uri { get; set; }
    public int MovieId { get; set; }
    public virtual required Movie Movie { get; set; }
    

}
