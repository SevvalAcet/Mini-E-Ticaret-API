using ETicaretAPI.Application.Repositories;
using ETicaretAPI.Domain.Entitites;

namespace ETicaretAPI.Persistence.Repositories
{
    public class OrderReadRepository : ReadRepository<Order>, IOrderReadRepository
    {
    }
}
