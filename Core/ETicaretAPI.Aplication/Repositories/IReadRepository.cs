using ETicaretAPI.Domain.Entitites.Common;
using System.Linq.Expressions;

namespace ETicaretAPI.Application.Repositories
{
    public interface IReadRepository<T> : IRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll();
        IQueryable<T> GetWhere(Expression<Func<T, bool>> method);
        Task<T> GetSingle(Expression<Func<T, bool>> method);
        Task<T> GetByIdAsync(String id);
    }
}
