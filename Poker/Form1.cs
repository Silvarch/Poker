namespace Poker
{
    public partial class Form1 : Form
    {
        Deck d1 = new Deck();
        int DrawNumber = 0; //this sets the current draw number and should be updated for each draw and reset if a new game is started
        int turn = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void DeckTest_TextChanged(object sender, EventArgs e)
        {

        }


        //shuffles deck and outputs deck contents to DeckTest textbox (testing purposes)
        private void TestButton_Click(object sender, EventArgs e)
        {
            d1.SetDeck();
            string test = d1.BeginShuffle();
            DeckTest.Text = test;

        }

        private void ButtonDeck_Click(object sender, EventArgs e)
        {
            DrawNumber++;
            int CardDraw = d1.Draw(DrawNumber); //because draw number is incremented though each iteration, the card darawn will always be the next in the arrays order

            string r1 = "Ace";
            string r2 = "Two";
            string r3 = "Three";
            string r4 = "Four";
            string r5 = "Five";
            string r6 = "Six";
            string r7 = "Seven";
            string r8 = "Eight";
            string r9 = "Nine";
            string r10 = "Ten";
            string r11 = "Jack";
            string r12 = "Queen";
            string r13 = "King";
            string s1 = "Hearts";
            string s2 = "Diamonds";
            string s3 = "Clubs";
            string s4 = "Spades";

            turn = 0; //remove after testing done

            //The following if statements check what turn it is along with the value of the card being drawn via the NewDeck Array
            if (turn == 0 && d1.NewDeck[CardDraw].Contains(r11) && d1.NewDeck[CardDraw].Contains(s1))
            {
                Player1Card1.Image = Poker.Properties.Resources.JackHearts;
                turn++;
            }
            if (turn == 0 && d1.NewDeck[CardDraw].Contains(r11) && d1.NewDeck[CardDraw].Contains(s2))
            {
                Player1Card1.Image = Poker.Properties.Resources.JackDiamonds;
                turn++;
            }
            if (turn == 0 && d1.NewDeck[CardDraw].Contains(r11) && d1.NewDeck[CardDraw].Contains(s3))
            {
                Player1Card1.Image = Poker.Properties.Resources.JackClubs;
                turn++;
            }
            if (turn == 0 && d1.NewDeck[CardDraw].Contains(r11) && d1.NewDeck[CardDraw].Contains(s4))
            {
                Player1Card1.Image = Poker.Properties.Resources.JackSpades;
                turn++;
            }
            if (turn == 0 && d1.NewDeck[CardDraw].Contains(r12) && d1.NewDeck[CardDraw].Contains(s1))
            {
                Player1Card1.Image = Poker.Properties.Resources.QueenHearts;
                turn++;
            }
            if (turn == 0 && d1.NewDeck[CardDraw].Contains(r12) && d1.NewDeck[CardDraw].Contains(s2))
            {
                Player1Card1.Image = Poker.Properties.Resources.QueenDiamonds;
                turn++;
            }
            if (turn == 0 && d1.NewDeck[CardDraw].Contains(r12) && d1.NewDeck[CardDraw].Contains(s3))
            {
                Player1Card1.Image = Poker.Properties.Resources.QueenClubs;
                turn++;
            }
            if (turn == 0 && d1.NewDeck[CardDraw].Contains(r12) && d1.NewDeck[CardDraw].Contains(s4))
            {
                Player1Card1.Image = Poker.Properties.Resources.QueenSpades;
                turn++;
            }
            if (turn == 0 && d1.NewDeck[CardDraw].Contains(r13) && d1.NewDeck[CardDraw].Contains(s1))
            {
                Player1Card1.Image = Poker.Properties.Resources.KingHearts;
                turn++;
            }
            if (turn == 0 && d1.NewDeck[CardDraw].Contains(r13) && d1.NewDeck[CardDraw].Contains(s2))
            {
                Player1Card1.Image = Poker.Properties.Resources.KingDiamonds;
                turn++;
            }
            if (turn == 0 && d1.NewDeck[CardDraw].Contains(r13) && d1.NewDeck[CardDraw].Contains(s3))
            {
                Player1Card1.Image = Poker.Properties.Resources.KingClubs;
                turn++;
            }
            if (turn == 0 && d1.NewDeck[CardDraw].Contains(r13) && d1.NewDeck[CardDraw].Contains(s4))
            {
                Player1Card1.Image = Poker.Properties.Resources.KingSpades;
                turn++;
            }

        }

        private void Shuffle_Click(object sender, EventArgs e)
        {
            d1.BeginShuffle();
            
        }

        private void test2_Click(object sender, EventArgs e)
        {
            DeckTest.Text = d1.NewDeck[0];
        }
    }
}