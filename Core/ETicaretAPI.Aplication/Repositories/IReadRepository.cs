using ETicaretAPI.Domain.Entitites.Common;
using System.Linq.Expressions;

namespace ETicaretAPI.Application.Repositories
{
    public interface IReadRepository<T> : IRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll(bool tracking = true);
        IQueryable<T> GetWhere(Expression<Func<T, bool>> method, bool tracking = true);
        Task<T> GetSingle(Expression<Func<T, bool>> method, bool tracking = true);
        Task<T> GetByIdAsync(String id, bool tracking = true);
    }
}
