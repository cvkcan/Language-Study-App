using Accessibility;
using Language_Study_App.Application.Features.Commands;
using Language_Study_App.Application.Features.Queries;
using Language_Study_App.Winforms.Pages;
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
    public partial class HomePage : Form
    {
        private readonly AddCommand _addCommand;
        private readonly UpdateCommand _updateCommand;
        private readonly GetByQuery _getByWordQuery;
        private readonly GetWhereQuery _getByStatusQuery;
        private readonly GetCount _getCount;
        private readonly GetRandom _getRandom;
        public HomePage(AddCommand addCommand, UpdateCommand updateCommand, GetByQuery getByWordQuery, GetWhereQuery getByStatusQuery, GetCount getCount, GetRandom getRandom)
        {
            InitializeComponent();
            _addCommand = addCommand;
            _updateCommand = updateCommand;
            _getByWordQuery = getByWordQuery;
            _getByStatusQuery = getByStatusQuery;
            _getCount = getCount;
            _getRandom = getRandom;
        }

        private void getWordButton_Click(object sender, EventArgs e)
        {
            GetWordPage getWordPage = new(_getByStatusQuery,_getCount,_getRandom);
            getWordPage.ShowDialog();
        }

        private void addWordButton_Click(object sender, EventArgs e)
        {
            AddWordPage addWordPage = new(_addCommand);
            addWordPage.ShowDialog();
        }

        private void updateWordButton_Click(object sender, EventArgs e)
        {
            UpdateWordPage updateWordPage = new(_updateCommand, _getByWordQuery);
            updateWordPage.ShowDialog();
        }
    }
}
