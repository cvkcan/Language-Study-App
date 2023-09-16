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
    public class GetByQuery
    {
        private readonly IWordReadRepository _wordReadRepository;
        private readonly ITranslateReadRepository _translateReadRepository;
        private readonly IPVReadRepository _pvReadRepository;
        private readonly IAllEntitieReadRepository _allEntitieReadRepository;

        public GetByQuery(IWordReadRepository wordReadRepository, IPVReadRepository pvReadRepository, ITranslateReadRepository translateReadRepository, IAllEntitieReadRepository allEntitieReadRepository)
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
        public async Task<T> GetById<T>(int id) where T : BaseEntitiy
        {
            object data = null;
            if (typeof(T) == typeof(Word))
            {
                data = await _wordReadRepository.GetByIdAsync(id);
            }
            else if (typeof(T) == typeof(Translate))
            {
                data = await _translateReadRepository.GetByIdAsync(id);
            }
            else if (typeof(T) == typeof(PV))
            {
                data = await _pvReadRepository.GetByIdAsync(id);
            }
            else if (typeof(T) == typeof(AllEntitie))
            {
                data = await _allEntitieReadRepository.GetByIdAsync(id);
            }
            return (T)data;
        }
    }
}
