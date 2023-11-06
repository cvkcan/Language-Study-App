using Language_Study_App.Application.Repositories;
using Language_Study_App.Domain.Entities.Common;
using Language_Study_App.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Language_Study_App.Persistence.Repositories
{
    public class WriteRepository<T> : IWriteRepository<T> where T : BaseEntitiy
    {
        private readonly LanguageStudyAppDb _context;

        public WriteRepository(LanguageStudyAppDb context)
        {
            _context = context;
        }

        public DbSet<T> Table { get => _context.Set<T>(); set => throw new NotImplementedException(); }

        public async Task<bool> AddAsync(T model)
        {
            EntityEntry<T> entityEntry = await _context.AddAsync(model);
            return entityEntry.State == EntityState.Added;
        }
        public async Task<int> SaveChangesAsync() => await _context.SaveChangesAsync();

        public bool Update(T model)
        {
            EntityEntry<T> entityEntry = _context.Update(model);
            return entityEntry.State == EntityState.Modified;
        }
    }
}
