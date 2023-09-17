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
    public class GetWhereQuery
    {
        private readonly IWordReadRepository _wordReadRepository;
        private readonly ITranslateReadRepository _translateReadRepository;
        private readonly IPVReadRepository _pvReadRepository;
        private readonly IAllEntitieReadRepository _allEntitieReadRepository;

        public GetWhereQuery(IWordReadRepository wordReadRepository, IPVReadRepository pvReadRepository, ITranslateReadRepository translateReadRepository, IAllEntitieReadRepository allEntitieReadRepository)
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
        public List<T> GetBySentece<T>(string value) where T : BaseEntitiy
        {
            object datas = null;
            if (typeof(T) == typeof(Word))
            {
                datas = _wordReadRepository.GetWhere(s => s.Sentece.Contains(value)).ToList();
            }
            else if (typeof(T) == typeof(Translate))
            {
                datas = _translateReadRepository.GetWhere(s => s.Sentece.Contains(value)).ToList();
            }
            else if (typeof(T) == typeof(PV))
            {
                datas = _pvReadRepository.GetWhere(s => s.Sentece.Contains(value)).ToList();
            }
            else if (typeof(T) == typeof(AllEntitie))
            {
                datas = _allEntitieReadRepository.GetWhere(s => s.Sentece.Contains(value)).ToList();
            }
            return (List<T>)datas;
        }
        public List<T> GetByTurkishMean<T>(string value) where T : BaseEntitiy
        {
            object datas = null;
            if (typeof(T) == typeof(Word))
            {
                datas = _wordReadRepository.GetWhere(s => s.TurkishMean.Contains(value)).ToList();
            }
            else if (typeof(T) == typeof(Translate))
            {
                datas = _translateReadRepository.GetWhere(s => s.TurkishMean.Contains(value)).ToList();
            }
            else if (typeof(T) == typeof(PV))
            {
                datas = _pvReadRepository.GetWhere(s => s.TurkishMean.Contains(value)).ToList();
            }
            else if (typeof(T) == typeof(AllEntitie))
            {
                datas = _allEntitieReadRepository.GetWhere(s => s.TurkishMean.Contains(value)).ToList();
            }
            return (List<T>)datas;
        }
        public List<T> GetByEnglishMean<T>(string value) where T : BaseEntitiy
        {
            object datas = null;
            if (typeof(T) == typeof(Word))
            {
                datas = _wordReadRepository.GetWhere(s => s.EnglishMean.Contains(value)).ToList();
            }
            else if (typeof(T) == typeof(Translate))
            {
                datas = _translateReadRepository.GetWhere(s => s.EnglishMean.Contains(value)).ToList();
            }
            else if (typeof(T) == typeof(PV))
            {
                datas = _pvReadRepository.GetWhere(s => s.EnglishMean.Contains(value)).ToList();
            }
            else if (typeof(T) == typeof(AllEntitie))
            {
                datas = _allEntitieReadRepository.GetWhere(s => s.EnglishMean.Contains(value)).ToList();
            }
            return (List<T>)datas;
        }
        //public List<T> GetByEnglishWord<T>(string value) where T : BaseEntitiy
        //{
        //    object datas = null;
        //    if (typeof(T) == typeof(Word))
        //    {
        //        datas = _wordReadRepository.GetWhere(s => s.EnglishWord.Contains(value)).ToList();
        //    }
        //    else if (typeof(T) == typeof(Translate))
        //    {
        //        datas = _translateReadRepository.GetWhere(s => s.EnglishTranslate.Contains(value)).ToList();
        //    }
        //    else if (typeof(T) == typeof(PV))
        //    {
        //        datas = _pvReadRepository.GetWhere(s => s.EnglishPV.Contains(value)).ToList();
        //    }
        //    else if (typeof(T) == typeof(AllEntitie))
        //    {
        //        datas = _allEntitieReadRepository.GetWhere(s => s.EnglishAllEntite.Contains(value)).ToList();
        //    }
        //    return (List<T>)datas;
        //}
        public List<BaseEntitiy> GetByEnglishWord(Type entityType, string value)
        {
            List<BaseEntitiy> result = new List<BaseEntitiy>();

            if (entityType == typeof(Word))
            {
                List<Word> words = _wordReadRepository.GetWhere(s => s.EnglishWord.Contains(value)).ToList();
                result.AddRange(words.Cast<BaseEntitiy>());
            }
            else if (entityType == typeof(Translate))
            {
                List<Translate> translates = _translateReadRepository.GetWhere(s => s.EnglishTranslate.Contains(value)).ToList();
                result.AddRange(translates.Cast<BaseEntitiy>());
            }
            else if (entityType == typeof(PV))
            {
                List<PV> pvs = _pvReadRepository.GetWhere(s => s.EnglishPV.Contains(value)).ToList();
                result.AddRange(pvs.Cast<BaseEntitiy>());
            }
            else if (entityType == typeof(AllEntitie))
            {
                List<AllEntitie> allEntities = _allEntitieReadRepository.GetWhere(s => s.EnglishAllEntite.Contains(value)).ToList();
                result.AddRange(allEntities.Cast<BaseEntitiy>());
            }

            return result;
        }


    }
}
