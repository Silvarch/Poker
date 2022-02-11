using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    internal class Deck
    {
        String[] NewDeck = new String[52]; // this array holds the 52 card deck with each element being a card.
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
    }
}
