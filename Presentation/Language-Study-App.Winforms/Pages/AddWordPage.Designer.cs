namespace Language_Study_App.Winforms.Pages
{
    partial class AddWordPage
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
            addWordPageButton = new Button();
            typeWordCheckBox = new CheckBox();
            typeTranslateCheckBox = new CheckBox();
            typeAllEntitieCheckBox = new CheckBox();
            typePVCheckbox = new CheckBox();
            englishWordLabel = new Label();
            englishMeanLabel = new Label();
            turkishMeanLabel = new Label();
            sentenceLabel = new Label();
            englishWordtextBox = new TextBox();
            englishMeantextBox = new TextBox();
            turkishMeantextBox = new TextBox();
            sentenceTextBox = new TextBox();
            SuspendLayout();
            // 
            // addWordPageButton
            // 
            addWordPageButton.Font = new Font("Cooper Black", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            addWordPageButton.Location = new Point(565, 441);
            addWordPageButton.Name = "addWordPageButton";
            addWordPageButton.Size = new Size(144, 61);
            addWordPageButton.TabIndex = 0;
            addWordPageButton.Text = "Add Word";
            addWordPageButton.UseVisualStyleBackColor = true;
            addWordPageButton.Click += addWordPageButton_Click;
            // 
            // typeWordCheckBox
            // 
            typeWordCheckBox.AutoSize = true;
            typeWordCheckBox.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            typeWordCheckBox.Location = new Point(565, 65);
            typeWordCheckBox.Name = "typeWordCheckBox";
            typeWordCheckBox.Size = new Size(135, 25);
            typeWordCheckBox.TabIndex = 1;
            typeWordCheckBox.Text = "Type Word";
            typeWordCheckBox.UseVisualStyleBackColor = true;
            typeWordCheckBox.CheckedChanged += typeWordCheckBox_CheckedChanged;
            // 
            // typeTranslateCheckBox
            // 
            typeTranslateCheckBox.AutoSize = true;
            typeTranslateCheckBox.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            typeTranslateCheckBox.Location = new Point(565, 128);
            typeTranslateCheckBox.Name = "typeTranslateCheckBox";
            typeTranslateCheckBox.Size = new Size(175, 25);
            typeTranslateCheckBox.TabIndex = 2;
            typeTranslateCheckBox.Text = "Type Translate";
            typeTranslateCheckBox.UseVisualStyleBackColor = true;
            typeTranslateCheckBox.CheckedChanged += typeTranslateCheckBox_CheckedChanged;
            // 
            // typeAllEntitieCheckBox
            // 
            typeAllEntitieCheckBox.Visible = false;
            typeAllEntitieCheckBox.AutoSize = true;
            typeAllEntitieCheckBox.Enabled = false;
            typeAllEntitieCheckBox.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            typeAllEntitieCheckBox.Location = new Point(564, 261);
            typeAllEntitieCheckBox.Name = "typeAllEntitieCheckBox";
            typeAllEntitieCheckBox.Size = new Size(180, 25);
            typeAllEntitieCheckBox.TabIndex = 4;
            typeAllEntitieCheckBox.Text = "Type AllEntitie";
            typeAllEntitieCheckBox.UseVisualStyleBackColor = true;
            // 
            // typePVCheckbox
            // 
            typePVCheckbox.AutoSize = true;
            typePVCheckbox.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            typePVCheckbox.Location = new Point(564, 192);
            typePVCheckbox.Name = "typePVCheckbox";
            typePVCheckbox.Size = new Size(110, 25);
            typePVCheckbox.TabIndex = 5;
            typePVCheckbox.Text = "Type PV";
            typePVCheckbox.UseVisualStyleBackColor = true;
            typePVCheckbox.CheckedChanged += typePVCheckbox_CheckedChanged;
            // 
            // englishWordLabel
            // 
            englishWordLabel.AutoSize = true;
            englishWordLabel.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            englishWordLabel.Location = new Point(52, 41);
            englishWordLabel.Name = "englishWordLabel";
            englishWordLabel.Size = new Size(141, 21);
            englishWordLabel.TabIndex = 6;
            englishWordLabel.Text = "English Word";
            // 
            // englishMeanLabel
            // 
            englishMeanLabel.AutoSize = true;
            englishMeanLabel.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            englishMeanLabel.Location = new Point(52, 128);
            englishMeanLabel.Name = "englishMeanLabel";
            englishMeanLabel.Size = new Size(139, 21);
            englishMeanLabel.TabIndex = 7;
            englishMeanLabel.Text = "English Mean";
            // 
            // turkishMeanLabel
            // 
            turkishMeanLabel.AutoSize = true;
            turkishMeanLabel.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            turkishMeanLabel.Location = new Point(52, 306);
            turkishMeanLabel.Name = "turkishMeanLabel";
            turkishMeanLabel.Size = new Size(145, 21);
            turkishMeanLabel.TabIndex = 8;
            turkishMeanLabel.Text = "Turkish Mean";
            // 
            // sentenceLabel
            // 
            sentenceLabel.AutoSize = true;
            sentenceLabel.Font = new Font("Cooper Black", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            sentenceLabel.Location = new Point(52, 410);
            sentenceLabel.Name = "sentenceLabel";
            sentenceLabel.Size = new Size(97, 21);
            sentenceLabel.TabIndex = 9;
            sentenceLabel.Text = "Sentence";
            // 
            // englishWordtextBox
            // 
            englishWordtextBox.Location = new Point(53, 65);
            englishWordtextBox.Name = "englishWordtextBox";
            englishWordtextBox.Size = new Size(428, 23);
            englishWordtextBox.TabIndex = 10;
            // 
            // englishMeantextBox
            // 
            englishMeantextBox.Location = new Point(52, 153);
            englishMeantextBox.Multiline = true;
            englishMeantextBox.Name = "englishMeantextBox";
            englishMeantextBox.Size = new Size(429, 97);
            englishMeantextBox.TabIndex = 11;
            // 
            // turkishMeantextBox
            // 
            turkishMeantextBox.Location = new Point(52, 330);
            turkishMeantextBox.Name = "turkishMeantextBox";
            turkishMeantextBox.Size = new Size(429, 23);
            turkishMeantextBox.TabIndex = 12;
            // 
            // sentenceTextBox
            // 
            sentenceTextBox.Location = new Point(53, 441);
            sentenceTextBox.Multiline = true;
            sentenceTextBox.Name = "sentenceTextBox";
            sentenceTextBox.Size = new Size(428, 173);
            sentenceTextBox.TabIndex = 13;
            // 
            // AddWordPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 637);
            Controls.Add(sentenceTextBox);
            Controls.Add(turkishMeantextBox);
            Controls.Add(englishMeantextBox);
            Controls.Add(englishWordtextBox);
            Controls.Add(sentenceLabel);
            Controls.Add(turkishMeanLabel);
            Controls.Add(englishMeanLabel);
            Controls.Add(englishWordLabel);
            Controls.Add(typePVCheckbox);
            Controls.Add(typeAllEntitieCheckBox);
            Controls.Add(typeTranslateCheckBox);
            Controls.Add(typeWordCheckBox);
            Controls.Add(addWordPageButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AddWordPage";
            Text = "AddWordPage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addWordPageButton;
        private CheckBox typeWordCheckBox;
        private CheckBox typeTranslateCheckBox;
        private CheckBox typeAllEntitieCheckBox;
        private CheckBox typePVCheckbox;
        private Label englishWordLabel;
        private Label englishMeanLabel;
        private Label turkishMeanLabel;
        private Label sentenceLabel;
        private TextBox englishWordtextBox;
        private TextBox englishMeantextBox;
        private TextBox turkishMeantextBox;
        private TextBox sentenceTextBox;
    }
}