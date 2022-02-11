using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    internal class Card
    {
        string Rank;
        string Suit;

        public string SetRank(int r) // sets the number/rank value of a card when called, based on the value of 'r'
        {
            switch (r)
            {
                case 0:
                    Rank = "Ace";
                    break;

                case 1:
                    Rank = "2";
                    break;

                case 2:
                    Rank = "3";
                    break;
                case 3:
                    Rank = "4";
                    break;
                case 4:
                    Rank = "5";
                    break;
                case 5:
                    Rank = "6";
                    break;
                case 6:
                    Rank = "7";
                    break;
                case 7:
                    Rank = "8";
                    break;
                case 8:
                    Rank = "9";
                    break;
                case 9:
                    Rank = "10";
                    break;
                case 10:
                    Rank = "Jack";
                    break;
                case 11:
                    Rank = "Queen";
                    break;
                case 12:
                    Rank = "King";
                    break;
            }
            return Rank;
        }
       
        
        public string SetSuit(int s) //sets the suit of a card when called based on the value of 's'
        {
            switch (s)
            {
                case 0:
                    Suit = "Diamonds";
                    break;
                case 1:
                    Suit = "Hearts";
                    break;
                case 2:
                    Suit = "Spades";
                    break;
                case 3:
                    Suit = "Clubs";
                    break;
            }
            return Suit;
        }

        public string CreateCard(int r, int s) // creates a card when called and returns thats card value as a string
        {
            string Rank = SetRank(r);
            string Suit = SetSuit(s);

            string NewLine = Environment.NewLine;
            string Card = $"{Rank} of {Suit} {NewLine}";

            return Card;
        }

    }
}
