using SuperHerois.Api.Entities;

namespace SuperHerois.Api.Data;

public class Query
{
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public IQueryable<SuperHeroi> GetSuperHerois(
        [Service] AppDbContext context) => context.SuperHerois;
}

