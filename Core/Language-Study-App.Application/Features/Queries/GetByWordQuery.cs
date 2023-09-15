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
    public class GetByWordQuery
    {
        private readonly IWordReadRepository _wordReadRepository;
        private readonly ITranslateReadRepository _translateReadRepository;
        private readonly IPVReadRepository _pvReadRepository;
        private readonly IAllEntitieReadRepository _allEntitieReadRepository;

        public GetByWordQuery(IWordReadRepository wordReadRepository, IPVReadRepository pvReadRepository, ITranslateReadRepository translateReadRepository, IAllEntitieReadRepository allEntitieReadRepository)
        {
            _wordReadRepository = wordReadRepository;
            _pvReadRepository = pvReadRepository;
            _translateReadRepository = translateReadRepository;
            _allEntitieReadRepository = allEntitieReadRepository;
        }
        public async Task<T> GetByWord<T>(string word) where T : BaseEntitiy
        {
            object datas = null;
            if (typeof(T) == typeof(Word))
            {
                datas = await _wordReadRepository.GetByWordAsync(word);
            }
            else if (typeof(T) == typeof(Translate))
            {
                datas = await _translateReadRepository.GetByWordAsync(word);
            }
            else if (typeof(T) == typeof(PV))
            {
                datas = await _pvReadRepository.GetByWordAsync(word);
            }
            else if (typeof(T) == typeof(AllEntitie))
            {
                datas = await _allEntitieReadRepository.GetByWordAsync(word);
            }
            return (T)datas;

        }
    }
}
