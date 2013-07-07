using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokerEditor
{
    public class Player
    {
        private string name;
        public string Name
        {
            get { return name; }
        }
        private int stack;
        public int Stack
        {
            get { return stack; }
            set { stack = value; }
        }
        public bool InGame = true;
        private bool isHero;
        public bool IsHero
        {
            get { return isHero; }
        }
        private int reservedMoney;
        public int ReservedMoney
        {
            get { return reservedMoney; }
            set { reservedMoney = value; }
        }
        public Card[] cards = new Card[2];
        public NumericUpDown numeric;
        public Label reserved;
        public Player(string name, int stack, bool isHero, NumericUpDown numeric, Label reserved)
        {
            this.name = name;
            this.stack = stack;
            this.isHero = isHero;
            this.numeric = numeric;
            this.reserved = reserved;
        }
        public Player()
        {
        }
        public Player CopyPlayer(Player player)
        {
            var newPlayer = new Player(player.Name, player.Stack, player.IsHero, player.numeric, player.reserved);
            newPlayer.InGame = player.InGame;
            for (int i = 0; i < player.cards.Length; i++)
            {
                newPlayer.cards[i] = player.cards[i];
            }
            newPlayer.reservedMoney = player.reservedMoney;
            return newPlayer;
        }   
    }
}
