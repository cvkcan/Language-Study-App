using Language_Study_App.Application.Features.Commands;
using Language_Study_App.Application.Features.Queries;
using Language_Study_App.Application.Repositories;
using Language_Study_App.Domain.Entities;
using Language_Study_App.Domain.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Language_Study_App.Winforms
{
    public partial class Form1 : Form
    {
        private readonly AddCommand _addCommand;
        private readonly UpdateCommand _updateCommand;
        private readonly GetByIdQuery _getByIdQuery;
        private readonly GetByStatusQuery _getByStatusQuery;
        private readonly GetByWordQuery _getByWordQuery;
        public Form1(AddCommand addCommand, UpdateCommand updateCommand, GetByIdQuery getByIdQuery, GetByStatusQuery getByStatusQuery, GetByWordQuery getByWordQuery)
        {
            InitializeComponent();
            _addCommand = addCommand;
            _updateCommand = updateCommand;
            _getByIdQuery = getByIdQuery;
            _getByStatusQuery = getByStatusQuery;
            _getByWordQuery = getByWordQuery;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            #region MyRegion
            //var word = new Word
            //{
            //    EnglishWord = textBox1.Text,
            //    EnglishMean = textBox2.Text,
            //    Sentece = textBox3.Text,
            //    TurkishMean = textBox4.Text
            //};
            //await _addCommand.AddAsyncWord(word);
            //MessageBox.Show("Test");




            //var data = await _getByIdQuery.GetByIdWord("FADE2D44-4746-4AA4-ABBE-C5C95517E2D2");
            //MessageBox.Show(data.EnglishWord);




            //var word = new Word
            //{
            //    EnglishWord = textBox1.Text,
            //    EnglishMean = textBox2.Text,
            //    Sentece = textBox3.Text,
            //    TurkishMean = textBox4.Text
            //};
            //await _updateCommand.UpdateWord("FADE2D44-4746-4AA4-ABBE-C5C95517E2D2", word);
            //MessageBox.Show("Test");




            //var word = new Word
            //{
            //    EnglishWord = textBox1.Text,
            //    EnglishMean = textBox2.Text,
            //    Sentece = textBox3.Text,
            //    TurkishMean = textBox4.Text
            //};
            //await _addCommand.AddAsync(word);
            //MessageBox.Show("Test");

            //var dat = await _getByIdQuery.GetByIdW("FADE2D44-4746-4AA4-ABBE-C5C95517E2D2");
            //MessageBox.Show(dat);





            //var word = new Word
            //{
            //    EnglishWord = textBox1.Text,
            //    EnglishMean = textBox2.Text,
            //    Sentece = textBox3.Text,
            //    TurkishMean = textBox4.Text
            //};

            //await _addCommand.AddAsync(word);
            //MessageBox.Show("Done");
            //var word = new Word
            //{
            //    EnglishWord = textBox1.Text,
            //    EnglishMean = textBox2.Text,
            //    Sentece = textBox3.Text,
            //    TurkishMean = textBox4.Text

            //};

            //await _updateCommand.Update(1,word);
            //MessageBox.Show("Test");




            //var datas = _getByStatusQuery.GetByStatus<Word>(StateTypes.Success);
            //if (datas.Count > 0)
            //{
            //    foreach (var item in datas)
            //    {
            //        MessageBox.Show(item.EnglishMean);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Kelime yok!");
            //}



            var datas = await _getByWordQuery.GetByWord<Word>("dfg");
            MessageBox.Show(datas.Sentece);
            #endregion





        }
    }
}
