using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PokerEditor
{
    public class Card
    {
        private string name;
        public string Getname()
        {
            return name;
        }
        private int kolor;
        public int Kolor
        {
           get{ return kolor;}
        }
        private int numer;
        public int Numer{
            get { return numer; }
        }
        private bool canBeUsed = true;
        public bool CanBeUsed
        {
            get { return canBeUsed; }
            set { canBeUsed = value; }
        }
        private bool reserved = false;
        public bool Reserved
        {
            get { return reserved; }
            set { reserved = value; }
        }
        public Image image;

        
        public Card(int number)
        {
            kolor = number / 13;
            numer = number % 13;
            name = Number(numer, kolor);
            if (numer == 1)
            {
                numer = 14;
            }
            if (numer == 0)
            {
                numer = 13;
            }

        }
        public Card(string str)
        {
            var str2 = str.ToCharArray();
            var score = 0;
            if (str[0] == 'A')
            {
                score = 1;
            }
            else if (str[0] == 'K')
            {
                score = 13;
            }
            else if (str[0] == 'Q')
            {
                score = 12;
            }
            else if (str[0] == 'J')
            {
                score = 11;
            }
            else
            {
                score = Convert.ToInt32(str[0]);
            }
            if (str[1] == 'S')
            {              
            }
            else if (str[1] == 'H')
            {
                score = 13 + score;
            }
            else if (str[1] == 'D')
            {
                score = 2 * 13 + score;

            }
            else if (str[1] == 'C')
            {
                score = 39 + score;
            }


            kolor = score / 13;
            numer = score % 13;
            name = Number(numer, kolor);
            if (numer == 1)
            {
                numer = 14;
            }
            if (numer == 0)
            {
                numer = 13;
            }


        }

        private string Number(int number , int kolor)
        {
            
            var a = "";
            var b = "";
            if (number == 1)
            {
                a = "A";
            }
            else if (number ==11)
	{
        a = "J";
	}
            else if (number == 12)
            {
                a = "Q";

            }
            else if (number == 0)
            {
                a = "K";
            }
            else
            {
                a = number.ToString();              

            }
            if (kolor == 0)
            {
                b = "S";
            }
            else if (kolor == 1)
            {
                b = "H";
            }
            else if (kolor == 2)
            {
                b = "D";
            }
            else
            {
                b = "C";
            }

            return a + b;

        }
        public Card CopyCard(Card card)
        {
            var newCard = new Card(card.kolor * 13 + (card.numer % 13));
            newCard.canBeUsed = card.CanBeUsed;
            return newCard;
        }


    }
}
