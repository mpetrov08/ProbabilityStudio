namespace ProbabilityStudio
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            experimentChoicer = new ListBox();
            startButton = new Button();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // experimentChoicer
            // 
            experimentChoicer.FormattingEnabled = true;
            experimentChoicer.ItemHeight = 15;
            experimentChoicer.Items.AddRange(new object[] { "Coin", "Dice" });
            experimentChoicer.Location = new Point(12, 39);
            experimentChoicer.Name = "experimentChoicer";
            experimentChoicer.Size = new Size(151, 109);
            experimentChoicer.TabIndex = 0;
            experimentChoicer.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // startButton
            // 
            startButton.Location = new Point(45, 172);
            startButton.Name = "startButton";
            startButton.Size = new Size(75, 23);
            startButton.TabIndex = 1;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(211, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1, 449);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(283, 39);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 3;
            label1.Text = "MathResult";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(286, 80);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 4;
            label2.Text = "Simulation";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(startButton);
            Controls.Add(experimentChoicer);
            Name = "Form1";
            Text = "ProbabilityStudio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox experimentChoicer;
        private Button startButton;
        private Panel panel1;
        private Label label1;
        private Label label2;
    }
}
