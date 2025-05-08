using SuperHerois.Api.Data;

namespace SuperHerois.Api.Repositories;

public class FilmeRepository : IFilmeRepository
{
    private readonly AppDbContext _appDbContext;

    public FilmeRepository(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }
}