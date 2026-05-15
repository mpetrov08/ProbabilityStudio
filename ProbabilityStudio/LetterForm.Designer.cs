namespace ProbabilityStudio
{
    partial class LetterForm
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
            openFileButton = new Button();
            fileContentTextBox = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            searchedLetterTextBox = new TextBox();
            trialsCountLabel = new Label();
            saveButton = new Button();
            searchLetterLabel = new Label();
            trialsCountNumericUpDown = new NumericUpDown();
            caseInsensitiveCheckBox = new CheckBox();
            withoutPunctuationCheckBox = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)trialsCountNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // openFileButton
            // 
            openFileButton.Location = new Point(25, 24);
            openFileButton.Name = "openFileButton";
            openFileButton.Size = new Size(750, 33);
            openFileButton.TabIndex = 0;
            openFileButton.Text = "Зареди файл";
            openFileButton.UseVisualStyleBackColor = true;
            openFileButton.Click += openFileButton_Click;
            // 
            // fileContentTextBox
            // 
            fileContentTextBox.Location = new Point(25, 63);
            fileContentTextBox.Multiline = true;
            fileContentTextBox.Name = "fileContentTextBox";
            fileContentTextBox.Size = new Size(750, 193);
            fileContentTextBox.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // searchedLetterTextBox
            // 
            searchedLetterTextBox.Location = new Point(179, 284);
            searchedLetterTextBox.Name = "searchedLetterTextBox";
            searchedLetterTextBox.Size = new Size(118, 23);
            searchedLetterTextBox.TabIndex = 3;
            // 
            // trialsCountLabel
            // 
            trialsCountLabel.AutoSize = true;
            trialsCountLabel.CausesValidation = false;
            trialsCountLabel.Location = new Point(318, 291);
            trialsCountLabel.Name = "trialsCountLabel";
            trialsCountLabel.Size = new Size(139, 15);
            trialsCountLabel.TabIndex = 4;
            trialsCountLabel.Text = "Въведете брой тегления";
            // 
            // saveButton
            // 
            saveButton.Location = new Point(612, 282);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(163, 25);
            saveButton.TabIndex = 6;
            saveButton.Text = "Запази данните";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // searchLetterLabel
            // 
            searchLetterLabel.AutoSize = true;
            searchLetterLabel.Location = new Point(25, 291);
            searchLetterLabel.Name = "searchLetterLabel";
            searchLetterLabel.Size = new Size(148, 15);
            searchLetterLabel.TabIndex = 7;
            searchLetterLabel.Text = "Въведете търсената буква";
            // 
            // trialsCountNumericUpDown
            // 
            trialsCountNumericUpDown.Location = new Point(476, 283);
            trialsCountNumericUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            trialsCountNumericUpDown.Name = "trialsCountNumericUpDown";
            trialsCountNumericUpDown.Size = new Size(120, 23);
            trialsCountNumericUpDown.TabIndex = 8;
            trialsCountNumericUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // caseInsensitiveCheckBox
            // 
            caseInsensitiveCheckBox.AutoSize = true;
            caseInsensitiveCheckBox.Location = new Point(25, 357);
            caseInsensitiveCheckBox.Name = "caseInsensitiveCheckBox";
            caseInsensitiveCheckBox.Size = new Size(281, 19);
            caseInsensitiveCheckBox.TabIndex = 9;
            caseInsensitiveCheckBox.Text = "Да няма значения малки или големи букви са";
            caseInsensitiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // withoutPunctuationCheckBox
            // 
            withoutPunctuationCheckBox.AutoSize = true;
            withoutPunctuationCheckBox.Location = new Point(347, 357);
            withoutPunctuationCheckBox.Name = "withoutPunctuationCheckBox";
            withoutPunctuationCheckBox.Size = new Size(365, 19);
            withoutPunctuationCheckBox.TabIndex = 10;
            withoutPunctuationCheckBox.Text = "Да не се зачитат пунктуационни знации празни пространства";
            withoutPunctuationCheckBox.UseVisualStyleBackColor = true;
            // 
            // LetterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 465);
            Controls.Add(withoutPunctuationCheckBox);
            Controls.Add(caseInsensitiveCheckBox);
            Controls.Add(trialsCountNumericUpDown);
            Controls.Add(searchLetterLabel);
            Controls.Add(saveButton);
            Controls.Add(trialsCountLabel);
            Controls.Add(searchedLetterTextBox);
            Controls.Add(fileContentTextBox);
            Controls.Add(openFileButton);
            Name = "LetterForm";
            Text = "LetterForm";
            ((System.ComponentModel.ISupportInitialize)trialsCountNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button openFileButton;
        private TextBox fileContentTextBox;
        private OpenFileDialog openFileDialog1;
        private TextBox searchedLetterTextBox;
        private Label trialsCountLabel;
        private Button saveButton;
        private Label searchLetterLabel;
        private NumericUpDown trialsCountNumericUpDown;
        private CheckBox caseInsensitiveCheckBox;
        private CheckBox withoutPunctuationCheckBox;
    }
}