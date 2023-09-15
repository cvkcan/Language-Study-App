using Language_Study_App.Application.Repositories;
using Language_Study_App.Domain.Entities;
using Language_Study_App.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Language_Study_App.Application.Features.Commands
{
    public class AddCommand
    {
        private readonly IAllEntiteWriteRepository _allEntiteWriteRepository;
        private readonly IWordWriteRepository _wordWriteRepository;
        private readonly ITranslateWriteRepository _translateWriteRepository;
        private readonly IPVWriteRepository _pvWriteRepository;

        public AddCommand(IPVWriteRepository pvWriteRepository, ITranslateWriteRepository translateWriteRepository, IWordWriteRepository wordWriteRepository, IAllEntiteWriteRepository allEntiteWriteRepository)
        {
            _pvWriteRepository = pvWriteRepository;
            _translateWriteRepository = translateWriteRepository;
            _wordWriteRepository = wordWriteRepository;
            _allEntiteWriteRepository = allEntiteWriteRepository;
        }
        public async Task<bool> AddAsync<T>(T entity) where T : BaseEntitiy
        {
            if (entity is Word word)
            {
                await _wordWriteRepository.AddAsync(new()
                {
                    EnglishMean=word.EnglishMean,
                    EnglishWord = word.EnglishWord,
                    Sentece = word.Sentece,
                    TurkishMean = word.TurkishMean
                });
                await _wordWriteRepository.SaveChangesAsync();
            }
            else if (entity is Translate translate)
            {
                await _translateWriteRepository.AddAsync(new()
                {
                    EnglishMean=translate.EnglishMean,
                    EnglishTranslate = translate.EnglishTranslate,
                    Sentece = translate.Sentece,
                    TurkishMean = translate.TurkishMean 
                });
                await _translateWriteRepository.SaveChangesAsync();
            }
            else if (entity is PV pv)
            {
                await _pvWriteRepository.AddAsync(new()
                {
                    EnglishMean=pv.EnglishMean,
                    EnglishPV = pv.EnglishPV,
                    Sentece=pv.Sentece,
                    TurkishMean = pv.TurkishMean
                });
                await _pvWriteRepository.SaveChangesAsync();
            }
            else if (entity is AllEntitie allEntitie)
            {
                await _allEntiteWriteRepository.AddAsync(new()
                {
                    EnglishAllEntite=allEntitie.EnglishAllEntite,
                    EnglishMean = allEntitie.EnglishMean,
                    Sentece=allEntitie.Sentece,
                    TurkishMean = allEntitie.TurkishMean
                });
                await _allEntiteWriteRepository.SaveChangesAsync();
            }
            return true;
        }
    }
}
