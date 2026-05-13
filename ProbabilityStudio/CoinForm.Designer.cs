namespace ProbabilityStudio
{
    partial class CoinForm
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
            textBox1 = new TextBox();
            label1 = new Label();
            options = new GroupBox();
            radioButtonTails2 = new RadioButton();
            radioButtonHead1 = new RadioButton();
            options.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 162);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 132);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // options
            // 
            options.Controls.Add(radioButtonTails2);
            options.Controls.Add(radioButtonHead1);
            options.Location = new Point(12, 12);
            options.Name = "options";
            options.Size = new Size(200, 100);
            options.TabIndex = 2;
            options.TabStop = false;
            options.Text = "Choose side of the coin";
            // 
            // radioButtonTails2
            // 
            radioButtonTails2.AutoSize = true;
            radioButtonTails2.Location = new Point(6, 60);
            radioButtonTails2.Name = "radioButtonTails2";
            radioButtonTails2.Size = new Size(48, 19);
            radioButtonTails2.TabIndex = 1;
            radioButtonTails2.TabStop = true;
            radioButtonTails2.Text = "Tails";
            radioButtonTails2.UseVisualStyleBackColor = true;
            // 
            // radioButtonHead1
            // 
            radioButtonHead1.AutoSize = true;
            radioButtonHead1.Location = new Point(6, 35);
            radioButtonHead1.Name = "radioButtonHead1";
            radioButtonHead1.Size = new Size(53, 19);
            radioButtonHead1.TabIndex = 0;
            radioButtonHead1.TabStop = true;
            radioButtonHead1.Text = "Head";
            radioButtonHead1.UseVisualStyleBackColor = true;
            // 
            // CoinForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(options);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "CoinForm";
            Text = "CoinForm";
            Load += CoinForm_Load;
            options.ResumeLayout(false);
            options.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private GroupBox options;
        private RadioButton radioButtonTails2;
        private RadioButton radioButtonHead1;
    }
}