namespace Language_Study_App.Winforms
{
    partial class HomePage
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
            addWordButton = new Button();
            updateWordButton = new Button();
            SuspendLayout();
            // 
            // getWordButton
            // 
            getWordButton.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            getWordButton.Location = new Point(261, 33);
            getWordButton.Name = "getWordButton";
            getWordButton.Size = new Size(284, 107);
            getWordButton.TabIndex = 0;
            getWordButton.Text = "Get Word";
            getWordButton.UseVisualStyleBackColor = true;
            getWordButton.Click += getWordButton_Click;
            // 
            // addWordButton
            // 
            addWordButton.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addWordButton.Location = new Point(261, 156);
            addWordButton.Name = "addWordButton";
            addWordButton.Size = new Size(284, 107);
            addWordButton.TabIndex = 1;
            addWordButton.Text = "Add Word";
            addWordButton.UseVisualStyleBackColor = true;
            addWordButton.Click += addWordButton_Click;
            // 
            // updateWordButton
            // 
            updateWordButton.Font = new Font("Cooper Black", 12F, FontStyle.Regular, GraphicsUnit.Point);
            updateWordButton.Location = new Point(261, 287);
            updateWordButton.Name = "updateWordButton";
            updateWordButton.Size = new Size(284, 107);
            updateWordButton.TabIndex = 2;
            updateWordButton.Text = "Update Word";
            updateWordButton.UseVisualStyleBackColor = true;
            updateWordButton.Click += updateWordButton_Click;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(updateWordButton);
            Controls.Add(addWordButton);
            Controls.Add(getWordButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "HomePage";
            Text = "HomePage";
            ResumeLayout(false);
        }

        #endregion

        private Button getWordButton;
        private Button addWordButton;
        private Button updateWordButton;
    }
}