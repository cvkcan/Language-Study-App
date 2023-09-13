using Language_Study_App.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Language_Study_App.Application.Repositories
{
    public interface IReadRepository<T>  : IRepository<T> where T : BaseEntitiy
    {
        IQueryable<T> GettAll();
        IQueryable<T> GetWhere(Expression<Func<T, bool>> method);
    }
}
