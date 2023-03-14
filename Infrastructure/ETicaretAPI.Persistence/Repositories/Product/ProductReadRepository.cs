using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Domain.Entitites;

namespace ETicaretAPI.Persistence.Repositories
{
    public class ProductReadRepository : ReadRepository<Product>, IProductReadRepository
    {
    }
}
