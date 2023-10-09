using Language_Study_App.Application.Repositories;
using Language_Study_App.Domain.Entities;
using Language_Study_App.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Language_Study_App.Application.Features.Queries
{
    public class GetCount
    {
        private readonly IWordReadRepository _wordReadRepository;
        private readonly ITranslateReadRepository _translateReadRepository;
        private readonly IPVReadRepository _pvReadRepository;
        private readonly IAllEntitieReadRepository _allEntitieReadRepository;

        public GetCount(IWordReadRepository wordReadRepository, IPVReadRepository pvReadRepository, ITranslateReadRepository translateReadRepository, IAllEntitieReadRepository allEntitieReadRepository)
        {
            _wordReadRepository = wordReadRepository;
            _pvReadRepository = pvReadRepository;
            _translateReadRepository = translateReadRepository;
            _allEntitieReadRepository = allEntitieReadRepository;
        }

        public async Task<int> GetByIdCount<T>() where T : BaseEntitiy
        {
            int data = 0;
            if (typeof(T) == typeof(Word))
            {
                data = await _wordReadRepository.GetByCountId();
            }
            else if (typeof(T) == typeof(Translate))
            {
                data =  await _translateReadRepository.GetByCountId();
            }
            else if (typeof(T) == typeof(PV))
            {
                data = await _pvReadRepository.GetByCountId();
            }
            else if (typeof(T) == typeof(AllEntitie))
            {
                data =  await _allEntitieReadRepository.GetByCountId();
            }
            return data;
        }
    }
}
