using SuperHerois.Api.Data;

namespace SuperHerois.Api.Repositories;

public class SuperHeroiRepository : ISuperHeroiRepository
{
    private readonly AppDbContext _appDbContext;

    public SuperHeroiRepository(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }
}
