
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    internal class Deck
    {
        public String[] NewDeck = new String[52]; // this array holds the 52 card deck with each element being a card.
        Card c1 = new Card();
        
        

        public string SetDeck()
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

            //assigns to string 'result': all elements of the Create deck array (all cards in deck) for testing/verification purposes 
            String seperator = "\n";
            string result = "";
            result += String.Join(seperator, NewDeck);

            return result;

        }
        public string BeginShuffle()
        {
            string result = Shuffle(NewDeck);

            return result;

        }
        
        static string Shuffle(string[] NewDeck)
        {
            Random random = new Random();
            NewDeck = NewDeck.OrderBy(x => random.Next()).ToArray();

            String seperator = "\n";
            string result = "";
            result += String.Join(seperator, NewDeck);

            return result;


        }   
        
        public int Draw(int DrawNumber)
        {
            int card = 0;
            switch (DrawNumber)
            {
                case 0:
                    card = 0; break;
                case 1:
                    card = 1; break;
                case 2:
                    card = 2; break;
                case 3:
                    card = 3; break;
                case 4:
                    card = 4; break;
                case 5:
                    card = 5; break;
                case 6:
                    card = 6; break;
                case 7:
                    card = 7; break;
                case 8:
                    card = 8; break;
                case 9:
                    card = 9; break;
                case 10:
                    card = 10; break;
                case 11:
                    card = 11; break;
                case 12:
                    card = 12; break;
                case 13:
                    card = 13; break;
                case 14:
                    card = 14; break;
                case 15:
                    card = 15; break;
                case 16:
                    card = 16; break;
                case 17:
                    card = 17; break;
                case 18:
                    card = 18; break;
                case 19:
                    card = 19; break;
                case 20:
                    card = 20; break;
                case 21:
                    card = 21; break;
                case 22:
                    card = 22; break;
                case 23:
                    card = 23; break;
                case 24:
                    card = 24; break;
                case 25:
                    card = 25; break;
                case 26:
                    card = 26; break;
                case 27:
                    card = 27; break;
                case 28:
                    card = 28; break;
                case 29:
                    card = 29; break;
                case 30:
                    card = 30; break;
                case 31:
                    card = 31; break;
                case 32:
                    card = 32; break;
                case 33:
                    card = 33; break;
                case 34:
                    card = 34; break;
                case 35:
                    card = 35; break;
                case 36:
                    card = 36; break;
                case 37:
                    card = 37; break;
                case 38:
                    card = 38; break;
                case 39:
                    card = 39; break;
                case 40:
                    card = 40; break;
                case 41:
                    card = 41; break;
                case 42:
                    card = 42; break;
                case 43:
                    card = 43; break;
                case 44:
                    card = 44; break;
                case 45:
                    card = 45; break;
                case 46:
                    card = 46; break;
                case 47:
                    card = 47; break;
                case 48:
                    card = 48; break;
                case 49:
                    card = 49; break;
                case 50:
                    card = 50; break;
                case 51:
                    card = 51; break;

            }
            return card;
        }
    }
}
