using Language_Study_App.Application.Features.Queries;
using Language_Study_App.Application.Repositories;
using Language_Study_App.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
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
        private readonly GetByIdQuery _getByIdQuery; //SİLİNECEEEEEEEEEEEEEEEEEEEEEK

        public UpdateCommand(IPVWriteRepository pvWriteRepository, ITranslateWriteRepository translateWriteRepository, IWordWriteRepository wordWriteRepository, IAllEntiteWriteRepository allEntiteWriteRepository, GetByIdQuery getByIdQuery)
        {
            _pvWriteRepository = pvWriteRepository;
            _translateWriteRepository = translateWriteRepository;
            _wordWriteRepository = wordWriteRepository;
            _allEntiteWriteRepository = allEntiteWriteRepository;
            _getByIdQuery = getByIdQuery; //SİLİNECEEEEEEEEEEEEEEEEEEEEEEEEEEEK
        }

        public async Task<bool> UpdateWord(string id,Word word)
        {
            Word data = await _getByIdQuery.GetByIdWord(id);
            data.EnglishMean=word.EnglishMean;
            data.EnglishWord = word.EnglishWord;
            data.TurkishMean = word.TurkishMean;
            data.Sentece = word.Sentece;
            _wordWriteRepository.Update(data);
            await _wordWriteRepository.SaveChangesAsync();
            return new();
        }
    }
}
