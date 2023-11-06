using Language_Study_App.Application.Repositories;
using Language_Study_App.Domain.Entities.Common;
using Language_Study_App.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Language_Study_App.Persistence.Repositories
{
    public class Repository<T> : IRepository<T> where T : BaseEntitiy
    {
        private readonly LanguageStudyAppDb _context;

        public Repository(LanguageStudyAppDb context)
        {
            _context = context;
        }

        public DbSet<T> Table { get => _context.Set<T>(); set => throw new NotImplementedException(); }
    }
}
