using Language_Study_App.Application.Repositories;
using Language_Study_App.Domain.Entities;
using Language_Study_App.Persistence.Contexts;

namespace Language_Study_App.Persistence.Repositories
{
    public class TranslateWriteRepository : WriteRepository<Translate>, ITranslateWriteRepository
    {
        public TranslateWriteRepository(LanguageStudyAppDb context) : base(context)
        {
        }
    }
}
