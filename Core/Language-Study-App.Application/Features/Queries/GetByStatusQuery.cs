using Language_Study_App.Application.Repositories;
using Language_Study_App.Domain.Entities;
using Language_Study_App.Domain.Entities.Common;
using Language_Study_App.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Language_Study_App.Application.Features.Queries
{
    public class GetByStatusQuery
    {
        private readonly IWordReadRepository _wordReadRepository;
        private readonly ITranslateReadRepository _translateReadRepository;
        private readonly IPVReadRepository _pvReadRepository;
        private readonly IAllEntitieReadRepository _allEntitieReadRepository;

        public GetByStatusQuery(IWordReadRepository wordReadRepository, IPVReadRepository pvReadRepository, ITranslateReadRepository translateReadRepository, IAllEntitieReadRepository allEntitieReadRepository)
        {
            _wordReadRepository = wordReadRepository;
            _pvReadRepository = pvReadRepository;
            _translateReadRepository = translateReadRepository;
            _allEntitieReadRepository = allEntitieReadRepository;
        }

        public List<T> GetByStatus<T>(StateTypes stateTypes) where T : BaseEntitiy
        {
            object datas = null;  
            if (typeof(T) == typeof(Word))
            {
                datas =  _wordReadRepository.GetWhere(s=>s.StateType == stateTypes).ToList();
            }
            else if (typeof(T) == typeof(Translate))
            {
                datas = _translateReadRepository.GetWhere(s => s.StateType == stateTypes).ToList();
            }
            else if (typeof(T) == typeof(PV))
            {
                datas = _pvReadRepository.GetWhere(s => s.StateType == stateTypes).ToList();
            }
            else if (typeof(T) == typeof(AllEntitie))
            {
                datas = _allEntitieReadRepository.GetWhere(s => s.StateType == stateTypes).ToList();
            }
            return (List<T>)datas;
        }
    }
}
