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
            int searchedValue = 0;
            DiceSearchType diceSearchType;

            if (numberOptionRadioButton.Checked)
            {
                diceSearchType = DiceSearchType.ExactValue;
                if (side1RadionButton.Checked) searchedValue = 1;
                else if (side2RadioButton.Checked) searchedValue = 2;
                else if (side3RadioButton.Checked) searchedValue = 3;
                else if (side4RadioButton.Checked) searchedValue = 4;
                else if (side5RadioButton.Checked) searchedValue = 5;
                else if (side6RadioButton.Checked) searchedValue = 6;
            }
            else
            {
                diceSearchType = DiceSearchType.Sum;
                searchedValue = (int)searchedSumNumericUpDown.Value;
            }

            int trialCount = (int)trialCountNumericUpDown.Value;

            Experiment = new DiceExperiment(diceSearchType, searchedValue, trialCount);
            this.Close();
        }
    }
}
