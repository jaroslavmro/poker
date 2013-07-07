using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerEditor
{
    class Best_Hand
    {
        public int[] wartość_kart = new int[] { 0, 0, 0, 0, 0, 0 };
        //public int[] Wartość_kart
        //{
        //    get { return wartość_kart; }
        //    set { wartość_kart = value; }
        //}
        public int[] numery = new int[5];
        public int[] kolory = new int[5];
        public Card[] Cards;

        public Best_Hand(Card[] karty)
        {
            //int[] numery = new int[5];
            //int[] kolory = new int[5];
            this.Cards = karty;
            for (int i = 0; i < 5; i++)
            {
                numery[i] = Cards[i].Numer;
                kolory[i] = Cards[i].Kolor;
            }
            HandValue();
           
            //Royal flush	straight from A to 10 and Flush                  10,0,0,0,0,0
            //Straight flush straight and Flush                              9,(lowest card, 0 , 0 , 0 ,0)
            //Four of a kind	4 of the same number                         8,(number of 4 cards, other card, 0 , 0 ,0)
            //Full house	    3 of same number and 2 of other same number  7,(number of 3 cards, number of 2 , 0 , 0 , 0)
            //Flush	            5 of same color                              6,(highest card, Lower , lower, lower, lowest)
            //Straight	        5 kolejnych liczb                            5,(lowest card, 0 , 0 , 0 , 0)
            //Three of a kind	3 of same number                             4,(number of 3 cards, Higher of 2 other, lower of two other, 0 , 0) 
            //Two pair	        2 of same number and 2 of other same number  3 (number of higher pair, number of lower pair, 5th card , 0 , 0)
            //One pair          2 of same number                             2,(number of pair, highest of 3 , medium , lowest of 3, 0)
            //No pair	        no pair value of highest card;         value 1, (highest card, Lower , lower, lower, lowest)
        }
        public void HandValue()
        {
            
            Array.Sort(numery);
            for (int i = 0; i < 2; i++)
            {
                var a = numery[4 - i];
                numery[4 - i] = numery[i];
                numery[i] = a;
            }
            Array.Sort(kolory);
            var nowyWynik = CardValue(numery, kolory);
            for (int i = 0; i < 6; i++)
            {
                if (wartość_kart[i] > nowyWynik[i])
                {
                    break;
                }
                else if (wartość_kart[i] < nowyWynik[i])
                {
                    wartość_kart = nowyWynik;
                    break;
                }
            }
        }
        public bool isStraight(int[] numery)
        {
            var b = false;
            if (numery[0] == 14 && numery[4] != 1)
            {
                int[] numery2 = new int[5];
                for (int i = 0; i < 5; i++)
                {
                    numery2[i] = numery[i];
                }                
                numery2[0] = 1;
                Array.Sort(numery2);
                for (int i = 0; i < 2; i++)
                {
                    var a = numery2[4 - i];
                    numery2[4 - i] = numery2[i];
                    numery2[i] = a;
                }
                b = isStraight(numery2);
            }
            var num = 0;
            while (num < 4 && numery[num] == numery[num + 1] + 1)
            {
                num++;
                if (num == 4)
                {
                    b = true;
                }
            }
            return b;
        }
        public bool isFlush(int[] kolory)
        {
            return kolory[0] == kolory[4];
        }
        public bool isFourOfKind(int[] numery)
        {
            return numery[0] == numery[3] || numery[1] == numery[4];
        }
        public bool isFullHouse(int[] numery)
        {
            return (numery[0] == numery[2] && numery[3] == numery[4]) || (numery[0] == numery[1] && numery[2] == numery[4]);
        }
        public bool isThreeOfKind(int[] numery)
        {
            return (numery[0] == numery[2]) || (numery[1] == numery[3]) || (numery[2] == numery[4]);
        }
        public bool isTwoPair(int[] numery)
        {
            return (numery[0] == numery[1] && numery[2] == numery[3]) || (numery[1] == numery[2] && numery[3] == numery[4]) || (numery[0] == numery[1] && numery[3] == numery[4]);
        }
        public bool isPair(int[] numery)
        {
            return numery[0] == numery[1] || numery[2] == numery[3] || numery[1] == numery[2] || numery[3] == numery[4];
        }
        public int[] CardValue(int[] numery, int[] kolory)
        {
            int[] wartość_kart2 = new int[] { 0, 0, 0, 0, 0, 0 };
            bool straight = isStraight(numery);
            bool flush = isFlush(kolory);
            if (straight && flush)
            {
                if (numery[4] == 10)
                {
                    wartość_kart2[0] = 10;
                }
                else
                {
                    wartość_kart2[0] = 9;
                    if (numery[0] == 14 && numery[4] == 2)
                    {
                        wartość_kart2[1] = numery[0] %13;
                    }
                    else
                    {
                        wartość_kart2[1] = numery[4];
                    }                    
                }
                return wartość_kart2;
            }
            bool FourOfKind = isFourOfKind(numery);
            if (FourOfKind)
            {
                wartość_kart2[0] = 8;
                wartość_kart2[1] = numery[2];
                if (numery[0] == numery[2])
                {
                    wartość_kart2[2] = numery[4];
                }
                else
                {
                    wartość_kart2[2] = numery[0];
                }
                return wartość_kart2;
            }
            bool FullHouse = isFullHouse(numery);
            if (FullHouse)
            {
                wartość_kart2[0] = 7;
                wartość_kart2[1] = numery[2];
                if (numery[0] == numery[2])
                {
                    wartość_kart2[2] = numery[4];
                }
                else
                {
                    wartość_kart2[2] = numery[0];
                }
                return wartość_kart2;
            }
            if (flush)
            {
                wartość_kart2[0] = 6;
                for (int i = 1; i < 6; i++)
                {
                    wartość_kart2[i] = numery[i - 1];
                }
                return wartość_kart2;
            }
            if (straight)
            {
                wartość_kart2[0] = 5;
                if (numery[0] == 14  && numery[4] == 2)
                {
                    wartość_kart2[1] = numery[0] %13;
                }
                else
                {
                    wartość_kart2[1] = numery[4];
                }                                
                return wartość_kart2;
            }
            bool ThreeOfKind = isThreeOfKind(numery);
            if (ThreeOfKind)
            {
                wartość_kart2[0] = 4;
                wartość_kart2[1] = numery[2];
                if (numery[0] == numery[2])
                {
                    wartość_kart2[2] = numery[3];
                    wartość_kart2[3] = numery[4];
                }
                else if (numery[1] == numery[3])
                {
                    wartość_kart2[2] = numery[0];
                    wartość_kart2[3] = numery[4];
                }
                else
                {
                    wartość_kart2[2] = numery[0];
                    wartość_kart2[3] = numery[1];
                }
                return wartość_kart2;
            }
            bool TwoPair = isTwoPair(numery);
            if (TwoPair)
            {
                wartość_kart2[0] = 3;
                wartość_kart2[1] = numery[1];
                wartość_kart2[2] = numery[3];
                if (numery[0] == numery[1] && numery[2] == numery[3])
                {
                    wartość_kart2[3] = numery[4];
                }
                else if ((numery[1] == numery[2] && numery[3] == numery[4]))
                {
                    wartość_kart2[3] = numery[0];
                }
                else
                {
                    wartość_kart2[3] = numery[2];
                }
                return wartość_kart2;
            }
            bool Pair = isPair(numery);
            if (Pair)
            {
                wartość_kart2[0] = 2;
                if (numery[0] == numery[1])
                {
                    wartość_kart2[1] = numery[0];
                    wartość_kart2[2] = numery[2];
                    wartość_kart2[3] = numery[3];
                    wartość_kart2[4] = numery[4];
                }
                else if (numery[2] == numery[3])
                {
                    wartość_kart2[1] = numery[2];
                    wartość_kart2[2] = numery[0];
                    wartość_kart2[3] = numery[1];
                    wartość_kart2[4] = numery[4];
                }
                else if (numery[1] == numery[2])
                {
                    wartość_kart2[1] = numery[1];
                    wartość_kart2[2] = numery[0];
                    wartość_kart2[3] = numery[3];
                    wartość_kart2[4] = numery[4];
                }
                else
                {
                    wartość_kart2[1] = numery[3];
                    wartość_kart2[2] = numery[0];
                    wartość_kart2[3] = numery[1];
                    wartość_kart2[4] = numery[2];
                }
                return wartość_kart2;
            }
            wartość_kart2[0] = 1;
            for (int i = 0; i < 5; i++)
            {
                wartość_kart2[i + 1] = numery[i];
            }
             return wartość_kart2;
        }


    }
}
