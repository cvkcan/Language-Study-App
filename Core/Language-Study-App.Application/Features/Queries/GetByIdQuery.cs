using Language_Study_App.Application.Repositories;
using Language_Study_App.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Language_Study_App.Application.Features.Queries
{
    public class GetByIdQuery
    {
        private readonly IWordReadRepository _wordReadRepository;

        public GetByIdQuery(IWordReadRepository wordReadRepository)
        {
            _wordReadRepository = wordReadRepository;
        }

        public async Task<Word> GetByIdWord(string id)
        {
            var data = await _wordReadRepository.GetByIdAsync(id);
            return data;
        }
    }
}
