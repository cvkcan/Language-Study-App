using Language_Study_App.Application.Features.Commands;
using Language_Study_App.Domain.Entities;
using Language_Study_App.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Language_Study_App.Winforms.Pages
{
    public partial class AddWordPage : Form
    {
        private readonly AddCommand _addCommand;


        public AddWordPage(AddCommand addCommand)
        {
            InitializeComponent();
            _addCommand = addCommand;
        }

        #region Event Area
        private async void addWordPageButton_Click(object sender, EventArgs e)
        {
            if (IsEmpty())
            {
                if (IsChecked())
                {
                    var tableName = await AddAsync();
                    MessageBox.Show($"'{englishWordtextBox.Text}' bilgisi '{tableName.ToLower()}' tablosuna eklenmiştir.");
                    ClearField();
                }
                else
                {
                    MessageBox.Show("Eklenecek tablo türünü seçin");
                }
            }
            else
            {
                MessageBox.Show("İlgili alanları doldurunuz!");
            }
        }
        private void typeWordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            JustOneChecked();
        }

        private void typeTranslateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            JustOneChecked();
        }

        private void typePVCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            JustOneChecked();
        }
        #endregion

        #region Func Area
        private void JustOneChecked()
        {
            if (typePVCheckbox.Checked)
            {
                typeWordCheckBox.Checked = false;
                typeTranslateCheckBox.Checked = false;
            }
            else if (typeWordCheckBox.Checked)
            {
                typePVCheckbox.Checked = false;
                typeTranslateCheckBox.Checked = false;
            }
            else if (typeTranslateCheckBox.Checked)
            {
                typePVCheckbox.Checked = false;
                typeWordCheckBox.Checked = false;
            }

            if (typePVCheckbox.Checked || typeTranslateCheckBox.Checked || typeWordCheckBox.Checked)
            {
                typeAllEntitieCheckBox.Checked = true;
            }
            else
            {
                typeAllEntitieCheckBox.Checked = false;
            }

        }
        private bool IsChecked()
        {
            if (!typeWordCheckBox.Checked && !typeTranslateCheckBox.Checked && !typeAllEntitieCheckBox.Checked && !typePVCheckbox.Checked)
                return false;
            else
                return true;
        }
        private bool IsEmpty()
        {
            if (string.IsNullOrWhiteSpace(englishWordtextBox.Text) || string.IsNullOrWhiteSpace(englishMeantextBox.Text) || string.IsNullOrWhiteSpace(turkishMeantextBox.Text) || string.IsNullOrWhiteSpace(sentenceTextBox.Text))
                return false;
            else return true;
        }

        private object EntiteType()
        {
            object entityType = null;
            if (typeWordCheckBox.Checked) entityType = typeof(Word);
            else if (typePVCheckbox.Checked) entityType = typeof(PV);
            else if (typeTranslateCheckBox.Checked) entityType = typeof(Translate);
            else entityType=null;
            return entityType;
        }
        private void ClearField()
        {
            englishWordtextBox.Clear();
            englishMeantextBox.Clear();
            turkishMeantextBox.Clear();
            sentenceTextBox.Clear();
            typeWordCheckBox.Checked = false;
            typePVCheckbox.Checked = false;
            typeTranslateCheckBox.Checked = false;
        }

        private async Task<string> AddAsync()
        {
            var data = EntiteType();
            string type = "";
            if (data == typeof(Word))
            {
                type = "Word";
                var model = new Word
                {
                    EnglishWord = englishWordtextBox.Text,
                    EnglishMean = englishMeantextBox.Text,
                    TurkishMean = turkishMeantextBox.Text,
                    Sentece = sentenceTextBox.Text
                };
                await _addCommand.AddAsync(model);
            }
            else if (data == typeof(Translate))
            {
                type = "Translate";
                var model = new Translate
                {
                    EnglishTranslate = englishWordtextBox.Text,
                    EnglishMean = englishMeantextBox.Text,
                    TurkishMean = turkishMeantextBox.Text,
                    Sentece = sentenceTextBox.Text
                };
                await _addCommand.AddAsync(model);
            }
            else if (data == typeof(PV))
            {
                type = "PV";
                var model = new PV
                {
                    EnglishPV = englishWordtextBox.Text,
                    EnglishMean = englishMeantextBox.Text,
                    TurkishMean = turkishMeantextBox.Text,
                    Sentece = sentenceTextBox.Text
                };
                await _addCommand.AddAsync(model);
            }
            return type;
        }
        #endregion
    }
}
