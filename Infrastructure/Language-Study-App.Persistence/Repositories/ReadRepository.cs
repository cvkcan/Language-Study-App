using Language_Study_App.Application.Repositories;
using Language_Study_App.Domain.Entities.Common;
using Language_Study_App.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Language_Study_App.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntitiy
    {
        private readonly LanguageStudyAppDb _context;

        public ReadRepository(LanguageStudyAppDb context)
        {
            _context = context;
        }

        public DbSet<T> Table { get => _context.Set<T>(); set => throw new NotImplementedException(); }

        public async Task<T> GetByIdAsync(string id, bool tracking = true)
        {
            var query= Table.AsQueryable();
            if (!tracking)
                query=query.AsNoTracking();
            return await query.FirstOrDefaultAsync(d => d.Id == Guid.Parse(id));
        }

        public IQueryable<T> GettAll(bool tracking = false)
        {
            var query = Table.AsQueryable();
            return query;
        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method, bool tracking)
        {
            throw new NotImplementedException();
        }
    }
}
