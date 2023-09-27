using Language_Study_App.Application.Enums;
using Language_Study_App.Application.Features.Commands;
using Language_Study_App.Application.Features.Queries;
using Language_Study_App.Domain.Entities;
using Language_Study_App.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Language_Study_App.Winforms.Pages
{
    public partial class UpdateWordPage : Form
    {
        private readonly UpdateCommand _updateCommand;
        private readonly GetByQuery _getByWordQuery;
        public UpdateWordPage(UpdateCommand updateCommand, GetByQuery getByWordQuery)
        {
            InitializeComponent();
            GetComboboxs();
            _updateCommand = updateCommand;
            _getByWordQuery = getByWordQuery;
        }

        #region Event Area
        private async void searchButton_Click(object sender, EventArgs e)
        {
            List<BaseEntitiy> search = await UpdateSearch<BaseEntitiy>();
            if (search.Count>0)
            {
                foreach (var item in search)
                {
                    searchValueLabel.Text = $"ID:{item.Id} - Word: {searchTextBox.Text} ";
                    idValueLabel.Text = item.Id.ToString();
                    entitieTypeComboBox.SelectedItem = searchComboBox.SelectedItem;
                }
            }
            else
            {
                idValueLabel.Text = "ID:";
                MessageBox.Show($"'{searchTextBox.Text}' ifadesi bulunamadı.");
            }
        }
        private async void updateWordPageButton_Click(object sender, EventArgs e)
        {
            if (IsEmptyUpdateItems())
            {
                if (await UpdateAsync(Convert.ToInt32(idValueLabel.Text)))
                {
                    MessageBox.Show($"{idValueLabel.Text} id'li {searchTextBox.Text} kelime güncellendi");
                }
                else
                {
                    MessageBox.Show("İşlem başarısız. Değiştirmek istediğiniz kelimeyi aradıktan sonra güncelleme işlemi yapabilirsiniz.");
                }
            }
            else
            {
                MessageBox.Show("Boş değerleri doldurunuz.");
            }
        }
        #endregion

        #region Func Area
        private void GetComboboxs()
        {
            statusTypeComboBox.DataSource = Enum.GetValues(typeof(StateTypes));
            searchComboBox.DataSource = Enum.GetValues(typeof(EntiteTypes));
            entitieTypeComboBox.DataSource = Enum.GetValues(typeof(EntiteTypes));
        }

        private bool IsEmptySearchCombobox()
        {
            if (searchComboBox.SelectedIndex == -1)
                return false;
            else
                return true;
        }

        private bool IsEmptyUpdateItems()
        {
            int idValue;
            if (entitieTypeComboBox.SelectedIndex == -1 || statusTypeComboBox.SelectedIndex == -1 || string.IsNullOrEmpty(englishWordTextBox.Text) || string.IsNullOrEmpty(englishMeanTextBox.Text) || string.IsNullOrEmpty(turkishMeanTextBox.Text) || string.IsNullOrEmpty(sentenceTextBox.Text) || !int.TryParse(idValueLabel.Text, out idValue))
            {
                return false;
            }
            return true;
        }

        private async Task<bool> UpdateAsync(int idvalue)
        {
            string type = entitieTypeComboBox.SelectedItem.ToString();
            if (Enum.TryParse(statusTypeComboBox.SelectedItem.ToString(), out Language_Study_App.Domain.Enums.StateTypes result))
            {
                if (type == "Word")
                {
                    Word word = new Word
                    {
                        EnglishMean = englishMeanTextBox.Text,
                        EnglishWord = englishWordTextBox.Text,
                        StateType = result,
                        Sentece = sentenceTextBox.Text,
                        TurkishMean = turkishMeanTextBox.Text
                    };
                    await _updateCommand.Update(idvalue, word);
                }
                else if (type == "Translate")
                {
                    Translate translate = new Translate
                    {
                        EnglishMean = englishMeanTextBox.Text,
                        EnglishTranslate = englishWordTextBox.Text,
                        StateType = result,
                        Sentece = sentenceTextBox.Text,
                        TurkishMean = turkishMeanTextBox.Text
                    };
                    await _updateCommand.Update(idvalue, translate);
                }
                else if (type == "PV")
                {
                    PV pv = new PV
                    {
                        EnglishMean = englishMeanTextBox.Text,
                        EnglishPV = englishWordTextBox.Text,
                        StateType = result,
                        Sentece = sentenceTextBox.Text,
                        TurkishMean = turkishMeanTextBox.Text
                    };
                    await _updateCommand.Update(idvalue, pv);
                }
                else if (type == "AllEntite")
                {
                    AllEntitie allEntitie = new AllEntitie
                    {
                        EnglishMean = englishMeanTextBox.Text,
                        EnglishAllEntite = englishWordTextBox.Text,
                        StateType = result,
                        Sentece = sentenceTextBox.Text,
                        TurkishMean = turkishMeanTextBox.Text
                    };
                    await _updateCommand.Update(idvalue, allEntitie);
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        private async Task<List<T>> UpdateSearch<T>() where T : BaseEntitiy
        {

            string type = searchComboBox.SelectedItem.ToString();
            List<T> entite = new List<T>();

            if (type == "Word")
            {
                Word word = await _getByWordQuery.GetByWord<Word>(searchTextBox.Text);
                if (word != null)
                    entite.Add((T)Convert.ChangeType(word, typeof(Word)));
            }
            else if (type == "Translate")
            {
                Translate translate = await _getByWordQuery.GetByWord<Translate>(searchTextBox.Text);
                if (translate != null)
                    entite.Add((T)Convert.ChangeType(translate, typeof(Translate)));
            }
            else if (type == "PV")
            {
                PV pv = await _getByWordQuery.GetByWord<PV>(searchTextBox.Text);
                if (pv != null)
                    entite.Add((T)Convert.ChangeType(pv, typeof(PV)));
            }
            else if (type == "AllEntitie")
            {
                AllEntitie allEntitie = await _getByWordQuery.GetByWord<AllEntitie>(searchTextBox.Text);
                if (allEntitie != null)
                    entite.Add((T)Convert.ChangeType(allEntitie, typeof(AllEntitie)));
            }
            else
            {
                return null;
            }
            return entite;
        }

        #endregion
    }
}
