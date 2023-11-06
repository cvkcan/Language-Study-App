using Language_Study_App.Application.Repositories;
using Language_Study_App.Domain.Entities;
using Language_Study_App.Domain.Entities.Common;

namespace Language_Study_App.Application.Features.Queries
{
    public class GetByIdQuery
    {
        private readonly IWordReadRepository _wordReadRepository;
        private readonly ITranslateReadRepository _translateReadRepository;
        private readonly IPVReadRepository _pvReadRepository;
        private readonly IAllEntitieReadRepository _allEntitieReadRepository;

        public GetByIdQuery(IWordReadRepository wordReadRepository, IPVReadRepository pvReadRepository, ITranslateReadRepository translateReadRepository, IAllEntitieReadRepository allEntitieReadRepository)
        {
            _wordReadRepository = wordReadRepository;
            _pvReadRepository = pvReadRepository;
            _translateReadRepository = translateReadRepository;
            _allEntitieReadRepository = allEntitieReadRepository;
        }
        public async Task<T> GetById<T>(int id) where T : BaseEntitiy
        {
            object data=null;
            if (typeof(T) == typeof(Word))
            {
                data=await _wordReadRepository.GetByIdAsync(id);
            }
            else if (typeof(T) == typeof(Translate))
            {
                data= await _translateReadRepository.GetByIdAsync(id);
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
