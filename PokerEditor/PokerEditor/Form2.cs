using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokerEditor
{
    public partial class Form2 : Form
    {
        Image img = Image.FromFile(@"C:\Users\Oni\documents\visual studio 2012\Projects\PokerEditor\PokerEditor\pokier karts.png");
        Deck deck;
        Card[] cardy;
        public Label[] labels;
        bool empty = true;
        Form1 form;
        Graphics g;
        Bitmap bmp;
        //public Form2(Deck deck)
        public Form2(Form1 form, int numOfCards, Card[] SelectedCards)
        {
            InitializeComponent();
            this.form = form;
            deck = form.deck;
            if (form.game != null)
            {
                deck = form.game.deck;
            }
            DrawCards();
            cardy = new Card[numOfCards];
            for (int i = 0; i < numOfCards; i++)
            {
                if (SelectedCards[i] != null)
                {
                    cardy[i] = SelectedCards[i];
                }
            }
            labels = new Label[] { label1, label2, label3 };       
        }
        public Bitmap CropImage(Bitmap source, Rectangle section)
        {
            // An empty bitmap which will hold the cropped image
            bmp = new Bitmap(section.Width, section.Height);

            g = Graphics.FromImage(bmp);

            // Draw the given area (section) of the source image
            // at location 0,0 on the empty bitmap (bmp)
            g.DrawImage(source, 0, 0, section, GraphicsUnit.Pixel);

            return bmp;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Point m = PointToClient(new Point(Cursor.Position.X -1  , Cursor.Position.Y -42));
            label1.Text = m.X + " " + m.Y;

            CheckCard(m);
            DrawCards();

            for (int i = 0; i < cardy.Length; i++)
            {
               
                if (cardy[i] != null)
                {
                    labels[i].Text = cardy[i].Getname();
                }
                else
                {
                    labels[i].Text = " ";
                }
            }
            form.label3.Text = label1.Text;





        }
        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            
            form.deck = deck;
            if (form.game != null)
            {
                if (form.game.State == 2)
            {
                for (int i = 0; i < 3; i++)
                {
                    form.game.tableCards[i] = cardy[i];
                }
            }
            else if (form.game.State == 3)
            {
                form.game.tableCards[3] = cardy[0];
            }
            else if (form.game.State == 4)
            {
                form.game.tableCards[4] = cardy[0];  
            }
            }
            
            this.Close();
        }
        public void DrawCards()
        {
            Image[] images = new Image[52];
            Bitmap source = new Bitmap(img);
            Rectangle section;
            for (int i = 0; i < 52; i++)
            {
                var kolor = deck.cards[i].Kolor;
                var numer = deck.cards[i].Numer;
                
                section = new Rectangle(new Point((14 - numer) * 57, kolor * 80), new Size(57, 80));

                Bitmap CroppedImage = CropImage(source, section);
                deck.cards[i].image = CroppedImage;

            }
            Bitmap final = new Bitmap(750, 400);
            Graphics g = Graphics.FromImage(final);
            for (int i = 0; i < 52; i++)
            {
                var card = deck.cards[i];
                if (card.CanBeUsed)
                {
                    g.DrawImage(card.image, (14 - card.Numer) * 57, card.Kolor * 80, 57, 80);
                }


            }
            pictureBox1.Image = final;
        }
        public void CheckCard(Point m)
        {
            for (int i = 0; i < 52; i++)
            {
                var card = deck.cards[i];
                empty = IsEmptySlot(cardy);
                if (m.X >= (14 - card.Numer) * 57 && m.X < (15 - card.Numer) * 57 && m.Y >= card.Kolor * 80 && m.Y < (card.Kolor + 1) * 80)
                {
                    
                    label1.Text += " " + card.Getname();
                    
                    for (int k = 0; k < cardy.Length; k++)
                    {
                        if (cardy[k] == null && card.CanBeUsed && empty)
                        {
                            card.CanBeUsed = !card.CanBeUsed;
                            cardy[k] = card;
                            form.cards = cardy;
                            form.next.Visible = !IsEmptySlot(cardy);
                            break;
                        }
                        if (cardy[k] == card && !card.CanBeUsed)
                        {
                            card.CanBeUsed = !card.CanBeUsed;
                            cardy[k] = null;
                            form.cards = cardy;
                            form.next.Visible = !IsEmptySlot(cardy);
                            break;
                        }
                    }
                    break;

                }

            }
        }
        public bool IsEmptySlot(Card[] cardy)
        {
            for (int i = 0; i < cardy.Length; i++)
            {
                if (cardy[i] == null)
                {
                    
                    return true;
                }
            }
            
            return false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

       

    }
}
