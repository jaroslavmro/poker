using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokerEditor
{
    public class Game
    {
        public Player[] players;
        private int state = 1;
        public int State
        {
            get { return state; }
            set { state = value; }
        }
        public Card[] tableCards;
        public Deck deck;
        private int pot = 0;
        private int CallCount = 0;
        public int callCount
        {
            get { return CallCount; }
            set { CallCount = value; }
        }
        private int BigBlind;
        public int bigBlind
        {
            get { return BigBlind; }
        }
        private int SmallBlind;
        public int smallBlind
        {
            get { return SmallBlind; }
        }
        private int CurrentStake;
        public int currentStake
        {
            get { return CurrentStake; }
            set { CurrentStake = value; }
        }
        private int reRaiseValue;
        public int ReRaiseValue
        {
            get { return reRaiseValue; }
            set { reRaiseValue = value; }
        }
        private int Position = 3;
        private int PlayersInGame;
        public int playersInGame
        {
            get { return PlayersInGame; }
        }
        public Label PotLabel;
        public int Pot
        {
            get { return pot; }
            set { pot = value; }
        }
        public Game(Player[] players, Deck deck, int[] blinds,Label PotLabel)
        {
            this.players = players;
            this.deck = deck;
            this.BigBlind = blinds[1];
            this.SmallBlind = blinds[0];
            this.PotLabel = PotLabel;
            CurrentStake = BigBlind;
            reRaiseValue = 2 * BigBlind;
            this.PlayersInGame = players.Length;
            this.tableCards = new Card[5];
        }
        public void MakeFold(Player player)
        {
            player.InGame = false;
            Position++;
            PlayersInGame--;
        }
        public void MakeCall(Player player)
        {
            pot += CurrentStake - player.ReservedMoney;
            PotLabel.Text = pot.ToString();
            player.Stack -= CurrentStake - player.ReservedMoney;
            player.numeric.Value = player.Stack;
            player.ReservedMoney = CurrentStake;
            player.reserved.Text = player.ReservedMoney.ToString();
            CallCount++;
            Position++;
        }
        public void MakeRaise(Player player, int RaiseValue)
        {
            reRaiseValue = 2 * RaiseValue - CurrentStake;
            CurrentStake = RaiseValue;
            pot += CurrentStake - player.ReservedMoney;
            PotLabel.Text = pot.ToString();
            player.Stack -= CurrentStake - player.ReservedMoney;
            player.numeric.Value = player.Stack;
            player.ReservedMoney = CurrentStake;
            player.reserved.Text = player.ReservedMoney.ToString();
            CallCount = 1;
            Position++;

        }
        public void PostBlind()
        {
            if (players.Length > 2 )
            {
                players[1].ReservedMoney = SmallBlind;
                players[1].Stack -= SmallBlind;
                players[2].ReservedMoney = BigBlind;
                players[2].Stack -= BigBlind;
                pot = SmallBlind + BigBlind;
                players[1].numeric.Value = players[1].Stack;
                players[2].numeric.Value = players[2].Stack;
                players[1].reserved.Text = players[1].ReservedMoney.ToString();
                players[2].reserved.Text = players[2].ReservedMoney.ToString();
            }
            else
            {
                players[0].ReservedMoney = SmallBlind;
                players[0].Stack -= SmallBlind;
                players[1].ReservedMoney = BigBlind;
                players[1].Stack -= BigBlind;
                pot = SmallBlind + BigBlind;
                players[0].numeric.Value = players[0].Stack;
                players[1].numeric.Value = players[1].Stack;
                players[0].reserved.Text = players[0].ReservedMoney.ToString();
                players[1].reserved.Text = players[1].ReservedMoney.ToString();
                Position = 0;
            }
            PotLabel.Text = pot.ToString();
        }
        public Player NextPlayerToPlay()
        {
            var NotFound = true;
            Player player = new Player();
            while (NotFound)
            {
                if (players[Position % players.Length].InGame)
                {
                    player = players[Position % players.Length];
                    NotFound = false;
                }
                else
                {
                    Position++;
                }
            }
            return player;
        }
        public Game CopyGame(Game game)
        {
            var newPlayers = new Player[game.players.Length];
            for (int i = 0; i < game.players.Length; i++)
            {
                newPlayers[i] = game.players[i].CopyPlayer(game.players[i]);
            }
            var newDeck = game.deck.CopyDeck(game.deck);
            var newGame = new Game(newPlayers, newDeck, new int[] { game.SmallBlind, game.BigBlind }, game.PotLabel);

            newGame.state = game.state;
            newGame.CallCount = game.CallCount;
            newGame.CurrentStake = game.CurrentStake;
            newGame.ReRaiseValue= game.ReRaiseValue;
            newGame.Position = game.Position;
            newGame.PlayersInGame = game.PlayersInGame;
            newGame.Pot = game.Pot;

            return newGame;
        }

    }
}
