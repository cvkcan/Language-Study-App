using Language_Study_App.Application.Repositories;
using Language_Study_App.Domain.Entities;
using Language_Study_App.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Language_Study_App.Persistence.Repositories
{
    public class WordWriteRepository : WriteRepository<Word> , IWordWriteRepository
    {
        public WordWriteRepository(LanguageStudyAppDb context) : base(context)
        {
        }
    }
}
