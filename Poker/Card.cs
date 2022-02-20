using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    internal class Card
    {
        /* these two strings are used in the SetRank and SetSuit methods*/
        string Rank;
        string Suit;

        public Card()
        {
            Rank = "";
            Suit = "";
        }



        /* sets the number/rank value of a card when called, based on the value of 'r'*/
        public string SetRank(int r)
        {
            switch (r)
            {
                case 0:
                    Rank = "@"; //@ is used in place of 10 to make checking for matches in the points class easier
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
                    Rank = "J";
                    break;
                case 11:
                    Rank = "Q";
                    break;
                case 12:
                    Rank = "K";
                    break;
            }
            return Rank;
        }

        /*sets the suit of a card when called based on the value of 's'*/
        public string SetSuit(int s)
        {
            switch (s)
            {
                case 0:
                    Suit = "H";
                    break;
                case 1:
                    Suit = "D";
                    break;
                case 2:
                    Suit = "S";
                    break;
                case 3:
                    Suit = "C";
                    break;
            }
            return Suit;
        }


        /* creates a card when called and returns thats card value as a string*/
        public string CreateCard(int r, int s)
        {
            string Rank = SetRank(r);
            string Suit = SetSuit(s);
            string Card = $"{Rank}{Suit}";

            return Card;
        }

    }
}