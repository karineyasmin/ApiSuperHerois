using SuperHerois.Api.Data;

namespace SuperHerois.Api.Repositories;

public class SuperPoderRepository : ISuperPoderRespository
{
    private readonly AppDbContext _appDbContext;

    public SuperPoderRepository(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }
}
