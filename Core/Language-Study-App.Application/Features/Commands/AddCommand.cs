using Language_Study_App.Application.Repositories;
using Language_Study_App.Domain.Entities;
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

        public async Task<bool> AddAsyncWord(Word word)
        {
            await _wordWriteRepository.AddAsync(new()
            {
                EnglishWord = word.EnglishWord,
                EnglishMean = word.EnglishMean,
                Sentece = word.Sentece,
                TurkishMean = word.TurkishMean
            });
            await _wordWriteRepository.SaveChangesAsync();
            return new();
        }
        public async Task<bool> AddAsyncTranslate(Translate translate)
        {
            await _translateWriteRepository.AddAsync(new()
            {
                EnglishTranslate = translate.EnglishTranslate,
                EnglishMean = translate.EnglishMean,
                Sentece = translate.Sentece,
                TurkishMean = translate.TurkishMean
            });
            await _translateWriteRepository.SaveChangesAsync();
            return new();
        }
        public async Task<bool> AddAsyncAllEntitie(AllEntitie allEntitie)
        {
            await _allEntiteWriteRepository.AddAsync(new()
            {
                EnglishAllEntite = allEntitie.EnglishAllEntite,
                EnglishMean = allEntitie.EnglishMean,
                Sentece = allEntitie.Sentece,
                TurkishMean = allEntitie.TurkishMean
            });
            await _allEntiteWriteRepository.SaveChangesAsync();
            return new();
        }
        public async Task<bool> AddAsyncPV(PV pV)
        {
            await _pvWriteRepository.AddAsync(new()
            {
                EnglishPV = pV.EnglishPV,
                EnglishMean = pV.EnglishMean,
                Sentece = pV.Sentece,
                TurkishMean = pV.TurkishMean
            });
            await _pvWriteRepository.SaveChangesAsync();
            return new();
        }
    }
}
