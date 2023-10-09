using Language_Study_App.Application.Enums;
using Language_Study_App.Application.Features.Queries;
using Language_Study_App.Domain.Entities;
using Language_Study_App.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.CodeDom;
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
        private readonly GetCount _getCount;
        private readonly GetRandom _getRandom;
        string isUsed = "";
        public GetWordPage(GetWhereQuery getByStatusQuery, GetCount getCount, GetRandom getRandom)
        {
            InitializeComponent();
            GetStateType();
            GetEntitieTypes();
            stateeTypeComboBox.SelectedItem = "---Disabled---";
            _getByStatusQuery = getByStatusQuery;
            _getCount = getCount;
            _getRandom = getRandom;
        }
        #region Event Area

        private void getWordButton_Click(object sender, EventArgs e)
        {
            GetWords();
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

        private async Task GetRandomValue()
        {
            dataGridView1.DataSource = await _getRandom.GetRandomAsync<Word>(GetTableCount());
        }

        private void GetEntitieTypes()
        {
            entitieTypesComboBox.DataSource = Enum.GetValues(typeof(EntiteTypes));
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

        private void dgwNull()
        {
            dataGridView1.DataSource = null;
            MessageBox.Show("Arama kritlerlerini giriniz!");
        }

        private void GetWords()
        {
            Enum.TryParse(stateeTypeComboBox.SelectedItem.ToString(), out Language_Study_App.Domain.Enums.StateTypes result);
            var entityType = GetEntities();
            if (entityType == typeof(Word))
            {
                if (isUsed == "Word")
                {
                    var ss = _getByStatusQuery.GetByEnglishWord<Word>(entityType, getWordTextBox.Text);
                    dataGridView1.DataSource = ss;
                }
                else if (isUsed == "TurkishMean")
                {
                    var ss = _getByStatusQuery.GetByTurkishMean<Word>(entityType, getTurkishTextBox.Text);
                    dataGridView1.DataSource = ss;
                }
                else if (isUsed == "Sentence")
                {
                    var ss = _getByStatusQuery.GetBySentece<Word>(entityType, getSentenceTextBox.Text);
                    dataGridView1.DataSource = ss;
                }
                else if (isUsed == "StateTypes")
                {
                    var ss = _getByStatusQuery.GetByStatus<Word>(entityType, result);
                    dataGridView1.DataSource = ss;
                }
                else if (isUsed == "EnglishMean")
                {
                    var ss = _getByStatusQuery.GetByEnglishMean<Word>(entityType, getEnglishTextBox.Text);
                    dataGridView1.DataSource = ss;
                }
                else
                {
                    dgwNull();
                }
            }
            else if (entityType == typeof(Translate))
            {
                if (isUsed == "Word")
                {
                    var ss = _getByStatusQuery.GetByEnglishWord<Translate>(entityType, getWordTextBox.Text);
                    dataGridView1.DataSource = ss;
                }
                else if (isUsed == "TurkishMean")
                {
                    var ss = _getByStatusQuery.GetByTurkishMean<Translate>(entityType, getTurkishTextBox.Text);
                    dataGridView1.DataSource = ss;
                }
                else if (isUsed == "Sentence")
                {
                    var ss = _getByStatusQuery.GetBySentece<Translate>(entityType, getSentenceTextBox.Text);
                    dataGridView1.DataSource = ss;
                }
                else if (isUsed == "StateTypes")
                {
                    var ss = _getByStatusQuery.GetByStatus<Translate>(entityType, result);
                    dataGridView1.DataSource = ss;
                }
                else if (isUsed == "EnglishMean")
                {
                    var ss = _getByStatusQuery.GetByEnglishMean<Translate>(entityType, getEnglishTextBox.Text);
                    dataGridView1.DataSource = ss;
                }
                else
                {
                    dgwNull();
                }
            }
            else if (entityType == typeof(PV))
            {
                if (isUsed == "Word")
                {
                    var ss = _getByStatusQuery.GetByEnglishWord<PV>(entityType, getWordTextBox.Text);
                    dataGridView1.DataSource = ss;
                }
                else if (isUsed == "TurkishMean")
                {
                    var ss = _getByStatusQuery.GetByTurkishMean<PV>(entityType, getTurkishTextBox.Text);
                    dataGridView1.DataSource = ss;
                }
                else if (isUsed == "Sentence")
                {
                    var ss = _getByStatusQuery.GetBySentece<PV>(entityType, getSentenceTextBox.Text);
                    dataGridView1.DataSource = ss;
                }
                else if (isUsed == "StateTypes")
                {
                    var ss = _getByStatusQuery.GetByStatus<PV>(entityType, result);
                    dataGridView1.DataSource = ss;
                }
                else if (isUsed == "EnglishMean")
                {
                    var ss = _getByStatusQuery.GetByEnglishMean<PV>(entityType, getEnglishTextBox.Text);
                    dataGridView1.DataSource = ss;
                }
                else
                {
                    dgwNull();
                }
            }
            else if (entityType == typeof(AllEntitie))
            {
                if (isUsed == "Word")
                {
                    var ss = _getByStatusQuery.GetByEnglishWord<AllEntitie>(entityType, getWordTextBox.Text);
                    dataGridView1.DataSource = ss;
                }
                else if (isUsed == "TurkishMean")
                {
                    var ss = _getByStatusQuery.GetByTurkishMean<AllEntitie>(entityType, getTurkishTextBox.Text);
                    dataGridView1.DataSource = ss;
                }
                else if (isUsed == "Sentence")
                {
                    var ss = _getByStatusQuery.GetBySentece<AllEntitie>(entityType, getSentenceTextBox.Text);
                    dataGridView1.DataSource = ss;
                }
                else if (isUsed == "StateTypes")
                {
                    var ss = _getByStatusQuery.GetByStatus<AllEntitie>(entityType, result);
                    dataGridView1.DataSource = ss;
                }
                else if (isUsed == "EnglishMean")
                {
                    var ss = _getByStatusQuery.GetByEnglishMean<AllEntitie>(entityType, getEnglishTextBox.Text);
                    dataGridView1.DataSource = ss;
                }
                else
                {
                    dgwNull();
                }
            }
        }

        private Type GetEntities()
        {
            Enum.TryParse(entitieTypesComboBox.SelectedItem.ToString(), out EntiteTypes entitie);
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
            return entityType;
        }

        private async Task<int> GetTableCount()
        {
            var entityType = GetEntities();
            if (entityType == typeof(Word))
            {
                return   await _getCount.GetByIdCount<Word>();
            }
            else if (entityType == typeof(Translate))
            {
                return  await _getCount.GetByIdCount<Translate>();
            }
            else if (entityType == typeof(PV))
            {
                return  await _getCount.GetByIdCount<PV>();
            }
            else
            {
                return  await _getCount.GetByIdCount<AllEntitie>();
            }
        }

        private async Task asdsa()
        {
            var value = await GetTableCount();
            if (value!=0)
            {
                Random random = new();
                int randomValue = random.Next(1,value);
            }
        }

        #endregion



    }
}
