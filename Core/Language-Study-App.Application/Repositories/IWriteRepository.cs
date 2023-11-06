using Language_Study_App.Domain.Entities.Common;

namespace Language_Study_App.Application.Repositories
{
    public interface IWriteRepository<T> : IRepository<T> where T : BaseEntitiy
    {
        Task<bool> AddAsync(T model);
        bool Update(T model);
        Task<int> SaveChangesAsync();
    }
}
