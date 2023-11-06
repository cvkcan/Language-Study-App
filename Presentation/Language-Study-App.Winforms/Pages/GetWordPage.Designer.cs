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
            getWordButton = new Button();
            stateeTypeComboBox = new ComboBox();
            getWordTextBox = new TextBox();
            getEnglishTextBox = new TextBox();
            getTurkishTextBox = new TextBox();
            getSentenceTextBox = new TextBox();
            entitieTypesComboBox = new ComboBox();
            dataGridView1 = new DataGridView();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // getWordButton
            // 
            getWordButton.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point);
            getWordButton.Location = new Point(955, 355);
            getWordButton.Name = "getWordButton";
            getWordButton.Size = new Size(304, 110);
            getWordButton.TabIndex = 1;
            getWordButton.Text = "Get Word";
            getWordButton.UseVisualStyleBackColor = true;
            getWordButton.Click += getWordButton_Click;
            // 
            // stateeTypeComboBox
            // 
            stateeTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            stateeTypeComboBox.FormattingEnabled = true;
            stateeTypeComboBox.Location = new Point(163, 436);
            stateeTypeComboBox.Name = "stateeTypeComboBox";
            stateeTypeComboBox.Size = new Size(248, 23);
            stateeTypeComboBox.TabIndex = 2;
            stateeTypeComboBox.SelectedIndexChanged += stateeTypeComboBox_SelectedIndexChanged;
            // 
            // getWordTextBox
            // 
            getWordTextBox.Location = new Point(576, 355);
            getWordTextBox.Name = "getWordTextBox";
            getWordTextBox.Size = new Size(253, 23);
            getWordTextBox.TabIndex = 3;
            getWordTextBox.KeyPress += getWordTextBox_KeyPress;
            // 
            // getEnglishTextBox
            // 
            getEnglishTextBox.Location = new Point(576, 436);
            getEnglishTextBox.Name = "getEnglishTextBox";
            getEnglishTextBox.Size = new Size(253, 23);
            getEnglishTextBox.TabIndex = 4;
            getEnglishTextBox.KeyPress += getEnglishTextBox_KeyPress;
            // 
            // getTurkishTextBox
            // 
            getTurkishTextBox.Location = new Point(576, 531);
            getTurkishTextBox.Name = "getTurkishTextBox";
            getTurkishTextBox.Size = new Size(253, 23);
            getTurkishTextBox.TabIndex = 5;
            getTurkishTextBox.KeyPress += getTurkishTextBox_KeyPress;
            // 
            // getSentenceTextBox
            // 
            getSentenceTextBox.Location = new Point(163, 503);
            getSentenceTextBox.Multiline = true;
            getSentenceTextBox.Name = "getSentenceTextBox";
            getSentenceTextBox.Size = new Size(322, 100);
            getSentenceTextBox.TabIndex = 6;
            getSentenceTextBox.KeyPress += getSentenceTextBox_KeyPress;
            // 
            // entitieTypesComboBox
            // 
            entitieTypesComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            entitieTypesComboBox.FormattingEnabled = true;
            entitieTypesComboBox.Location = new Point(163, 355);
            entitieTypesComboBox.Name = "entitieTypesComboBox";
            entitieTypesComboBox.Size = new Size(248, 23);
            entitieTypesComboBox.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(34, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(1392, 279);
            dataGridView1.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(163, 331);
            label7.Name = "label7";
            label7.Size = new Size(124, 21);
            label7.TabIndex = 18;
            label7.Text = "Entite Type";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(163, 479);
            label5.Name = "label5";
            label5.Size = new Size(97, 21);
            label5.TabIndex = 23;
            label5.Text = "Sentence";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(163, 412);
            label4.Name = "label4";
            label4.Size = new Size(126, 21);
            label4.TabIndex = 22;
            label4.Text = "Status Type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(576, 501);
            label3.Name = "label3";
            label3.Size = new Size(145, 21);
            label3.TabIndex = 21;
            label3.Text = "Turkish Mean";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(576, 412);
            label2.Name = "label2";
            label2.Size = new Size(139, 21);
            label2.TabIndex = 20;
            label2.Text = "English Mean";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(576, 331);
            label1.Name = "label1";
            label1.Size = new Size(141, 21);
            label1.TabIndex = 19;
            label1.Text = "English Word";
            // 
            // button1
            // 
            button1.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(955, 493);
            button1.Name = "button1";
            button1.Size = new Size(304, 110);
            button1.TabIndex = 24;
            button1.Text = "Get Random Word";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // GetWordPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1438, 657);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(dataGridView1);
            Controls.Add(entitieTypesComboBox);
            Controls.Add(getSentenceTextBox);
            Controls.Add(getTurkishTextBox);
            Controls.Add(getEnglishTextBox);
            Controls.Add(getWordTextBox);
            Controls.Add(stateeTypeComboBox);
            Controls.Add(getWordButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "GetWordPage";
            Text = "GetWordPage";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button getWordButton;
        private ComboBox stateeTypeComboBox;
        private TextBox getWordTextBox;
        private TextBox getEnglishTextBox;
        private TextBox getTurkishTextBox;
        private TextBox getSentenceTextBox;
        private ComboBox entitieTypesComboBox;
        private DataGridView dataGridView1;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
    }
}