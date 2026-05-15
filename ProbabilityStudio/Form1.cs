using ProbabilityStudio.Models;

namespace ProbabilityStudio
{
    public partial class Form1 : Form
    {
        IExperiment Experiment;

        public Form1()
        {
            InitializeComponent(); //ok
        }
        
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (experimentChoicer.SelectedItem == "Coin")
            {
                CoinForm coinForm = new CoinForm();
                coinForm.Show();
            }
            else if (experimentChoicer.SelectedItem == "Dice")
            {
                DiceForm diceForm = new DiceForm();
                diceForm.ShowDialog();

                if (diceForm.Experiment != null)
                {
                    Experiment = diceForm.Experiment;

                    mathResultLabel.Text = $"{Experiment.CalculateProbability()}";

                    SimulationResult simulationResult = Experiment.Simulate();
                    simulationLabel.Text = $"{(decimal)simulationResult.SuccessfulTrials / simulationResult.TrialCount}";
                }
            }
            else if (experimentChoicer.SelectedItem == "Letter")
            {
                LetterForm letterForm = new LetterForm();
                letterForm.ShowDialog();

                if (letterForm.Experiment != null)
                {
                    Experiment = letterForm.Experiment;
                    mathResultLabel.Text = $"{Experiment.CalculateProbability()}";

                    SimulationResult simulationResult = Experiment.Simulate();
                    simulationLabel.Text = $"{(decimal)simulationResult.SuccessfulTrials / simulationResult.TrialCount}";
                }
            }
        }
    }
}
