using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        internal Points p1 = new Points(); // reference for the points clss whcih can now be called by the Form1 Class

        /* method used to shuffle the deck. if the deck does not yet exist, d1.SetDeck is called to do so before proceeding. All card images are set to null so that
         a new game can be started by clicking shuffle. Deck.CardDraw and Turn are set to zero as well for the same reason, along with the two Hand arrays. */
        private void Shuffle_Click(object sender, EventArgs e)
        {
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

            
            PLayer1Points.Clear();
            PLayer2Points.Clear();
            p1.P1Points = 0;
            p1.P2Points = 0;
            ButtonDeck.Enabled = true;
            Deck.Reset();

        }


        private void CheckWinner_Click(object sender, EventArgs e)
        {
            if (Deck.FullHands == true)
            {
                int winner;
                p1.CheckFullHouse();
                p1.CheckStraight();
                p1.CheckFlush();
                p1.CheckFourOfAKind();
                p1.CheckThreeOfAKind();
                p1.CheckPair();
                p1.CheckPair();
                winner = p1.CheckWinner();

                if (winner == 1)
                {
                    PLayer1Points.Text = "Winner!" + p1.GetP1Points();
                    PLayer2Points.Text = "Loser!" + p1.GetP2Points();
                }
                else if (winner == 2)
                {
                    PLayer1Points.Text = "Loser" + p1.GetP1Points();
                    PLayer2Points.Text = "Winner!" + p1.GetP2Points();
                }
                else
                {
                    PLayer1Points.Text = "Tie!" + p1.GetP1Points();
                    PLayer2Points.Text = "Tie!" + p1.GetP2Points();
                }
            }
        }


        /*This is a very long series of if statements that simply takes the value provided by Deck.Draw(Which is always a card object via Deck.DeckList which correlates with the turn number. It then checks the card and displays the coresponding graphic*/
        private void ButtonDeck_Click(object sender, EventArgs e)
        {
            string n = Deck.Draw();

            if (Deck.Turn == 1)
            {
                switch (n)// n has the value returned by Deck.draw which returns the approriate Deck.DeckList card for the draw
                {
                    case "@H":
                        Player1Card1.Image = Poker.Properties.Resources.AceHearts;
                        break;
                    case "@D":
                        Player1Card1.Image = Poker.Properties.Resources.AceDiamonds;
                        break;
                    case "@C":
                        Player1Card1.Image = Poker.Properties.Resources.AceClubs;
                        break;
                    case "@S":
                        Player1Card1.Image = Poker.Properties.Resources.AceSpades;
                        break;
                    case "2H":
                        Player1Card1.Image = Poker.Properties.Resources.TwoHearts;
                        break;
                    case "2D":
                        Player1Card1.Image = Poker.Properties.Resources.TwoDiamonds;
                        break;
                    case "2C":
                        Player1Card1.Image = Poker.Properties.Resources.TwoClubs;
                        break;
                    case "2S":
                        Player1Card1.Image = Poker.Properties.Resources.TwoSpades;
                        break;
                    case "3H":
                        Player1Card1.Image = Poker.Properties.Resources.ThreeHearts;
                        break;
                    case "3D":
                        Player1Card1.Image = Poker.Properties.Resources.ThreeDiamonds;
                        break;
                    case "3C":
                        Player1Card1.Image = Poker.Properties.Resources.ThreeClubs;
                        break;
                    case "3S":
                        Player1Card1.Image = Poker.Properties.Resources.ThreeSpades;
                        break;
                    case "4H":
                        Player1Card1.Image = Poker.Properties.Resources.FourHearts;
                        break;
                    case "4D":
                        Player1Card1.Image = Poker.Properties.Resources.FourDiamonds;
                        break;
                    case "4C":
                        Player1Card1.Image = Poker.Properties.Resources.FourClubs;
                        break;
                    case "4S":
                        Player1Card1.Image = Poker.Properties.Resources.FourSpades;
                        break;
                    case "5H":
                        Player1Card1.Image = Poker.Properties.Resources.FiveHearts;
                        break;
                    case "5D":
                        Player1Card1.Image = Poker.Properties.Resources.FiveDiamonds;
                        break;
                    case "5C":
                        Player1Card1.Image = Poker.Properties.Resources.FiveClubs;
                        break;
                    case "5S":
                        Player1Card1.Image = Poker.Properties.Resources.FiveSpades;
                        break;
                    case "6H":
                        Player1Card1.Image = Poker.Properties.Resources.SixHearts;
                        break;
                    case "6D":
                        Player1Card1.Image = Poker.Properties.Resources.SixDiamonds;
                        break;
                    case "6C":
                        Player1Card1.Image = Poker.Properties.Resources.SixClubs;
                        break;
                    case "6S":
                        Player1Card1.Image = Poker.Properties.Resources.SixSpades;
                        break;
                    case "7H":
                        Player1Card1.Image = Poker.Properties.Resources.SevenHearts;
                        break;
                    case "7D":
                        Player1Card1.Image = Poker.Properties.Resources.SevenDiamonds;
                        break;
                    case "7C":
                        Player1Card1.Image = Poker.Properties.Resources.SevenClubs;
                        break;
                    case "7S":
                        Player1Card1.Image = Poker.Properties.Resources.SevenSpades;
                        break;
                    case "8H":
                        Player1Card1.Image = Poker.Properties.Resources.EightHearts;
                        break;
                    case "8D":
                        Player1Card1.Image = Poker.Properties.Resources.EightDiamonds;
                        break;
                    case "8C":
                        Player1Card1.Image = Poker.Properties.Resources.EightClubs;
                        break;
                    case "8S":
                        Player1Card1.Image = Poker.Properties.Resources.EightSpades;
                        break;
                    case "9H":
                        Player1Card1.Image = Poker.Properties.Resources.NineHearts;
                        break;
                    case "9D":
                        Player1Card1.Image = Poker.Properties.Resources.NineDiamonds;
                        break;
                    case "9C":
                        Player1Card1.Image = Poker.Properties.Resources.NineClubs;
                        break;
                    case "9S":
                        Player1Card1.Image = Poker.Properties.Resources.NineSpades;
                        break;
                    case "10H":
                        Player1Card1.Image = Poker.Properties.Resources.TenHearts;
                        break;
                    case "10D":
                        Player1Card1.Image = Poker.Properties.Resources.TenDiamonds;
                        break;
                    case "10C":
                        Player1Card1.Image = Poker.Properties.Resources.TenClubs;
                        break;
                    case "10S":
                        Player1Card1.Image = Poker.Properties.Resources.TenSpades;
                        break;
                    case "JH":
                        Player1Card1.Image = Poker.Properties.Resources.JackHearts;
                        break;
                    case "JD":
                        Player1Card1.Image = Poker.Properties.Resources.JackDiamonds;
                        break;
                    case "JC":
                        Player1Card1.Image = Poker.Properties.Resources.JackClubs;
                        break;
                    case "JS":
                        Player1Card1.Image = Poker.Properties.Resources.JackSpades;
                        break;
                    case "QH":
                        Player1Card1.Image = Poker.Properties.Resources.QueenHearts;
                        break;
                    case "QD":
                        Player1Card1.Image = Poker.Properties.Resources.QueenDiamonds;
                        break;
                    case "QC":
                        Player1Card1.Image = Poker.Properties.Resources.QueenClubs1;
                        break;
                    case "QS":
                        Player1Card1.Image = Poker.Properties.Resources.QueenSpades;
                        break;
                    case "KH":
                        Player1Card1.Image = Poker.Properties.Resources.KingHearts;
                        break;
                    case "KD":
                        Player1Card1.Image = Poker.Properties.Resources.KingDiamonds1;
                        break;
                    case "KC":
                        Player1Card1.Image = Poker.Properties.Resources.KingClubs;
                        break;
                    case "KS":
                        Player1Card1.Image = Poker.Properties.Resources.KingSpades;
                        break;
                }
            }

            if (Deck.Turn == 3)
            {
                switch (n)// n has the value returned by Deck.draw which returns the approriate Deck.DeckList card for the draw
                {
                    case "@H":
                        Player1Card2.Image = Poker.Properties.Resources.AceHearts;
                        break;
                    case "@D":
                        Player1Card2.Image = Poker.Properties.Resources.AceDiamonds;
                        break;
                    case "@C":
                        Player1Card2.Image = Poker.Properties.Resources.AceClubs;
                        break;
                    case "@S":
                        Player1Card2.Image = Poker.Properties.Resources.AceSpades;
                        break;
                    case "2H":
                        Player1Card2.Image = Poker.Properties.Resources.TwoHearts;
                        break;
                    case "2D":
                        Player1Card2.Image = Poker.Properties.Resources.TwoDiamonds;
                        break;
                    case "2C":
                        Player1Card2.Image = Poker.Properties.Resources.TwoClubs;
                        break;
                    case "2S":
                        Player1Card2.Image = Poker.Properties.Resources.TwoSpades;
                        break;
                    case "3H":
                        Player1Card2.Image = Poker.Properties.Resources.ThreeHearts;
                        break;
                    case "3D":
                        Player1Card2.Image = Poker.Properties.Resources.ThreeDiamonds;
                        break;
                    case "3C":
                        Player1Card2.Image = Poker.Properties.Resources.ThreeClubs;
                        break;
                    case "3S":
                        Player1Card2.Image = Poker.Properties.Resources.ThreeSpades;
                        break;
                    case "4H":
                        Player1Card2.Image = Poker.Properties.Resources.FourHearts;
                        break;
                    case "4D":
                        Player1Card2.Image = Poker.Properties.Resources.FourDiamonds;
                        break;
                    case "4C":
                        Player1Card2.Image = Poker.Properties.Resources.FourClubs;
                        break;
                    case "4S":
                        Player1Card2.Image = Poker.Properties.Resources.FourSpades;
                        break;
                    case "5H":
                        Player1Card2.Image = Poker.Properties.Resources.FiveHearts;
                        break;
                    case "5D":
                        Player1Card2.Image = Poker.Properties.Resources.FiveDiamonds;
                        break;
                    case "5C":
                        Player1Card2.Image = Poker.Properties.Resources.FiveClubs;
                        break;
                    case "5S":
                        Player1Card2.Image = Poker.Properties.Resources.FiveSpades;
                        break;
                    case "6H":
                        Player1Card2.Image = Poker.Properties.Resources.SixHearts;
                        break;
                    case "6D":
                        Player1Card2.Image = Poker.Properties.Resources.SixDiamonds;
                        break;
                    case "6C":
                        Player1Card2.Image = Poker.Properties.Resources.SixClubs;
                        break;
                    case "6S":
                        Player1Card2.Image = Poker.Properties.Resources.SixSpades;
                        break;
                    case "7H":
                        Player1Card2.Image = Poker.Properties.Resources.SevenHearts;
                        break;
                    case "7D":
                        Player1Card2.Image = Poker.Properties.Resources.SevenDiamonds;
                        break;
                    case "7C":
                        Player1Card2.Image = Poker.Properties.Resources.SevenClubs;
                        break;
                    case "7S":
                        Player1Card2.Image = Poker.Properties.Resources.SevenSpades;
                        break;
                    case "8H":
                        Player1Card2.Image = Poker.Properties.Resources.EightHearts;
                        break;
                    case "8D":
                        Player1Card2.Image = Poker.Properties.Resources.EightDiamonds;
                        break;
                    case "8C":
                        Player1Card2.Image = Poker.Properties.Resources.EightClubs;
                        break;
                    case "8S":
                        Player1Card2.Image = Poker.Properties.Resources.EightSpades;
                        break;
                    case "9H":
                        Player1Card2.Image = Poker.Properties.Resources.NineHearts;
                        break;
                    case "9D":
                        Player1Card2.Image = Poker.Properties.Resources.NineDiamonds;
                        break;
                    case "9C":
                        Player1Card2.Image = Poker.Properties.Resources.NineClubs;
                        break;
                    case "9S":
                        Player1Card2.Image = Poker.Properties.Resources.NineSpades;
                        break;
                    case "10H":
                        Player1Card2.Image = Poker.Properties.Resources.TenHearts;
                        break;
                    case "10D":
                        Player1Card2.Image = Poker.Properties.Resources.TenDiamonds;
                        break;
                    case "10C":
                        Player1Card2.Image = Poker.Properties.Resources.TenClubs;
                        break;
                    case "10S":
                        Player1Card2.Image = Poker.Properties.Resources.TenSpades;
                        break;
                    case "JH":
                        Player1Card2.Image = Poker.Properties.Resources.JackHearts;
                        break;
                    case "JD":
                        Player1Card2.Image = Poker.Properties.Resources.JackDiamonds;
                        break;
                    case "JC":
                        Player1Card2.Image = Poker.Properties.Resources.JackClubs;
                        break;
                    case "JS":
                        Player1Card2.Image = Poker.Properties.Resources.JackSpades;
                        break;
                    case "QH":
                        Player1Card2.Image = Poker.Properties.Resources.QueenHearts;
                        break;
                    case "QD":
                        Player1Card2.Image = Poker.Properties.Resources.QueenDiamonds;
                        break;
                    case "QC":
                        Player1Card2.Image = Poker.Properties.Resources.QueenClubs1;
                        break;
                    case "QS":
                        Player1Card2.Image = Poker.Properties.Resources.QueenSpades;
                        break;
                    case "KH":
                        Player1Card2.Image = Poker.Properties.Resources.KingHearts;
                        break;
                    case "KD":
                        Player1Card2.Image = Poker.Properties.Resources.KingDiamonds1;
                        break;
                    case "KC":
                        Player1Card2.Image = Poker.Properties.Resources.KingClubs;
                        break;
                    case "KS":
                        Player1Card2.Image = Poker.Properties.Resources.KingSpades;
                        break;
                }
            }
            if (Deck.Turn == 5)
            {
                switch (n)// n has the value returned by Deck.draw which returns the approriate Deck.DeckList card for the draw
                {
                    case "@H":
                        Player1Card3.Image = Poker.Properties.Resources.AceHearts;
                        break;
                    case "@D":
                        Player1Card3.Image = Poker.Properties.Resources.AceDiamonds;
                        break;
                    case "@C":
                        Player1Card3.Image = Poker.Properties.Resources.AceClubs;
                        break;
                    case "@S":
                        Player1Card3.Image = Poker.Properties.Resources.AceSpades;
                        break;
                    case "2H":
                        Player1Card3.Image = Poker.Properties.Resources.TwoHearts;
                        break;
                    case "2D":
                        Player1Card3.Image = Poker.Properties.Resources.TwoDiamonds;
                        break;
                    case "2C":
                        Player1Card3.Image = Poker.Properties.Resources.TwoClubs;
                        break;
                    case "2S":
                        Player1Card3.Image = Poker.Properties.Resources.TwoSpades;
                        break;
                    case "3H":
                        Player1Card3.Image = Poker.Properties.Resources.ThreeHearts;
                        break;
                    case "3D":
                        Player1Card3.Image = Poker.Properties.Resources.ThreeDiamonds;
                        break;
                    case "3C":
                        Player1Card3.Image = Poker.Properties.Resources.ThreeClubs;
                        break;
                    case "3S":
                        Player1Card3.Image = Poker.Properties.Resources.ThreeSpades;
                        break;
                    case "4H":
                        Player1Card3.Image = Poker.Properties.Resources.FourHearts;
                        break;
                    case "4D":
                        Player1Card3.Image = Poker.Properties.Resources.FourDiamonds;
                        break;
                    case "4C":
                        Player1Card3.Image = Poker.Properties.Resources.FourClubs;
                        break;
                    case "4S":
                        Player1Card3.Image = Poker.Properties.Resources.FourSpades;
                        break;
                    case "5H":
                        Player1Card3.Image = Poker.Properties.Resources.FiveHearts;
                        break;
                    case "5D":
                        Player1Card3.Image = Poker.Properties.Resources.FiveDiamonds;
                        break;
                    case "5C":
                        Player1Card3.Image = Poker.Properties.Resources.FiveClubs;
                        break;
                    case "5S":
                        Player1Card3.Image = Poker.Properties.Resources.FiveSpades;
                        break;
                    case "6H":
                        Player1Card3.Image = Poker.Properties.Resources.SixHearts;
                        break;
                    case "6D":
                        Player1Card3.Image = Poker.Properties.Resources.SixDiamonds;
                        break;
                    case "6C":
                        Player1Card3.Image = Poker.Properties.Resources.SixClubs;
                        break;
                    case "6S":
                        Player1Card3.Image = Poker.Properties.Resources.SixSpades;
                        break;
                    case "7H":
                        Player1Card3.Image = Poker.Properties.Resources.SevenHearts;
                        break;
                    case "7D":
                        Player1Card3.Image = Poker.Properties.Resources.SevenDiamonds;
                        break;
                    case "7C":
                        Player1Card3.Image = Poker.Properties.Resources.SevenClubs;
                        break;
                    case "7S":
                        Player1Card3.Image = Poker.Properties.Resources.SevenSpades;
                        break;
                    case "8H":
                        Player1Card3.Image = Poker.Properties.Resources.EightHearts;
                        break;
                    case "8D":
                        Player1Card3.Image = Poker.Properties.Resources.EightDiamonds;
                        break;
                    case "8C":
                        Player1Card3.Image = Poker.Properties.Resources.EightClubs;
                        break;
                    case "8S":
                        Player1Card3.Image = Poker.Properties.Resources.EightSpades;
                        break;
                    case "9H":
                        Player1Card3.Image = Poker.Properties.Resources.NineHearts;
                        break;
                    case "9D":
                        Player1Card3.Image = Poker.Properties.Resources.NineDiamonds;
                        break;
                    case "9C":
                        Player1Card3.Image = Poker.Properties.Resources.NineClubs;
                        break;
                    case "9S":
                        Player1Card3.Image = Poker.Properties.Resources.NineSpades;
                        break;
                    case "10H":
                        Player1Card3.Image = Poker.Properties.Resources.TenHearts;
                        break;
                    case "10D":
                        Player1Card3.Image = Poker.Properties.Resources.TenDiamonds;
                        break;
                    case "10C":
                        Player1Card3.Image = Poker.Properties.Resources.TenClubs;
                        break;
                    case "10S":
                        Player1Card3.Image = Poker.Properties.Resources.TenSpades;
                        break;
                    case "JH":
                        Player1Card3.Image = Poker.Properties.Resources.JackHearts;
                        break;
                    case "JD":
                        Player1Card3.Image = Poker.Properties.Resources.JackDiamonds;
                        break;
                    case "JC":
                        Player1Card3.Image = Poker.Properties.Resources.JackClubs;
                        break;
                    case "JS":
                        Player1Card3.Image = Poker.Properties.Resources.JackSpades;
                        break;
                    case "QH":
                        Player1Card3.Image = Poker.Properties.Resources.QueenHearts;
                        break;
                    case "QD":
                        Player1Card3.Image = Poker.Properties.Resources.QueenDiamonds;
                        break;
                    case "QC":
                        Player1Card3.Image = Poker.Properties.Resources.QueenClubs1;
                        break;
                    case "QS":
                        Player1Card3.Image = Poker.Properties.Resources.QueenSpades;
                        break;
                    case "KH":
                        Player1Card3.Image = Poker.Properties.Resources.KingHearts;
                        break;
                    case "KD":
                        Player1Card3.Image = Poker.Properties.Resources.KingDiamonds1;
                        break;
                    case "KC":
                        Player1Card3.Image = Poker.Properties.Resources.KingClubs;
                        break;
                    case "KS":
                        Player1Card3.Image = Poker.Properties.Resources.KingSpades;
                        break;
                }
            }

            if (Deck.Turn == 7)
            {
                switch (n)// n has the value returned by Deck.draw which returns the approriate Deck.DeckList card for the draw
                {
                    case "@H":
                        Player1Card4.Image = Poker.Properties.Resources.AceHearts;
                        break;
                    case "@D":
                        Player1Card4.Image = Poker.Properties.Resources.AceDiamonds;
                        break;
                    case "@C":
                        Player1Card4.Image = Poker.Properties.Resources.AceClubs;
                        break;
                    case "@S":
                        Player1Card4.Image = Poker.Properties.Resources.AceSpades;
                        break;
                    case "2H":
                        Player1Card4.Image = Poker.Properties.Resources.TwoHearts;
                        break;
                    case "2D":
                        Player1Card4.Image = Poker.Properties.Resources.TwoDiamonds;
                        break;
                    case "2C":
                        Player1Card4.Image = Poker.Properties.Resources.TwoClubs;
                        break;
                    case "2S":
                        Player1Card4.Image = Poker.Properties.Resources.TwoSpades;
                        break;
                    case "3H":
                        Player1Card4.Image = Poker.Properties.Resources.ThreeHearts;
                        break;
                    case "3D":
                        Player1Card4.Image = Poker.Properties.Resources.ThreeDiamonds;
                        break;
                    case "3C":
                        Player1Card4.Image = Poker.Properties.Resources.ThreeClubs;
                        break;
                    case "3S":
                        Player1Card4.Image = Poker.Properties.Resources.ThreeSpades;
                        break;
                    case "4H":
                        Player1Card4.Image = Poker.Properties.Resources.FourHearts;
                        break;
                    case "4D":
                        Player1Card4.Image = Poker.Properties.Resources.FourDiamonds;
                        break;
                    case "4C":
                        Player1Card4.Image = Poker.Properties.Resources.FourClubs;
                        break;
                    case "4S":
                        Player1Card4.Image = Poker.Properties.Resources.FourSpades;
                        break;
                    case "5H":
                        Player1Card4.Image = Poker.Properties.Resources.FiveHearts;
                        break;
                    case "5D":
                        Player1Card4.Image = Poker.Properties.Resources.FiveDiamonds;
                        break;
                    case "5C":
                        Player1Card4.Image = Poker.Properties.Resources.FiveClubs;
                        break;
                    case "5S":
                        Player1Card4.Image = Poker.Properties.Resources.FiveSpades;
                        break;
                    case "6H":
                        Player1Card4.Image = Poker.Properties.Resources.SixHearts;
                        break;
                    case "6D":
                        Player1Card4.Image = Poker.Properties.Resources.SixDiamonds;
                        break;
                    case "6C":
                        Player1Card4.Image = Poker.Properties.Resources.SixClubs;
                        break;
                    case "6S":
                        Player1Card4.Image = Poker.Properties.Resources.SixSpades;
                        break;
                    case "7H":
                        Player1Card4.Image = Poker.Properties.Resources.SevenHearts;
                        break;
                    case "7D":
                        Player1Card4.Image = Poker.Properties.Resources.SevenDiamonds;
                        break;
                    case "7C":
                        Player1Card4.Image = Poker.Properties.Resources.SevenClubs;
                        break;
                    case "7S":
                        Player1Card4.Image = Poker.Properties.Resources.SevenSpades;
                        break;
                    case "8H":
                        Player1Card4.Image = Poker.Properties.Resources.EightHearts;
                        break;
                    case "8D":
                        Player1Card4.Image = Poker.Properties.Resources.EightDiamonds;
                        break;
                    case "8C":
                        Player1Card4.Image = Poker.Properties.Resources.EightClubs;
                        break;
                    case "8S":
                        Player1Card4.Image = Poker.Properties.Resources.EightSpades;
                        break;
                    case "9H":
                        Player1Card4.Image = Poker.Properties.Resources.NineHearts;
                        break;
                    case "9D":
                        Player1Card4.Image = Poker.Properties.Resources.NineDiamonds;
                        break;
                    case "9C":
                        Player1Card4.Image = Poker.Properties.Resources.NineClubs;
                        break;
                    case "9S":
                        Player1Card4.Image = Poker.Properties.Resources.NineSpades;
                        break;
                    case "10H":
                        Player1Card4.Image = Poker.Properties.Resources.TenHearts;
                        break;
                    case "10D":
                        Player1Card4.Image = Poker.Properties.Resources.TenDiamonds;
                        break;
                    case "10C":
                        Player1Card4.Image = Poker.Properties.Resources.TenClubs;
                        break;
                    case "10S":
                        Player1Card4.Image = Poker.Properties.Resources.TenSpades;
                        break;
                    case "JH":
                        Player1Card4.Image = Poker.Properties.Resources.JackHearts;
                        break;
                    case "JD":
                        Player1Card4.Image = Poker.Properties.Resources.JackDiamonds;
                        break;
                    case "JC":
                        Player1Card4.Image = Poker.Properties.Resources.JackClubs;
                        break;
                    case "JS":
                        Player1Card4.Image = Poker.Properties.Resources.JackSpades;
                        break;
                    case "QH":
                        Player1Card4.Image = Poker.Properties.Resources.QueenHearts;
                        break;
                    case "QD":
                        Player1Card4.Image = Poker.Properties.Resources.QueenDiamonds;
                        break;
                    case "QC":
                        Player1Card4.Image = Poker.Properties.Resources.QueenClubs1;
                        break;
                    case "QS":
                        Player1Card4.Image = Poker.Properties.Resources.QueenSpades;
                        break;
                    case "KH":
                        Player1Card4.Image = Poker.Properties.Resources.KingHearts;
                        break;
                    case "KD":
                        Player1Card4.Image = Poker.Properties.Resources.KingDiamonds1;
                        break;
                    case "KC":
                        Player1Card4.Image = Poker.Properties.Resources.KingClubs;
                        break;
                    case "KS":
                        Player1Card4.Image = Poker.Properties.Resources.KingSpades;
                        break;
                }
            }
            if (Deck.Turn == 9)
            {
                switch (n)// n has the value returned by Deck.draw which returns the approriate Deck.DeckList card for the draw
                {
                    case "@H":
                        Player1Card5.Image = Poker.Properties.Resources.AceHearts;
                        break;
                    case "@D":
                        Player1Card5.Image = Poker.Properties.Resources.AceDiamonds;
                        break;
                    case "@C":
                        Player1Card5.Image = Poker.Properties.Resources.AceClubs;
                        break;
                    case "@S":
                        Player1Card5.Image = Poker.Properties.Resources.AceSpades;
                        break;
                    case "2H":
                        Player1Card5.Image = Poker.Properties.Resources.TwoHearts;
                        break;
                    case "2D":
                        Player1Card5.Image = Poker.Properties.Resources.TwoDiamonds;
                        break;
                    case "2C":
                        Player1Card5.Image = Poker.Properties.Resources.TwoClubs;
                        break;
                    case "2S":
                        Player1Card5.Image = Poker.Properties.Resources.TwoSpades;
                        break;
                    case "3H":
                        Player1Card5.Image = Poker.Properties.Resources.ThreeHearts;
                        break;
                    case "3D":
                        Player1Card5.Image = Poker.Properties.Resources.ThreeDiamonds;
                        break;
                    case "3C":
                        Player1Card5.Image = Poker.Properties.Resources.ThreeClubs;
                        break;
                    case "3S":
                        Player1Card5.Image = Poker.Properties.Resources.ThreeSpades;
                        break;
                    case "4H":
                        Player1Card5.Image = Poker.Properties.Resources.FourHearts;
                        break;
                    case "4D":
                        Player1Card5.Image = Poker.Properties.Resources.FourDiamonds;
                        break;
                    case "4C":
                        Player1Card5.Image = Poker.Properties.Resources.FourClubs;
                        break;
                    case "4S":
                        Player1Card5.Image = Poker.Properties.Resources.FourSpades;
                        break;
                    case "5H":
                        Player1Card5.Image = Poker.Properties.Resources.FiveHearts;
                        break;
                    case "5D":
                        Player1Card5.Image = Poker.Properties.Resources.FiveDiamonds;
                        break;
                    case "5C":
                        Player1Card5.Image = Poker.Properties.Resources.FiveClubs;
                        break;
                    case "5S":
                        Player1Card5.Image = Poker.Properties.Resources.FiveSpades;
                        break;
                    case "6H":
                        Player1Card5.Image = Poker.Properties.Resources.SixHearts;
                        break;
                    case "6D":
                        Player1Card5.Image = Poker.Properties.Resources.SixDiamonds;
                        break;
                    case "6C":
                        Player1Card5.Image = Poker.Properties.Resources.SixClubs;
                        break;
                    case "6S":
                        Player1Card5.Image = Poker.Properties.Resources.SixSpades;
                        break;
                    case "7H":
                        Player1Card5.Image = Poker.Properties.Resources.SevenHearts;
                        break;
                    case "7D":
                        Player1Card5.Image = Poker.Properties.Resources.SevenDiamonds;
                        break;
                    case "7C":
                        Player1Card5.Image = Poker.Properties.Resources.SevenClubs;
                        break;
                    case "7S":
                        Player1Card5.Image = Poker.Properties.Resources.SevenSpades;
                        break;
                    case "8H":
                        Player1Card5.Image = Poker.Properties.Resources.EightHearts;
                        break;
                    case "8D":
                        Player1Card5.Image = Poker.Properties.Resources.EightDiamonds;
                        break;
                    case "8C":
                        Player1Card5.Image = Poker.Properties.Resources.EightClubs;
                        break;
                    case "8S":
                        Player1Card5.Image = Poker.Properties.Resources.EightSpades;
                        break;
                    case "9H":
                        Player1Card5.Image = Poker.Properties.Resources.NineHearts;
                        break;
                    case "9D":
                        Player1Card5.Image = Poker.Properties.Resources.NineDiamonds;
                        break;
                    case "9C":
                        Player1Card5.Image = Poker.Properties.Resources.NineClubs;
                        break;
                    case "9S":
                        Player1Card5.Image = Poker.Properties.Resources.NineSpades;
                        break;
                    case "10H":
                        Player1Card5.Image = Poker.Properties.Resources.TenHearts;
                        break;
                    case "10D":
                        Player1Card5.Image = Poker.Properties.Resources.TenDiamonds;
                        break;
                    case "10C":
                        Player1Card5.Image = Poker.Properties.Resources.TenClubs;
                        break;
                    case "10S":
                        Player1Card5.Image = Poker.Properties.Resources.TenSpades;
                        break;
                    case "JH":
                        Player1Card5.Image = Poker.Properties.Resources.JackHearts;
                        break;
                    case "JD":
                        Player1Card5.Image = Poker.Properties.Resources.JackDiamonds;
                        break;
                    case "JC":
                        Player1Card5.Image = Poker.Properties.Resources.JackClubs;
                        break;
                    case "JS":
                        Player1Card5.Image = Poker.Properties.Resources.JackSpades;
                        break;
                    case "QH":
                        Player1Card5.Image = Poker.Properties.Resources.QueenHearts;
                        break;
                    case "QD":
                        Player1Card5.Image = Poker.Properties.Resources.QueenDiamonds;
                        break;
                    case "QC":
                        Player1Card5.Image = Poker.Properties.Resources.QueenClubs1;
                        break;
                    case "QS":
                        Player1Card5.Image = Poker.Properties.Resources.QueenSpades;
                        break;
                    case "KH":
                        Player1Card5.Image = Poker.Properties.Resources.KingHearts;
                        break;
                    case "KD":
                        Player1Card5.Image = Poker.Properties.Resources.KingDiamonds1;
                        break;
                    case "KC":
                        Player1Card5.Image = Poker.Properties.Resources.KingClubs;
                        break;
                    case "KS":
                        Player1Card5.Image = Poker.Properties.Resources.KingSpades;
                        break;
                }
            }
            if (Deck.Turn == 2)
            {
                switch (n)// n has the value returned by Deck.draw which returns the approriate Deck.DeckList card for the draw
                {
                    case "@H":
                        Player2Card1.Image = Poker.Properties.Resources.AceHearts;
                        break;
                    case "@D":
                        Player2Card1.Image = Poker.Properties.Resources.AceDiamonds;
                        break;
                    case "@C":
                        Player2Card1.Image = Poker.Properties.Resources.AceClubs;
                        break;
                    case "@S":
                        Player2Card1.Image = Poker.Properties.Resources.AceSpades;
                        break;
                    case "2H":
                        Player2Card1.Image = Poker.Properties.Resources.TwoHearts;
                        break;
                    case "2D":
                        Player2Card1.Image = Poker.Properties.Resources.TwoDiamonds;
                        break;
                    case "2C":
                        Player2Card1.Image = Poker.Properties.Resources.TwoClubs;
                        break;
                    case "2S":
                        Player2Card1.Image = Poker.Properties.Resources.TwoSpades;
                        break;
                    case "3H":
                        Player2Card1.Image = Poker.Properties.Resources.ThreeHearts;
                        break;
                    case "3D":
                        Player2Card1.Image = Poker.Properties.Resources.ThreeDiamonds;
                        break;
                    case "3C":
                        Player2Card1.Image = Poker.Properties.Resources.ThreeClubs;
                        break;
                    case "3S":
                        Player2Card1.Image = Poker.Properties.Resources.ThreeSpades;
                        break;
                    case "4H":
                        Player2Card1.Image = Poker.Properties.Resources.FourHearts;
                        break;
                    case "4D":
                        Player2Card1.Image = Poker.Properties.Resources.FourDiamonds;
                        break;
                    case "4C":
                        Player2Card1.Image = Poker.Properties.Resources.FourClubs;
                        break;
                    case "4S":
                        Player2Card1.Image = Poker.Properties.Resources.FourSpades;
                        break;
                    case "5H":
                        Player2Card1.Image = Poker.Properties.Resources.FiveHearts;
                        break;
                    case "5D":
                        Player2Card1.Image = Poker.Properties.Resources.FiveDiamonds;
                        break;
                    case "5C":
                        Player2Card1.Image = Poker.Properties.Resources.FiveClubs;
                        break;
                    case "5S":
                        Player2Card1.Image = Poker.Properties.Resources.FiveSpades;
                        break;
                    case "6H":
                        Player2Card1.Image = Poker.Properties.Resources.SixHearts;
                        break;
                    case "6D":
                        Player2Card1.Image = Poker.Properties.Resources.SixDiamonds;
                        break;
                    case "6C":
                        Player2Card1.Image = Poker.Properties.Resources.SixClubs;
                        break;
                    case "6S":
                        Player2Card1.Image = Poker.Properties.Resources.SixSpades;
                        break;
                    case "7H":
                        Player2Card1.Image = Poker.Properties.Resources.SevenHearts;
                        break;
                    case "7D":
                        Player2Card1.Image = Poker.Properties.Resources.SevenDiamonds;
                        break;
                    case "7C":
                        Player2Card1.Image = Poker.Properties.Resources.SevenClubs;
                        break;
                    case "7S":
                        Player2Card1.Image = Poker.Properties.Resources.SevenSpades;
                        break;
                    case "8H":
                        Player2Card1.Image = Poker.Properties.Resources.EightHearts;
                        break;
                    case "8D":
                        Player2Card1.Image = Poker.Properties.Resources.EightDiamonds;
                        break;
                    case "8C":
                        Player2Card1.Image = Poker.Properties.Resources.EightClubs;
                        break;
                    case "8S":
                        Player2Card1.Image = Poker.Properties.Resources.EightSpades;
                        break;
                    case "9H":
                        Player2Card1.Image = Poker.Properties.Resources.NineHearts;
                        break;
                    case "9D":
                        Player2Card1.Image = Poker.Properties.Resources.NineDiamonds;
                        break;
                    case "9C":
                        Player2Card1.Image = Poker.Properties.Resources.NineClubs;
                        break;
                    case "9S":
                        Player2Card1.Image = Poker.Properties.Resources.NineSpades;
                        break;
                    case "10H":
                        Player2Card1.Image = Poker.Properties.Resources.TenHearts;
                        break;
                    case "10D":
                        Player2Card1.Image = Poker.Properties.Resources.TenDiamonds;
                        break;
                    case "10C":
                        Player2Card1.Image = Poker.Properties.Resources.TenClubs;
                        break;
                    case "10S":
                        Player2Card1.Image = Poker.Properties.Resources.TenSpades;
                        break;
                    case "JH":
                        Player2Card1.Image = Poker.Properties.Resources.JackHearts;
                        break;
                    case "JD":
                        Player2Card1.Image = Poker.Properties.Resources.JackDiamonds;
                        break;
                    case "JC":
                        Player2Card1.Image = Poker.Properties.Resources.JackClubs;
                        break;
                    case "JS":
                        Player2Card1.Image = Poker.Properties.Resources.JackSpades;
                        break;
                    case "QH":
                        Player2Card1.Image = Poker.Properties.Resources.QueenHearts;
                        break;
                    case "QD":
                        Player2Card1.Image = Poker.Properties.Resources.QueenDiamonds;
                        break;
                    case "QC":
                        Player2Card1.Image = Poker.Properties.Resources.QueenClubs1;
                        break;
                    case "QS":
                        Player2Card1.Image = Poker.Properties.Resources.QueenSpades;
                        break;
                    case "KH":
                        Player2Card1.Image = Poker.Properties.Resources.KingHearts;
                        break;
                    case "KD":
                        Player2Card1.Image = Poker.Properties.Resources.KingDiamonds1;
                        break;
                    case "KC":
                        Player2Card1.Image = Poker.Properties.Resources.KingClubs;
                        break;
                    case "KS":
                        Player2Card1.Image = Poker.Properties.Resources.KingSpades;
                        break;
                }
            }
            if (Deck.Turn == 4)
            {
                switch (n)// n has the value returned by Deck.draw which returns the approriate Deck.DeckList card for the draw
                {
                    case "@H":
                        Player2Card2.Image = Poker.Properties.Resources.AceHearts;
                        break;
                    case "@D":
                        Player2Card2.Image = Poker.Properties.Resources.AceDiamonds;
                        break;
                    case "@C":
                        Player2Card2.Image = Poker.Properties.Resources.AceClubs;
                        break;
                    case "@S":
                        Player2Card2.Image = Poker.Properties.Resources.AceSpades;
                        break;
                    case "2H":
                        Player2Card2.Image = Poker.Properties.Resources.TwoHearts;
                        break;
                    case "2D":
                        Player2Card2.Image = Poker.Properties.Resources.TwoDiamonds;
                        break;
                    case "2C":
                        Player2Card2.Image = Poker.Properties.Resources.TwoClubs;
                        break;
                    case "2S":
                        Player2Card2.Image = Poker.Properties.Resources.TwoSpades;
                        break;
                    case "3H":
                        Player2Card2.Image = Poker.Properties.Resources.ThreeHearts;
                        break;
                    case "3D":
                        Player2Card2.Image = Poker.Properties.Resources.ThreeDiamonds;
                        break;
                    case "3C":
                        Player2Card2.Image = Poker.Properties.Resources.ThreeClubs;
                        break;
                    case "3S":
                        Player2Card2.Image = Poker.Properties.Resources.ThreeSpades;
                        break;
                    case "4H":
                        Player2Card2.Image = Poker.Properties.Resources.FourHearts;
                        break;
                    case "4D":
                        Player2Card2.Image = Poker.Properties.Resources.FourDiamonds;
                        break;
                    case "4C":
                        Player2Card2.Image = Poker.Properties.Resources.FourClubs;
                        break;
                    case "4S":
                        Player2Card2.Image = Poker.Properties.Resources.FourSpades;
                        break;
                    case "5H":
                        Player2Card2.Image = Poker.Properties.Resources.FiveHearts;
                        break;
                    case "5D":
                        Player2Card2.Image = Poker.Properties.Resources.FiveDiamonds;
                        break;
                    case "5C":
                        Player2Card2.Image = Poker.Properties.Resources.FiveClubs;
                        break;
                    case "5S":
                        Player2Card2.Image = Poker.Properties.Resources.FiveSpades;
                        break;
                    case "6H":
                        Player2Card2.Image = Poker.Properties.Resources.SixHearts;
                        break;
                    case "6D":
                        Player2Card2.Image = Poker.Properties.Resources.SixDiamonds;
                        break;
                    case "6C":
                        Player2Card2.Image = Poker.Properties.Resources.SixClubs;
                        break;
                    case "6S":
                        Player2Card2.Image = Poker.Properties.Resources.SixSpades;
                        break;
                    case "7H":
                        Player2Card2.Image = Poker.Properties.Resources.SevenHearts;
                        break;
                    case "7D":
                        Player2Card2.Image = Poker.Properties.Resources.SevenDiamonds;
                        break;
                    case "7C":
                        Player2Card2.Image = Poker.Properties.Resources.SevenClubs;
                        break;
                    case "7S":
                        Player2Card2.Image = Poker.Properties.Resources.SevenSpades;
                        break;
                    case "8H":
                        Player2Card2.Image = Poker.Properties.Resources.EightHearts;
                        break;
                    case "8D":
                        Player2Card2.Image = Poker.Properties.Resources.EightDiamonds;
                        break;
                    case "8C":
                        Player2Card2.Image = Poker.Properties.Resources.EightClubs;
                        break;
                    case "8S":
                        Player2Card2.Image = Poker.Properties.Resources.EightSpades;
                        break;
                    case "9H":
                        Player2Card2.Image = Poker.Properties.Resources.NineHearts;
                        break;
                    case "9D":
                        Player2Card2.Image = Poker.Properties.Resources.NineDiamonds;
                        break;
                    case "9C":
                        Player2Card2.Image = Poker.Properties.Resources.NineClubs;
                        break;
                    case "9S":
                        Player2Card2.Image = Poker.Properties.Resources.NineSpades;
                        break;
                    case "10H":
                        Player2Card2.Image = Poker.Properties.Resources.TenHearts;
                        break;
                    case "10D":
                        Player2Card2.Image = Poker.Properties.Resources.TenDiamonds;
                        break;
                    case "10C":
                        Player2Card2.Image = Poker.Properties.Resources.TenClubs;
                        break;
                    case "10S":
                        Player2Card2.Image = Poker.Properties.Resources.TenSpades;
                        break;
                    case "JH":
                        Player2Card2.Image = Poker.Properties.Resources.JackHearts;
                        break;
                    case "JD":
                        Player2Card2.Image = Poker.Properties.Resources.JackDiamonds;
                        break;
                    case "JC":
                        Player2Card2.Image = Poker.Properties.Resources.JackClubs;
                        break;
                    case "JS":
                        Player2Card2.Image = Poker.Properties.Resources.JackSpades;
                        break;
                    case "QH":
                        Player2Card2.Image = Poker.Properties.Resources.QueenHearts;
                        break;
                    case "QD":
                        Player2Card2.Image = Poker.Properties.Resources.QueenDiamonds;
                        break;
                    case "QC":
                        Player2Card2.Image = Poker.Properties.Resources.QueenClubs1;
                        break;
                    case "QS":
                        Player2Card2.Image = Poker.Properties.Resources.QueenSpades;
                        break;
                    case "KH":
                        Player2Card2.Image = Poker.Properties.Resources.KingHearts;
                        break;
                    case "KD":
                        Player2Card2.Image = Poker.Properties.Resources.KingDiamonds1;
                        break;
                    case "KC":
                        Player2Card2.Image = Poker.Properties.Resources.KingClubs;
                        break;
                    case "KS":
                        Player2Card2.Image = Poker.Properties.Resources.KingSpades;
                        break;
                }
            }
            if (Deck.Turn == 6)
            {
                switch (n)// n has the value returned by Deck.draw which returns the approriate Deck.DeckList card for the draw
                {
                    case "@H":
                        Player2Card3.Image = Poker.Properties.Resources.AceHearts;
                        break;
                    case "@D":
                        Player2Card3.Image = Poker.Properties.Resources.AceDiamonds;
                        break;
                    case "@C":
                        Player2Card3.Image = Poker.Properties.Resources.AceClubs;
                        break;
                    case "@S":
                        Player2Card3.Image = Poker.Properties.Resources.AceSpades;
                        break;
                    case "2H":
                        Player2Card3.Image = Poker.Properties.Resources.TwoHearts;
                        break;
                    case "2D":
                        Player2Card3.Image = Poker.Properties.Resources.TwoDiamonds;
                        break;
                    case "2C":
                        Player2Card3.Image = Poker.Properties.Resources.TwoClubs;
                        break;
                    case "2S":
                        Player2Card3.Image = Poker.Properties.Resources.TwoSpades;
                        break;
                    case "3H":
                        Player2Card3.Image = Poker.Properties.Resources.ThreeHearts;
                        break;
                    case "3D":
                        Player2Card3.Image = Poker.Properties.Resources.ThreeDiamonds;
                        break;
                    case "3C":
                        Player2Card3.Image = Poker.Properties.Resources.ThreeClubs;
                        break;
                    case "3S":
                        Player2Card3.Image = Poker.Properties.Resources.ThreeSpades;
                        break;
                    case "4H":
                        Player2Card3.Image = Poker.Properties.Resources.FourHearts;
                        break;
                    case "4D":
                        Player2Card3.Image = Poker.Properties.Resources.FourDiamonds;
                        break;
                    case "4C":
                        Player2Card3.Image = Poker.Properties.Resources.FourClubs;
                        break;
                    case "4S":
                        Player2Card3.Image = Poker.Properties.Resources.FourSpades;
                        break;
                    case "5H":
                        Player2Card3.Image = Poker.Properties.Resources.FiveHearts;
                        break;
                    case "5D":
                        Player2Card3.Image = Poker.Properties.Resources.FiveDiamonds;
                        break;
                    case "5C":
                        Player2Card3.Image = Poker.Properties.Resources.FiveClubs;
                        break;
                    case "5S":
                        Player2Card3.Image = Poker.Properties.Resources.FiveSpades;
                        break;
                    case "6H":
                        Player2Card3.Image = Poker.Properties.Resources.SixHearts;
                        break;
                    case "6D":
                        Player2Card3.Image = Poker.Properties.Resources.SixDiamonds;
                        break;
                    case "6C":
                        Player2Card3.Image = Poker.Properties.Resources.SixClubs;
                        break;
                    case "6S":
                        Player2Card3.Image = Poker.Properties.Resources.SixSpades;
                        break;
                    case "7H":
                        Player2Card3.Image = Poker.Properties.Resources.SevenHearts;
                        break;
                    case "7D":
                        Player2Card3.Image = Poker.Properties.Resources.SevenDiamonds;
                        break;
                    case "7C":
                        Player2Card3.Image = Poker.Properties.Resources.SevenClubs;
                        break;
                    case "7S":
                        Player2Card3.Image = Poker.Properties.Resources.SevenSpades;
                        break;
                    case "8H":
                        Player2Card3.Image = Poker.Properties.Resources.EightHearts;
                        break;
                    case "8D":
                        Player2Card3.Image = Poker.Properties.Resources.EightDiamonds;
                        break;
                    case "8C":
                        Player2Card3.Image = Poker.Properties.Resources.EightClubs;
                        break;
                    case "8S":
                        Player2Card3.Image = Poker.Properties.Resources.EightSpades;
                        break;
                    case "9H":
                        Player2Card3.Image = Poker.Properties.Resources.NineHearts;
                        break;
                    case "9D":
                        Player2Card3.Image = Poker.Properties.Resources.NineDiamonds;
                        break;
                    case "9C":
                        Player2Card3.Image = Poker.Properties.Resources.NineClubs;
                        break;
                    case "9S":
                        Player2Card3.Image = Poker.Properties.Resources.NineSpades;
                        break;
                    case "10H":
                        Player2Card3.Image = Poker.Properties.Resources.TenHearts;
                        break;
                    case "10D":
                        Player2Card3.Image = Poker.Properties.Resources.TenDiamonds;
                        break;
                    case "10C":
                        Player2Card3.Image = Poker.Properties.Resources.TenClubs;
                        break;
                    case "10S":
                        Player2Card3.Image = Poker.Properties.Resources.TenSpades;
                        break;
                    case "JH":
                        Player2Card3.Image = Poker.Properties.Resources.JackHearts;
                        break;
                    case "JD":
                        Player2Card3.Image = Poker.Properties.Resources.JackDiamonds;
                        break;
                    case "JC":
                        Player2Card3.Image = Poker.Properties.Resources.JackClubs;
                        break;
                    case "JS":
                        Player2Card3.Image = Poker.Properties.Resources.JackSpades;
                        break;
                    case "QH":
                        Player2Card3.Image = Poker.Properties.Resources.QueenHearts;
                        break;
                    case "QD":
                        Player2Card3.Image = Poker.Properties.Resources.QueenDiamonds;
                        break;
                    case "QC":
                        Player2Card3.Image = Poker.Properties.Resources.QueenClubs1;
                        break;
                    case "QS":
                        Player2Card3.Image = Poker.Properties.Resources.QueenSpades;
                        break;
                    case "KH":
                        Player2Card3.Image = Poker.Properties.Resources.KingHearts;
                        break;
                    case "KD":
                        Player2Card3.Image = Poker.Properties.Resources.KingDiamonds1;
                        break;
                    case "KC":
                        Player2Card3.Image = Poker.Properties.Resources.KingClubs;
                        break;
                    case "KS":
                        Player2Card3.Image = Poker.Properties.Resources.KingSpades;
                        break;
                }
            }
            if (Deck.Turn == 8)
            {
                switch (n)// n has the value returned by Deck.draw which returns the approriate Deck.DeckList card for the draw
                {
                    case "@H":
                        Player2Card4.Image = Poker.Properties.Resources.AceHearts;
                        break;
                    case "@D":
                        Player2Card4.Image = Poker.Properties.Resources.AceDiamonds;
                        break;
                    case "@C":
                        Player2Card4.Image = Poker.Properties.Resources.AceClubs;
                        break;
                    case "@S":
                        Player2Card4.Image = Poker.Properties.Resources.AceSpades;
                        break;
                    case "2H":
                        Player2Card4.Image = Poker.Properties.Resources.TwoHearts;
                        break;
                    case "2D":
                        Player2Card4.Image = Poker.Properties.Resources.TwoDiamonds;
                        break;
                    case "2C":
                        Player2Card4.Image = Poker.Properties.Resources.TwoClubs;
                        break;
                    case "2S":
                        Player2Card4.Image = Poker.Properties.Resources.TwoSpades;
                        break;
                    case "3H":
                        Player2Card4.Image = Poker.Properties.Resources.ThreeHearts;
                        break;
                    case "3D":
                        Player2Card4.Image = Poker.Properties.Resources.ThreeDiamonds;
                        break;
                    case "3C":
                        Player2Card4.Image = Poker.Properties.Resources.ThreeClubs;
                        break;
                    case "3S":
                        Player2Card4.Image = Poker.Properties.Resources.ThreeSpades;
                        break;
                    case "4H":
                        Player2Card4.Image = Poker.Properties.Resources.FourHearts;
                        break;
                    case "4D":
                        Player2Card4.Image = Poker.Properties.Resources.FourDiamonds;
                        break;
                    case "4C":
                        Player2Card4.Image = Poker.Properties.Resources.FourClubs;
                        break;
                    case "4S":
                        Player2Card4.Image = Poker.Properties.Resources.FourSpades;
                        break;
                    case "5H":
                        Player2Card4.Image = Poker.Properties.Resources.FiveHearts;
                        break;
                    case "5D":
                        Player2Card4.Image = Poker.Properties.Resources.FiveDiamonds;
                        break;
                    case "5C":
                        Player2Card4.Image = Poker.Properties.Resources.FiveClubs;
                        break;
                    case "5S":
                        Player2Card4.Image = Poker.Properties.Resources.FiveSpades;
                        break;
                    case "6H":
                        Player2Card4.Image = Poker.Properties.Resources.SixHearts;
                        break;
                    case "6D":
                        Player2Card4.Image = Poker.Properties.Resources.SixDiamonds;
                        break;
                    case "6C":
                        Player2Card4.Image = Poker.Properties.Resources.SixClubs;
                        break;
                    case "6S":
                        Player2Card4.Image = Poker.Properties.Resources.SixSpades;
                        break;
                    case "7H":
                        Player2Card4.Image = Poker.Properties.Resources.SevenHearts;
                        break;
                    case "7D":
                        Player2Card4.Image = Poker.Properties.Resources.SevenDiamonds;
                        break;
                    case "7C":
                        Player2Card4.Image = Poker.Properties.Resources.SevenClubs;
                        break;
                    case "7S":
                        Player2Card4.Image = Poker.Properties.Resources.SevenSpades;
                        break;
                    case "8H":
                        Player2Card4.Image = Poker.Properties.Resources.EightHearts;
                        break;
                    case "8D":
                        Player2Card4.Image = Poker.Properties.Resources.EightDiamonds;
                        break;
                    case "8C":
                        Player2Card4.Image = Poker.Properties.Resources.EightClubs;
                        break;
                    case "8S":
                        Player2Card4.Image = Poker.Properties.Resources.EightSpades;
                        break;
                    case "9H":
                        Player2Card4.Image = Poker.Properties.Resources.NineHearts;
                        break;
                    case "9D":
                        Player2Card4.Image = Poker.Properties.Resources.NineDiamonds;
                        break;
                    case "9C":
                        Player2Card4.Image = Poker.Properties.Resources.NineClubs;
                        break;
                    case "9S":
                        Player2Card4.Image = Poker.Properties.Resources.NineSpades;
                        break;
                    case "10H":
                        Player2Card4.Image = Poker.Properties.Resources.TenHearts;
                        break;
                    case "10D":
                        Player2Card4.Image = Poker.Properties.Resources.TenDiamonds;
                        break;
                    case "10C":
                        Player2Card4.Image = Poker.Properties.Resources.TenClubs;
                        break;
                    case "10S":
                        Player2Card4.Image = Poker.Properties.Resources.TenSpades;
                        break;
                    case "JH":
                        Player2Card4.Image = Poker.Properties.Resources.JackHearts;
                        break;
                    case "JD":
                        Player2Card4.Image = Poker.Properties.Resources.JackDiamonds;
                        break;
                    case "JC":
                        Player2Card4.Image = Poker.Properties.Resources.JackClubs;
                        break;
                    case "JS":
                        Player2Card4.Image = Poker.Properties.Resources.JackSpades;
                        break;
                    case "QH":
                        Player2Card4.Image = Poker.Properties.Resources.QueenHearts;
                        break;
                    case "QD":
                        Player2Card4.Image = Poker.Properties.Resources.QueenDiamonds;
                        break;
                    case "QC":
                        Player2Card4.Image = Poker.Properties.Resources.QueenClubs1;
                        break;
                    case "QS":
                        Player2Card4.Image = Poker.Properties.Resources.QueenSpades;
                        break;
                    case "KH":
                        Player2Card4.Image = Poker.Properties.Resources.KingHearts;
                        break;
                    case "KD":
                        Player2Card4.Image = Poker.Properties.Resources.KingDiamonds1;
                        break;
                    case "KC":
                        Player2Card4.Image = Poker.Properties.Resources.KingClubs;
                        break;
                    case "KS":
                        Player2Card4.Image = Poker.Properties.Resources.KingSpades;
                        break;
                }
            }
            if (Deck.Turn == 10)
            {
                switch (n)// n has the value returned by Deck.draw which returns the approriate Deck.DeckList card for the draw
                {
                    case "@H":
                        Player2Card5.Image = Poker.Properties.Resources.AceHearts;
                        break;
                    case "@D":
                        Player2Card5.Image = Poker.Properties.Resources.AceDiamonds;
                        break;
                    case "@C":
                        Player2Card5.Image = Poker.Properties.Resources.AceClubs;
                        break;
                    case "@S":
                        Player2Card5.Image = Poker.Properties.Resources.AceSpades;
                        break;
                    case "2H":
                        Player2Card5.Image = Poker.Properties.Resources.TwoHearts;
                        break;
                    case "2D":
                        Player2Card5.Image = Poker.Properties.Resources.TwoDiamonds;
                        break;
                    case "2C":
                        Player2Card5.Image = Poker.Properties.Resources.TwoClubs;
                        break;
                    case "2S":
                        Player2Card5.Image = Poker.Properties.Resources.TwoSpades;
                        break;
                    case "3H":
                        Player2Card5.Image = Poker.Properties.Resources.ThreeHearts;
                        break;
                    case "3D":
                        Player2Card5.Image = Poker.Properties.Resources.ThreeDiamonds;
                        break;
                    case "3C":
                        Player2Card5.Image = Poker.Properties.Resources.ThreeClubs;
                        break;
                    case "3S":
                        Player2Card5.Image = Poker.Properties.Resources.ThreeSpades;
                        break;
                    case "4H":
                        Player2Card5.Image = Poker.Properties.Resources.FourHearts;
                        break;
                    case "4D":
                        Player2Card5.Image = Poker.Properties.Resources.FourDiamonds;
                        break;
                    case "4C":
                        Player2Card5.Image = Poker.Properties.Resources.FourClubs;
                        break;
                    case "4S":
                        Player2Card5.Image = Poker.Properties.Resources.FourSpades;
                        break;
                    case "5H":
                        Player2Card5.Image = Poker.Properties.Resources.FiveHearts;
                        break;
                    case "5D":
                        Player2Card5.Image = Poker.Properties.Resources.FiveDiamonds;
                        break;
                    case "5C":
                        Player2Card5.Image = Poker.Properties.Resources.FiveClubs;
                        break;
                    case "5S":
                        Player2Card5.Image = Poker.Properties.Resources.FiveSpades;
                        break;
                    case "6H":
                        Player2Card5.Image = Poker.Properties.Resources.SixHearts;
                        break;
                    case "6D":
                        Player2Card5.Image = Poker.Properties.Resources.SixDiamonds;
                        break;
                    case "6C":
                        Player2Card5.Image = Poker.Properties.Resources.SixClubs;
                        break;
                    case "6S":
                        Player2Card5.Image = Poker.Properties.Resources.SixSpades;
                        break;
                    case "7H":
                        Player2Card5.Image = Poker.Properties.Resources.SevenHearts;
                        break;
                    case "7D":
                        Player2Card5.Image = Poker.Properties.Resources.SevenDiamonds;
                        break;
                    case "7C":
                        Player2Card5.Image = Poker.Properties.Resources.SevenClubs;
                        break;
                    case "7S":
                        Player2Card5.Image = Poker.Properties.Resources.SevenSpades;
                        break;
                    case "8H":
                        Player2Card5.Image = Poker.Properties.Resources.EightHearts;
                        break;
                    case "8D":
                        Player2Card5.Image = Poker.Properties.Resources.EightDiamonds;
                        break;
                    case "8C":
                        Player2Card5.Image = Poker.Properties.Resources.EightClubs;
                        break;
                    case "8S":
                        Player2Card5.Image = Poker.Properties.Resources.EightSpades;
                        break;
                    case "9H":
                        Player2Card5.Image = Poker.Properties.Resources.NineHearts;
                        break;
                    case "9D":
                        Player2Card5.Image = Poker.Properties.Resources.NineDiamonds;
                        break;
                    case "9C":
                        Player2Card5.Image = Poker.Properties.Resources.NineClubs;
                        break;
                    case "9S":
                        Player2Card5.Image = Poker.Properties.Resources.NineSpades;
                        break;
                    case "10H":
                        Player2Card5.Image = Poker.Properties.Resources.TenHearts;
                        break;
                    case "10D":
                        Player2Card5.Image = Poker.Properties.Resources.TenDiamonds;
                        break;
                    case "10C":
                        Player2Card5.Image = Poker.Properties.Resources.TenClubs;
                        break;
                    case "10S":
                        Player2Card5.Image = Poker.Properties.Resources.TenSpades;
                        break;
                    case "JH":
                        Player2Card5.Image = Poker.Properties.Resources.JackHearts;
                        break;
                    case "JD":
                        Player2Card5.Image = Poker.Properties.Resources.JackDiamonds;
                        break;
                    case "JC":
                        Player2Card5.Image = Poker.Properties.Resources.JackClubs;
                        break;
                    case "JS":
                        Player2Card5.Image = Poker.Properties.Resources.JackSpades;
                        break;
                    case "QH":
                        Player2Card5.Image = Poker.Properties.Resources.QueenHearts;
                        break;
                    case "QD":
                        Player2Card5.Image = Poker.Properties.Resources.QueenDiamonds;
                        break;
                    case "QC":
                        Player2Card5.Image = Poker.Properties.Resources.QueenClubs1;
                        break;
                    case "QS":
                        Player2Card5.Image = Poker.Properties.Resources.QueenSpades;
                        break;
                    case "KH":
                        Player2Card5.Image = Poker.Properties.Resources.KingHearts;
                        break;
                    case "KD":
                        Player2Card5.Image = Poker.Properties.Resources.KingDiamonds1;
                        break;
                    case "KC":
                        Player2Card5.Image = Poker.Properties.Resources.KingClubs;
                        break;
                    case "KS":
                        Player2Card5.Image = Poker.Properties.Resources.KingSpades;
                        break;
                }
            }
            if (Deck.Turn >= 10)
            {
                ButtonDeck.Enabled = false;
            }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}



