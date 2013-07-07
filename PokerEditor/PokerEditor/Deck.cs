using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerEditor
{
    public class Deck
    {
        public int [] deck = new int[52];
        public Card[] cards = new Card[52];
        private void NewDeck()
        {
            for (int i = 0; i < 52; i++)
            {
                deck[i] = i + 1;
                cards[i] = new Card(i);
            }
        }
        public Deck()
        {
            NewDeck();

        }
       

        private void ShuffleDeck()
        {
            var rand = new Random();
            // algorytm Fisher - Yates'a 
            // shuffle
            for (int i = 0; i < 51; i++)
            { var k = rand.Next(0, 52 - i);
                var m = deck[k];
                for (int j = k+1; j < 52; j++)
                {
                    var r = deck[j];
                    deck[j-1] = r;
                    deck[j] = m;
                }                
            }
        }
        public void ZbudujDeck()
        {
            NewDeck();
            ShuffleDeck();
        }
        public Card TakeOneCard ()
        {
            
            var m = deck[0];
            var card = new Card(m);
            for (int j = 1; j < 52; j++)
            {
                var r = deck[j];
                deck[j - 1] = r;
                deck[j] = m;
            }

            return card;
        }
        public Deck CopyDeck(Deck deck)
        {
            var newDeck = new Deck();

            for (int i = 0; i < deck.cards.Length; i++)
            {
                newDeck.cards[i] = deck.cards[i].CopyCard(deck.cards[i]);
            }
            return newDeck;

        }



    }
}
