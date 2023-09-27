using Language_Study_App.Application.Repositories;
using Language_Study_App.Domain.Entities;
using Language_Study_App.Domain.Entities.Common;
using Language_Study_App.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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


        public List<T> GetBySentece<T>(Type entityType, string value) where T : BaseEntitiy
        {
            List<T> result = new();

            if (entityType == typeof(Word))
            {
                List<Word> words = _wordReadRepository.GetWhere(s => s.Sentece.Contains(value)).ToList();
                result.AddRange(words.Cast<T>());
            }
            else if (entityType == typeof(Translate))
            {
                List<Translate> translate = _translateReadRepository.GetWhere(s => s.Sentece.Contains(value)).ToList();
                result.AddRange(translate.Cast<T>());
            }
            else if (entityType == typeof(PV))
            {
                List<PV> pvs = _pvReadRepository.GetWhere(s => s.Sentece.Contains(value)).ToList();
                result.AddRange(pvs.Cast<T>());
            }
            else if (entityType == typeof(AllEntitie))
            {
                List<AllEntitie> allEntities = _allEntitieReadRepository.GetWhere(s => s.Sentece.Contains(value)).ToList();
                result.AddRange(allEntities.Cast<T>());
            }
            return result;
        }
        public List<T> GetByTurkishMean<T>(Type entityType,string value) where T : BaseEntitiy
        {
            List<T> result = new();

            if (entityType == typeof(Word))
            {
                List<Word> words = _wordReadRepository.GetWhere(s => s.TurkishMean.Contains(value)).ToList();
                result.AddRange(words.Cast<T>());
            }
            else if (entityType == typeof(Translate))
            {
                List<Translate> translate = _translateReadRepository.GetWhere(s => s.TurkishMean.Contains(value)).ToList();
                result.AddRange(translate.Cast<T>());
            }
            else if (entityType == typeof(PV))
            {
                List<PV> pvs = _pvReadRepository.GetWhere(s => s.TurkishMean.Contains(value)).ToList();
                result.AddRange(pvs.Cast<T>());
            }
            else if (entityType == typeof(AllEntitie))
            {
                List<AllEntitie> allEntities = _allEntitieReadRepository.GetWhere(s => s.TurkishMean.Contains(value)).ToList();
                result.AddRange(allEntities.Cast<T>());
            }
            return result;
        }
        public List<T> GetByEnglishMean<T>(Type entityType ,string value) where T : BaseEntitiy
        {
            List<T> result = new();

            if (entityType  == typeof(Word))
            {
                List<Word> words = _wordReadRepository.GetWhere(s => s.EnglishMean.Contains(value)).ToList();
                result.AddRange(words.Cast<T>());
            }
            else if (entityType == typeof(Translate))
            {
                List<Translate> translates = _translateReadRepository.GetWhere(s => s.EnglishMean.Contains(value)).ToList();
                result.AddRange(translates.Cast<T>());
            }
            else if (entityType == typeof(PV))
            {
                List<PV> pvs = _pvReadRepository.GetWhere(s => s.EnglishMean.Contains(value)).ToList();
                result.AddRange(pvs.Cast<T>());
            }
            else if (entityType == typeof(AllEntitie))
            {
                List<AllEntitie> allEntities = _allEntitieReadRepository.GetWhere(s => s.EnglishMean.Contains(value)).ToList();
                result.AddRange(allEntities.Cast<T>());
            }

            return result;
        }
        public List<T> GetByEnglishWord<T>(Type entityType, string value) where T :BaseEntitiy
        {
            List<T> result = new();

            if (entityType == typeof(Word))
            {
                List<Word> words = _wordReadRepository.GetWhere(s => s.EnglishWord.Contains(value)).ToList();
                result.AddRange(words.Cast<T>());
            }
            else if (entityType == typeof(Translate))
            {
                List<Translate> translates = _translateReadRepository.GetWhere(s => s.EnglishTranslate.Contains(value)).ToList();
                result.AddRange(translates.Cast<T>());
            }
            else if (entityType == typeof(PV))
            {
                List<PV> pvs = _pvReadRepository.GetWhere(s => s.EnglishPV.Contains(value)).ToList();
                result.AddRange(pvs.Cast<T>());
            }
            else if (entityType == typeof(AllEntitie))
            {
                List<AllEntitie> allEntities = _allEntitieReadRepository.GetWhere(s => s.EnglishAllEntite.Contains(value)).ToList();
                result.AddRange(allEntities.Cast<T>());
            }

            return result;
        }
        public List<T> GetByStatus<T>(Type entityType, StateTypes value) where T : BaseEntitiy
        {
            List<T> result = new List<T>();

            if (entityType == typeof(Word))
            {
                List<Word> words = _wordReadRepository.GetWhere(s => s.StateType == value).ToList();
                result.AddRange(words.Cast<T>());
            }
            else if (entityType == typeof(Translate))
            {
                List<Translate> translates = _translateReadRepository.GetWhere(s => s.StateType == value).ToList();
                result.AddRange(translates.Cast<T>());
            }
            else if (entityType == typeof(PV))
            {
                List<PV> pvs = _pvReadRepository.GetWhere(s => s.StateType == value).ToList();
                result.AddRange(pvs.Cast<T>());
            }
            else if (entityType == typeof(AllEntitie))
            {
                List<AllEntitie> allEntities = _allEntitieReadRepository.GetWhere(s => s.StateType == value).ToList();
                result.AddRange(allEntities.Cast<T>());
            }

            return result;
        }

    }
}
