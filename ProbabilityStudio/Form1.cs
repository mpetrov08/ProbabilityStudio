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
        }
    }
}
