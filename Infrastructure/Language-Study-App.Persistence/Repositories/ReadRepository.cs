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

        public IQueryable<T> GettAll()
        {
            var query = Table.AsQueryable();
            return query;
        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method)
        {
            throw new NotImplementedException();
        }
    }
}
