using ProbabilityStudio.Models;
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
        IExperiment experiment;

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
        }
    }
}
