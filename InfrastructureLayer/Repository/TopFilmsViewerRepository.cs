using DomainLayer;

namespace InfrastructureLayer;

public class TopFilmsViewerRepository:ITopFilmsViewer
{
    private readonly TopFilmsDbContext _dbContext;

    public TopFilmsViewerRepository(TopFilmsDbContext dbContext)
     {
        _dbContext = dbContext;
    }
    
}
