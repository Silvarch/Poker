
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    public static class Deck
    {
        static Card c1 = new Card(); // ensues that methods from the Card class can be called

        static Points p1 = new Points();

        public static List<String> DeckList = new List<String>(); // initiates a list which will later be filled with objects via the SetDeck method
        public static bool FullHands = false; // used by Form1.CheckWinner to check if points can be counted yet


        public static int Turn = 0;// determins the current turn and is incremented after each draw, capping at 10
        public static Random random = new Random(); //used by shuffle method to assist in assigning random values to list members


        public static String[] Hand1 = new String[5]; //used to store card values of player 1's Deck.Hand
        public static String[] Hand2 = new string[5]; //used to store card values of player 2's Deck.Hand
        /*For simplicities sake card values are stored using the folowing naming convention: RankSuit. for example: AH == Ace of hearts, JD == Jack of diamonds. This should aid whoever creates the point scoring class */




        /* loeds the unshuffled deck when called. This works by assigning DeckList[]'s variables to values provided by the CreateCard method in the Card class*/
        public static void SetDeck()
        {

            int CardNum = 0; // used to assign gards to an array element

            for (int j = 0; j < 4; j++)//the 'j' for loop will determine the suit of the card being added to DeckList
            {

                for (int i = 0; i < 13; i++)
                {

                    string card = c1.CreateCard(i, j);
                    DeckList.Add(card);
                    CardNum++; // increases cardnum so that the next array element can be assigned

                }

            }

        }

        /*this method allows for other classes to initiate a shuffle as it calls the static method 'Shuffle' directly from*/
        public static void BeginShuffle()
        {
            Shuffle(DeckList);

        }

        /* simple solution to shuffle the objects in DeckList*/
        public static void Shuffle<String>(this IList<String> DeckList)
        {
            SetDeck();

            int CardCount = 52; // set to a static 52 so that no duplicate cards are printed
            while (CardCount > 1)
            {
                CardCount--;
                int k = random.Next(CardCount);
                String value = DeckList[k];
                DeckList[k] = DeckList[CardCount];
                DeckList[CardCount] = value;

            }
        }

         * Returns a card object when called(see ButtonDeck_Click method in the Form1 class). This method also checks to see if the deck has been loaded yet, if not, the SetDeck() method is called to do so*/
        public static string Draw()
        {
            if (DeckList.Contains("A") == false)//checks to see if list has been populated "A" will always be present when poulated. sets deck if needed.
            {
                SetDeck();
            }
        }
    }
}