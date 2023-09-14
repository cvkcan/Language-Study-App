using Language_Study_App.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Language_Study_App.Application.Features.Queries
{
    public class GetByWordQuery
    {
        private readonly IWordReadRepository _wordReadRepository;

        public GetByWordQuery(IWordReadRepository wordReadRepository)
        {
            _wordReadRepository = wordReadRepository;
        }
        public void GetBy()
        {

        }
    }
}
