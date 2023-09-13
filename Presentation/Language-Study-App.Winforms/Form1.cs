using Language_Study_App.Application.Repositories;
using Language_Study_App.Domain.Enums;
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
        private readonly IWordWriteRepository _wordWriteRepository;
        public Form1(IWordWriteRepository wordWriteRepository)
        {
            InitializeComponent();
            _wordWriteRepository = wordWriteRepository;
        }


        private async void button1_Click(object sender, EventArgs e)
        {
            await _wordWriteRepository.AddAsync(new()
            {
                EnglishMean="asda",
                Sentece="asd",
                EnglishWord="q1",
                Id=Guid.NewGuid(),
                StateType=StateTypes.Success,
                TurkishMean="rk"
            });
            await _wordWriteRepository.SaveChangesAsync();
            MessageBox.Show("Test");
        }
    }
}
