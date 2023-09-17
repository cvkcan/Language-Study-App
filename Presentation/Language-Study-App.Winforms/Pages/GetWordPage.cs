using Language_Study_App.Application.Enums;
using Language_Study_App.Application.Features.Queries;
using Language_Study_App.Domain.Entities;
using Language_Study_App.Domain.Entities.Common;
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
        string isUsed = "";
        public GetWordPage(GetWhereQuery getByStatusQuery)
        {
            InitializeComponent();
            GetStateType();
            GetEntitieTypes();
            stateeTypeComboBox.SelectedItem = "---Disabled---";
            _getByStatusQuery = getByStatusQuery;
        }
        #region Event Area
        //private void getWordButton_Click(object sender, EventArgs e)
        //{
        //    Enum.TryParse(entitieTypesComboBox.SelectedItem.ToString(), out EntiteTypes entitie);
        //    Enum.TryParse(stateeTypeComboBox.SelectedItem.ToString(), out StateTypes result);
        //    if (isUsed == "EnglishMean")
        //    {
        //        var ss = _getByStatusQuery.GetByEnglishWord<entitie>(getEnglishTextBox.Text);
        //        dataGridView1.DataSource = ss;
        //    }
        //    else if (isUsed == "Translate")
        //    {
        //        var ss = _getByStatusQuery.GetByEnglishWord<entitie>(getTurkishTextBox.Text);
        //        dataGridView1.DataSource = ss;
        //    }
        //    else if (isUsed == "PV")
        //    {
        //        var ss = _getByStatusQuery.GetByEnglishWord<entitie>(getSentenceTextBox.Text);
        //        dataGridView1.DataSource = ss;
        //    }
        //    else if (isUsed == "")
        //    {
        //        var ss = _getByStatusQuery.GetByEnglishWord<entitie>(getEnglishTextBox.Text);
        //        dataGridView1.DataSource = ss;
        //    }
        //    else
        //    {
        //        dataGridView1.DataSource = null;
        //    }
        //}
        ////private void getWordButton_Click(object sender, EventArgs e)
        ////{
        ////    if (entitieTypesComboBox.SelectedItem is EntiteTypes entitie || stateeTypeComboBox.SelectedItem is StateTypes result)
        ////    {
        ////        if (isUsed == "EnglishMean")
        ////        {
        ////            var ss = _getByStatusQuery.GetByEnglishWord<Word>(getEnglishTextBox.Text);
        ////            dataGridView1.DataSource = ss;
        ////        }
        ////        else if (isUsed == "Translate")
        ////        {
        ////            var ss = _getByStatusQuery.GetByEnglishWord<Word>(getTurkishTextBox.Text);
        ////            dataGridView1.DataSource = ss;
        ////        }
        ////        else if (isUsed == "PV")
        ////        {
        ////            var ss = _getByStatusQuery.GetByEnglishWord<Word>(getSentenceTextBox.Text);
        ////            dataGridView1.DataSource = ss;
        ////        }
        ////        else if (isUsed == "")
        ////        {
        ////            var ss = _getByStatusQuery.GetByEnglishWord<Word>(getEnglishTextBox.Text);
        ////            dataGridView1.DataSource = ss;
        ////        }
        ////        else
        ////        {
        ////            dataGridView1.DataSource = null;
        ////        }
        ////    }
        ////}


        private void getWordButton_Click(object sender, EventArgs e)
        {
            Enum.TryParse(entitieTypesComboBox.SelectedItem.ToString(), out EntiteTypes entitie);
            Enum.TryParse(stateeTypeComboBox.SelectedItem.ToString(), out StateTypes result);

            // Öncelikle generic türü belirleyin
            Type entityType = null;
            if (entitie == EntiteTypes.Word)
            {
                entityType = typeof(Word);
            }
            else if (entitie == EntiteTypes.Translate)
            {
                entityType = typeof(Translate);
            }
            else if (entitie == EntiteTypes.PV)
            {
                entityType = typeof(PV);
            }
            else if (entitie == EntiteTypes.AllEntitie)
            {
                entityType = typeof(AllEntitie);
            }

            if (isUsed == "Word")
            {
                // Generic türü kullanarak GetByEnglishWord'u çağırın
                var ss = _getByStatusQuery.GetByEnglishWord(entityType, getWordTextBox.Text);
                dataGridView1.DataSource = ss;
            }
            else if (isUsed == "Translate")
            {
                var ss = _getByStatusQuery.GetByEnglishWord(entityType, getTurkishTextBox.Text);
                dataGridView1.DataSource = ss;
            }
            else if (isUsed == "PV")
            {
                var ss = _getByStatusQuery.GetByEnglishWord(entityType, getSentenceTextBox.Text);
                dataGridView1.DataSource = ss;
            }
            else if (isUsed == "")
            {
                var ss = _getByStatusQuery.GetByEnglishWord(entityType, getEnglishTextBox.Text);
                dataGridView1.DataSource = ss;
            }
            else
            {
                dataGridView1.DataSource = null;
            }
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

        private void stateeTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IsEnabled();
        }
        #endregion

        #region Func Area

        private EntiteTypes ReadCombobox()
        {
            Enum.TryParse(entitieTypesComboBox.SelectedItem.ToString(), out EntiteTypes entitie);
            return entitie;
        }

        private void GetEntitieTypes()
        {
            foreach (var item in Enum.GetValues(typeof(EntiteTypes)))
            {
                entitieTypesComboBox.Items.Add(item);
            }
        }

        private void GetStateType()
        {
            foreach (var item in Enum.GetValues(typeof(StateTypes)))
            {
                stateeTypeComboBox.Items.Add(item);
            }
            stateeTypeComboBox.Items.Add("---Disabled---");
        }

        private string IsEnabled()
        {

            if (!string.IsNullOrWhiteSpace(getEnglishTextBox.Text))
            {
                getSentenceTextBox.Enabled = false;
                getTurkishTextBox.Enabled = false;
                getWordTextBox.Enabled = false;
                stateeTypeComboBox.Enabled = false;
                isUsed = "EnglishMean";
            }
            else if (!string.IsNullOrWhiteSpace(getSentenceTextBox.Text))
            {
                getEnglishTextBox.Enabled = false;
                getWordTextBox.Enabled = false;
                getTurkishTextBox.Enabled = false;
                stateeTypeComboBox.Enabled = false;
                isUsed = "Sentence";
            }
            else if (!string.IsNullOrWhiteSpace(getTurkishTextBox.Text))
            {
                getEnglishTextBox.Enabled = false;
                getSentenceTextBox.Enabled = false;
                getWordTextBox.Enabled = false;
                stateeTypeComboBox.Enabled = false;
                isUsed = "TurkishMean";
            }
            else if (!string.IsNullOrWhiteSpace(getWordTextBox.Text))
            {
                getSentenceTextBox.Enabled = false;
                getTurkishTextBox.Enabled = false;
                getEnglishTextBox.Enabled = false;
                stateeTypeComboBox.Enabled = false;
                isUsed = "Word";
            }
            else if (stateeTypeComboBox.SelectedItem.ToString() != "---Disabled---")
            {
                getSentenceTextBox.Enabled = false;
                getTurkishTextBox.Enabled = false;
                getEnglishTextBox.Enabled = false;
                getWordTextBox.Enabled = false;
                isUsed = "StateTypes";
            }
            else
            {
                getSentenceTextBox.Enabled = true;
                getTurkishTextBox.Enabled = true;
                getEnglishTextBox.Enabled = true;
                getWordTextBox.Enabled = true;
                stateeTypeComboBox.Enabled = true;
            }
            return isUsed;
        }
        #endregion



    }
}
