namespace Language_Study_App.Winforms.Pages
{
    partial class GetWordPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            getWordButton = new Button();
            stateeTypeComboBox = new ComboBox();
            getWordTextBox = new TextBox();
            getEnglishTextBox = new TextBox();
            getTurkishTextBox = new TextBox();
            getSentenceTextBox = new TextBox();
            entitieTypesComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(34, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1372, 440);
            dataGridView1.TabIndex = 0;
            // 
            // getWordButton
            // 
            getWordButton.Location = new Point(34, 543);
            getWordButton.Name = "getWordButton";
            getWordButton.Size = new Size(449, 183);
            getWordButton.TabIndex = 1;
            getWordButton.Text = "button1";
            getWordButton.UseVisualStyleBackColor = true;
            getWordButton.Click += getWordButton_Click;
            // 
            // stateeTypeComboBox
            // 
            stateeTypeComboBox.FormattingEnabled = true;
            stateeTypeComboBox.Location = new Point(1093, 756);
            stateeTypeComboBox.Name = "stateeTypeComboBox";
            stateeTypeComboBox.Size = new Size(258, 23);
            stateeTypeComboBox.TabIndex = 2;
            stateeTypeComboBox.SelectedIndexChanged += stateeTypeComboBox_SelectedIndexChanged;
            // 
            // getWordTextBox
            // 
            getWordTextBox.Location = new Point(1093, 484);
            getWordTextBox.Name = "getWordTextBox";
            getWordTextBox.Size = new Size(253, 23);
            getWordTextBox.TabIndex = 3;
            getWordTextBox.KeyPress += getWordTextBox_KeyPress;
            // 
            // getEnglishTextBox
            // 
            getEnglishTextBox.Location = new Point(1093, 543);
            getEnglishTextBox.Name = "getEnglishTextBox";
            getEnglishTextBox.Size = new Size(253, 23);
            getEnglishTextBox.TabIndex = 4;
            getEnglishTextBox.KeyPress += getEnglishTextBox_KeyPress;
            // 
            // getTurkishTextBox
            // 
            getTurkishTextBox.Location = new Point(1093, 605);
            getTurkishTextBox.Name = "getTurkishTextBox";
            getTurkishTextBox.Size = new Size(253, 23);
            getTurkishTextBox.TabIndex = 5;
            getTurkishTextBox.KeyPress += getTurkishTextBox_KeyPress;
            // 
            // getSentenceTextBox
            // 
            getSentenceTextBox.Location = new Point(1093, 682);
            getSentenceTextBox.Name = "getSentenceTextBox";
            getSentenceTextBox.Size = new Size(311, 23);
            getSentenceTextBox.TabIndex = 6;
            getSentenceTextBox.KeyPress += getSentenceTextBox_KeyPress;
            // 
            // entitieTypesComboBox
            // 
            entitieTypesComboBox.FormattingEnabled = true;
            entitieTypesComboBox.Location = new Point(543, 471);
            entitieTypesComboBox.Name = "entitieTypesComboBox";
            entitieTypesComboBox.Size = new Size(333, 23);
            entitieTypesComboBox.TabIndex = 7;
            // 
            // GetWordPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1438, 823);
            Controls.Add(entitieTypesComboBox);
            Controls.Add(getSentenceTextBox);
            Controls.Add(getTurkishTextBox);
            Controls.Add(getEnglishTextBox);
            Controls.Add(getWordTextBox);
            Controls.Add(stateeTypeComboBox);
            Controls.Add(getWordButton);
            Controls.Add(dataGridView1);
            Name = "GetWordPage";
            Text = "GetWordPage";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button getWordButton;
        private ComboBox stateeTypeComboBox;
        private TextBox getWordTextBox;
        private TextBox getEnglishTextBox;
        private TextBox getTurkishTextBox;
        private TextBox getSentenceTextBox;
        private ComboBox entitieTypesComboBox;
    }
}