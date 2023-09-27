namespace Language_Study_App.Winforms.Pages
{
    partial class UpdateWordPage
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
            searchButton = new Button();
            searchTextBox = new TextBox();
            updateWordPageButton = new Button();
            englishWordTextBox = new TextBox();
            englishMeanTextBox = new TextBox();
            turkishMeanTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            sentenceTextBox = new TextBox();
            statusTypeComboBox = new ComboBox();
            label6 = new Label();
            searchValueLabel = new Label();
            groupBox1 = new GroupBox();
            searchComboBox = new ComboBox();
            label7 = new Label();
            entitieTypeComboBox = new ComboBox();
            idValueLabel = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // searchButton
            // 
            searchButton.Font = new Font("Cooper Black", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            searchButton.Location = new Point(109, 136);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(113, 56);
            searchButton.TabIndex = 0;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(41, 30);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(252, 23);
            searchTextBox.TabIndex = 1;
            // 
            // updateWordPageButton
            // 
            updateWordPageButton.Font = new Font("Cooper Black", 18F, FontStyle.Regular, GraphicsUnit.Point);
            updateWordPageButton.Location = new Point(600, 533);
            updateWordPageButton.Name = "updateWordPageButton";
            updateWordPageButton.Size = new Size(243, 121);
            updateWordPageButton.TabIndex = 2;
            updateWordPageButton.Text = "Update Word";
            updateWordPageButton.UseVisualStyleBackColor = true;
            updateWordPageButton.Click += updateWordPageButton_Click;
            // 
            // englishWordTextBox
            // 
            englishWordTextBox.Location = new Point(102, 211);
            englishWordTextBox.Name = "englishWordTextBox";
            englishWordTextBox.Size = new Size(320, 23);
            englishWordTextBox.TabIndex = 3;
            // 
            // englishMeanTextBox
            // 
            englishMeanTextBox.Location = new Point(102, 297);
            englishMeanTextBox.Name = "englishMeanTextBox";
            englishMeanTextBox.Size = new Size(320, 23);
            englishMeanTextBox.TabIndex = 4;
            // 
            // turkishMeanTextBox
            // 
            turkishMeanTextBox.Location = new Point(102, 400);
            turkishMeanTextBox.Name = "turkishMeanTextBox";
            turkishMeanTextBox.Size = new Size(320, 23);
            turkishMeanTextBox.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(99, 187);
            label1.Name = "label1";
            label1.Size = new Size(141, 21);
            label1.TabIndex = 7;
            label1.Text = "English Word";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(101, 273);
            label2.Name = "label2";
            label2.Size = new Size(139, 21);
            label2.TabIndex = 8;
            label2.Text = "English Mean";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(101, 376);
            label3.Name = "label3";
            label3.Size = new Size(145, 21);
            label3.TabIndex = 9;
            label3.Text = "Turkish Mean";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(103, 473);
            label4.Name = "label4";
            label4.Size = new Size(126, 21);
            label4.TabIndex = 10;
            label4.Text = "Status Type";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(100, 575);
            label5.Name = "label5";
            label5.Size = new Size(97, 21);
            label5.TabIndex = 11;
            label5.Text = "Sentence";
            // 
            // sentenceTextBox
            // 
            sentenceTextBox.Location = new Point(99, 599);
            sentenceTextBox.Multiline = true;
            sentenceTextBox.Name = "sentenceTextBox";
            sentenceTextBox.Size = new Size(319, 155);
            sentenceTextBox.TabIndex = 12;
            // 
            // statusTypeComboBox
            // 
            statusTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            statusTypeComboBox.FormattingEnabled = true;
            statusTypeComboBox.Location = new Point(103, 509);
            statusTypeComboBox.Name = "statusTypeComboBox";
            statusTypeComboBox.Size = new Size(182, 23);
            statusTypeComboBox.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(92, 6);
            label6.Name = "label6";
            label6.Size = new Size(143, 21);
            label6.TabIndex = 14;
            label6.Text = "Search Value:";
            // 
            // searchValueLabel
            // 
            searchValueLabel.AutoSize = true;
            searchValueLabel.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            searchValueLabel.Location = new Point(20, 242);
            searchValueLabel.Name = "searchValueLabel";
            searchValueLabel.Size = new Size(15, 21);
            searchValueLabel.TabIndex = 15;
            searchValueLabel.Text = "-";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.IndianRed;
            groupBox1.Controls.Add(searchComboBox);
            groupBox1.Controls.Add(searchValueLabel);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(searchButton);
            groupBox1.Controls.Add(searchTextBox);
            groupBox1.Location = new Point(600, 102);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(330, 285);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            // 
            // searchComboBox
            // 
            searchComboBox.FormattingEnabled = true;
            searchComboBox.Location = new Point(92, 76);
            searchComboBox.Name = "searchComboBox";
            searchComboBox.Size = new Size(148, 23);
            searchComboBox.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(102, 95);
            label7.Name = "label7";
            label7.Size = new Size(124, 21);
            label7.TabIndex = 17;
            label7.Text = "Entite Type";
            // 
            // entitieTypeComboBox
            // 
            entitieTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            entitieTypeComboBox.FormattingEnabled = true;
            entitieTypeComboBox.Location = new Point(103, 119);
            entitieTypeComboBox.Name = "entitieTypeComboBox";
            entitieTypeComboBox.Size = new Size(182, 23);
            entitieTypeComboBox.TabIndex = 18;
            // 
            // idValueLabel
            // 
            idValueLabel.AutoSize = true;
            idValueLabel.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            idValueLabel.Location = new Point(102, 24);
            idValueLabel.Name = "idValueLabel";
            idValueLabel.Size = new Size(44, 21);
            idValueLabel.TabIndex = 19;
            idValueLabel.Text = "ID: ";
            // 
            // UpdateWordPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 797);
            Controls.Add(idValueLabel);
            Controls.Add(entitieTypeComboBox);
            Controls.Add(label7);
            Controls.Add(statusTypeComboBox);
            Controls.Add(sentenceTextBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(turkishMeanTextBox);
            Controls.Add(englishMeanTextBox);
            Controls.Add(englishWordTextBox);
            Controls.Add(updateWordPageButton);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "UpdateWordPage";
            Text = "UpdateWordPage";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button searchButton;
        private TextBox searchTextBox;
        private Button updateWordPageButton;
        private TextBox englishWordTextBox;
        private TextBox englishMeanTextBox;
        private TextBox turkishMeanTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox sentenceTextBox;
        private ComboBox statusTypeComboBox;
        private Label label6;
        private Label searchValueLabel;
        private GroupBox groupBox1;
        private ComboBox searchComboBox;
        private Label label7;
        private ComboBox entitieTypeComboBox;
        private Label idValueLabel;
    }
}