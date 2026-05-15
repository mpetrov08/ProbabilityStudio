using ProbabilityStudio.Models;
using ProbabilityStudio.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProbabilityStudio
{
    public partial class LetterForm : Form
    {
        public IExperiment Experiment;
        public LetterForm()
        {
            InitializeComponent();
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = new StreamReader(openFileDialog1.FileName);
                fileContentTextBox.Text = reader.ReadToEnd();
                reader.Close();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string text = fileContentTextBox.Text;
            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show("Моля, въведете текст!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (searchedLetterTextBox.Text.Length != 1)
            {
                MessageBox.Show("Моля, въведете една буква!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            char searchedLetter = char.Parse(searchedLetterTextBox.Text);

            int trialCount = (int)trialsCountNumericUpDown.Value;

            bool isCaseSensitive = !caseInsensitiveCheckBox.Checked;
            bool isIncludedPunctuationAndSpaces = !withoutPunctuationCheckBox.Checked;
            
            Experiment = new LetterExperiment(text, searchedLetter, trialCount, isCaseSensitive, isIncludedPunctuationAndSpaces);
            this.Close();
        }
    }
}
