using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    public class Deck
    {
        public String[] NewDeck = new String[52];// this array holds the 52 card deck with each element being a card.
        public int Turn = 0;
        public int CardDraw = 0; //because draw number is incremented though each iteration, the card drawn will always be the next in the arrays order


        public String[] Hand1 = new String[5]; //used to store card values of player 1's hand
        public string[] Hand2 = new string[5]; //used to store card values of player 2's hand
        /*For simplicities sake card values are stored using the folowing naming convention: RankSuit. for example: AH == Ace of hearts, JD == Jack of diamonds. This should aid whoever creates the point scoring class */

        Card c1 = new Card();
        

        
        /* loeds the unshuffled deck when called. This works by assigning NewDeck[]'s variables to values provided by the CreateCard method in the Card class*/
        public void SetDeck()
        {
            
            int CardNum = 0; // used to assign gards to an array element

            for (int j = 0; j < 4; j++)//the 'j' for loop will determine the suit of the card being added to NewDeck
            {

                for (int i = 0; i < 13; i++)
                {
                    
                    NewDeck[CardNum] = c1.CreateCard(i, j);
                    CardNum++; // increases cardnum so that the next array element can be assigned

                }

            }
 
            

            

        }

        /* simple solution toshuffle the contents of the NewDeck Array and randomize them*/
        public void BeginShuffle()
        {

            Random r = new Random();

            NewDeck = NewDeck.OrderBy(x => r.Next()).ToArray();

        }
        
        
        /* called by the ButtonDeck_click method in the Form1 class, returns a value between 0 and 51 based on the contents of the specified NewDeck[] Array.
         * This value is used to determin what card is drawn from the deck (see ButtonDeck_Click method in the Form1 class). This method also checks
         to see if the deck has been loaded yet, if not, the SetDeck() method is called to do so*/
        public int Draw()
        {
            if (NewDeck[0] == null)
            {
                SetDeck();
            }

            
            

            string r1 = "Ace";
            string r2 = "2";
            string r3 = "3";
            string r4 = "4";
            string r5 = "5";
            string r6 = "6";
            string r7 = "7";
            string r8 = "8";
            string r9 = "9";
            string r10 = "10";
            string r11 = "Jack";
            string r12 = "Queen";
            string r13 = "King";
            string s1 = "Hearts";
            string s2 = "Diamonds";
            string s3 = "Clubs";
            string s4 = "Spades";
            int card = 0;

            

            //The following if statements check what Turn it is along with the value of the card being drawn via the NewDeck Array
            if (NewDeck[CardDraw].Contains(r1) && NewDeck[CardDraw].Contains(s1))
            {
                card = 0;
                Turn++;
            }
            if (NewDeck[CardDraw].Contains(r1) && NewDeck[CardDraw].Contains(s2))
            {
                card = 1;
                Turn++;
            }
            if (NewDeck[CardDraw].Contains(r1) && NewDeck[CardDraw].Contains(s3))
            {
                card = 2;
                Turn++;
            }
            if (NewDeck[CardDraw].Contains(r1) && NewDeck[CardDraw].Contains(s4))
            {
                card = 3;
                Turn++;
            }
            if (NewDeck[CardDraw].Contains(r2) && NewDeck[CardDraw].Contains(s1))
            {
                card = 4;
                Turn++;
            }
            if (NewDeck[CardDraw].Contains(r2) && NewDeck[CardDraw].Contains(s2))
            {
                card = 5;
                Turn++;
            }
            if (NewDeck[CardDraw].Contains(r2) && NewDeck[CardDraw].Contains(s3))
            {
                card = 6;
                Turn++;
            }
            if (NewDeck[CardDraw].Contains(r2) && NewDeck[CardDraw].Contains(s4))
            {
                card = 7;
                Turn++;
            }
            if (NewDeck[CardDraw].Contains(r3) && NewDeck[CardDraw].Contains(s1))
            {
                card = 8;
                Turn++;
            }
            if (NewDeck[CardDraw].Contains(r3) && NewDeck[CardDraw].Contains(s2))
            {
                card = 9;
                Turn++;
            }
            if (NewDeck[CardDraw].Contains(r3) && NewDeck[CardDraw].Contains(s3))
            {
                card = 10;
                Turn++;
            }
            if (NewDeck[CardDraw].Contains(r3) && NewDeck[CardDraw].Contains(s4))
            {
                card = 11;
                Turn++;
            }
            if (NewDeck[CardDraw].Contains(r4) && NewDeck[CardDraw].Contains(s1))
            {
                card = 12;
                Turn++;
            }
            if (NewDeck[CardDraw].Contains(r4) && NewDeck[CardDraw].Contains(s2))
            {
                card = 13;
                Turn++;
            }
            if (NewDeck[CardDraw].Contains(r4) && NewDeck[CardDraw].Contains(s3))
            {
                card = 14;
                Turn++;
            }
            if (NewDeck[CardDraw].Contains(r4) && NewDeck[CardDraw].Contains(s4))
            {
                card = 15;
                Turn++;
            }
            if (NewDeck[CardDraw].Contains(r5) && NewDeck[CardDraw].Contains(s1))
            {
                card = 16;
                Turn++;
            }
            if (NewDeck[CardDraw].Contains(r5) && NewDeck[CardDraw].Contains(s2))
            {
                card = 17;
                Turn++;
            }
            if (NewDeck[CardDraw].Contains(r5) && NewDeck[CardDraw].Contains(s3))
            {
                card = 18;
                Turn++;
            }
            if (NewDeck[CardDraw].Contains(r5) && NewDeck[CardDraw].Contains(s4))
            {
                card = 19;
                Turn++;
            }
            if (NewDeck[CardDraw].Contains(r6) && NewDeck[CardDraw].Contains(s1))
            {
                card = 20;
                Turn++;
            }
            if (NewDeck[CardDraw].Contains(r6) && NewDeck[CardDraw].Contains(s2))
            {
                card = 21;
                Turn++;
            }
            if (NewDeck[CardDraw].Contains(r6) && NewDeck[CardDraw].Contains(s3))
            {
                card = 22;
                Turn++;
            }
            if (NewDeck[CardDraw].Contains(r6) && NewDeck[CardDraw].Contains(s4))
            {
                card = 23;
                Turn++;
            }
            if (NewDeck[CardDraw].Contains(r7) && NewDeck[CardDraw].Contains(s1))
            {
                card = 24;
                Turn++;
            }
            if (NewDeck[CardDraw].Contains(r7) && NewDeck[CardDraw].Contains(s2))
            {
                card = 25;
                Turn++;
            }
            if (NewDeck[CardDraw].Contains(r7) && NewDeck[CardDraw].Contains(s3))
            {
                card = 26;
                Turn++;
            }
            if (NewDeck[CardDraw].Contains(r7) && NewDeck[CardDraw].Contains(s4))
            {
                card = 27;
                Turn++;
            }
            if (NewDeck[CardDraw].Contains(r8) && NewDeck[CardDraw].Contains(s1))
            {
                card = 28;
                Turn++;
            }
            if (NewDeck[CardDraw].Contains(r8) && NewDeck[CardDraw].Contains(s2))
            {
                card = 29;
                Turn++;
            }
            if (NewDeck[CardDraw].Contains(r8) && NewDeck[CardDraw].Contains(s3))
            {
                card = 30;
                Turn++;
            }
            if (NewDeck[CardDraw].Contains(r8) && NewDeck[CardDraw].Contains(s4))
            {
                card = 31;
                Turn++;
            }
            if (NewDeck[CardDraw].Contains(r9) && NewDeck[CardDraw].Contains(s1))
            {
                card = 32;
                Turn++;
            }
            if (NewDeck[CardDraw].Contains(r9) && NewDeck[CardDraw].Contains(s2))
            {
                card = 33;
                Turn++;
            }
            if (NewDeck[CardDraw].Contains(r9) && NewDeck[CardDraw].Contains(s3))
            {
                card = 34;
                Turn++;
            }
            if (NewDeck[CardDraw].Contains(r9) && NewDeck[CardDraw].Contains(s4))
            {
                card = 35;
                Turn++;
            }
            if (NewDeck[CardDraw].Contains(r10) && NewDeck[CardDraw].Contains(s1))
            {
                card = 36;
                Turn++;
            }
            if (NewDeck[CardDraw].Contains(r10) && NewDeck[CardDraw].Contains(s2))
            {
                card = 37;
                Turn++;
            }
            if (NewDeck[CardDraw].Contains(r10) && NewDeck[CardDraw].Contains(s3))
            {
                card = 38;
                Turn++;
            }
            if (NewDeck[CardDraw].Contains(r10) && NewDeck[CardDraw].Contains(s4))
            {
                card = 39;
                Turn++;
            }

            if (NewDeck[CardDraw].Contains(r11) && NewDeck[CardDraw].Contains(s1))
            {
                card = 40;
                Turn++;
            }
            if (NewDeck[CardDraw].Contains(r11) && NewDeck[CardDraw].Contains(s2))
            {
                card = 41;
                Turn++;
            }
            if (NewDeck[CardDraw].Contains(r11) && NewDeck[CardDraw].Contains(s3))
            {
                card = 42;
                Turn++;
            }
            if (NewDeck[CardDraw].Contains(r11) && NewDeck[CardDraw].Contains(s4))
            {
                card = 43;
                Turn++;
            }
            if (NewDeck[CardDraw].Contains(r12) && NewDeck[CardDraw].Contains(s1))
            {
                card = 44;
                Turn++;
            }
            if (NewDeck[CardDraw].Contains(r12) && NewDeck[CardDraw].Contains(s2))
            {
                card = 45;
                Turn++;
            }
            if (NewDeck[CardDraw].Contains(r12) && NewDeck[CardDraw].Contains(s3))
            {
                card = 46;
                Turn++;
            }
            if (NewDeck[CardDraw].Contains(r12) && NewDeck[CardDraw].Contains(s4))
            {
                card = 47;
                Turn++;
            }
            if (NewDeck[CardDraw].Contains(r13) && NewDeck[CardDraw].Contains(s1))
            {
                card = 48;
                Turn++;
            }
            if (NewDeck[CardDraw].Contains(r13) && NewDeck[CardDraw].Contains(s2))
            {
                card = 49;
                Turn++;
            }
            if (NewDeck[CardDraw].Contains(r13) && NewDeck[CardDraw].Contains(s3))
            {
                card = 50;
                Turn++;
            }
            if (NewDeck[CardDraw].Contains(r13) && NewDeck[CardDraw].Contains(s4))
            {
                card = 51;
                Turn++;
            }

            CardDraw++;
            return card;

        }
    }
}

