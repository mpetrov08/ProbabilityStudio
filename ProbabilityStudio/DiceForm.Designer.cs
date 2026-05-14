namespace ProbabilityStudio
{
    partial class DiceForm
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
            searchedSumLabel = new Label();
            trialCountLabel = new Label();
            searchedNumberGroupBox = new GroupBox();
            side6RadioButton = new RadioButton();
            side5RadioButton = new RadioButton();
            side4RadioButton = new RadioButton();
            side3RadioButton = new RadioButton();
            side2RadioButton = new RadioButton();
            side1RadionButton = new RadioButton();
            saveButton = new Button();
            trialCountNumericUpDown = new NumericUpDown();
            searchCriteriaGroupBox = new GroupBox();
            sumOptionRadioButton = new RadioButton();
            numberOptionRadioButton = new RadioButton();
            searchedSumNumericUpDown = new NumericUpDown();
            searchedNumberGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trialCountNumericUpDown).BeginInit();
            searchCriteriaGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)searchedSumNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // searchedSumLabel
            // 
            searchedSumLabel.AutoSize = true;
            searchedSumLabel.Location = new Point(258, 12);
            searchedSumLabel.Name = "searchedSumLabel";
            searchedSumLabel.Size = new Size(83, 15);
            searchedSumLabel.TabIndex = 0;
            searchedSumLabel.Text = "Търсена сума";
            searchedSumLabel.Visible = false;
            // 
            // trialCountLabel
            // 
            trialCountLabel.AutoSize = true;
            trialCountLabel.Location = new Point(24, 124);
            trialCountLabel.Name = "trialCountLabel";
            trialCountLabel.Size = new Size(96, 15);
            trialCountLabel.TabIndex = 2;
            trialCountLabel.Text = "Брой хвърляния";
            // 
            // searchedNumberGroupBox
            // 
            searchedNumberGroupBox.Controls.Add(side6RadioButton);
            searchedNumberGroupBox.Controls.Add(side5RadioButton);
            searchedNumberGroupBox.Controls.Add(side4RadioButton);
            searchedNumberGroupBox.Controls.Add(side3RadioButton);
            searchedNumberGroupBox.Controls.Add(side2RadioButton);
            searchedNumberGroupBox.Controls.Add(side1RadionButton);
            searchedNumberGroupBox.Location = new Point(258, 68);
            searchedNumberGroupBox.Name = "searchedNumberGroupBox";
            searchedNumberGroupBox.Size = new Size(165, 153);
            searchedNumberGroupBox.TabIndex = 4;
            searchedNumberGroupBox.TabStop = false;
            searchedNumberGroupBox.Text = "Търсено число";
            searchedNumberGroupBox.Visible = false;
            // 
            // side6RadioButton
            // 
            side6RadioButton.AutoSize = true;
            side6RadioButton.Location = new Point(115, 107);
            side6RadioButton.Name = "side6RadioButton";
            side6RadioButton.Size = new Size(31, 19);
            side6RadioButton.TabIndex = 5;
            side6RadioButton.TabStop = true;
            side6RadioButton.Text = "6";
            side6RadioButton.UseVisualStyleBackColor = true;
            // 
            // side5RadioButton
            // 
            side5RadioButton.AutoSize = true;
            side5RadioButton.Location = new Point(115, 69);
            side5RadioButton.Name = "side5RadioButton";
            side5RadioButton.Size = new Size(31, 19);
            side5RadioButton.TabIndex = 4;
            side5RadioButton.TabStop = true;
            side5RadioButton.Text = "5";
            side5RadioButton.UseVisualStyleBackColor = true;
            // 
            // side4RadioButton
            // 
            side4RadioButton.AutoSize = true;
            side4RadioButton.Location = new Point(115, 35);
            side4RadioButton.Name = "side4RadioButton";
            side4RadioButton.Size = new Size(31, 19);
            side4RadioButton.TabIndex = 3;
            side4RadioButton.TabStop = true;
            side4RadioButton.Text = "4";
            side4RadioButton.UseVisualStyleBackColor = true;
            // 
            // side3RadioButton
            // 
            side3RadioButton.AutoSize = true;
            side3RadioButton.Location = new Point(23, 107);
            side3RadioButton.Name = "side3RadioButton";
            side3RadioButton.Size = new Size(31, 19);
            side3RadioButton.TabIndex = 2;
            side3RadioButton.TabStop = true;
            side3RadioButton.Text = "3";
            side3RadioButton.UseVisualStyleBackColor = true;
            // 
            // side2RadioButton
            // 
            side2RadioButton.AutoSize = true;
            side2RadioButton.Location = new Point(23, 69);
            side2RadioButton.Name = "side2RadioButton";
            side2RadioButton.Size = new Size(31, 19);
            side2RadioButton.TabIndex = 1;
            side2RadioButton.TabStop = true;
            side2RadioButton.Text = "2";
            side2RadioButton.UseVisualStyleBackColor = true;
            // 
            // side1RadionButton
            // 
            side1RadionButton.AutoSize = true;
            side1RadionButton.Location = new Point(23, 35);
            side1RadionButton.Name = "side1RadionButton";
            side1RadionButton.Size = new Size(31, 19);
            side1RadionButton.TabIndex = 0;
            side1RadionButton.TabStop = true;
            side1RadionButton.Text = "1";
            side1RadionButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(23, 198);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(121, 23);
            saveButton.TabIndex = 5;
            saveButton.Text = "Запази данните";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // trialCountNumericUpDown
            // 
            trialCountNumericUpDown.Location = new Point(24, 153);
            trialCountNumericUpDown.Name = "trialCountNumericUpDown";
            trialCountNumericUpDown.Size = new Size(120, 23);
            trialCountNumericUpDown.TabIndex = 7;
            // 
            // searchCriteriaGroupBox
            // 
            searchCriteriaGroupBox.Controls.Add(sumOptionRadioButton);
            searchCriteriaGroupBox.Controls.Add(numberOptionRadioButton);
            searchCriteriaGroupBox.Location = new Point(23, 12);
            searchCriteriaGroupBox.Name = "searchCriteriaGroupBox";
            searchCriteriaGroupBox.Size = new Size(200, 100);
            searchCriteriaGroupBox.TabIndex = 8;
            searchCriteriaGroupBox.TabStop = false;
            searchCriteriaGroupBox.Text = "Критерий";
            // 
            // sumOptionRadioButton
            // 
            sumOptionRadioButton.AutoSize = true;
            sumOptionRadioButton.Location = new Point(6, 56);
            sumOptionRadioButton.Name = "sumOptionRadioButton";
            sumOptionRadioButton.Size = new Size(54, 19);
            sumOptionRadioButton.TabIndex = 1;
            sumOptionRadioButton.TabStop = true;
            sumOptionRadioButton.Text = "Сума";
            sumOptionRadioButton.UseVisualStyleBackColor = true;
            sumOptionRadioButton.CheckedChanged += sumOptionRadioButton_CheckedChanged;
            // 
            // numberOptionRadioButton
            // 
            numberOptionRadioButton.AutoSize = true;
            numberOptionRadioButton.Location = new Point(6, 22);
            numberOptionRadioButton.Name = "numberOptionRadioButton";
            numberOptionRadioButton.Size = new Size(60, 19);
            numberOptionRadioButton.TabIndex = 0;
            numberOptionRadioButton.TabStop = true;
            numberOptionRadioButton.Text = "Число";
            numberOptionRadioButton.UseVisualStyleBackColor = true;
            numberOptionRadioButton.CheckedChanged += numberOptionRadioButton_CheckedChanged;
            // 
            // searchedSumNumericUpDown
            // 
            searchedSumNumericUpDown.Location = new Point(258, 34);
            searchedSumNumericUpDown.Name = "searchedSumNumericUpDown";
            searchedSumNumericUpDown.Size = new Size(120, 23);
            searchedSumNumericUpDown.TabIndex = 9;
            searchedSumNumericUpDown.Visible = false;
            // 
            // DiceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 299);
            Controls.Add(searchedSumNumericUpDown);
            Controls.Add(searchCriteriaGroupBox);
            Controls.Add(trialCountNumericUpDown);
            Controls.Add(saveButton);
            Controls.Add(searchedNumberGroupBox);
            Controls.Add(trialCountLabel);
            Controls.Add(searchedSumLabel);
            Name = "DiceForm";
            Text = "DiceForm";
            searchedNumberGroupBox.ResumeLayout(false);
            searchedNumberGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trialCountNumericUpDown).EndInit();
            searchCriteriaGroupBox.ResumeLayout(false);
            searchCriteriaGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)searchedSumNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label searchedSumLabel;
        private Label trialCountLabel;
        private GroupBox searchedNumberGroupBox;
        private RadioButton side6RadioButton;
        private RadioButton side5RadioButton;
        private RadioButton side4RadioButton;
        private RadioButton side3RadioButton;
        private RadioButton side2RadioButton;
        private RadioButton side1RadionButton;
        private Button saveButton;
        private NumericUpDown trialCountNumericUpDown;
        private GroupBox searchCriteriaGroupBox;
        private RadioButton sumOptionRadioButton;
        private RadioButton numberOptionRadioButton;
        private NumericUpDown searchedSumNumericUpDown;
    }
}