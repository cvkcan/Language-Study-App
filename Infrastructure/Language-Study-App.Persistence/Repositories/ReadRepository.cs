using Language_Study_App.Application.Repositories;
using Language_Study_App.Domain.Entities;
using Language_Study_App.Domain.Entities.Common;
using Language_Study_App.Domain.Enums;
using Language_Study_App.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

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

  
        public async Task<T> GetByIdAsync(int id, bool tracking = true)
        {
            var query = Table.AsQueryable();
            if (!tracking)
                query = query.AsNoTracking();
            return await query.FirstOrDefaultAsync(d => d.Id == id);
        }

        public async Task<T> GetByWordAsync(string word, bool tracking = true)
        {
            var query = Table.AsQueryable();
            if (!tracking)
                query = query.AsNoTracking();
            object result = null;
            if (typeof(T) == typeof(Word))
               result = await query.OfType<Word>().FirstOrDefaultAsync(w => w.EnglishWord == word);
            else if (typeof(T) == typeof(Translate))
                result = await query.OfType<Translate>().FirstOrDefaultAsync(w => w.EnglishTranslate == word);
            else if (typeof(T) == typeof(PV))
                result = await query.OfType<PV>().FirstOrDefaultAsync(w => w.EnglishPV == word);
            else if (typeof(T) == typeof(AllEntitie))
                result = await query.OfType<AllEntitie>().FirstOrDefaultAsync(w => w.EnglishAllEntite == word);
            return (T)(object)result;

            //Bu kadar işlemi burada yapmak ne kadar doğru bilmiyorum. Kontrol edilecek.
        }

        public IQueryable<T> GettAll(bool tracking = false)
        {
            var query = Table.AsQueryable();
            return query;
        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method, bool tracking)
        {
            var query= Table.AsQueryable();
            if(!tracking)
                query = query.AsNoTracking();
            return query.Where(method);
        }

        public async Task<int> GetByCountId(bool tracking = true)
        {
            var query = Table.AsQueryable();
            if (!tracking)
                query = query.AsNoTracking();
            int value1 = await query.CountAsync();
            return  value1;
        }

    }
}
