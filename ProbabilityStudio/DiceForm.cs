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
    public partial class DiceForm : Form
    {
        public IExperiment Experiment;

        public DiceForm()
        {
            InitializeComponent();
        }

        private void numberOptionRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            searchedNumberGroupBox.Visible = true;

            searchedSumLabel.Visible = false;
            searchedSumNumericUpDown.Visible = false;
        }

        private void sumOptionRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            searchedSumLabel.Visible = true;
            searchedSumNumericUpDown.Visible = true;

            searchedNumberGroupBox.Visible = false;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            int trialCount = (int)trialCountNumericUpDown.Value;

            int searchedValue = 0;
            if (numberOptionRadioButton.Checked)
            {
                if (side1RadionButton.Checked) searchedValue = 1;
                else if (side2RadioButton.Checked) searchedValue = 2;
                else if (side3RadioButton.Checked) searchedValue = 3;
                else if (side4RadioButton.Checked) searchedValue = 4;
                else if (side5RadioButton.Checked) searchedValue = 5;
                else if (side6RadioButton.Checked) searchedValue = 6;
                else
                {
                    MessageBox.Show("Изберете число!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Experiment = new DiceExperiment(DiceSearchType.ExactValue, searchedValue, trialCount);
            }
            else if(sumOptionRadioButton.Checked)
            {
                searchedValue = (int)searchedSumNumericUpDown.Value;

                if (searchedValue < trialCount || searchedValue > trialCount * 6)
                {
                    MessageBox.Show("Не е възможно да се получи тази сума при хвърлянията!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Experiment = new DiceExperiment(DiceSearchType.Sum, searchedValue, trialCount);
            }
            else
            {
                MessageBox.Show("Изберете критерий!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.Close();
        }
    }
}
