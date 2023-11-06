using Language_Study_App.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;

namespace Language_Study_App.Application.Repositories
{
    public interface IRepository<T> where T : BaseEntitiy
    {
         DbSet<T> Table { get; set; }
    }
}
