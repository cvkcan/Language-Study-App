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
        private readonly GetByIdQuery _getByIdQuery;

        public UpdateCommand(IPVWriteRepository pvWriteRepository, ITranslateWriteRepository translateWriteRepository, IWordWriteRepository wordWriteRepository, IAllEntiteWriteRepository allEntiteWriteRepository, GetByIdQuery getByIdQuery)
        {
            _pvWriteRepository = pvWriteRepository;
            _translateWriteRepository = translateWriteRepository;
            _wordWriteRepository = wordWriteRepository;
            _allEntiteWriteRepository = allEntiteWriteRepository;
            _getByIdQuery = getByIdQuery;
        }
       public async Task<bool> Update<T> (int id, T entity) where T : BaseEntitiy
       {
            var data = await _getByIdQuery.GetById(id);
            if (entity is Word word)
            {
                data.TurkishMean = word.TurkishMean;
                data.EnglishMean = word.EnglishMean;
                data.EnglishWord = word.EnglishWord;
                data.StateType = word.StateType;
                data.Sentece = word.Sentece;
                await _wordWriteRepository.SaveChangesAsync();
            }
            else if (entity is Translate translate)
            {
                data.TurkishMean = translate.TurkishMean;
                data.EnglishMean = translate.EnglishMean;
                data.EnglishWord = translate.EnglishTranslate;
                data.StateType = translate.StateType;
                data.Sentece = translate.Sentece;
                await _translateWriteRepository.SaveChangesAsync();
            }
            else if (entity is PV pv)
            {
                data.TurkishMean = pv.TurkishMean;
                data.EnglishMean = pv.EnglishMean;
                data.EnglishWord = pv.EnglishPV;
                data.StateType = pv.StateType;
                data.Sentece = pv.Sentece;
                await _pvWriteRepository.SaveChangesAsync();
            }
            else if (entity is AllEntitie allEntitie)
            {
                data.TurkishMean = allEntitie.TurkishMean;
                data.EnglishMean = allEntitie.EnglishMean;
                data.EnglishWord = allEntitie.EnglishAllEntite;
                data.StateType = allEntitie.StateType;
                data.Sentece = allEntitie.Sentece;
                await _allEntiteWriteRepository.SaveChangesAsync();
            }
            return new();
       }

    }
}
