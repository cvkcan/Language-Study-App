using Language_Study_App.Application.Repositories;
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
        private readonly IWordWriteRepository _wordWriteRepository;
        private readonly IWordReadRepository _wordReadRepository;
        public Form1(IWordWriteRepository wordWriteRepository, IWordReadRepository wordReadRepository)
        {
            InitializeComponent();
            _wordWriteRepository = wordWriteRepository;
            _wordReadRepository = wordReadRepository;
        }


        private async void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
