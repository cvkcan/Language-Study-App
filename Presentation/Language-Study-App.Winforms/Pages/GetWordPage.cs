using Language_Study_App.Application.Features.Queries;
using Language_Study_App.Domain.Entities;
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

namespace Language_Study_App.Winforms.Pages
{
    public partial class GetWordPage : Form
    {
        private readonly GetWhereQuery _getByStatusQuery;
        public GetWordPage(GetWhereQuery getByStatusQuery)
        {
            InitializeComponent();
            GetStateType();
            _getByStatusQuery = getByStatusQuery;
        }
        #region Event Area
        private void getWordButton_Click(object sender, EventArgs e)
        {
            Enum.TryParse(stateeTypeComboBox.SelectedItem.ToString(), out StateTypes result);
            var ss = _getByStatusQuery.GetByStatus<Word>(result);
            dataGridView1.DataSource = ss;
        }
        private void getWordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            IsEnabled();
        }

        private void getEnglishTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            IsEnabled();
        }

        private void getTurkishTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            IsEnabled();
        }

        private void getSentenceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            IsEnabled();
        }
        #endregion

        #region Func Area
        private void GetStateType()
        {
            stateeTypeComboBox.DataSource = Enum.GetValues(typeof(StateTypes));
        }

        private void IsEnabled()
        {
            if (!string.IsNullOrWhiteSpace(getEnglishTextBox.Text))
            {
                getSentenceTextBox.Enabled = false;
                getTurkishTextBox.Enabled = false;
                getWordTextBox.Enabled = false;
            }
            else if (!string.IsNullOrWhiteSpace(getSentenceTextBox.Text))
            {
                getEnglishTextBox.Enabled = false;
                getWordTextBox.Enabled = false;
                getTurkishTextBox.Enabled = false;
            }
            else if (!string.IsNullOrWhiteSpace(getTurkishTextBox.Text))
            {
                getEnglishTextBox.Enabled = false;
                getSentenceTextBox.Enabled = false;
                getWordTextBox.Enabled = false;
            }
            else if (!string.IsNullOrWhiteSpace(getWordTextBox.Text))
            {
                getSentenceTextBox.Enabled = false;
                getTurkishTextBox.Enabled = false;
                getEnglishTextBox.Enabled = false;
            }
            else
            {
                getSentenceTextBox.Enabled = true;
                getTurkishTextBox.Enabled = true;
                getEnglishTextBox.Enabled = true;
                getWordTextBox.Enabled=true;
            }
        }
        #endregion

       
    }
}
