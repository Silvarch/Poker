namespace Poker
{
    public partial class Form1 : Form
    {
        Deck d1 = new Deck();
        public Form1()
        {
            InitializeComponent();
        }

        private void DeckTest_TextChanged(object sender, EventArgs e)
        {

        }


        //outputs deck contents to DeckTest textbox
        private void TestButton_Click(object sender, EventArgs e)
        {
            string test = d1.SetDeck();
            DeckTest.Text = test;
        }
    }
}