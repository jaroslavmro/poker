using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PokerEditor
{

    public partial class Form1 : Form
    {
        Label[] labels;
        NumericUpDown[] nums;
        Image img = Image.FromFile(@"C:\Users\Oni\documents\visual studio 2012\Projects\PokerEditor\PokerEditor\pokier karts.png");
        public Deck deck = new Deck();
        Player[] players;
        public Card[] cards = new Card[3];
        public Game game;
        Label[] Betlabels;
        public bool IsCardsSelected;
        
        public Form1()
        {
            InitializeComponent();
            labels = new Label[9];
            labels[0] = Player1;
            labels[1] = Player2;
            labels[2] = Player3;
            labels[3] = Player4;
            labels[4] = Player5;
            labels[5] = Player6;
            labels[6] = Player7;
            labels[7] = Player8;
            labels[8] = Player9;
            Betlabels = new Label[9];
            Betlabels[0] = Player1Bet;
            Betlabels[1] = Player2Bet;
            Betlabels[2] = Player3Bet;
            Betlabels[3] = Player4Bet;
            Betlabels[4] = Player5Bet;
            Betlabels[5] = Player6Bet;
            Betlabels[6] = Player7Bet;
            Betlabels[7] = Player8Bet;
            Betlabels[8] = Player9Bet;
            nums = new NumericUpDown[9];
            nums[0] = Player1Stack;
            nums[1] = Player2Stack;
            nums[2] = Player3Stack;
            nums[3] = Player4Stack;
            nums[4] = Player5Stack;
            nums[5] = Player6Stack;
            nums[6] = Player7Stack;
            nums[7] = Player8Stack;
            nums[8] = Player9Stack;
        }

        private void NumOfPlayers_ValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < 9; i++)
            {
                if (NumOfPlayers.Value <= i)
                {
                    labels[i].Visible = false;
                    nums[i].Visible = false;
                    Betlabels[i].Visible = false;
                }
                else
                {
                    labels[i].Visible = true;
                    nums[i].Visible = true;
                    Betlabels[i].Visible = true;
                }
            }
        }

        private void BigBlind_ValueChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i].Value = 100 * BigBlind.Value;
            }
        }

        private void Player1_Click(object sender, EventArgs e)
        {
            MakeHeroDealer(Player1);
           
        }
        private void Player2_Click(object sender, EventArgs e)
        {
            MakeHeroDealer(Player2);
        }
        private void Player3_Click(object sender, EventArgs e)
        {
            MakeHeroDealer(Player3);
        }
        private void Player4_Click(object sender, EventArgs e)
        {
            MakeHeroDealer(Player4);
        }
        private void Player5_Click(object sender, EventArgs e)
        {
            MakeHeroDealer(Player5);
        }
        private void Player6_Click(object sender, EventArgs e)
        {
            MakeHeroDealer(Player6);
        }
        private void Player7_Click(object sender, EventArgs e)
        {
            MakeHeroDealer(Player7);
        }
        private void Player8_Click(object sender, EventArgs e)
        {
            MakeHeroDealer(Player8);
        }
        private void Player9_Click(object sender, EventArgs e)
        {
            MakeHeroDealer(Player9);
        }
        private void MakeHeroDealer(Label label)
        {
            if (Hero.Checked)
            {
                HeroLabel.Text = label.Text;
            }
            else
            {
                DealerLabel.Text = label.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap source = new Bitmap(img);
            Rectangle section = new Rectangle(new Point(57, 80), new Size(57, 80));

            Bitmap CroppedImage = CropImage(source, section);
            pictureBox2.Image = CroppedImage;
            if (game == null)
            {
                Form2 form2 = new Form2(this,2,cards);
            form2.Show();
            }
            else if (game.State == 2)
            {
                
                Form2 form2 = new Form2(this, 3, cards);
                form2.Show();

            }
            else if (game.State == 3)
            {

                Form2 form2 = new Form2(this, 1, cards);
                form2.Show();

            }
            else if (game.State == 4)
            {

                Form2 form2 = new Form2(this, 1, cards);
                form2.Show();

            }
           
            
        }
        public Bitmap CropImage(Bitmap source, Rectangle section)
        {
            // An empty bitmap which will hold the cropped image
            Bitmap bmp = new Bitmap(section.Width, section.Height);

            Graphics g = Graphics.FromImage(bmp);

            // Draw the given area (section) of the source image
            // at location 0,0 on the empty bitmap (bmp)
            g.DrawImage(source, 0, 0, section, GraphicsUnit.Pixel);

            return bmp;
        }

        private void next_Click(object sender, EventArgs e)
        {
            if (game == null)
            {
                CreateGame();
                
               

            }
            else if (game.State == 2)
            {
                foreach (var item in game.players)
                {
                    item.ReservedMoney = 0;
                    item.reserved.Text = item.ReservedMoney.ToString();
                    
                }
                for (int i = 0; i < game.tableCards.Length; i++)
                
                game.callCount = 0;
                game.ReRaiseValue = game.bigBlind;
                game.currentStake = 0;
                HideShowPlayerUI();
                
            }
            else if (game.State == 3)
            {
                foreach (var item in game.players)
                {
                    item.ReservedMoney = 0;
                    item.reserved.Text = item.ReservedMoney.ToString();

                }
                
                game.callCount = 0;
                game.ReRaiseValue = game.bigBlind;
                game.currentStake = 0;
                HideShowPlayerUI();

            }
            else if (game.State == 4)
            {
                foreach (var item in game.players)
                {
                    item.ReservedMoney = 0;
                    item.reserved.Text = item.ReservedMoney.ToString();

                }
                
                game.callCount = 0;
                game.ReRaiseValue = game.bigBlind;
                game.currentStake = 0;
                HideShowPlayerUI();
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(game.tableCards[i].Getname());
                }

            }
        }
        public int IsDealerOrHeroInPlayers(Label label , int num)
        {
            string name = label.Text;
            for (int i = 0; i < num; i++)
            {
                if (name == labels[i].Text)
                {
                    return i;
                }

            }
            return -1;
        }
        public bool AllCardsSelected(Card[] karty)
        {
            for (int i = 0; i < karty.Length; i++)
            {
                if (karty[i] == null)
                {
                    return false;
                }
            }
            return true;
        }

        private void FoldButton_Click(object sender, EventArgs e)
        {
            var PlayerToMove = game.NextPlayerToPlay();
            game.MakeFold(PlayerToMove);
            if (ThisWasLastPlayer())
            {
                HideShowPlayerUI();
                next.Visible = false;
            }
        }

        private void CallButton_Click(object sender, EventArgs e)
        {
            var PlayerToMove = game.NextPlayerToPlay();
            game.MakeCall(PlayerToMove);
            if (ThisWasLastPlayer())
            {
                HideShowPlayerUI();
                next.Visible = false;
            }
        }

        private void RaiseButton_Click(object sender, EventArgs e)
        {
            var PlayerToMove = game.NextPlayerToPlay();
            if ((int)Raiser.Value >= game.ReRaiseValue)
            {
                game.MakeRaise(PlayerToMove, (int) Raiser.Value);
            }
            else
            {
                MessageBox.Show("Your raise value is incorrect");
            }
            
        }

        private void Raiser_ValueChanged(object sender, EventArgs e)
        {

            RaiserValueChanger();
        }
        public bool ThisWasLastPlayer()
        {
            bool ans;
            if (game.playersInGame > 1)
            {
                
                ans= game.playersInGame == game.callCount;
                if (ans)
                {
                    game.State++;
                    button1.Text = "Choose Flop Cards";
                    if (game.State == 5)
                    {
                        button1.Text = "To the String";
                    }
                    button1.Visible = true;                    
                    cards = new Card[3];
                }
            }
            else
            {
                ans = true;
            }
            
            return ans;

        }
        public void HideShowPlayerUI()
        {
            FoldButton.Visible = !FoldButton.Visible;
            CallButton.Visible = !CallButton.Visible;
            RaiseButton.Visible = !RaiseButton.Visible;
            Raiser.Visible = !Raiser.Visible;
            RaiseTrackBar.Visible = !RaiseTrackBar.Visible;
            next.Visible = !next.Visible;
        }
        public void CreateGame()
        {
            int num = (int)NumOfPlayers.Value;
            players = new Player[num];
            int dealer = IsDealerOrHeroInPlayers(DealerLabel, num);
            bool isDealer = false;
            if (dealer >= 0)
            {
                isDealer = true;
            }
            int hero = IsDealerOrHeroInPlayers(HeroLabel, num);
            bool isHero = false;
            if (hero >= 0)
            {
                isHero = true;
            }
            bool allCardSelected = AllCardsSelected(cards);
            int[] blinds = new int[] { (int)SmallBlind.Value, (int)BigBlind.Value };

            if (isDealer && isHero && allCardSelected && blinds[0] < blinds[1])
            {
                for (int i = 0; i < num; i++)
                {
                    Player player = new Player(labels[i].Text, (int)nums[i].Value, hero == i, nums[i], Betlabels[i]);
                    if (hero == i)
                    {
                        player.cards = cards;

                    }
                    players[(i + num - dealer) % num] = player;

                }
                game = new Game(players, deck, blinds, Pot);
                Console.WriteLine(" Udało się " + players[0].Name);
                for (int i = 0; i < game.players.Length; i++)
                {
                    string str = game.players[i].Name + " " + game.players[i].Stack;
                    if (game.players[i].IsHero)
                    {
                        str += " Hero";
                    }
                }
                HideShowPlayerUI();
                game.PostBlind();
                button1.Visible = false;
                NumOfPlayers.Enabled = false;
                SmallBlind.Enabled = false;
                BigBlind.Enabled = false;
                foreach (var item in game.players)
                {
                    item.numeric.Enabled = false;

                }
                HeroLabel.Enabled = false;
                DealerLabel.Enabled = false;


            }
            else
            {
                MessageBox.Show("You done something wrong");
            }
        }
        public void RaiserValueChanger()
        {
            Raiser.Minimum = Math.Min(game.ReRaiseValue, game.NextPlayerToPlay().Stack);
            Raiser.Maximum = game.NextPlayerToPlay().Stack;
            Raiser.Increment = game.bigBlind;
        }
       

    }
}
