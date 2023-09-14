using Language_Study_App.Application.Repositories;
using Language_Study_App.Domain.Entities;
using Language_Study_App.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
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
            var product =await _wordReadRepository.GetByIdAsync(id);
            return product;
        }
    }
}
