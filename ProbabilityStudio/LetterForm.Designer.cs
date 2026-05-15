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
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            button2 = new Button();
            searchLetterLabel = new Label();
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
            // textBox2
            // 
            textBox2.Location = new Point(179, 284);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(118, 23);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.CausesValidation = false;
            label2.Location = new Point(318, 291);
            label2.Name = "label2";
            label2.Size = new Size(139, 15);
            label2.TabIndex = 4;
            label2.Text = "Въведете брой тегления";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(463, 283);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(124, 23);
            textBox3.TabIndex = 5;
            // 
            // button2
            // 
            button2.Location = new Point(612, 282);
            button2.Name = "button2";
            button2.Size = new Size(163, 25);
            button2.TabIndex = 6;
            button2.Text = "Запази данните";
            button2.UseVisualStyleBackColor = true;
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
            // LetterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 343);
            Controls.Add(searchLetterLabel);
            Controls.Add(button2);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(fileContentTextBox);
            Controls.Add(openFileButton);
            Name = "LetterForm";
            Text = "LetterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button openFileButton;
        private TextBox fileContentTextBox;
        private OpenFileDialog openFileDialog1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Button button2;
        private Label searchLetterLabel;
    }
}