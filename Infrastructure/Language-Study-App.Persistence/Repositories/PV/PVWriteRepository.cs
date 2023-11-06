using Language_Study_App.Application.Repositories;
using Language_Study_App.Domain.Entities;
using Language_Study_App.Persistence.Contexts;

namespace Language_Study_App.Persistence.Repositories
{
    public class PVWriteRepository : WriteRepository<PV>, IPVWriteRepository
    {
        public PVWriteRepository(LanguageStudyAppDb context) : base(context)
        {
        }
    }
}
