using Language_Study_App.Application.Features.Queries;
using Language_Study_App.Application.Repositories;
using Language_Study_App.Domain.Entities;
using Language_Study_App.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Language_Study_App.Application.Features.Commands
{
    public class UpdateCommand
    {
        private readonly IAllEntiteWriteRepository _allEntiteWriteRepository;
        private readonly IWordWriteRepository _wordWriteRepository;
        private readonly ITranslateWriteRepository _translateWriteRepository;
        private readonly IPVWriteRepository _pvWriteRepository;
        //private readonly GetByIdQuery _getByIdQuery;
        private readonly GetByQuery _getByQuery;

        public UpdateCommand(IPVWriteRepository pvWriteRepository, ITranslateWriteRepository translateWriteRepository, IWordWriteRepository wordWriteRepository, IAllEntiteWriteRepository allEntiteWriteRepository,/* GetByIdQuery getByIdQuery*/GetByQuery getByQuery)
        {
            _pvWriteRepository = pvWriteRepository;
            _translateWriteRepository = translateWriteRepository;
            _wordWriteRepository = wordWriteRepository;
            _allEntiteWriteRepository = allEntiteWriteRepository;
            _getByQuery = getByQuery;
            //_getByIdQuery = getByIdQuery;
        }
        public async Task<bool> Update<T> (int id, T entity) where T : BaseEntitiy
       {
            if (entity is Word word)
            {
                var data = await _getByQuery.GetById<Word>(id);
                data.TurkishMean = word.TurkishMean;
                data.EnglishMean = word.EnglishMean;
                data.EnglishWord = word.EnglishWord;
                data.StateType = word.StateType;
                data.Sentece = word.Sentece;
                await _wordWriteRepository.SaveChangesAsync();
            }
            else if (entity is Translate translate)
            {
                var data = await _getByQuery.GetById<Translate>(id);
                data.TurkishMean = translate.TurkishMean;
                data.EnglishMean = translate.EnglishMean;
                data.EnglishTranslate = translate.EnglishTranslate;
                data.StateType = translate.StateType;
                data.Sentece = translate.Sentece;
                await _translateWriteRepository.SaveChangesAsync();
            }
            else if (entity is PV pv)
            {
                var data = await _getByQuery.GetById<PV>(id);
                data.TurkishMean = pv.TurkishMean;
                data.EnglishMean = pv.EnglishMean;
                data.EnglishPV = pv.EnglishPV;
                data.StateType = pv.StateType;
                data.Sentece = pv.Sentece;
                await _pvWriteRepository.SaveChangesAsync();
            }
            else if (entity is AllEntitie allEntitie)
            {
                var data = await _getByQuery.GetById<AllEntitie>(id);
                data.TurkishMean = allEntitie.TurkishMean;
                data.EnglishMean = allEntitie.EnglishMean;
                data.EnglishAllEntite = allEntitie.EnglishAllEntite;
                data.StateType = allEntitie.StateType;
                data.Sentece = allEntitie.Sentece;
                await _allEntiteWriteRepository.SaveChangesAsync();
            }
            return new();
       }

    }
}
