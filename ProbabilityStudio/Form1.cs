using ProbabilityStudio.Models;

namespace ProbabilityStudio
{
    public partial class Form1 : Form
    {
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
                diceForm.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
