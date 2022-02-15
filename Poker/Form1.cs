namespace Poker
{
    public partial class Form1 : Form
    {
        Deck d1 = new Deck(); //allows Deck class methods to be called using default constructor
        
        
        public Form1()
        {
            InitializeComponent();
        }

        /* method used to shuffle the deck. if the deck does not yet exist, d1.SetDeck is called to do so before proceeding. All card images are set to null so that
         a new game can be started by clicking shuffle. d1.CardDraw and Turn are set to zero as well for the same reason, along with the two Hand arrays. */
        private void Shuffle_Click(object sender, EventArgs e)
        {
            if (d1.NewDeck[0] == null)
            {
                d1.SetDeck();
            }
            Player1Card1.Image = null;
            Player1Card2.Image = null;
            Player1Card3.Image = null;
            Player1Card4.Image = null;
            Player1Card5.Image = null;
            Player2Card1.Image = null;
            Player2Card2.Image = null;
            Player2Card3.Image = null;
            Player2Card4.Image = null;
            Player2Card5.Image = null;

            d1.CardDraw = 0;
            d1.Turn = 0;

            d1.BeginShuffle();
            ButtonDeck.Enabled = true;
            Array.Clear(d1.Hand1, 0, d1.Hand1.Length);
            Array.Clear(d1.Hand2, 0, d1.Hand2.Length);

        }


        /*This is a very long series of if statements that accomplish a few things. First the turn is checked which allows the corred card number to be dealt 
         to the appropriate player. Secondly, it assigns the card value(Rank/Suit) to an array that corresponds to the players current hand which will be used for
        deciding a winner in another class. The Methad also disables the deck button once turn 10 is reached as either player will have a full hand*/
        private void ButtonDeck_Click(object sender, EventArgs e)
        {
            if (d1.CardDraw < 52)
            {
                int n = d1.Draw();
                if (d1.Turn == 1)
                {
                    switch (n)// n has the value returned by d1.draw which corelates with a specific card
                    {

                        case 0:
                            Player1Card1.Image = Poker.Properties.Resources.AceHearts;
                            d1.Hand1[0] = "AH";
                            break;
                        case 1:
                            Player1Card1.Image = Poker.Properties.Resources.AceDiamonds;
                            d1.Hand1[0] = "AD";
                            break;
                        case 2:
                            Player1Card1.Image = Poker.Properties.Resources.AceClubs;
                            d1.Hand1[0] = "AC";
                            break;
                        case 3:
                            Player1Card1.Image = Poker.Properties.Resources.AceSpades;
                            d1.Hand1[0] = "AS";
                            break;
                        case 4:
                            Player1Card1.Image = Poker.Properties.Resources.TwoHearts;
                            d1.Hand1[0] = "2H";
                            break;
                        case 5:
                            Player1Card1.Image = Poker.Properties.Resources.TwoDiamonds;
                            d1.Hand1[0] = "2D";
                            break;
                        case 6:
                            Player1Card1.Image = Poker.Properties.Resources.TwoClubs;
                            d1.Hand1[0] = "2C";
                            break;
                        case 7:
                            Player1Card1.Image = Poker.Properties.Resources.TwoSpades;
                            d1.Hand1[0] = "2S";
                            break;
                        case 8:
                            Player1Card1.Image = Poker.Properties.Resources.ThreeHearts;
                            d1.Hand1[0] = "3H";
                            break;
                        case 9:
                            Player1Card1.Image = Poker.Properties.Resources.ThreeDiamonds;
                            d1.Hand1[0] = "3D";
                            break;
                        case 10:
                            Player1Card1.Image = Poker.Properties.Resources.ThreeClubs;
                            d1.Hand1[0] = "3C";
                            break;
                        case 11:
                            Player1Card1.Image = Poker.Properties.Resources.ThreeSpades;
                            d1.Hand1[0] = "3S";
                            break;
                        case 12:
                            Player1Card1.Image = Poker.Properties.Resources.FourHearts;
                            d1.Hand1[0] = "4H";
                            break;
                        case 13:
                            Player1Card1.Image = Poker.Properties.Resources.FourDiamonds;
                            d1.Hand1[0] = "4D";
                            break;
                        case 14:
                            Player1Card1.Image = Poker.Properties.Resources.FourClubs;
                            d1.Hand1[0] = "4C";
                            break;
                        case 15:
                            Player1Card1.Image = Poker.Properties.Resources.FourSpades;
                            d1.Hand1[0] = "4S";
                            break;
                        case 16:
                            Player1Card1.Image = Poker.Properties.Resources.FiveHearts;
                            d1.Hand1[0] = "5H";
                            break;
                        case 17:
                            Player1Card1.Image = Poker.Properties.Resources.FiveDiamonds;
                            d1.Hand1[0] = "5D";
                            break;
                        case 18:
                            Player1Card1.Image = Poker.Properties.Resources.FiveClubs;
                            d1.Hand1[0] = "5C";
                            break;
                        case 19:
                            Player1Card1.Image = Poker.Properties.Resources.FiveSpades;
                            d1.Hand1[0] = "5S";
                            break;
                        case 20:
                            Player1Card1.Image = Poker.Properties.Resources.SixHearts;
                            d1.Hand1[0] = "6H";
                            break;
                        case 21:
                            Player1Card1.Image = Poker.Properties.Resources.SixDiamonds;
                            d1.Hand1[0] = "6D";
                            break;
                        case 22:
                            Player1Card1.Image = Poker.Properties.Resources.SixClubs;
                            d1.Hand1[0] = "6C";
                            break;
                        case 23:
                            Player1Card1.Image = Poker.Properties.Resources.SixSpades;
                            d1.Hand1[0] = "6S";
                            break;
                        case 24:
                            Player1Card1.Image = Poker.Properties.Resources.SevenHearts;
                            d1.Hand1[0] = "7H";
                            break;
                        case 25:
                            Player1Card1.Image = Poker.Properties.Resources.SevenDiamonds;
                            d1.Hand1[0] = "7D";
                            break;
                        case 26:
                            Player1Card1.Image = Poker.Properties.Resources.SevenClubs;
                            d1.Hand1[0] = "7C";
                            break;
                        case 27:
                            Player1Card1.Image = Poker.Properties.Resources.SevenSpades;
                            d1.Hand1[0] = "7S";
                            break;
                        case 28:
                            Player1Card1.Image = Poker.Properties.Resources.EightHearts;
                            d1.Hand1[0] = "8H";
                            break;
                        case 29:
                            Player1Card1.Image = Poker.Properties.Resources.EightDiamonds;
                            d1.Hand1[0] = "8D";
                            break;
                        case 30:
                            Player1Card1.Image = Poker.Properties.Resources.EightClubs;
                            d1.Hand1[0] = "8C";
                            break;
                        case 31:
                            Player1Card1.Image = Poker.Properties.Resources.EightSpades;
                            d1.Hand1[0] = "8S";
                            break;
                        case 32:
                            Player1Card1.Image = Poker.Properties.Resources.NineHearts;
                            d1.Hand1[0] = "9H";
                            break;
                        case 33:
                            Player1Card1.Image = Poker.Properties.Resources.NineDiamonds;
                            d1.Hand1[0] = "9D";
                            break;
                        case 34:
                            Player1Card1.Image = Poker.Properties.Resources.NineClubs;
                            d1.Hand1[0] = "9C";
                            break;
                        case 35:
                            Player1Card1.Image = Poker.Properties.Resources.NineSpades;
                            d1.Hand1[0] = "9S";
                            break;
                        case 36:
                            Player1Card1.Image = Poker.Properties.Resources.TenHearts;
                            d1.Hand1[0] = "10H";
                            break;
                        case 37:
                            Player1Card1.Image = Poker.Properties.Resources.TenDiamonds;
                            d1.Hand1[0] = "10D";
                            break;
                        case 38:
                            Player1Card1.Image = Poker.Properties.Resources.TenClubs;
                            d1.Hand1[0] = "10C";
                            break;
                        case 39:
                            Player1Card1.Image = Poker.Properties.Resources.TenSpades;
                            d1.Hand1[0] = "10S";
                            break;
                        case 40:
                            Player1Card1.Image = Poker.Properties.Resources.JackHearts;
                            d1.Hand1[0] = "JH";
                            break;
                        case 41:
                            Player1Card1.Image = Poker.Properties.Resources.JackDiamonds;
                            d1.Hand1[0] = "JD";
                            break;
                        case 42:
                            Player1Card1.Image = Poker.Properties.Resources.JackClubs;
                            d1.Hand1[0] = "JC";
                            break;
                        case 43:
                            Player1Card1.Image = Poker.Properties.Resources.JackSpades;
                            d1.Hand1[0] = "JS";
                            break;
                        case 44:
                            Player1Card1.Image = Poker.Properties.Resources.QueenHearts;
                            d1.Hand1[0] = "QH";
                            break;
                        case 45:
                            Player1Card1.Image = Poker.Properties.Resources.QueenDiamonds;
                            d1.Hand1[0] = "QD";
                            break;
                        case 46:
                            Player1Card1.Image = Poker.Properties.Resources.QueenClubs1;
                            d1.Hand1[0] = "QC";
                            break;
                        case 47:
                            Player1Card1.Image = Poker.Properties.Resources.QueenSpades;
                            d1.Hand1[0] = "QS";
                            break;
                        case 48:
                            Player1Card1.Image = Poker.Properties.Resources.KingHearts;
                            d1.Hand1[0] = "KH";
                            break;
                        case 49:
                            Player1Card1.Image = Poker.Properties.Resources.KingDiamonds1;
                            d1.Hand1[0] = "KD";
                            break;
                        case 50:
                            Player1Card1.Image = Poker.Properties.Resources.KingClubs;
                            d1.Hand1[0] = "KC";
                            break;
                        case 51:
                            Player1Card1.Image = Poker.Properties.Resources.KingSpades;
                            d1.Hand1[0] = "KS";
                            break;
                    }
                
                }
                if (d1.Turn == 3)
                {
                    switch (n)
                    {

                        case 0:
                            Player1Card2.Image = Poker.Properties.Resources.AceHearts;
                            d1.Hand1[1] = "AH";
                            break;
                        case 1:
                            Player1Card2.Image = Poker.Properties.Resources.AceDiamonds;
                            d1.Hand1[1] = "AD";
                            break;
                        case 2:
                            Player1Card2.Image = Poker.Properties.Resources.AceClubs;
                            d1.Hand1[1] = "AC";
                            break;
                        case 3:
                            Player1Card2.Image = Poker.Properties.Resources.AceSpades;
                            d1.Hand1[1] = "AS";
                            break;
                        case 4:
                            Player1Card2.Image = Poker.Properties.Resources.TwoHearts;
                            d1.Hand1[1] = "2H";
                            break;
                        case 5:
                            Player1Card2.Image = Poker.Properties.Resources.TwoDiamonds;
                            d1.Hand1[1] = "2D";
                            break;
                        case 6:
                            Player1Card2.Image = Poker.Properties.Resources.TwoClubs;
                            d1.Hand1[1] = "2C";
                            break;
                        case 7:
                            Player1Card2.Image = Poker.Properties.Resources.TwoSpades;
                            d1.Hand1[1] = "2S";
                            break;
                        case 8:
                            Player1Card2.Image = Poker.Properties.Resources.ThreeHearts;
                            d1.Hand1[1] = "3H";
                            break;
                        case 9:
                            Player1Card2.Image = Poker.Properties.Resources.ThreeDiamonds;
                            d1.Hand1[1] = "3D";
                            break;
                        case 10:
                            Player1Card2.Image = Poker.Properties.Resources.ThreeClubs;
                            d1.Hand1[1] = "3C";
                            break;
                        case 11:
                            Player1Card2.Image = Poker.Properties.Resources.ThreeSpades;
                            d1.Hand1[1] = "3S";
                            break;
                        case 12:
                            Player1Card2.Image = Poker.Properties.Resources.FourHearts;
                            d1.Hand1[1] = "4H";
                            break;
                        case 13:
                            Player1Card2.Image = Poker.Properties.Resources.FourDiamonds;
                            d1.Hand1[1] = "4D";
                            break;
                        case 14:
                            Player1Card2.Image = Poker.Properties.Resources.FourClubs;
                            d1.Hand1[1] = "4C";
                            break;
                        case 15:
                            Player1Card2.Image = Poker.Properties.Resources.FourSpades;
                            d1.Hand1[1] = "4S";
                            break;
                        case 16:
                            Player1Card2.Image = Poker.Properties.Resources.FiveHearts;
                            d1.Hand1[1] = "5H";
                            break;
                        case 17:
                            Player1Card2.Image = Poker.Properties.Resources.FiveDiamonds;
                            d1.Hand1[1] = "5D";
                            break;
                        case 18:
                            Player1Card2.Image = Poker.Properties.Resources.FiveClubs;
                            d1.Hand1[1] = "5C";
                            break;
                        case 19:
                            Player1Card2.Image = Poker.Properties.Resources.FiveSpades;
                            d1.Hand1[1] = "5S";
                            break;
                        case 20:
                            Player1Card2.Image = Poker.Properties.Resources.SixHearts;
                            d1.Hand1[1] = "6H";
                            break;
                        case 21:
                            Player1Card2.Image = Poker.Properties.Resources.SixDiamonds;
                            d1.Hand1[1] = "6D";
                            break;
                        case 22:
                            Player1Card2.Image = Poker.Properties.Resources.SixClubs;
                            d1.Hand1[1] = "6C";
                            break;
                        case 23:
                            Player1Card2.Image = Poker.Properties.Resources.SixSpades;
                            d1.Hand1[1] = "6S";
                            break;
                        case 24:
                            Player1Card2.Image = Poker.Properties.Resources.SevenHearts;
                            d1.Hand1[1] = "7H";
                            break;
                        case 25:
                            Player1Card2.Image = Poker.Properties.Resources.SevenDiamonds;
                            d1.Hand1[1] = "7D";
                            break;
                        case 26:
                            Player1Card2.Image = Poker.Properties.Resources.SevenClubs;
                            d1.Hand1[1] = "7C";
                            break;
                        case 27:
                            Player1Card2.Image = Poker.Properties.Resources.SevenSpades;
                            d1.Hand1[1] = "7S";
                            break;
                        case 28:
                            Player1Card2.Image = Poker.Properties.Resources.EightHearts;
                            d1.Hand1[1] = "8H";
                            break;
                        case 29:
                            Player1Card2.Image = Poker.Properties.Resources.EightDiamonds;
                            d1.Hand1[1] = "8D";
                            break;
                        case 30:
                            Player1Card2.Image = Poker.Properties.Resources.EightClubs;
                            d1.Hand1[1] = "8C";
                            break;
                        case 31:
                            Player1Card2.Image = Poker.Properties.Resources.EightSpades;
                            d1.Hand1[1] = "8S";
                            break;
                        case 32:
                            Player1Card2.Image = Poker.Properties.Resources.NineHearts;
                            d1.Hand1[1] = "9H";
                            break;
                        case 33:
                            Player1Card2.Image = Poker.Properties.Resources.NineDiamonds;
                            d1.Hand1[1] = "9D";
                            break;
                        case 34:
                            Player1Card2.Image = Poker.Properties.Resources.NineClubs;
                            d1.Hand1[1] = "9C";
                            break;
                        case 35:
                            Player1Card2.Image = Poker.Properties.Resources.NineSpades;
                            d1.Hand1[1] = "9S";
                            break;
                        case 36:
                            Player1Card2.Image = Poker.Properties.Resources.TenHearts;
                            d1.Hand1[1] = "10H";
                            break;
                        case 37:
                            Player1Card2.Image = Poker.Properties.Resources.TenDiamonds;
                            d1.Hand1[1] = "10D";
                            break;
                        case 38:
                            Player1Card2.Image = Poker.Properties.Resources.TenClubs;
                            d1.Hand1[1] = "10C";
                            break;
                        case 39:
                            Player1Card2.Image = Poker.Properties.Resources.TenSpades;
                            d1.Hand1[1] = "10S";
                            break;
                        case 40:
                            Player1Card2.Image = Poker.Properties.Resources.JackHearts;
                            d1.Hand1[1] = "JH";
                            break;
                        case 41:
                            Player1Card2.Image = Poker.Properties.Resources.JackDiamonds;
                            d1.Hand1[1] = "JD";
                            break;
                        case 42:
                            Player1Card2.Image = Poker.Properties.Resources.JackClubs;
                            d1.Hand1[1] = "JC";
                            break;
                        case 43:
                            Player1Card2.Image = Poker.Properties.Resources.JackSpades;
                            d1.Hand1[1] = "JS";
                            break;
                        case 44:
                            Player1Card2.Image = Poker.Properties.Resources.QueenHearts;
                            d1.Hand1[1] = "QH";
                            break;
                        case 45:
                            Player1Card2.Image = Poker.Properties.Resources.QueenDiamonds;
                            d1.Hand1[1] = "QD";
                            break;
                        case 46:
                            Player1Card2.Image = Poker.Properties.Resources.QueenClubs1;
                            d1.Hand1[1] = "QC";
                            break;
                        case 47:
                            Player1Card2.Image = Poker.Properties.Resources.QueenSpades;
                            d1.Hand1[1] = "QS";
                            break;
                        case 48:
                            Player1Card2.Image = Poker.Properties.Resources.KingHearts;
                            d1.Hand1[1] = "KH";
                            break;
                        case 49:
                            Player1Card2.Image = Poker.Properties.Resources.KingDiamonds1;
                            d1.Hand1[1] = "KD";
                            break;
                        case 50:
                            Player1Card2.Image = Poker.Properties.Resources.KingClubs;
                            d1.Hand1[1] = "KC";
                            break;
                        case 51:
                            Player1Card2.Image = Poker.Properties.Resources.KingSpades;
                            d1.Hand1[1] = "KS";
                            break;
                    }
                }
                if (d1.Turn == 5)
                {
                    switch (n)
                    {

                        case 0:
                            Player1Card3.Image = Poker.Properties.Resources.AceHearts;
                            d1.Hand1[2] = "AH";
                            break;
                        case 1:
                            Player1Card3.Image = Poker.Properties.Resources.AceDiamonds;
                            d1.Hand1[2] = "AD";
                            break;
                        case 2:
                            Player1Card3.Image = Poker.Properties.Resources.AceClubs;
                            d1.Hand1[2] = "AC";
                            break;
                        case 3:
                            Player1Card3.Image = Poker.Properties.Resources.AceSpades;
                            d1.Hand1[2] = "AS";
                            break;
                        case 4:
                            Player1Card3.Image = Poker.Properties.Resources.TwoHearts;
                            d1.Hand1[2] = "2H";
                            break;
                        case 5:
                            Player1Card3.Image = Poker.Properties.Resources.TwoDiamonds;
                            d1.Hand1[2] = "2D";
                            break;
                        case 6:
                            Player1Card3.Image = Poker.Properties.Resources.TwoClubs;
                            d1.Hand1[2] = "2C";
                            break;
                        case 7:
                            Player1Card3.Image = Poker.Properties.Resources.TwoSpades;
                            d1.Hand1[2] = "2S";
                            break;
                        case 8:
                            Player1Card3.Image = Poker.Properties.Resources.ThreeHearts;
                            d1.Hand1[2] = "3H";
                            break;
                        case 9:
                            Player1Card3.Image = Poker.Properties.Resources.ThreeDiamonds;
                            d1.Hand1[2] = "3D";
                            break;
                        case 10:
                            Player1Card3.Image = Poker.Properties.Resources.ThreeClubs;
                            d1.Hand1[2] = "3C";
                            break;
                        case 11:
                            Player1Card3.Image = Poker.Properties.Resources.ThreeSpades;
                            d1.Hand1[2] = "3S";
                            break;
                        case 12:
                            Player1Card3.Image = Poker.Properties.Resources.FourHearts;
                            d1.Hand1[2] = "4H";
                            break;
                        case 13:
                            Player1Card3.Image = Poker.Properties.Resources.FourDiamonds;
                            d1.Hand1[2] = "4D";
                            break;
                        case 14:
                            Player1Card3.Image = Poker.Properties.Resources.FourClubs;
                            d1.Hand1[2] = "4C";
                            break;
                        case 15:
                            Player1Card3.Image = Poker.Properties.Resources.FourSpades;
                            d1.Hand1[2] = "4S";
                            break;
                        case 16:
                            Player1Card3.Image = Poker.Properties.Resources.FiveHearts;
                            d1.Hand1[2] = "5H";
                            break;
                        case 17:
                            Player1Card3.Image = Poker.Properties.Resources.FiveDiamonds;
                            d1.Hand1[2] = "5D";
                            break;
                        case 18:
                            Player1Card3.Image = Poker.Properties.Resources.FiveClubs;
                            d1.Hand1[2] = "5C";
                            break;
                        case 19:
                            Player1Card3.Image = Poker.Properties.Resources.FiveSpades;
                            d1.Hand1[2] = "5S";
                            break;
                        case 20:
                            Player1Card3.Image = Poker.Properties.Resources.SixHearts;
                            d1.Hand1[2] = "6H";
                            break;
                        case 21:
                            Player1Card3.Image = Poker.Properties.Resources.SixDiamonds;
                            d1.Hand1[2] = "6D";
                            break;
                        case 22:
                            Player1Card3.Image = Poker.Properties.Resources.SixClubs;
                            d1.Hand1[2] = "6C";
                            break;
                        case 23:
                            Player1Card3.Image = Poker.Properties.Resources.SixSpades;
                            d1.Hand1[2] = "6S";
                            break;
                        case 24:
                            Player1Card3.Image = Poker.Properties.Resources.SevenHearts;
                            d1.Hand1[2] = "7H";
                            break;
                        case 25:
                            Player1Card3.Image = Poker.Properties.Resources.SevenDiamonds;
                            d1.Hand1[2] = "7D";
                            break;
                        case 26:
                            Player1Card3.Image = Poker.Properties.Resources.SevenClubs;
                            d1.Hand1[2] = "7C";
                            break;
                        case 27:
                            Player1Card3.Image = Poker.Properties.Resources.SevenSpades;
                            d1.Hand1[2] = "7S";
                            break;
                        case 28:
                            Player1Card3.Image = Poker.Properties.Resources.EightHearts;
                            d1.Hand1[2] = "8H";
                            break;
                        case 29:
                            Player1Card3.Image = Poker.Properties.Resources.EightDiamonds;
                            d1.Hand1[2] = "8D";
                            break;
                        case 30:
                            Player1Card3.Image = Poker.Properties.Resources.EightClubs;
                            d1.Hand1[2] = "8C";
                            break;
                        case 31:
                            Player1Card3.Image = Poker.Properties.Resources.EightSpades;
                            d1.Hand1[2] = "8S";
                            break;
                        case 32:
                            Player1Card3.Image = Poker.Properties.Resources.NineHearts;
                            d1.Hand1[2] = "9H";
                            break;
                        case 33:
                            Player1Card3.Image = Poker.Properties.Resources.NineDiamonds;
                            d1.Hand1[2] = "9D";
                            break;
                        case 34:
                            Player1Card3.Image = Poker.Properties.Resources.NineClubs;
                            d1.Hand1[2] = "9C";
                            break;
                        case 35:
                            Player1Card3.Image = Poker.Properties.Resources.NineSpades;
                            d1.Hand1[2] = "9S";
                            break;
                        case 36:
                            Player1Card3.Image = Poker.Properties.Resources.TenHearts;
                            d1.Hand1[2] = "10H";
                            break;
                        case 37:
                            Player1Card3.Image = Poker.Properties.Resources.TenDiamonds;
                            d1.Hand1[2] = "10D";
                            break;
                        case 38:
                            Player1Card3.Image = Poker.Properties.Resources.TenClubs;
                            d1.Hand1[2] = "10C";
                            break;
                        case 39:
                            Player1Card3.Image = Poker.Properties.Resources.TenSpades;
                            d1.Hand1[2] = "10S";
                            break;
                        case 40:
                            Player1Card3.Image = Poker.Properties.Resources.JackHearts;
                            d1.Hand1[2] = "JH";
                            break;
                        case 41:
                            Player1Card3.Image = Poker.Properties.Resources.JackDiamonds;
                            d1.Hand1[2] = "JD";
                            break;
                        case 42:
                            Player1Card3.Image = Poker.Properties.Resources.JackClubs;
                            d1.Hand1[2] = "JC";
                            break;
                        case 43:
                            Player1Card3.Image = Poker.Properties.Resources.JackSpades;
                            d1.Hand1[2] = "JS";
                            break;
                        case 44:
                            Player1Card3.Image = Poker.Properties.Resources.QueenHearts;
                            d1.Hand1[2] = "QH";
                            break;
                        case 45:
                            Player1Card3.Image = Poker.Properties.Resources.QueenDiamonds;
                            d1.Hand1[2] = "QD";
                            break;
                        case 46:
                            Player1Card3.Image = Poker.Properties.Resources.QueenClubs1;
                            d1.Hand1[2] = "QC";
                            break;
                        case 47:
                            Player1Card3.Image = Poker.Properties.Resources.QueenSpades;
                            d1.Hand1[2] = "QS";
                            break;
                        case 48:
                            Player1Card3.Image = Poker.Properties.Resources.KingHearts;
                            d1.Hand1[2] = "KH";
                            break;
                        case 49:
                            Player1Card3.Image = Poker.Properties.Resources.KingDiamonds1;
                            d1.Hand1[2] = "KD";
                            break;
                        case 50:
                            Player1Card3.Image = Poker.Properties.Resources.KingClubs;
                            d1.Hand1[2] = "KC";
                            break;
                        case 51:
                            Player1Card3.Image = Poker.Properties.Resources.KingSpades;
                            d1.Hand1[2] = "KS";
                            break;
                    }
                }
                if (d1.Turn == 7)
                {
                    switch (n)
                    {

                        case 0:
                            Player1Card4.Image = Poker.Properties.Resources.AceHearts;
                            d1.Hand1[3] = "AH";
                            break;
                        case 1:
                            Player1Card4.Image = Poker.Properties.Resources.AceDiamonds;
                            d1.Hand1[3] = "AD";
                            break;
                        case 2:
                            Player1Card4.Image = Poker.Properties.Resources.AceClubs;
                            d1.Hand1[3] = "AC";
                            break;
                        case 3:
                            Player1Card4.Image = Poker.Properties.Resources.AceSpades;
                            d1.Hand1[3] = "AS";
                            break;
                        case 4:
                            Player1Card4.Image = Poker.Properties.Resources.TwoHearts;
                            d1.Hand1[3] = "2H";
                            break;
                        case 5:
                            Player1Card4.Image = Poker.Properties.Resources.TwoDiamonds;
                            d1.Hand1[3] = "2D";
                            break;
                        case 6:
                            Player1Card4.Image = Poker.Properties.Resources.TwoClubs;
                            d1.Hand1[3] = "2C";
                            break;
                        case 7:
                            Player1Card4.Image = Poker.Properties.Resources.TwoSpades;
                            d1.Hand1[3] = "2S";
                            break;
                        case 8:
                            Player1Card4.Image = Poker.Properties.Resources.ThreeHearts;
                            d1.Hand1[3] = "3H";
                            break;
                        case 9:
                            Player1Card4.Image = Poker.Properties.Resources.ThreeDiamonds;
                            d1.Hand1[3] = "3D";
                            break;
                        case 10:
                            Player1Card4.Image = Poker.Properties.Resources.ThreeClubs;
                            d1.Hand1[3] = "3C";
                            break;
                        case 11:
                            Player1Card4.Image = Poker.Properties.Resources.ThreeSpades;
                            d1.Hand1[3] = "3S";
                            break;
                        case 12:
                            Player1Card4.Image = Poker.Properties.Resources.FourHearts;
                            d1.Hand1[3] = "4H";
                            break;
                        case 13:
                            Player1Card4.Image = Poker.Properties.Resources.FourDiamonds;
                            d1.Hand1[3] = "4D";
                            break;
                        case 14:
                            Player1Card4.Image = Poker.Properties.Resources.FourClubs;
                            d1.Hand1[3] = "4C";
                            break;
                        case 15:
                            Player1Card4.Image = Poker.Properties.Resources.FourSpades;
                            d1.Hand1[3] = "4S";
                            break;
                        case 16:
                            Player1Card4.Image = Poker.Properties.Resources.FiveHearts;
                            d1.Hand1[3] = "5H";
                            break;
                        case 17:
                            Player1Card4.Image = Poker.Properties.Resources.FiveDiamonds;
                            d1.Hand1[3] = "5D";
                            break;
                        case 18:
                            Player1Card4.Image = Poker.Properties.Resources.FiveClubs;
                            d1.Hand1[3] = "5C";
                            break;
                        case 19:
                            Player1Card4.Image = Poker.Properties.Resources.FiveSpades;
                            d1.Hand1[3] = "5S";
                            break;
                        case 20:
                            Player1Card4.Image = Poker.Properties.Resources.SixHearts;
                            d1.Hand1[3] = "6H";
                            break;
                        case 21:
                            Player1Card4.Image = Poker.Properties.Resources.SixDiamonds;
                            d1.Hand1[3] = "6D";
                            break;
                        case 22:
                            Player1Card4.Image = Poker.Properties.Resources.SixClubs;
                            d1.Hand1[3] = "6C";
                            break;
                        case 23:
                            Player1Card4.Image = Poker.Properties.Resources.SixSpades;
                            d1.Hand1[3] = "6S";
                            break;
                        case 24:
                            Player1Card4.Image = Poker.Properties.Resources.SevenHearts;
                            d1.Hand1[3] = "7H";
                            break;
                        case 25:
                            Player1Card4.Image = Poker.Properties.Resources.SevenDiamonds;
                            d1.Hand1[3] = "7D";
                            break;
                        case 26:
                            Player1Card4.Image = Poker.Properties.Resources.SevenClubs;
                            d1.Hand1[3] = "7C";
                            break;
                        case 27:
                            Player1Card4.Image = Poker.Properties.Resources.SevenSpades;
                            d1.Hand1[3] = "7S";
                            break;
                        case 28:
                            Player1Card4.Image = Poker.Properties.Resources.EightHearts;
                            d1.Hand1[3] = "8H";
                            break;
                        case 29:
                            Player1Card4.Image = Poker.Properties.Resources.EightDiamonds;
                            d1.Hand1[3] = "8D";
                            break;
                        case 30:
                            Player1Card4.Image = Poker.Properties.Resources.EightClubs;
                            d1.Hand1[3] = "8C";
                            break;
                        case 31:
                            Player1Card4.Image = Poker.Properties.Resources.EightSpades;
                            d1.Hand1[3] = "8S";
                            break;
                        case 32:
                            Player1Card4.Image = Poker.Properties.Resources.NineHearts;
                            d1.Hand1[3] = "9H";
                            break;
                        case 33:
                            Player1Card4.Image = Poker.Properties.Resources.NineDiamonds;
                            d1.Hand1[3] = "9D";
                            break;
                        case 34:
                            Player1Card4.Image = Poker.Properties.Resources.NineClubs;
                            d1.Hand1[3] = "9C";
                            break;
                        case 35:
                            Player1Card4.Image = Poker.Properties.Resources.NineSpades;
                            d1.Hand1[3] = "9S";
                            break;
                        case 36:
                            Player1Card4.Image = Poker.Properties.Resources.TenHearts;
                            d1.Hand1[3] = "10H";
                            break;
                        case 37:
                            Player1Card4.Image = Poker.Properties.Resources.TenDiamonds;
                            d1.Hand1[3] = "10D";
                            break;
                        case 38:
                            Player1Card4.Image = Poker.Properties.Resources.TenClubs;
                            d1.Hand1[3] = "10C";
                            break;
                        case 39:
                            Player1Card4.Image = Poker.Properties.Resources.TenSpades;
                            d1.Hand1[3] = "10S";
                            break;
                        case 40:
                            Player1Card4.Image = Poker.Properties.Resources.JackHearts;
                            d1.Hand1[3] = "JH";
                            break;
                        case 41:
                            Player1Card4.Image = Poker.Properties.Resources.JackDiamonds;
                            d1.Hand1[3] = "JD";
                            break;
                        case 42:
                            Player1Card4.Image = Poker.Properties.Resources.JackClubs;
                            d1.Hand1[3] = "JC";
                            break;
                        case 43:
                            Player1Card4.Image = Poker.Properties.Resources.JackSpades;
                            d1.Hand1[3] = "JS";
                            break;
                        case 44:
                            Player1Card4.Image = Poker.Properties.Resources.QueenHearts;
                            d1.Hand1[3] = "QH";
                            break;
                        case 45:
                            Player1Card4.Image = Poker.Properties.Resources.QueenDiamonds;
                            d1.Hand1[3] = "QD";
                            break;
                        case 46:
                            Player1Card4.Image = Poker.Properties.Resources.QueenClubs1;
                            d1.Hand1[3] = "QC";
                            break;
                        case 47:
                            Player1Card4.Image = Poker.Properties.Resources.QueenSpades;
                            d1.Hand1[3] = "QS";
                            break;
                        case 48:
                            Player1Card4.Image = Poker.Properties.Resources.KingHearts;
                            d1.Hand1[3] = "KH";
                            break;
                        case 49:
                            Player1Card4.Image = Poker.Properties.Resources.KingDiamonds1;
                            d1.Hand1[3] = "KD";
                            break;
                        case 50:
                            Player1Card4.Image = Poker.Properties.Resources.KingClubs;
                            d1.Hand1[3] = "KC";
                            break;
                        case 51:
                            Player1Card4.Image = Poker.Properties.Resources.KingSpades;
                            d1.Hand1[3] = "KS";
                            break;
                    }
                }
                if (d1.Turn == 9)
                {
                    switch (n)
                    {

                        case 0:
                            Player1Card5.Image = Poker.Properties.Resources.AceHearts;
                            d1.Hand1[4] = "AH";
                            break;
                        case 1:
                            Player1Card5.Image = Poker.Properties.Resources.AceDiamonds;
                            d1.Hand1[4] = "AD";
                            break;
                        case 2:
                            Player1Card5.Image = Poker.Properties.Resources.AceClubs;
                            d1.Hand1[4] = "AC";
                            break;
                        case 3:
                            Player1Card5.Image = Poker.Properties.Resources.AceSpades;
                            d1.Hand1[4] = "AS";
                            break;
                        case 4:
                            Player1Card5.Image = Poker.Properties.Resources.TwoHearts;
                            d1.Hand1[4] = "2H";
                            break;
                        case 5:
                            Player1Card5.Image = Poker.Properties.Resources.TwoDiamonds;
                            d1.Hand1[4] = "2D";
                            break;
                        case 6:
                            Player1Card5.Image = Poker.Properties.Resources.TwoClubs;
                            d1.Hand1[4] = "2C";
                            break;
                        case 7:
                            Player1Card5.Image = Poker.Properties.Resources.TwoSpades;
                            d1.Hand1[4] = "2S";
                            break;
                        case 8:
                            Player1Card5.Image = Poker.Properties.Resources.ThreeHearts;
                            d1.Hand1[4] = "3H";
                            break;
                        case 9:
                            Player1Card5.Image = Poker.Properties.Resources.ThreeDiamonds;
                            d1.Hand1[4] = "3D";
                            break;
                        case 10:
                            Player1Card5.Image = Poker.Properties.Resources.ThreeClubs;
                            d1.Hand1[4] = "3C";
                            break;
                        case 11:
                            Player1Card5.Image = Poker.Properties.Resources.ThreeSpades;
                            d1.Hand1[4] = "3S";
                            break;
                        case 12:
                            Player1Card5.Image = Poker.Properties.Resources.FourHearts;
                            d1.Hand1[4] = "4H";
                            break;
                        case 13:
                            Player1Card5.Image = Poker.Properties.Resources.FourDiamonds;
                            d1.Hand1[4] = "4D";
                            break;
                        case 14:
                            Player1Card5.Image = Poker.Properties.Resources.FourClubs;
                            d1.Hand1[4] = "4C";
                            break;
                        case 15:
                            Player1Card5.Image = Poker.Properties.Resources.FourSpades;
                            d1.Hand1[4] = "4S";
                            break;
                        case 16:
                            Player1Card5.Image = Poker.Properties.Resources.FiveHearts;
                            d1.Hand1[4] = "5H";
                            break;
                        case 17:
                            Player1Card5.Image = Poker.Properties.Resources.FiveDiamonds;
                            d1.Hand1[4] = "5D";
                            break;
                        case 18:
                            Player1Card5.Image = Poker.Properties.Resources.FiveClubs;
                            d1.Hand1[4] = "5C";
                            break;
                        case 19:
                            Player1Card5.Image = Poker.Properties.Resources.FiveSpades;
                            d1.Hand1[4] = "5S";
                            break;
                        case 20:
                            Player1Card5.Image = Poker.Properties.Resources.SixHearts;
                            d1.Hand1[4] = "6H";
                            break;
                        case 21:
                            Player1Card5.Image = Poker.Properties.Resources.SixDiamonds;
                            d1.Hand1[4] = "6D";
                            break;
                        case 22:
                            Player1Card5.Image = Poker.Properties.Resources.SixClubs;
                            d1.Hand1[4] = "6C";
                            break;
                        case 23:
                            Player1Card5.Image = Poker.Properties.Resources.SixSpades;
                            d1.Hand1[4] = "6S";
                            break;
                        case 24:
                            Player1Card5.Image = Poker.Properties.Resources.SevenHearts;
                            d1.Hand1[4] = "7H";
                            break;
                        case 25:
                            Player1Card5.Image = Poker.Properties.Resources.SevenDiamonds;
                            d1.Hand1[4] = "7D";
                            break;
                        case 26:
                            Player1Card5.Image = Poker.Properties.Resources.SevenClubs;
                            d1.Hand1[4] = "7C";
                            break;
                        case 27:
                            Player1Card5.Image = Poker.Properties.Resources.SevenSpades;
                            d1.Hand1[4] = "7S";
                            break;
                        case 28:
                            Player1Card5.Image = Poker.Properties.Resources.EightHearts;
                            d1.Hand1[4] = "8H";
                            break;
                        case 29:
                            Player1Card5.Image = Poker.Properties.Resources.EightDiamonds;
                            d1.Hand1[4] = "8D";
                            break;
                        case 30:
                            Player1Card5.Image = Poker.Properties.Resources.EightClubs;
                            d1.Hand1[4] = "8C";
                            break;
                        case 31:
                            Player1Card5.Image = Poker.Properties.Resources.EightSpades;
                            d1.Hand1[4] = "8S";
                            break;
                        case 32:
                            Player1Card5.Image = Poker.Properties.Resources.NineHearts;
                            d1.Hand1[4] = "9H";
                            break;
                        case 33:
                            Player1Card5.Image = Poker.Properties.Resources.NineDiamonds;
                            d1.Hand1[4] = "9D";
                            break;
                        case 34:
                            Player1Card5.Image = Poker.Properties.Resources.NineClubs;
                            d1.Hand1[4] = "9C";
                            break;
                        case 35:
                            Player1Card5.Image = Poker.Properties.Resources.NineSpades;
                            d1.Hand1[4] = "9S";
                            break;
                        case 36:
                            Player1Card5.Image = Poker.Properties.Resources.TenHearts;
                            d1.Hand1[4] = "10H";
                            break;
                        case 37:
                            Player1Card5.Image = Poker.Properties.Resources.TenDiamonds;
                            d1.Hand1[4] = "10D";
                            break;
                        case 38:
                            Player1Card5.Image = Poker.Properties.Resources.TenClubs;
                            d1.Hand1[4] = "10C";
                            break;
                        case 39:
                            Player1Card5.Image = Poker.Properties.Resources.TenSpades;
                            d1.Hand1[4] = "10S";
                            break;
                        case 40:
                            Player1Card5.Image = Poker.Properties.Resources.JackHearts;
                            d1.Hand1[4] = "JH";
                            break;
                        case 41:
                            Player1Card5.Image = Poker.Properties.Resources.JackDiamonds;
                            d1.Hand1[4] = "JD";
                            break;
                        case 42:
                            Player1Card5.Image = Poker.Properties.Resources.JackClubs;
                            d1.Hand1[4] = "JC";
                            break;
                        case 43:
                            Player1Card5.Image = Poker.Properties.Resources.JackSpades;
                            d1.Hand1[4] = "JS";
                            break;
                        case 44:
                            Player1Card5.Image = Poker.Properties.Resources.QueenHearts;
                            d1.Hand1[4] = "QH";
                            break;
                        case 45:
                            Player1Card5.Image = Poker.Properties.Resources.QueenDiamonds;
                            d1.Hand1[4] = "QD";
                            break;
                        case 46:
                            Player1Card5.Image = Poker.Properties.Resources.QueenClubs1;
                            d1.Hand1[4] = "QC";
                            break;
                        case 47:
                            Player1Card5.Image = Poker.Properties.Resources.QueenSpades;
                            d1.Hand1[4] = "QS";
                            break;
                        case 48:
                            Player1Card5.Image = Poker.Properties.Resources.KingHearts;
                            d1.Hand1[4] = "KH";
                            break;
                        case 49:
                            Player1Card5.Image = Poker.Properties.Resources.KingDiamonds1;
                            d1.Hand1[4] = "KD";
                            break;
                        case 50:
                            Player1Card5.Image = Poker.Properties.Resources.KingClubs;
                            d1.Hand1[4] = "KC";
                            break;
                        case 51:
                            Player1Card5.Image = Poker.Properties.Resources.KingSpades;
                            d1.Hand1[4] = "KS";
                            break;
                    }
                }
                if (d1.Turn == 2)
                {
                    switch (n)
                    {

                        case 0:
                            Player2Card1.Image = Poker.Properties.Resources.AceHearts;
                            d1.Hand2[0] = "AH";
                            break;
                        case 1:
                            Player2Card1.Image = Poker.Properties.Resources.AceDiamonds;
                            d1.Hand2[0] = "AD";
                            break;
                        case 2:
                            Player2Card1.Image = Poker.Properties.Resources.AceClubs;
                            d1.Hand2[0] = "AC";
                            break;
                        case 3:
                            Player2Card1.Image = Poker.Properties.Resources.AceSpades;
                            d1.Hand2[0] = "AS";
                            break;
                        case 4:
                            Player2Card1.Image = Poker.Properties.Resources.TwoHearts;
                            d1.Hand2[0] = "2H";
                            break;
                        case 5:
                            Player2Card1.Image = Poker.Properties.Resources.TwoDiamonds;
                            d1.Hand2[0] = "2D";
                            break;
                        case 6:
                            Player2Card1.Image = Poker.Properties.Resources.TwoClubs;
                            d1.Hand2[0] = "2C";
                            break;
                        case 7:
                            Player2Card1.Image = Poker.Properties.Resources.TwoSpades;
                            d1.Hand2[0] = "2S";
                            break;
                        case 8:
                            Player2Card1.Image = Poker.Properties.Resources.ThreeHearts;
                            d1.Hand2[0] = "3H";
                            break;
                        case 9:
                            Player2Card1.Image = Poker.Properties.Resources.ThreeDiamonds;
                            d1.Hand2[0] = "3D";
                            break;
                        case 10:
                            Player2Card1.Image = Poker.Properties.Resources.ThreeClubs;
                            d1.Hand2[0] = "3C";
                            break;
                        case 11:
                            Player2Card1.Image = Poker.Properties.Resources.ThreeSpades;
                            d1.Hand2[0] = "3S";
                            break;
                        case 12:
                            Player2Card1.Image = Poker.Properties.Resources.FourHearts;
                            d1.Hand2[0] = "4H";
                            break;
                        case 13:
                            Player2Card1.Image = Poker.Properties.Resources.FourDiamonds;
                            d1.Hand2[0] = "4D";
                            break;
                        case 14:
                            Player2Card1.Image = Poker.Properties.Resources.FourClubs;
                            d1.Hand2[0] = "4C";
                            break;
                        case 15:
                            Player2Card1.Image = Poker.Properties.Resources.FourSpades;
                            d1.Hand2[0] = "4S";
                            break;
                        case 16:
                            Player2Card1.Image = Poker.Properties.Resources.FiveHearts;
                            d1.Hand2[0] = "5H";
                            break;
                        case 17:
                            Player2Card1.Image = Poker.Properties.Resources.FiveDiamonds;
                            d1.Hand2[0] = "5D";
                            break;
                        case 18:
                            Player2Card1.Image = Poker.Properties.Resources.FiveClubs;
                            d1.Hand2[0] = "5C";
                            break;
                        case 19:
                            Player2Card1.Image = Poker.Properties.Resources.FiveSpades;
                            d1.Hand2[0] = "5S";
                            break;
                        case 20:
                            Player2Card1.Image = Poker.Properties.Resources.SixHearts;
                            d1.Hand2[0] = "6H";
                            break;
                        case 21:
                            Player2Card1.Image = Poker.Properties.Resources.SixDiamonds;
                            d1.Hand2[0] = "6D";
                            break;
                        case 22:
                            Player2Card1.Image = Poker.Properties.Resources.SixClubs;
                            d1.Hand2[0] = "6C";
                            break;
                        case 23:
                            Player2Card1.Image = Poker.Properties.Resources.SixSpades;
                            d1.Hand2[0] = "6S";
                            break;
                        case 24:
                            Player2Card1.Image = Poker.Properties.Resources.SevenHearts;
                            d1.Hand2[0] = "7H";
                            break;
                        case 25:
                            Player2Card1.Image = Poker.Properties.Resources.SevenDiamonds;
                            d1.Hand2[0] = "7D";
                            break;
                        case 26:
                            Player2Card1.Image = Poker.Properties.Resources.SevenClubs;
                            d1.Hand2[0] = "7C";
                            break;
                        case 27:
                            Player2Card1.Image = Poker.Properties.Resources.SevenSpades;
                            d1.Hand2[0] = "7S";
                            break;
                        case 28:
                            Player2Card1.Image = Poker.Properties.Resources.EightHearts;
                            d1.Hand2[0] = "8H";
                            break;
                        case 29:
                            Player2Card1.Image = Poker.Properties.Resources.EightDiamonds;
                            d1.Hand2[0] = "8D";
                            break;
                        case 30:
                            Player2Card1.Image = Poker.Properties.Resources.EightClubs;
                            d1.Hand2[0] = "8C";
                            break;
                        case 31:
                            Player2Card1.Image = Poker.Properties.Resources.EightSpades;
                            d1.Hand2[0] = "8S";
                            break;
                        case 32:
                            Player2Card1.Image = Poker.Properties.Resources.NineHearts;
                            d1.Hand2[0] = "9H";
                            break;
                        case 33:
                            Player2Card1.Image = Poker.Properties.Resources.NineDiamonds;
                            d1.Hand2[0] = "9D";
                            break;
                        case 34:
                            Player2Card1.Image = Poker.Properties.Resources.NineClubs;
                            d1.Hand2[0] = "9C";
                            break;
                        case 35:
                            Player2Card1.Image = Poker.Properties.Resources.NineSpades;
                            d1.Hand2[0] = "9S";
                            break;
                        case 36:
                            Player2Card1.Image = Poker.Properties.Resources.TenHearts;
                            d1.Hand2[0] = "10H";
                            break;
                        case 37:
                            Player2Card1.Image = Poker.Properties.Resources.TenDiamonds;
                            d1.Hand2[0] = "10D";
                            break;
                        case 38:
                            Player2Card1.Image = Poker.Properties.Resources.TenClubs;
                            d1.Hand2[0] = "10C";
                            break;
                        case 39:
                            Player2Card1.Image = Poker.Properties.Resources.TenSpades;
                            d1.Hand2[0] = "10S";
                            break;
                        case 40:
                            Player2Card1.Image = Poker.Properties.Resources.JackHearts;
                            d1.Hand2[0] = "JH";
                            break;
                        case 41:
                            Player2Card1.Image = Poker.Properties.Resources.JackDiamonds;
                            d1.Hand2[0] = "JD";
                            break;
                        case 42:
                            Player2Card1.Image = Poker.Properties.Resources.JackClubs;
                            d1.Hand2[0] = "JC";
                            break;
                        case 43:
                            Player2Card1.Image = Poker.Properties.Resources.JackSpades;
                            d1.Hand2[0] = "JS";
                            break;
                        case 44:
                            Player2Card1.Image = Poker.Properties.Resources.QueenHearts;
                            d1.Hand2[0] = "QH";
                            break;
                        case 45:
                            Player2Card1.Image = Poker.Properties.Resources.QueenDiamonds;
                            d1.Hand2[0] = "QD";
                            break;
                        case 46:
                            Player2Card1.Image = Poker.Properties.Resources.QueenClubs1;
                            d1.Hand2[0] = "QC";
                            break;
                        case 47:
                            Player2Card1.Image = Poker.Properties.Resources.QueenSpades;
                            d1.Hand2[0] = "QS";
                            break;
                        case 48:
                            Player2Card1.Image = Poker.Properties.Resources.KingHearts;
                            d1.Hand2[0] = "KH";
                            break;
                        case 49:
                            Player2Card1.Image = Poker.Properties.Resources.KingDiamonds1;
                            d1.Hand2[0] = "KD";
                            break;
                        case 50:
                            Player2Card1.Image = Poker.Properties.Resources.KingClubs;
                            d1.Hand2[0] = "KC";
                            break;
                        case 51:
                            Player2Card1.Image = Poker.Properties.Resources.KingSpades;
                            d1.Hand2[0] = "KS";
                            break;
                    }
                }
                if (d1.Turn == 4)
                {
                    switch (n)
                    {

                        case 0:
                            Player2Card2.Image = Poker.Properties.Resources.AceHearts;
                            d1.Hand2[1] = "AH";
                            break;
                        case 1:
                            Player2Card2.Image = Poker.Properties.Resources.AceDiamonds;
                            d1.Hand2[1] = "AD";
                            break;
                        case 2:
                            Player2Card2.Image = Poker.Properties.Resources.AceClubs;
                            d1.Hand2[1] = "AC";
                            break;
                        case 3:
                            Player2Card2.Image = Poker.Properties.Resources.AceSpades;
                            d1.Hand2[1] = "AS";
                            break;
                        case 4:
                            Player2Card2.Image = Poker.Properties.Resources.TwoHearts;
                            d1.Hand2[1] = "2H";
                            break;
                        case 5:
                            Player2Card2.Image = Poker.Properties.Resources.TwoDiamonds;
                            d1.Hand2[1] = "2D";
                            break;
                        case 6:
                            Player2Card2.Image = Poker.Properties.Resources.TwoClubs;
                            d1.Hand2[1] = "2C";
                            break;
                        case 7:
                            Player2Card2.Image = Poker.Properties.Resources.TwoSpades;
                            d1.Hand2[1] = "2S";
                            break;
                        case 8:
                            Player2Card2.Image = Poker.Properties.Resources.ThreeHearts;
                            d1.Hand2[1] = "3H";
                            break;
                        case 9:
                            Player2Card2.Image = Poker.Properties.Resources.ThreeDiamonds;
                            d1.Hand2[1] = "3D";
                            break;
                        case 10:
                            Player2Card2.Image = Poker.Properties.Resources.ThreeClubs;
                            d1.Hand2[1] = "3C";
                            break;
                        case 11:
                            Player2Card2.Image = Poker.Properties.Resources.ThreeSpades;
                            d1.Hand2[1] = "3S";
                            break;
                        case 12:
                            Player2Card2.Image = Poker.Properties.Resources.FourHearts;
                            d1.Hand2[1] = "4H";
                            break;
                        case 13:
                            Player2Card2.Image = Poker.Properties.Resources.FourDiamonds;
                            d1.Hand2[1] = "4D";
                            break;
                        case 14:
                            Player2Card2.Image = Poker.Properties.Resources.FourClubs;
                            d1.Hand2[1] = "4C";
                            break;
                        case 15:
                            Player2Card2.Image = Poker.Properties.Resources.FourSpades;
                            d1.Hand2[1] = "4S";
                            break;
                        case 16:
                            Player2Card2.Image = Poker.Properties.Resources.FiveHearts;
                            d1.Hand2[1] = "5H";
                            break;
                        case 17:
                            Player2Card2.Image = Poker.Properties.Resources.FiveDiamonds;
                            d1.Hand2[1] = "5D";
                            break;
                        case 18:
                            Player2Card2.Image = Poker.Properties.Resources.FiveClubs;
                            d1.Hand2[1] = "5C";
                            break;
                        case 19:
                            Player2Card2.Image = Poker.Properties.Resources.FiveSpades;
                            d1.Hand2[1] = "5S";
                            break;
                        case 20:
                            Player2Card2.Image = Poker.Properties.Resources.SixHearts;
                            d1.Hand2[1] = "6H";
                            break;
                        case 21:
                            Player2Card2.Image = Poker.Properties.Resources.SixDiamonds;
                            d1.Hand2[1] = "6D";
                            break;
                        case 22:
                            Player2Card2.Image = Poker.Properties.Resources.SixClubs;
                            d1.Hand2[1] = "6C";
                            break;
                        case 23:
                            Player2Card2.Image = Poker.Properties.Resources.SixSpades;
                            d1.Hand2[1] = "6S";
                            break;
                        case 24:
                            Player2Card2.Image = Poker.Properties.Resources.SevenHearts;
                            d1.Hand2[1] = "7H";
                            break;
                        case 25:
                            Player2Card2.Image = Poker.Properties.Resources.SevenDiamonds;
                            d1.Hand2[1] = "7D";
                            break;
                        case 26:
                            Player2Card2.Image = Poker.Properties.Resources.SevenClubs;
                            d1.Hand2[1] = "7C";
                            break;
                        case 27:
                            Player2Card2.Image = Poker.Properties.Resources.SevenSpades;
                            d1.Hand2[1] = "7S";
                            break;
                        case 28:
                            Player2Card2.Image = Poker.Properties.Resources.EightHearts;
                            d1.Hand2[1] = "8H";
                            break;
                        case 29:
                            Player2Card2.Image = Poker.Properties.Resources.EightDiamonds;
                            d1.Hand2[1] = "8D";
                            break;
                        case 30:
                            Player2Card2.Image = Poker.Properties.Resources.EightClubs;
                            d1.Hand2[1] = "8C";
                            break;
                        case 31:
                            Player2Card2.Image = Poker.Properties.Resources.EightSpades;
                            d1.Hand2[1] = "8S";
                            break;
                        case 32:
                            Player2Card2.Image = Poker.Properties.Resources.NineHearts;
                            d1.Hand2[1] = "9H";
                            break;
                        case 33:
                            Player2Card2.Image = Poker.Properties.Resources.NineDiamonds;
                            d1.Hand2[1] = "9D";
                            break;
                        case 34:
                            Player2Card2.Image = Poker.Properties.Resources.NineClubs;
                            d1.Hand2[1] = "9C";
                            break;
                        case 35:
                            Player2Card2.Image = Poker.Properties.Resources.NineSpades;
                            d1.Hand2[1] = "9S";
                            break;
                        case 36:
                            Player2Card2.Image = Poker.Properties.Resources.TenHearts;
                            d1.Hand2[1] = "10H";
                            break;
                        case 37:
                            Player2Card2.Image = Poker.Properties.Resources.TenDiamonds;
                            d1.Hand2[1] = "10D";
                            break;
                        case 38:
                            Player2Card2.Image = Poker.Properties.Resources.TenClubs;
                            d1.Hand2[1] = "10C";
                            break;
                        case 39:
                            Player2Card2.Image = Poker.Properties.Resources.TenSpades;
                            d1.Hand2[1] = "10S";
                            break;
                        case 40:
                            Player2Card2.Image = Poker.Properties.Resources.JackHearts;
                            d1.Hand2[1] = "JH";
                            break;
                        case 41:
                            Player2Card2.Image = Poker.Properties.Resources.JackDiamonds;
                            d1.Hand2[1] = "JD";
                            break;
                        case 42:
                            Player2Card2.Image = Poker.Properties.Resources.JackClubs;
                            d1.Hand2[1] = "JC";
                            break;
                        case 43:
                            Player2Card2.Image = Poker.Properties.Resources.JackSpades;
                            d1.Hand2[1] = "JS";
                            break;
                        case 44:
                            Player2Card2.Image = Poker.Properties.Resources.QueenHearts;
                            d1.Hand2[1] = "QH";
                            break;
                        case 45:
                            Player2Card2.Image = Poker.Properties.Resources.QueenDiamonds;
                            d1.Hand2[1] = "QD";
                            break;
                        case 46:
                            Player2Card2.Image = Poker.Properties.Resources.QueenClubs1;
                            d1.Hand2[1] = "QC";
                            break;
                        case 47:
                            Player2Card2.Image = Poker.Properties.Resources.QueenSpades;
                            d1.Hand2[1] = "QS";
                            break;
                        case 48:
                            Player2Card2.Image = Poker.Properties.Resources.KingHearts;
                            d1.Hand2[1] = "KH";
                            break;
                        case 49:
                            Player2Card2.Image = Poker.Properties.Resources.KingDiamonds1;
                            d1.Hand2[1] = "KD";
                            break;
                        case 50:
                            Player2Card2.Image = Poker.Properties.Resources.KingClubs;
                            d1.Hand2[1] = "KC";
                            break;
                        case 51:
                            Player2Card2.Image = Poker.Properties.Resources.KingSpades;
                            d1.Hand2[1] = "KS";
                            break;
                    }
                }
                if (d1.Turn == 6)
                {
                    switch (n)
                    {

                        case 0:
                            Player2Card3.Image = Poker.Properties.Resources.AceHearts;
                            d1.Hand2[2] = "AH";
                            break;
                        case 1:
                            Player2Card3.Image = Poker.Properties.Resources.AceDiamonds;
                            d1.Hand2[2] = "AD";
                            break;
                        case 2:
                            Player2Card3.Image = Poker.Properties.Resources.AceClubs;
                            d1.Hand2[2] = "AC";
                            break;
                        case 3:
                            Player2Card3.Image = Poker.Properties.Resources.AceSpades;
                            d1.Hand2[2] = "AS";
                            break;
                        case 4:
                            Player2Card3.Image = Poker.Properties.Resources.TwoHearts;
                            d1.Hand2[2] = "2H";
                            break;
                        case 5:
                            Player2Card3.Image = Poker.Properties.Resources.TwoDiamonds;
                            d1.Hand2[2] = "2D";
                            break;
                        case 6:
                            Player2Card3.Image = Poker.Properties.Resources.TwoClubs;
                            d1.Hand2[2] = "2C";
                            break;
                        case 7:
                            Player2Card3.Image = Poker.Properties.Resources.TwoSpades;
                            d1.Hand2[2] = "2S";
                            break;
                        case 8:
                            Player2Card3.Image = Poker.Properties.Resources.ThreeHearts;
                            d1.Hand2[2] = "3H";
                            break;
                        case 9:
                            Player2Card3.Image = Poker.Properties.Resources.ThreeDiamonds;
                            d1.Hand2[2] = "3D";
                            break;
                        case 10:
                            Player2Card3.Image = Poker.Properties.Resources.ThreeClubs;
                            d1.Hand2[2] = "3C";
                            break;
                        case 11:
                            Player2Card3.Image = Poker.Properties.Resources.ThreeSpades;
                            d1.Hand2[2] = "3S";
                            break;
                        case 12:
                            Player2Card3.Image = Poker.Properties.Resources.FourHearts;
                            d1.Hand2[2] = "4H";
                            break;
                        case 13:
                            Player2Card3.Image = Poker.Properties.Resources.FourDiamonds;
                            d1.Hand2[2] = "4D";
                            break;
                        case 14:
                            Player2Card3.Image = Poker.Properties.Resources.FourClubs;
                            d1.Hand2[2] = "4C";
                            break;
                        case 15:
                            Player2Card3.Image = Poker.Properties.Resources.FourSpades;
                            d1.Hand2[2] = "4S";
                            break;
                        case 16:
                            Player2Card3.Image = Poker.Properties.Resources.FiveHearts;
                            d1.Hand2[2] = "5H";
                            break;
                        case 17:
                            Player2Card3.Image = Poker.Properties.Resources.FiveDiamonds;
                            d1.Hand2[2] = "5D";
                            break;
                        case 18:
                            Player2Card3.Image = Poker.Properties.Resources.FiveClubs;
                            d1.Hand2[2] = "5C";
                            break;
                        case 19:
                            Player2Card3.Image = Poker.Properties.Resources.FiveSpades;
                            d1.Hand2[2] = "5S";
                            break;
                        case 20:
                            Player2Card3.Image = Poker.Properties.Resources.SixHearts;
                            d1.Hand2[2] = "6H";
                            break;
                        case 21:
                            Player2Card3.Image = Poker.Properties.Resources.SixDiamonds;
                            d1.Hand2[2] = "6D";
                            break;
                        case 22:
                            Player2Card3.Image = Poker.Properties.Resources.SixClubs;
                            d1.Hand2[2] = "6C";
                            break;
                        case 23:
                            Player2Card3.Image = Poker.Properties.Resources.SixSpades;
                            d1.Hand2[2] = "6S";
                            break;
                        case 24:
                            Player2Card3.Image = Poker.Properties.Resources.SevenHearts;
                            d1.Hand2[2] = "7H";
                            break;
                        case 25:
                            Player2Card3.Image = Poker.Properties.Resources.SevenDiamonds;
                            d1.Hand2[2] = "7D";
                            break;
                        case 26:
                            Player2Card3.Image = Poker.Properties.Resources.SevenClubs;
                            d1.Hand2[2] = "7C";
                            break;
                        case 27:
                            Player2Card3.Image = Poker.Properties.Resources.SevenSpades;
                            d1.Hand2[2] = "7S";
                            break;
                        case 28:
                            Player2Card3.Image = Poker.Properties.Resources.EightHearts;
                            d1.Hand2[2] = "8H";
                            break;
                        case 29:
                            Player2Card3.Image = Poker.Properties.Resources.EightDiamonds;
                            d1.Hand2[2] = "8D";
                            break;
                        case 30:
                            Player2Card3.Image = Poker.Properties.Resources.EightClubs;
                            d1.Hand2[2] = "8C";
                            break;
                        case 31:
                            Player2Card3.Image = Poker.Properties.Resources.EightSpades;
                            d1.Hand2[2] = "8S";
                            break;
                        case 32:
                            Player2Card3.Image = Poker.Properties.Resources.NineHearts;
                            d1.Hand2[2] = "9H";
                            break;
                        case 33:
                            Player2Card3.Image = Poker.Properties.Resources.NineDiamonds;
                            d1.Hand2[2] = "9D";
                            break;
                        case 34:
                            Player2Card3.Image = Poker.Properties.Resources.NineClubs;
                            d1.Hand2[2] = "9C";
                            break;
                        case 35:
                            Player2Card3.Image = Poker.Properties.Resources.NineSpades;
                            d1.Hand2[2] = "9S";
                            break;
                        case 36:
                            Player2Card3.Image = Poker.Properties.Resources.TenHearts;
                            d1.Hand2[2] = "10H";
                            break;
                        case 37:
                            Player2Card3.Image = Poker.Properties.Resources.TenDiamonds;
                            d1.Hand2[2] = "10D";
                            break;
                        case 38:
                            Player2Card3.Image = Poker.Properties.Resources.TenClubs;
                            d1.Hand2[2] = "10C";
                            break;
                        case 39:
                            Player2Card3.Image = Poker.Properties.Resources.TenSpades;
                            d1.Hand2[2] = "10S";
                            break;
                        case 40:
                            Player2Card3.Image = Poker.Properties.Resources.JackHearts;
                            d1.Hand2[2] = "JH";
                            break;
                        case 41:
                            Player2Card3.Image = Poker.Properties.Resources.JackDiamonds;
                            d1.Hand2[2] = "JD";
                            break;
                        case 42:
                            Player2Card3.Image = Poker.Properties.Resources.JackClubs;
                            d1.Hand2[2] = "JC";
                            break;
                        case 43:
                            Player2Card3.Image = Poker.Properties.Resources.JackSpades;
                            d1.Hand2[2] = "JS";
                            break;
                        case 44:
                            Player2Card3.Image = Poker.Properties.Resources.QueenHearts;
                            d1.Hand2[2] = "QH";
                            break;
                        case 45:
                            Player2Card3.Image = Poker.Properties.Resources.QueenDiamonds;
                            d1.Hand2[2] = "QD";
                            break;
                        case 46:
                            Player2Card3.Image = Poker.Properties.Resources.QueenClubs1;
                            d1.Hand2[2] = "QC";
                            break;
                        case 47:
                            Player2Card3.Image = Poker.Properties.Resources.QueenSpades;
                            d1.Hand2[2] = "QS";
                            break;
                        case 48:
                            Player2Card3.Image = Poker.Properties.Resources.KingHearts;
                            d1.Hand2[2] = "KH";
                            break;
                        case 49:
                            Player2Card3.Image = Poker.Properties.Resources.KingDiamonds1;
                            d1.Hand2[2] = "KD";
                            break;
                        case 50:
                            Player2Card3.Image = Poker.Properties.Resources.KingClubs;
                            d1.Hand2[2] = "KC";
                            break;
                        case 51:
                            Player2Card3.Image = Poker.Properties.Resources.KingSpades;
                            d1.Hand2[2] = "KS";
                            break;
                    }
                }
                if (d1.Turn == 8)
                {
                    switch (n)
                    {

                        case 0:
                            Player2Card4.Image = Poker.Properties.Resources.AceHearts;
                            d1.Hand2[3] = "AH";
                            break;
                        case 1:
                            Player2Card4.Image = Poker.Properties.Resources.AceDiamonds;
                            d1.Hand2[3] = "AD";
                            break;
                        case 2:
                            Player2Card4.Image = Poker.Properties.Resources.AceClubs;
                            d1.Hand2[3] = "AC";
                            break;
                        case 3:
                            Player2Card4.Image = Poker.Properties.Resources.AceSpades;
                            d1.Hand2[3] = "AS";
                            break;
                        case 4:
                            Player2Card4.Image = Poker.Properties.Resources.TwoHearts;
                            d1.Hand2[3] = "2H";
                            break;
                        case 5:
                            Player2Card4.Image = Poker.Properties.Resources.TwoDiamonds;
                            d1.Hand2[3] = "2D";
                            break;
                        case 6:
                            Player2Card4.Image = Poker.Properties.Resources.TwoClubs;
                            d1.Hand2[3] = "2C";
                            break;
                        case 7:
                            Player2Card4.Image = Poker.Properties.Resources.TwoSpades;
                            d1.Hand2[3] = "2S";
                            break;
                        case 8:
                            Player2Card4.Image = Poker.Properties.Resources.ThreeHearts;
                            d1.Hand2[3] = "3H";
                            break;
                        case 9:
                            Player2Card4.Image = Poker.Properties.Resources.ThreeDiamonds;
                            d1.Hand2[3] = "3D";
                            break;
                        case 10:
                            Player2Card4.Image = Poker.Properties.Resources.ThreeClubs;
                            d1.Hand2[3] = "3C";
                            break;
                        case 11:
                            Player2Card4.Image = Poker.Properties.Resources.ThreeSpades;
                            d1.Hand2[3] = "3S";
                            break;
                        case 12:
                            Player2Card4.Image = Poker.Properties.Resources.FourHearts;
                            d1.Hand2[3] = "4H";
                            break;
                        case 13:
                            Player2Card4.Image = Poker.Properties.Resources.FourDiamonds;
                            d1.Hand2[3] = "4D";
                            break;
                        case 14:
                            Player2Card4.Image = Poker.Properties.Resources.FourClubs;
                            d1.Hand2[3] = "4C";
                            break;
                        case 15:
                            Player2Card4.Image = Poker.Properties.Resources.FourSpades;
                            d1.Hand2[3] = "4S";
                            break;
                        case 16:
                            Player2Card4.Image = Poker.Properties.Resources.FiveHearts;
                            d1.Hand2[3] = "5H";
                            break;
                        case 17:
                            Player2Card4.Image = Poker.Properties.Resources.FiveDiamonds;
                            d1.Hand2[3] = "5D";
                            break;
                        case 18:
                            Player2Card4.Image = Poker.Properties.Resources.FiveClubs;
                            d1.Hand2[3] = "5C";
                            break;
                        case 19:
                            Player2Card4.Image = Poker.Properties.Resources.FiveSpades;
                            d1.Hand2[3] = "5S";
                            break;
                        case 20:
                            Player2Card4.Image = Poker.Properties.Resources.SixHearts;
                            d1.Hand2[3] = "6H";
                            break;
                        case 21:
                            Player2Card4.Image = Poker.Properties.Resources.SixDiamonds;
                            d1.Hand2[3] = "6D";
                            break;
                        case 22:
                            Player2Card4.Image = Poker.Properties.Resources.SixClubs;
                            d1.Hand2[3] = "6C";
                            break;
                        case 23:
                            Player2Card4.Image = Poker.Properties.Resources.SixSpades;
                            d1.Hand2[3] = "6S";
                            break;
                        case 24:
                            Player2Card4.Image = Poker.Properties.Resources.SevenHearts;
                            d1.Hand2[3] = "7H";
                            break;
                        case 25:
                            Player2Card4.Image = Poker.Properties.Resources.SevenDiamonds;
                            d1.Hand2[3] = "7D";
                            break;
                        case 26:
                            Player2Card4.Image = Poker.Properties.Resources.SevenClubs;
                            d1.Hand2[3] = "7C";
                            break;
                        case 27:
                            Player2Card4.Image = Poker.Properties.Resources.SevenSpades;
                            d1.Hand2[3] = "7S";
                            break;
                        case 28:
                            Player2Card4.Image = Poker.Properties.Resources.EightHearts;
                            d1.Hand2[3] = "8H";
                            break;
                        case 29:
                            Player2Card4.Image = Poker.Properties.Resources.EightDiamonds;
                            d1.Hand2[3] = "8D";
                            break;
                        case 30:
                            Player2Card4.Image = Poker.Properties.Resources.EightClubs;
                            d1.Hand2[3] = "8C";
                            break;
                        case 31:
                            Player2Card4.Image = Poker.Properties.Resources.EightSpades;
                            d1.Hand2[3] = "8S";
                            break;
                        case 32:
                            Player2Card4.Image = Poker.Properties.Resources.NineHearts;
                            d1.Hand2[3] = "9H";
                            break;
                        case 33:
                            Player2Card4.Image = Poker.Properties.Resources.NineDiamonds;
                            d1.Hand2[3] = "9D";
                            break;
                        case 34:
                            Player2Card4.Image = Poker.Properties.Resources.NineClubs;
                            d1.Hand2[3] = "9C";
                            break;
                        case 35:
                            Player2Card4.Image = Poker.Properties.Resources.NineSpades;
                            d1.Hand2[3] = "9S";
                            break;
                        case 36:
                            Player2Card4.Image = Poker.Properties.Resources.TenHearts;
                            d1.Hand2[3] = "10H";
                            break;
                        case 37:
                            Player2Card4.Image = Poker.Properties.Resources.TenDiamonds;
                            d1.Hand2[3] = "10D";
                            break;
                        case 38:
                            Player2Card4.Image = Poker.Properties.Resources.TenClubs;
                            d1.Hand2[3] = "10C";
                            break;
                        case 39:
                            Player2Card4.Image = Poker.Properties.Resources.TenSpades;
                            d1.Hand2[3] = "10S";
                            break;
                        case 40:
                            Player2Card4.Image = Poker.Properties.Resources.JackHearts;
                            d1.Hand2[3] = "JH";
                            break;
                        case 41:
                            Player2Card4.Image = Poker.Properties.Resources.JackDiamonds;
                            d1.Hand2[3] = "JD";
                            break;
                        case 42:
                            Player2Card4.Image = Poker.Properties.Resources.JackClubs;
                            d1.Hand2[3] = "JC";
                            break;
                        case 43:
                            Player2Card4.Image = Poker.Properties.Resources.JackSpades;
                            d1.Hand2[3] = "JS";
                            break;
                        case 44:
                            Player2Card4.Image = Poker.Properties.Resources.QueenHearts;
                            d1.Hand2[3] = "QH";
                            break;
                        case 45:
                            Player2Card4.Image = Poker.Properties.Resources.QueenDiamonds;
                            d1.Hand2[3] = "QD";
                            break;
                        case 46:
                            Player2Card4.Image = Poker.Properties.Resources.QueenClubs1;
                            d1.Hand2[3] = "QC";
                            break;
                        case 47:
                            Player2Card4.Image = Poker.Properties.Resources.QueenSpades;
                            d1.Hand2[3] = "QS";
                            break;
                        case 48:
                            Player2Card4.Image = Poker.Properties.Resources.KingHearts;
                            d1.Hand2[3] = "KH";
                            break;
                        case 49:
                            Player2Card4.Image = Poker.Properties.Resources.KingDiamonds1;
                            d1.Hand2[3] = "KD";
                            break;
                        case 50:
                            Player2Card4.Image = Poker.Properties.Resources.KingClubs;
                            d1.Hand2[3] = "KC";
                            break;
                        case 51:
                            Player2Card4.Image = Poker.Properties.Resources.KingSpades;
                            d1.Hand2[3] = "KS";
                            break;
                    }
                }
                if (d1.Turn == 10)
                {
                    switch (n)
                    {

                        case 0:
                            Player2Card5.Image = Poker.Properties.Resources.AceHearts;
                            d1.Hand2[4] = "AH";
                            break;
                        case 1:
                            Player2Card5.Image = Poker.Properties.Resources.AceDiamonds;
                            d1.Hand2[4] = "AD";
                            break;
                        case 2:
                            Player2Card5.Image = Poker.Properties.Resources.AceClubs;
                            d1.Hand2[4] = "AC";
                            break;
                        case 3:
                            Player2Card5.Image = Poker.Properties.Resources.AceSpades;
                            d1.Hand2[4] = "AS";
                            break;
                        case 4:
                            Player2Card5.Image = Poker.Properties.Resources.TwoHearts;
                            d1.Hand2[4] = "2H";
                            break;
                        case 5:
                            Player2Card5.Image = Poker.Properties.Resources.TwoDiamonds;
                            d1.Hand2[4] = "2D";
                            break;
                        case 6:
                            Player2Card5.Image = Poker.Properties.Resources.TwoClubs;
                            d1.Hand2[4] = "2C";
                            break;
                        case 7:
                            Player2Card5.Image = Poker.Properties.Resources.TwoSpades;
                            d1.Hand2[4] = "2S";
                            break;
                        case 8:
                            Player2Card5.Image = Poker.Properties.Resources.ThreeHearts;
                            d1.Hand2[4] = "3H";
                            break;
                        case 9:
                            Player2Card5.Image = Poker.Properties.Resources.ThreeDiamonds;
                            d1.Hand2[4] = "3D";
                            break;
                        case 10:
                            Player2Card5.Image = Poker.Properties.Resources.ThreeClubs;
                            d1.Hand2[4] = "3C";
                            break;
                        case 11:
                            Player2Card5.Image = Poker.Properties.Resources.ThreeSpades;
                            d1.Hand2[4] = "3S";
                            break;
                        case 12:
                            Player2Card5.Image = Poker.Properties.Resources.FourHearts;
                            d1.Hand2[4] = "4H";
                            break;
                        case 13:
                            Player2Card5.Image = Poker.Properties.Resources.FourDiamonds;
                            d1.Hand2[4] = "4D";
                            break;
                        case 14:
                            Player2Card5.Image = Poker.Properties.Resources.FourClubs;
                            d1.Hand2[4] = "4C";
                            break;
                        case 15:
                            Player2Card5.Image = Poker.Properties.Resources.FourSpades;
                            d1.Hand2[4] = "4S";
                            break;
                        case 16:
                            Player2Card5.Image = Poker.Properties.Resources.FiveHearts;
                            d1.Hand2[4] = "5H";
                            break;
                        case 17:
                            Player2Card5.Image = Poker.Properties.Resources.FiveDiamonds;
                            d1.Hand2[4] = "5D";
                            break;
                        case 18:
                            Player2Card5.Image = Poker.Properties.Resources.FiveClubs;
                            d1.Hand2[4] = "5C";
                            break;
                        case 19:
                            Player2Card5.Image = Poker.Properties.Resources.FiveSpades;
                            d1.Hand2[4] = "5S";
                            break;
                        case 20:
                            Player2Card5.Image = Poker.Properties.Resources.SixHearts;
                            d1.Hand2[4] = "6H";
                            break;
                        case 21:
                            Player2Card5.Image = Poker.Properties.Resources.SixDiamonds;
                            d1.Hand2[4] = "6D";
                            break;
                        case 22:
                            Player2Card5.Image = Poker.Properties.Resources.SixClubs;
                            d1.Hand2[4] = "6C";
                            break;
                        case 23:
                            Player2Card5.Image = Poker.Properties.Resources.SixSpades;
                            d1.Hand2[4] = "6S";
                            break;
                        case 24:
                            Player2Card5.Image = Poker.Properties.Resources.SevenHearts;
                            d1.Hand2[4] = "7H";
                            break;
                        case 25:
                            Player2Card5.Image = Poker.Properties.Resources.SevenDiamonds;
                            d1.Hand2[4] = "7D";
                            break;
                        case 26:
                            Player2Card5.Image = Poker.Properties.Resources.SevenClubs;
                            d1.Hand2[4] = "7C";
                            break;
                        case 27:
                            Player2Card5.Image = Poker.Properties.Resources.SevenSpades;
                            d1.Hand2[4] = "7S";
                            break;
                        case 28:
                            Player2Card5.Image = Poker.Properties.Resources.EightHearts;
                            d1.Hand2[4] = "8H";
                            break;
                        case 29:
                            Player2Card5.Image = Poker.Properties.Resources.EightDiamonds;
                            d1.Hand2[4] = "8D";
                            break;
                        case 30:
                            Player2Card5.Image = Poker.Properties.Resources.EightClubs;
                            d1.Hand2[4] = "8C";
                            break;
                        case 31:
                            Player2Card5.Image = Poker.Properties.Resources.EightSpades;
                            d1.Hand2[4] = "8S";
                            break;
                        case 32:
                            Player2Card5.Image = Poker.Properties.Resources.NineHearts;
                            d1.Hand2[4] = "9H";
                            break;
                        case 33:
                            Player2Card5.Image = Poker.Properties.Resources.NineDiamonds;
                            d1.Hand2[4] = "9D";
                            break;
                        case 34:
                            Player2Card5.Image = Poker.Properties.Resources.NineClubs;
                            d1.Hand2[4] = "9C";
                            break;
                        case 35:
                            Player2Card5.Image = Poker.Properties.Resources.NineSpades;
                            d1.Hand2[4] = "9S";
                            break;
                        case 36:
                            Player2Card5.Image = Poker.Properties.Resources.TenHearts;
                            d1.Hand2[4] = "10H";
                            break;
                        case 37:
                            Player2Card5.Image = Poker.Properties.Resources.TenDiamonds;
                            d1.Hand2[4] = "10D";
                            break;
                        case 38:
                            Player2Card5.Image = Poker.Properties.Resources.TenClubs;
                            d1.Hand2[4] = "10C";
                            break;
                        case 39:
                            Player2Card5.Image = Poker.Properties.Resources.TenSpades;
                            d1.Hand2[4] = "10S";
                            break;
                        case 40:
                            Player2Card5.Image = Poker.Properties.Resources.JackHearts;
                            d1.Hand2[4] = "JH";
                            break;
                        case 41:
                            Player2Card5.Image = Poker.Properties.Resources.JackDiamonds;
                            d1.Hand2[4] = "JD";
                            break;
                        case 42:
                            Player2Card5.Image = Poker.Properties.Resources.JackClubs;
                            d1.Hand2[4] = "JC";
                            break;
                        case 43:
                            Player2Card5.Image = Poker.Properties.Resources.JackSpades;
                            d1.Hand2[4] = "JS";
                            break;
                        case 44:
                            Player2Card5.Image = Poker.Properties.Resources.QueenHearts;
                            d1.Hand2[4] = "QH";
                            break;
                        case 45:
                            Player2Card5.Image = Poker.Properties.Resources.QueenDiamonds;
                            d1.Hand2[4] = "QD";
                            break;
                        case 46:
                            Player2Card5.Image = Poker.Properties.Resources.QueenClubs1;
                            d1.Hand2[4] = "QC";
                            break;
                        case 47:
                            Player2Card5.Image = Poker.Properties.Resources.QueenSpades;
                            d1.Hand2[4] = "QS";
                            break;
                        case 48:
                            Player2Card5.Image = Poker.Properties.Resources.KingHearts;
                            d1.Hand2[4] = "KH";
                            break;
                        case 49:
                            Player2Card5.Image = Poker.Properties.Resources.KingDiamonds1;
                            d1.Hand2[4] = "KD";
                            break;
                        case 50:
                            Player2Card5.Image = Poker.Properties.Resources.KingClubs;
                            d1.Hand2[4] = "KC";
                            break;
                        case 51:
                            Player2Card5.Image = Poker.Properties.Resources.KingSpades;
                            d1.Hand2[4] = "KS";
                            break;
                    }
                }
                if (d1.Turn >= 10)
                {
                    ButtonDeck.Enabled = false;
                }
            }
        }
    }
}
