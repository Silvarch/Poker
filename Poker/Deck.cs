
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    public static class Deck
    {
        static Card c1 = new Card(); //ensues that methods from the Card class can be called

        static Points p1 = new Points(); //ensues that methods from the Points class can be called

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

            int CardNum = 0; 

            for (int j = 0; j < 4; j++)//the 'j' for loop will determine the suit of the card being added to DeckList
            {

                for (int i = 0; i < 13; i++)
                {

                    string card = c1.CreateCard(i, j);
                    DeckList.Add(card);
                    CardNum++; 

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

         /* Returns a card object when called(see ButtonDeck_Click method in the Form1 class). This method also checks to see if the deck has been loaded yet, if not, the SetDeck() method is called to do so*/
        public static string Draw()
        {
            FullHands = false;
            if (DeckList.Contains("A") == false)//checks to see if list has been populated "A" will always be present when poulated. sets deck if needed.
            {
                SetDeck();
            }
            switch (Turn)
            {
                case 0:
                    Hand1[0] = DeckList[0];
                    Turn++;
                    return DeckList[0];
                    
                case 1:
                    Hand2[0] = DeckList[1];
                    Turn++;
                    return DeckList[1];
                    
                case 2:
                    Hand1[1] = DeckList[2];
                    Turn++;
                    return DeckList[2];
                    
                case 3:
                    Hand2[1] = DeckList[3];
                    Turn++;
                    return DeckList[3];
                case 4:
                    Hand1[2] = DeckList[4];
                    Turn++;
                    return DeckList[4];
               
                case 5:
                    Hand2[2] = DeckList[5];
                    Turn++;
                    return DeckList[5];
                    
                case 6:
                    Hand1[3] = DeckList[6];
                    Turn++;
                    return DeckList[6];
                    
                case 7:
                    Hand2[3] = DeckList[7];
                    Turn++;
                    return DeckList[7];
                    
                case 8:
                    Hand1[4] = DeckList[8];
                    Turn++;
                    return DeckList[8];
                    
                case 9:
                    Hand2[4] = DeckList[9];
                    Turn++;
                    FullHands = true;
                    return DeckList[9];
                    
            }
            return ""; //Default return required, the code should always return through switch statement
        }
    }
}