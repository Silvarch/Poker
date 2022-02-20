using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    internal class Points
    {
        public int P1Points = 0;
        public int P2Points = 0;


        /* Checks to see if a hand has 2 cards of the same suit and 3 cards of a different matching suit */
        public void CheckFullHouse()
        {
            int P1Match = 0;
            int P2Match = 0;


            for (int i = 0; i < Deck.Hand1.Length; i++)
            {
                for (int j = 0; j < Deck.Hand1.Length; j++)
                {
                    if (Deck.Hand1[i].Contains("H") && Deck.Hand1[j].Contains("H") && i != j)
                    {
                        for (int k = 0; k < Deck.Hand1.Length; k++)
                        {
                            for (int l = 0; l < Deck.Hand1.Length; l++)
                            {
                                for (int m = 0; m < Deck.Hand1.Length; m++)
                                {
                                    if (P1Match == 0 && Deck.Hand1[k].Contains("D") && Deck.Hand1[l].Contains("D") && Deck.Hand1[m].Contains("D") && k != l && k != m && l != k && l != m && m != k && m != l)
                                    {
                                        P1Points += 12;
                                        P1Match = 1;
                                    }
                                    else if (P1Match == 0 && Deck.Hand1[k].Contains("C") && Deck.Hand1[l].Contains("C") && Deck.Hand1[m].Contains("C") && k != l && k != m && l != k && l != m && m != k && m != l)
                                    {
                                        P1Points += 12;
                                        P1Match = 1;
                                    }
                                    else if (P1Match == 0 && Deck.Hand1[k].Contains("S") && Deck.Hand1[l].Contains("S") && Deck.Hand1[m].Contains("S") && k != l && k != m && l != k && l != m && m != k && m != l)
                                    {
                                        P1Points += 12;
                                        P1Match = 1;
                                    }
                                }
                            }
                        }
                    }
                    if (Deck.Hand1[i].Contains("D") && Deck.Hand1[j].Contains("D") && i != j)
                    {
                        for (int k = 0; k < Deck.Hand1.Length; k++)
                        {
                            for (int l = 0; l < Deck.Hand1.Length; l++)
                            {
                                for (int m = 0; m < Deck.Hand1.Length; m++)
                                {
                                    if (P1Match == 0 && Deck.Hand1[k].Contains("H") && Deck.Hand1[l].Contains("H") && Deck.Hand1[m].Contains("H") && k != l && k != m && l != k && l != m && m != k && m != l)
                                    {
                                        P1Points += 12;
                                        P1Match = 1;
                                    }
                                    else if (P1Match == 0 && Deck.Hand1[k].Contains("C") && Deck.Hand1[l].Contains("C") && Deck.Hand1[m].Contains("C") && k != l && k != m && l != k && l != m && m != k && m != l)
                                    {
                                        P1Points += 12;
                                        P1Match = 1;
                                    }
                                    else if (P1Match == 0 && Deck.Hand1[k].Contains("S") && Deck.Hand1[l].Contains("S") && Deck.Hand1[m].Contains("S") && k != l && k != m && l != k && l != m && m != k && m != l)
                                    {
                                        P1Points += 12;
                                        P1Match = 1;
                                    }
                                }
                            }
                        }
                    }
                    if (Deck.Hand1[i].Contains("C") && Deck.Hand1[j].Contains("C") && i != j)
                    {
                        for (int k = 0; k < Deck.Hand1.Length; k++)
                        {
                            for (int l = 0; l < Deck.Hand1.Length; l++)
                            {
                                for (int m = 0; m < Deck.Hand1.Length; m++)
                                {
                                    if (P1Match == 0 && Deck.Hand1[k].Contains("H") && Deck.Hand1[l].Contains("H") && Deck.Hand1[m].Contains("H") && k != l && k != m && l != k && l != m && m != k && m != l)
                                    {
                                        P1Points += 12;
                                        P1Match = 1;
                                    }
                                    else if (P1Match == 0 && Deck.Hand1[k].Contains("D") && Deck.Hand1[l].Contains("D") && Deck.Hand1[m].Contains("D") && k != l && k != m && l != k && l != m && m != k && m != l)
                                    {
                                        P1Points += 12;
                                        P1Match = 1;
                                    }
                                    else if (P1Match == 0 && Deck.Hand1[k].Contains("S") && Deck.Hand1[l].Contains("S") && Deck.Hand1[m].Contains("S") && k != l && k != m && l != k && l != m && m != k && m != l)
                                    {
                                        P1Points += 12;
                                        P1Match = 1;
                                    }
                                }
                            }
                        }
                    }
                    if (Deck.Hand1[i].Contains("S") && Deck.Hand1[j].Contains("S") && i != j)
                    {
                        for (int k = 0; k < Deck.Hand1.Length; k++)
                        {
                            for (int l = 0; l < Deck.Hand1.Length; l++)
                            {
                                for (int m = 0; m < Deck.Hand1.Length; m++)
                                {
                                    if (P1Match == 0 && Deck.Hand1[k].Contains("H") && Deck.Hand1[l].Contains("H") && Deck.Hand1[m].Contains("H") && k != l && k != m && l != k && l != m && m != k && m != l)
                                    {
                                        P1Points += 12;
                                        P1Match = 1;
                                    }
                                    else if (P1Match == 0 && Deck.Hand1[k].Contains("C") && Deck.Hand1[l].Contains("C") && Deck.Hand1[m].Contains("C") && k != l && k != m && l != k && l != m && m != k && m != l)
                                    {
                                        P1Points += 12;
                                        P1Match = 1;
                                    }
                                    else if (P1Match == 0 && Deck.Hand1[k].Contains("D") && Deck.Hand1[l].Contains("D") && Deck.Hand1[m].Contains("D") && k != l && k != m && l != k && l != m && m != k && m != l)
                                    {
                                        P1Points += 12;
                                        P1Match = 1;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < Deck.Hand2.Length; i++)
            {
                for (int j = 0; j < Deck.Hand2.Length; j++)
                {
                    if (Deck.Hand2[i].Contains("H") && Deck.Hand2[j].Contains("H") && i != j)
                    {
                        for (int k = 0; k < Deck.Hand2.Length; k++)
                        {
                            for (int l = 0; l < Deck.Hand2.Length; l++)
                            {
                                for (int m = 0; m < Deck.Hand2.Length; m++)
                                {
                                    if (P2Match == 0 && Deck.Hand2[k].Contains("D") && Deck.Hand2[l].Contains("D") && Deck.Hand2[m].Contains("D") && k != l && k != m && l != k && l != m && m != k && m != l)
                                    {
                                        P2Points += 12;
                                        P2Match = 1;
                                    }
                                    else if (P2Match == 0 && Deck.Hand2[k].Contains("C") && Deck.Hand2[l].Contains("C") && Deck.Hand2[m].Contains("C") && k != l && k != m && l != k && l != m && m != k && m != l)
                                    {
                                        P2Points += 12;
                                        P2Match = 1;
                                    }
                                    else if (P2Match == 0 && Deck.Hand2[k].Contains("S") && Deck.Hand2[l].Contains("S") && Deck.Hand2[m].Contains("S") && k != l && k != m && l != k && l != m && m != k && m != l)
                                    {
                                        P2Points += 12;
                                        P2Match = 1;
                                    }
                                }
                            }
                        }
                    }
                    if (Deck.Hand2[i].Contains("D") && Deck.Hand2[j].Contains("D") && i != j)
                    {
                        for (int k = 0; k < Deck.Hand2.Length; k++)
                        {
                            for (int l = 0; l < Deck.Hand2.Length; l++)
                            {
                                for (int m = 0; m < Deck.Hand2.Length; m++)
                                {
                                    if (P2Match == 0 && Deck.Hand2[k].Contains("H") && Deck.Hand2[l].Contains("H") && Deck.Hand2[m].Contains("H") && k != l && k != m && l != k && l != m && m != k && m != l)
                                    {
                                        P2Points += 12;
                                        P2Match = 1;
                                    }
                                    else if (P2Match == 0 && Deck.Hand2[k].Contains("C") && Deck.Hand2[l].Contains("C") && Deck.Hand2[m].Contains("C") && k != l && k != m && l != k && l != m && m != k && m != l)
                                    {
                                        P2Points += 12;
                                        P2Match = 1;
                                    }
                                    else if (P2Match == 0 && Deck.Hand2[k].Contains("S") && Deck.Hand2[l].Contains("S") && Deck.Hand2[m].Contains("S") && k != l && k != m && l != k && l != m && m != k && m != l)
                                    {
                                        P2Points += 12;
                                        P2Match = 1;
                                    }
                                }
                            }
                        }
                    }
                    if (Deck.Hand2[i].Contains("C") && Deck.Hand2[j].Contains("C") && i != j)
                    {
                        for (int k = 0; k < Deck.Hand2.Length; k++)
                        {
                            for (int l = 0; l < Deck.Hand2.Length; l++)
                            {
                                for (int m = 0; m < Deck.Hand2.Length; m++)
                                {
                                    if (P2Match == 0 && Deck.Hand2[k].Contains("H") && Deck.Hand2[l].Contains("H") && Deck.Hand2[m].Contains("H") && k != l && k != m && l != k && l != m && m != k && m != l)
                                    {
                                        P2Points += 12;
                                        P2Match = 1;
                                    }
                                    else if (P2Match == 0 && Deck.Hand2[k].Contains("D") && Deck.Hand2[l].Contains("D") && Deck.Hand2[m].Contains("D") && k != l && k != m && l != k && l != m && m != k && m != l)
                                    {
                                        P2Points += 12;
                                        P2Match = 1;
                                    }
                                    else if (P2Match == 0 && Deck.Hand2[k].Contains("S") && Deck.Hand2[l].Contains("S") && Deck.Hand2[m].Contains("S") && k != l && k != m && l != k && l != m && m != k && m != l)
                                    {
                                        P2Points += 12;
                                        P2Match = 1;
                                    }
                                }
                            }
                        }
                    }
                    if (Deck.Hand2[i].Contains("S") && Deck.Hand2[j].Contains("S") && i != j)
                    {
                        for (int k = 0; k < Deck.Hand2.Length; k++)
                        {
                            for (int l = 0; l < Deck.Hand2.Length; l++)
                            {
                                for (int m = 0; m < Deck.Hand2.Length; m++)
                                {
                                    if (P2Match == 0 && Deck.Hand2[k].Contains("H") && Deck.Hand2[l].Contains("H") && Deck.Hand2[m].Contains("H") && k != l && k != m && l != k && l != m && m != k && m != l)
                                    {
                                        P2Points += 12;
                                        P2Match = 1;
                                    }
                                    else if (P2Match == 0 && Deck.Hand2[k].Contains("C") && Deck.Hand2[l].Contains("C") && Deck.Hand2[m].Contains("C") && k != l && k != m && l != k && l != m && m != k && m != l)
                                    {
                                        P2Points += 12;
                                        P2Match = 1;
                                    }
                                    else if (P2Match == 0 && Deck.Hand2[k].Contains("D") && Deck.Hand2[l].Contains("D") && Deck.Hand2[m].Contains("D") && k != l && k != m && l != k && l != m && m != k && m != l)
                                    {
                                        P2Points += 12;
                                        P2Match = 1;
                                    }
                                }
                            }
                        }
                    }
                }
            }


        }

        /* Checks if a Deck.Hand array contains 5 cards that can be ordered in sequential rank  and applies points*/
        public void CheckStraight()
        {
            int P1Match = 0;
            int P2Match = 0;
            for (int i = 0; i < Deck.Hand1.Length; i++)
            {
                for (int j = 0; j < Deck.Hand1.Length; j++)
                {
                    for (int k = 0; k < Deck.Hand1.Length; k++)
                    {
                        for (int l = 0; l < Deck.Hand1.Length; l++)
                        {
                            for (int m = 0; m < Deck.Hand1.Length; m++)
                            {
                                if ((Deck.Hand1[i].Contains("@") && Deck.Hand1[j].Contains("2") && Deck.Hand1[k].Contains("3") && Deck.Hand1[l].Contains("4") && Deck.Hand1[m].Contains("5")) && i != j && i != k && i != l && j != k && j != l && k != l ||
                                    (Deck.Hand1[i].Contains("2") && Deck.Hand1[j].Contains("3") && Deck.Hand1[k].Contains("4") && Deck.Hand1[l].Contains("5") && Deck.Hand1[m].Contains("6")) && i != j && i != k && i != l && j != k && j != l && k != l ||
                                    (Deck.Hand1[i].Contains("3") && Deck.Hand1[j].Contains("4") && Deck.Hand1[k].Contains("5") && Deck.Hand1[l].Contains("6") && Deck.Hand1[m].Contains("7")) && i != j && i != k && i != l && j != k && j != l && k != l ||
                                    (Deck.Hand1[i].Contains("4") && Deck.Hand1[j].Contains("5") && Deck.Hand1[k].Contains("6") && Deck.Hand1[l].Contains("7") && Deck.Hand1[m].Contains("8")) && i != j && i != k && i != l && j != k && j != l && k != l ||
                                    (Deck.Hand1[i].Contains("5") && Deck.Hand1[j].Contains("6") && Deck.Hand1[k].Contains("7") && Deck.Hand1[l].Contains("8") && Deck.Hand1[m].Contains("9")) && i != j && i != k && i != l && j != k && j != l && k != l ||
                                    (Deck.Hand1[i].Contains("6") && Deck.Hand1[j].Contains("7") && Deck.Hand1[k].Contains("8") && Deck.Hand1[l].Contains("9") && Deck.Hand1[m].Contains("10")) && i != j && i != k && i != l && j != k && j != l && k != l ||
                                    (Deck.Hand1[i].Contains("7") && Deck.Hand1[j].Contains("8") && Deck.Hand1[k].Contains("9") && Deck.Hand1[l].Contains("10") && Deck.Hand1[m].Contains("J")) && i != j && i != k && i != l && j != k && j != l && k != l ||
                                    (Deck.Hand1[i].Contains("8") && Deck.Hand1[j].Contains("9") && Deck.Hand1[k].Contains("10") && Deck.Hand1[l].Contains("J") && Deck.Hand1[m].Contains("Q")) && i != j && i != k && i != l && j != k && j != l && k != l ||
                                    (Deck.Hand1[i].Contains("9") && Deck.Hand1[j].Contains("10") && Deck.Hand1[k].Contains("J") && Deck.Hand1[l].Contains("Q") && Deck.Hand1[m].Contains("K")) && i != j && i != k && i != l && j != k && j != l && k != l ||
                                    (Deck.Hand1[i].Contains("10") && Deck.Hand1[j].Contains("J") && Deck.Hand1[k].Contains("Q") && Deck.Hand1[l].Contains("K") && Deck.Hand1[m].Contains("@")) && i != j && i != k && i != l && j != k && j != l && k != l)
                                {
                                    P1Points += 10;
                                    P1Match = 1; // sets P1match to 1 so that the nesting for loops can be exited
                                    break;
                                }
                            }
                            if (P1Match == 1)
                            {
                                break;
                            }
                        }
                        if (P1Match == 1) // breaks from the k loop if a match has already been found
                        {
                            break;
                        }
                    }
                    if (P1Match == 1)
                    {
                        break;
                    }
                }
                if (P1Match == 1)
                {
                    break;
                }
            }
            for (int i = 0; i < Deck.Hand2.Length; i++)
            {
                for (int j = 0; j < Deck.Hand2.Length; j++)
                {
                    for (int k = 0; k < Deck.Hand2.Length; k++)
                    {
                        for (int l = 0; l < Deck.Hand2.Length; l++)
                        {
                            for (int m = 0; m < Deck.Hand2.Length; m++)
                            {
                                if ((Deck.Hand2[i].Contains("@") && Deck.Hand2[j].Contains("2") && Deck.Hand2[k].Contains("3") && Deck.Hand2[l].Contains("4") && Deck.Hand2[m].Contains("5")) && i != j && i != k && i != l && j != k && j != l && k != l ||
                                    (Deck.Hand2[i].Contains("2") && Deck.Hand2[j].Contains("3") && Deck.Hand2[k].Contains("4") && Deck.Hand2[l].Contains("5") && Deck.Hand2[m].Contains("6")) && i != j && i != k && i != l && j != k && j != l && k != l ||
                                    (Deck.Hand2[i].Contains("3") && Deck.Hand2[j].Contains("4") && Deck.Hand2[k].Contains("5") && Deck.Hand2[l].Contains("6") && Deck.Hand2[m].Contains("7")) && i != j && i != k && i != l && j != k && j != l && k != l ||
                                    (Deck.Hand2[i].Contains("4") && Deck.Hand2[j].Contains("5") && Deck.Hand2[k].Contains("6") && Deck.Hand2[l].Contains("7") && Deck.Hand2[m].Contains("8")) && i != j && i != k && i != l && j != k && j != l && k != l ||
                                    (Deck.Hand2[i].Contains("5") && Deck.Hand2[j].Contains("6") && Deck.Hand2[k].Contains("7") && Deck.Hand2[l].Contains("8") && Deck.Hand2[m].Contains("9")) && i != j && i != k && i != l && j != k && j != l && k != l ||
                                    (Deck.Hand2[i].Contains("6") && Deck.Hand2[j].Contains("7") && Deck.Hand2[k].Contains("8") && Deck.Hand2[l].Contains("9") && Deck.Hand2[m].Contains("10")) && i != j && i != k && i != l && j != k && j != l && k != l ||
                                    (Deck.Hand2[i].Contains("7") && Deck.Hand2[j].Contains("8") && Deck.Hand2[k].Contains("9") && Deck.Hand2[l].Contains("10") && Deck.Hand2[m].Contains("J")) && i != j && i != k && i != l && j != k && j != l && k != l ||
                                    (Deck.Hand2[i].Contains("8") && Deck.Hand2[j].Contains("9") && Deck.Hand2[k].Contains("10") && Deck.Hand2[l].Contains("J") && Deck.Hand2[m].Contains("Q")) && i != j && i != k && i != l && j != k && j != l && k != l ||
                                    (Deck.Hand2[i].Contains("9") && Deck.Hand2[j].Contains("10") && Deck.Hand2[k].Contains("J") && Deck.Hand2[l].Contains("Q") && Deck.Hand2[m].Contains("K")) && i != j && i != k && i != l && j != k && j != l && k != l ||
                                    (Deck.Hand2[i].Contains("10") && Deck.Hand2[j].Contains("J") && Deck.Hand2[k].Contains("Q") && Deck.Hand2[l].Contains("K") && Deck.Hand2[m].Contains("@")) && i != j && i != k && i != l && j != k && j != l && k != l)
                                {
                                    P2Points += 10;
                                    P2Match = 1; // sets P2match to 1 so that the nesting for loops can be exited
                                    break;
                                }
                            }
                            if (P2Match == 1) // breaks from the k loop if a match has already been found
                            {
                                break;
                            }
                        }
                        if (P2Match == 1) // breaks from the k loop if a match has already been found
                        {
                            break;
                        }
                    }
                    if (P2Match == 1)
                    {
                        break;
                    }
                }
                if (P2Match == 1)
                {
                    break;
                }
            }
        }

        /* Checks to see if four cards are of the same suit and applies points */
        public void CheckFlush()
        {
            int P1Match = 0;
            int P2Match = 0;
            for (int i = 0; i < Deck.Hand1.Length; i++)
            {
                for (int j = 0; j < Deck.Hand1.Length; j++)
                {
                    for (int k = 0; k < Deck.Hand1.Length; k++)
                    {
                        for (int l = 0; l < Deck.Hand1.Length; l++)
                        {
                            for (int m = 0; m < Deck.Hand1.Length; m++)
                            {
                                if (Deck.Hand1[i].Contains("H") && Deck.Hand1[j].Contains("H") && Deck.Hand1[k].Contains("H") && Deck.Hand1[l].Contains("H") && Deck.Hand1[m].Contains("H") && i != j && i != k && i != l && j != k && j != l && k != l ||
                                    Deck.Hand1[i].Contains("D") && Deck.Hand1[j].Contains("D") && Deck.Hand1[k].Contains("D") && Deck.Hand1[l].Contains("D") && Deck.Hand1[m].Contains("D") && i != j && i != k && i != l && j != k && j != l && k != l ||
                                    Deck.Hand1[i].Contains("C") && Deck.Hand1[j].Contains("C") && Deck.Hand1[k].Contains("C") && Deck.Hand1[l].Contains("C") && Deck.Hand1[m].Contains("C") && i != j && i != k && i != l && j != k && j != l && k != l ||
                                    Deck.Hand1[i].Contains("S") && Deck.Hand1[j].Contains("S") && Deck.Hand1[k].Contains("S") && Deck.Hand1[l].Contains("S") && Deck.Hand1[m].Contains("S") && i != j && i != k && i != l && j != k && j != l && k != l)
                                {
                                    P1Points += 8;
                                    P1Match = 1; // sets P1match to 1 so that the nesting for loops can be exited
                                    break;
                                }
                            }
                            if (P1Match == 1)
                            {
                                break;
                            }
                        }
                        if (P1Match == 1) // breaks from the k loop if a match has already been found
                        {
                            break;
                        }
                    }
                    if (P1Match == 1)
                    {
                        break;
                    }
                }
                if (P1Match == 1)
                {
                    break;
                }
            }
            for (int i = 0; i < Deck.Hand2.Length; i++)
            {
                for (int j = 0; j < Deck.Hand2.Length; j++)
                {
                    for (int k = 0; k < Deck.Hand2.Length; k++)
                    {
                        for (int l = 0; l < Deck.Hand2.Length; l++)
                        {
                            for (int m = 0; m < Deck.Hand2.Length; m++)
                            {
                                if ((Deck.Hand2[i].Contains("H") && Deck.Hand2[j].Contains("H") && Deck.Hand2[k].Contains("H") && Deck.Hand2[l].Contains("H") && Deck.Hand2[m].Contains("H")) && i != j && i != k && i != l && j != k && j != l && k != l ||
                                    (Deck.Hand2[i].Contains("D") && Deck.Hand2[j].Contains("D") && Deck.Hand2[k].Contains("D") && Deck.Hand2[l].Contains("D") && Deck.Hand2[m].Contains("D")) && i != j && i != k && i != l && j != k && j != l && k != l ||
                                    (Deck.Hand2[i].Contains("C") && Deck.Hand2[j].Contains("C") && Deck.Hand2[k].Contains("C") && Deck.Hand2[l].Contains("C") && Deck.Hand2[m].Contains("C")) && i != j && i != k && i != l && j != k && j != l && k != l ||
                                    (Deck.Hand2[i].Contains("S") && Deck.Hand2[j].Contains("S") && Deck.Hand2[k].Contains("S") && Deck.Hand2[l].Contains("S") && Deck.Hand2[m].Contains("S")) && i != j && i != k && i != l && j != k && j != l && k != l)
                                {
                                    P2Points += 8;
                                    P2Match = 1; // sets P2match to 1 so that the nesting for loops can be exited
                                    break;
                                }
                            }
                            if (P2Match == 1) // breaks from the k loop if a match has already been found
                            {
                                break;
                            }
                        }
                        if (P2Match == 1) // breaks from the k loop if a match has already been found
                        {
                            break;
                        }
                    }
                    if (P2Match == 1)
                    {
                        break;
                    }
                }
                if (P2Match == 1)
                {
                    break;
                }
            }


        }

        /* Uses nested for loops to check if four cards match and applies points. Sets appropriate Deck.Hand array values two zero if the conditions are met so that subsequent methods are rendered null*/
        public void CheckFourOfAKind()
        {
            int P1Match = 0;
            int P2Match = 0;
            for (int i = 0; i < Deck.Hand1.Length; i++)
            {
                for (int j = 0; j < Deck.Hand1.Length; j++)
                {
                    for (int k = 0; k < Deck.Hand1.Length; k++)
                    {
                        for (int l = 0; l < Deck.Hand1.Length; l++)
                        {
                            if (Deck.Hand1[i].Contains("@") && Deck.Hand1[j].Contains("@") && Deck.Hand1[k].Contains("@") && Deck.Hand1[l].Contains("@") && i != j && i != k && i != l && j != i && j != k && j != l && k != i && k != j && k != l && l != i && l != j && l != k || Deck.Hand1[i].Contains("2") && Deck.Hand1[j].Contains("2") && Deck.Hand1[k].Contains("2") && Deck.Hand1[l].Contains("2") && i != j && i != k && i != l && j != i && j != k && j != l && k != i && k != j && k != l && l != i && l != j && l != k ||
                                Deck.Hand1[i].Contains("3") && Deck.Hand1[j].Contains("3") && Deck.Hand1[k].Contains("3") && Deck.Hand1[l].Contains("3") && i != j && i != k && i != l && j != i && j != k && j != l && k != i && k != j && k != l && l != i && l != j && l != k || Deck.Hand1[i].Contains("4") && Deck.Hand1[j].Contains("4") && Deck.Hand1[k].Contains("4") && Deck.Hand1[l].Contains("4") && i != j && i != k && i != l && j != i && j != k && j != l && k != i && k != j && k != l && l != i && l != j && l != k ||
                                Deck.Hand1[i].Contains("5") && Deck.Hand1[j].Contains("5") && Deck.Hand1[k].Contains("5") && Deck.Hand1[l].Contains("5") && i != j && i != k && i != l && j != i && j != k && j != l && k != i && k != j && k != l && l != i && l != j && l != k || Deck.Hand1[i].Contains("6") && Deck.Hand1[j].Contains("6") && Deck.Hand1[k].Contains("6") && Deck.Hand1[l].Contains("6") && i != j && i != k && i != l && j != i && j != k && j != l && k != i && k != j && k != l && l != i && l != j && l != k ||
                                Deck.Hand1[i].Contains("7") && Deck.Hand1[j].Contains("7") && Deck.Hand1[k].Contains("7") && Deck.Hand1[l].Contains("7") && i != j && i != k && i != l && j != i && j != k && j != l && k != i && k != j && k != l && l != i && l != j && l != k || Deck.Hand1[i].Contains("8") && Deck.Hand1[j].Contains("8") && Deck.Hand1[k].Contains("8") && Deck.Hand1[l].Contains("8") && i != j && i != k && i != l && j != i && j != k && j != l && k != i && k != j && k != l && l != i && l != j && l != k ||
                                Deck.Hand1[i].Contains("9") && Deck.Hand1[j].Contains("9") && Deck.Hand1[k].Contains("9") && Deck.Hand1[l].Contains("9") && i != j && i != k && i != l && j != i && j != k && j != l && k != i && k != j && k != l && l != i && l != j && l != k || Deck.Hand1[i].Contains("10") && Deck.Hand1[j].Contains("10") && Deck.Hand1[k].Contains("10") && Deck.Hand1[l].Contains("10") && i != j && i != k && i != l && j != i && j != k && j != l && k != i && k != j && k != l && l != i && l != j && l != k ||
                                Deck.Hand1[i].Contains("J") && Deck.Hand1[j].Contains("J") && Deck.Hand1[k].Contains("J") && Deck.Hand1[l].Contains("J") && i != j && i != k && i != l && j != i && j != k && j != l && k != i && k != j && k != l && l != i && l != j && l != k || Deck.Hand1[i].Contains("Q") && Deck.Hand1[j].Contains("Q") && Deck.Hand1[k].Contains("Q") && Deck.Hand1[l].Contains("Q") && i != j && i != k && i != l && j != i && j != k && j != l && k != i && k != j && k != l && l != i && l != j && l != k ||
                                Deck.Hand1[i].Contains("K") && Deck.Hand1[j].Contains("K") && Deck.Hand1[k].Contains("K") && Deck.Hand1[l].Contains("K") && i != j && i != k && i != l && j != i && j != k && j != l && k != i && k != j && k != l && l != i && l != j && l != k)
                            {
                                P1Points += 4;

                                /* Sets the mathing card values to be different so that other methods including these values will be rendered null and since pair needs to be called twice to check for two pairs, the same match wont be caught twice */
                                Deck.Hand1[i] = "a";
                                Deck.Hand1[j] = "b";

                                P1Match = 1;
                                break;
                            }
                        }
                        if (P1Match == 1)
                        {
                            break;
                        }
                    }

                    if (P1Match == 1)
                    {
                        break;
                    }
                }
                P1Match = 1;
                break;
            }
            for (int i = 0; i < Deck.Hand2.Length; i++)
            {
                for (int j = 0; j < Deck.Hand2.Length; j++)
                {
                    for (int k = 0; k < Deck.Hand2.Length; k++)
                    {
                        for (int l = 0; l < Deck.Hand2.Length; l++)
                        {
                            if (Deck.Hand2[i].Contains("@") && Deck.Hand2[j].Contains("@") && Deck.Hand2[k].Contains("@") && Deck.Hand2[l].Contains("@") && i != j && i != k && i != l && j != i && j != k && j != l && k != i && k != j && k != l && l != i && l != j && l != k || Deck.Hand2[i].Contains("2") && Deck.Hand2[j].Contains("2") && Deck.Hand2[k].Contains("2") && Deck.Hand2[l].Contains("2") && i != j && i != k && i != l && j != i && j != k && j != l && k != i && k != j && k != l && l != i && l != j && l != k ||
                                Deck.Hand2[i].Contains("3") && Deck.Hand2[j].Contains("3") && Deck.Hand2[k].Contains("3") && Deck.Hand2[l].Contains("3") && i != j && i != k && i != l && j != i && j != k && j != l && k != i && k != j && k != l && l != i && l != j && l != k || Deck.Hand2[i].Contains("4") && Deck.Hand2[j].Contains("4") && Deck.Hand2[k].Contains("4") && Deck.Hand2[l].Contains("4") && i != j && i != k && i != l && j != i && j != k && j != l && k != i && k != j && k != l && l != i && l != j && l != k ||
                                Deck.Hand2[i].Contains("5") && Deck.Hand2[j].Contains("5") && Deck.Hand2[k].Contains("5") && Deck.Hand2[l].Contains("5") && i != j && i != k && i != l && j != i && j != k && j != l && k != i && k != j && k != l && l != i && l != j && l != k || Deck.Hand2[i].Contains("6") && Deck.Hand2[j].Contains("6") && Deck.Hand2[k].Contains("6") && Deck.Hand2[l].Contains("6") && i != j && i != k && i != l && j != i && j != k && j != l && k != i && k != j && k != l && l != i && l != j && l != k ||
                                Deck.Hand2[i].Contains("7") && Deck.Hand2[j].Contains("7") && Deck.Hand2[k].Contains("7") && Deck.Hand2[l].Contains("7") && i != j && i != k && i != l && j != i && j != k && j != l && k != i && k != j && k != l && l != i && l != j && l != k || Deck.Hand2[i].Contains("8") && Deck.Hand2[j].Contains("8") && Deck.Hand2[k].Contains("8") && Deck.Hand2[l].Contains("8") && i != j && i != k && i != l && j != i && j != k && j != l && k != i && k != j && k != l && l != i && l != j && l != k ||
                                Deck.Hand2[i].Contains("9") && Deck.Hand2[j].Contains("9") && Deck.Hand2[k].Contains("9") && Deck.Hand2[l].Contains("9") && i != j && i != k && i != l && j != i && j != k && j != l && k != i && k != j && k != l && l != i && l != j && l != k || Deck.Hand2[i].Contains("10") && Deck.Hand2[j].Contains("10") && Deck.Hand2[k].Contains("10") && Deck.Hand2[l].Contains("10") && i != j && i != k && i != l && j != i && j != k && j != l && k != i && k != j && k != l && l != i && l != j && l != k ||
                                Deck.Hand2[i].Contains("J") && Deck.Hand2[j].Contains("J") && Deck.Hand2[k].Contains("J") && Deck.Hand2[l].Contains("J") && i != j && i != k && i != l && j != i && j != k && j != l && k != i && k != j && k != l && l != i && l != j && l != k || Deck.Hand2[i].Contains("Q") && Deck.Hand2[j].Contains("Q") && Deck.Hand2[k].Contains("Q") && Deck.Hand2[l].Contains("Q") && i != j && i != k && i != l && j != i && j != k && j != l && k != i && k != j && k != l && l != i && l != j && l != k ||
                                Deck.Hand2[i].Contains("K") && Deck.Hand2[j].Contains("K") && Deck.Hand2[k].Contains("K") && Deck.Hand2[l].Contains("K") && i != j && i != k && i != l && j != i && j != k && j != l && k != i && k != j && k != l && l != i && l != j && l != k)
                            {
                                P2Points += 4;

                                /* Sets the mathing card values to be different so that other methods including these values will be rendered null and since pair needs to be called twice to check for two pairs, the same match wont be caught twice */
                                Deck.Hand2[i] = "a";
                                Deck.Hand2[j] = "b";

                                P2Match = 1;
                                break;
                            }
                        }
                        if (P2Match == 1)
                        {
                            break;
                        }
                    }

                    if (P2Match == 1)
                    {
                        break;
                    }
                }
            }
        }

        /* Uses nested for/while loops to check if three cards match and applies points. Sets appropriate Deck.Hand array values two zero if the conditions are met so that subsequent methods are rendered null*/
        public void CheckThreeOfAKind()
        {
            int P1Match = 0;
            int P2Match = 0;
            for (int i = 0; i < Deck.Hand1.Length; i++)
            {
                for (int j = 0; j < Deck.Hand1.Length; j++)
                {
                    for (int k = 0; k < Deck.Hand1.Length; k++)
                    {
                        if (Deck.Hand1[i].Contains("@") && Deck.Hand1[j].Contains("@") && Deck.Hand1[k].Contains("@") && i != j && i != k && j != i && j != k && k != i && k != j || Deck.Hand1[i].Contains("2") && Deck.Hand1[j].Contains("2") && Deck.Hand1[k].Contains("2") && i != j && i != k && j != i && j != k && k != i && k != j ||
                            Deck.Hand1[i].Contains("3") && Deck.Hand1[j].Contains("3") && Deck.Hand1[k].Contains("3") && i != j && i != k && j != i && j != k && k != i && k != j || Deck.Hand1[i].Contains("4") && Deck.Hand1[j].Contains("4") && Deck.Hand1[k].Contains("4") && i != j && i != k && j != i && j != k && k != i && k != j ||
                            Deck.Hand1[i].Contains("5") && Deck.Hand1[j].Contains("5") && Deck.Hand1[k].Contains("5") && i != j && i != k && j != i && j != k && k != i && k != j || Deck.Hand1[i].Contains("6") && Deck.Hand1[j].Contains("6") && Deck.Hand1[k].Contains("6") && i != j && i != k && j != i && j != k && k != i && k != j ||
                            Deck.Hand1[i].Contains("7") && Deck.Hand1[j].Contains("7") && Deck.Hand1[k].Contains("7") && i != j && i != k && j != i && j != k && k != i && k != j || Deck.Hand1[i].Contains("8") && Deck.Hand1[j].Contains("8") && Deck.Hand1[k].Contains("8") && i != j && i != k && j != i && j != k && k != i && k != j ||
                            Deck.Hand1[i].Contains("9") && Deck.Hand1[j].Contains("9") && Deck.Hand1[k].Contains("9") && i != j && i != k && j != i && j != k && k != i && k != j || Deck.Hand1[i].Contains("10") && Deck.Hand1[j].Contains("10") && Deck.Hand1[k].Contains("10") && i != j && i != k && j != i && j != k && k != i && k != j ||
                            Deck.Hand1[i].Contains("J") && Deck.Hand1[j].Contains("J") && Deck.Hand1[k].Contains("J") && i != j && i != k && j != i && j != k && k != i && k != j || Deck.Hand1[i].Contains("Q") && Deck.Hand1[j].Contains("Q") && Deck.Hand1[k].Contains("Q") && i != j && i != k && j != i && j != k && k != i && k != j ||
                            Deck.Hand1[i].Contains("K") && Deck.Hand1[j].Contains("K") && Deck.Hand1[k].Contains("K") && i != j && i != k && j != i && j != k && k != i && k != j)
                        {
                            P1Points += 3;

                            /* Sets the mathing card values to be different so that other methods including these values will be rendered null and since pair needs to be called twice to check for two pairs, the same match wont be caught twice */
                            Deck.Hand1[i] = "c";
                            Deck.Hand1[j] = "d";

                            P1Match = 1;
                            break;
                        }
                    }

                    if (P1Match == 1)
                    {
                        break;
                    }
                }
                if (P1Match == 1)
                break;
            }
            for (int i = 0; i < Deck.Hand2.Length; i++)
            {
                for (int j = 0; j < Deck.Hand2.Length; j++)
                {
                    for (int k = 0; k < Deck.Hand2.Length; k++)
                    {
                        if (Deck.Hand2[i].Contains("@") && Deck.Hand2[j].Contains("@") && Deck.Hand2[k].Contains("@") && i != j && i != k && j != i && j != k && k != i && k != j || Deck.Hand2[i].Contains("2") && Deck.Hand2[j].Contains("2") && Deck.Hand2[k].Contains("2") && i != j && i != k && j != i && j != k && k != i && k != j ||
                            Deck.Hand2[i].Contains("3") && Deck.Hand2[j].Contains("3") && Deck.Hand2[k].Contains("3") && i != j && i != k && j != i && j != k && k != i && k != j || Deck.Hand2[i].Contains("4") && Deck.Hand2[j].Contains("4") && Deck.Hand2[k].Contains("4") && i != j && i != k && j != i && j != k && k != i && k != j ||
                            Deck.Hand2[i].Contains("5") && Deck.Hand2[j].Contains("5") && Deck.Hand2[k].Contains("5") && i != j && i != k && j != i && j != k && k != i && k != j || Deck.Hand2[i].Contains("6") && Deck.Hand2[j].Contains("6") && Deck.Hand2[k].Contains("6") && i != j && i != k && j != i && j != k && k != i && k != j ||
                            Deck.Hand2[i].Contains("7") && Deck.Hand2[j].Contains("7") && Deck.Hand2[k].Contains("7") && i != j && i != k && j != i && j != k && k != i && k != j || Deck.Hand2[i].Contains("8") && Deck.Hand2[j].Contains("8") && Deck.Hand2[k].Contains("8") && i != j && i != k && j != i && j != k && k != i && k != j ||
                            Deck.Hand2[i].Contains("9") && Deck.Hand2[j].Contains("9") && Deck.Hand2[k].Contains("9") && i != j && i != k && j != i && j != k && k != i && k != j || Deck.Hand2[i].Contains("10") && Deck.Hand2[j].Contains("10") && Deck.Hand2[k].Contains("10") && i != j && i != k && j != i && j != k && k != i && k != j ||
                            Deck.Hand2[i].Contains("J") && Deck.Hand2[j].Contains("J") && Deck.Hand2[k].Contains("J") && i != j && i != k && j != i && j != k && k != i && k != j || Deck.Hand2[i].Contains("Q") && Deck.Hand2[j].Contains("Q") && Deck.Hand2[k].Contains("Q") && i != j && i != k && j != i && j != k && k != i && k != j ||
                            Deck.Hand2[i].Contains("K") && Deck.Hand2[j].Contains("K") && Deck.Hand2[k].Contains("K") && i != j && i != k && j != i && j != k && k != i && k != j)
                        {
                            P2Points += 3;

                            /* Sets the mathing card values to be different so that other methods including these values will be rendered null and since pair needs to be called twice to check for two pairs, the same match wont be caught twice */
                            Deck.Hand2[i] = "c";
                            Deck.Hand2[j] = "d";

                            P2Match = 1;
                            break;
                        }
                    }

                    if (P2Match == 1)
                    {
                        break;
                    }
                }
                if (P2Match == 1)
                break;
            }
        }

        /* Uses nested for/while loops to check if two cards match and applies points. Sets appropriate Deck.Hand array values two zero if the conditions are met so that subsequent methods are rendered null. will be called twice to check for two pairs*/
        public void CheckPair()
        {
            int P1Match = 0;
            int P2Match = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (Deck.Hand1[i].Contains("@") && Deck.Hand1[j].Contains("@") && i != j && j != i || Deck.Hand1[i].Contains("2") && Deck.Hand1[j].Contains("2") && i != j && j != i ||
                        Deck.Hand1[i].Contains("3") && Deck.Hand1[j].Contains("3") && i != j && j != i || Deck.Hand1[i].Contains("4") && Deck.Hand1[j].Contains("4") && i != j && j != i || Deck.Hand1[i].Contains("5") && Deck.Hand1[j].Contains("5") && i != j && j != i ||
                        Deck.Hand1[i].Contains("6") && Deck.Hand1[j].Contains("6") && i != j && j != i || Deck.Hand1[i].Contains("7") && Deck.Hand1[j].Contains("7") && i != j && j != i || Deck.Hand1[i].Contains("8") && Deck.Hand1[j].Contains("8") && i != j && j != i ||
                        Deck.Hand1[i].Contains("9") && Deck.Hand1[j].Contains("9") && i != j && j != i || Deck.Hand1[i].Contains("10") && Deck.Hand1[j].Contains("10") && i != j && j != i || Deck.Hand1[i].Contains("J") && Deck.Hand1[j].Contains("J") && i != j && j != i ||
                        Deck.Hand1[i].Contains("Q") && Deck.Hand1[j].Contains("Q") && i != j && j != i || Deck.Hand1[i].Contains("K") && Deck.Hand1[j].Contains("K") && i != j && j != i)
                    {
                        P1Points += 1;

                        /* Sets the mathing card values to be different so that other methods including these values will be rendered null and since pair needs to be called twice to check for two pairs, the same match wont be caught twice */
                        Deck.Hand1[i] = "e";
                        Deck.Hand1[j] = "f";

                        P1Match = 1;
                        break;
                    }                    
                }
                if (P1Match == 1)
                {
                    break;
                }
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (Deck.Hand2[i].Contains("@") && Deck.Hand2[j].Contains("@") && i != j && j != i || Deck.Hand2[i].Contains("2") && Deck.Hand2[j].Contains("2") && i != j && j != i ||
                        Deck.Hand2[i].Contains("3") && Deck.Hand2[j].Contains("3") && i != j && j != i || Deck.Hand2[i].Contains("4") && Deck.Hand2[j].Contains("4") && i != j && j != i || Deck.Hand2[i].Contains("5") && Deck.Hand2[j].Contains("5") && i != j && j != i ||
                        Deck.Hand2[i].Contains("6") && Deck.Hand2[j].Contains("6") && i != j && j != i || Deck.Hand2[i].Contains("7") && Deck.Hand2[j].Contains("7") && i != j && j != i || Deck.Hand2[i].Contains("8") && Deck.Hand2[j].Contains("8") && i != j && j != i ||
                        Deck.Hand2[i].Contains("9") && Deck.Hand2[j].Contains("9") && i != j && j != i || Deck.Hand2[i].Contains("10") && Deck.Hand2[j].Contains("10") && i != j && j != i || Deck.Hand2[i].Contains("J") && Deck.Hand2[j].Contains("J") && i != j && j != i ||
                        Deck.Hand2[i].Contains("Q") && Deck.Hand2[j].Contains("Q") && i != j && j != i || Deck.Hand2[i].Contains("K") && Deck.Hand2[j].Contains("K") && i != j && j != i)
                    {
                        P2Points += 1;

                        /* Sets the mathing card values to be different so that other methods including these values will be rendered null and since pair needs to be called twice to check for two pairs, the same match wont be caught twice */
                        Deck.Hand2[i] = "e";
                        Deck.Hand2[j] = "f";

                        P2Match = 1;
                        break;
                    }
                }
                if (P2Match == 1)
                {
                    break;
                }
            }
        }

        public int CheckWinner()
        {
            if (P1Points > P2Points)
            {
                return 1;
            }
            else if (P1Points < P2Points)
            {
                return 2;
            }
            else
                return 0;

        }

        public int GetP1Points()
        {

            return P1Points;
        }
        public int GetP2Points()
        {

            return P2Points;
        }

    }
}

