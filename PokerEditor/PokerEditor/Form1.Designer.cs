namespace PokerEditor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.NumOfPlayers = new System.Windows.Forms.NumericUpDown();
            this.Player9 = new System.Windows.Forms.Label();
            this.Player8 = new System.Windows.Forms.Label();
            this.Player7 = new System.Windows.Forms.Label();
            this.Player6 = new System.Windows.Forms.Label();
            this.Player5 = new System.Windows.Forms.Label();
            this.Player4 = new System.Windows.Forms.Label();
            this.Player3 = new System.Windows.Forms.Label();
            this.Player2 = new System.Windows.Forms.Label();
            this.Player1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Player3Stack = new System.Windows.Forms.NumericUpDown();
            this.Player4Stack = new System.Windows.Forms.NumericUpDown();
            this.Player5Stack = new System.Windows.Forms.NumericUpDown();
            this.Player6Stack = new System.Windows.Forms.NumericUpDown();
            this.Player7Stack = new System.Windows.Forms.NumericUpDown();
            this.Player8Stack = new System.Windows.Forms.NumericUpDown();
            this.Player2Stack = new System.Windows.Forms.NumericUpDown();
            this.Player1Stack = new System.Windows.Forms.NumericUpDown();
            this.BigBlind = new System.Windows.Forms.NumericUpDown();
            this.SmallBlind = new System.Windows.Forms.NumericUpDown();
            this.Player9Stack = new System.Windows.Forms.NumericUpDown();
            this.Hero = new System.Windows.Forms.RadioButton();
            this.Dealer = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DealerLabel = new System.Windows.Forms.Label();
            this.HeroLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.FoldButton = new System.Windows.Forms.Button();
            this.CallButton = new System.Windows.Forms.Button();
            this.RaiseButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.next = new System.Windows.Forms.Button();
            this.Pot = new System.Windows.Forms.Label();
            this.Player3Bet = new System.Windows.Forms.Label();
            this.Player4Bet = new System.Windows.Forms.Label();
            this.Player5Bet = new System.Windows.Forms.Label();
            this.Player6Bet = new System.Windows.Forms.Label();
            this.Player7Bet = new System.Windows.Forms.Label();
            this.Player8Bet = new System.Windows.Forms.Label();
            this.Player9Bet = new System.Windows.Forms.Label();
            this.Player2Bet = new System.Windows.Forms.Label();
            this.Player1Bet = new System.Windows.Forms.Label();
            this.Raiser = new System.Windows.Forms.NumericUpDown();
            this.RaiseTrackBar = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumOfPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player3Stack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player4Stack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player5Stack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player6Stack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player7Stack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player8Stack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2Stack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1Stack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BigBlind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SmallBlind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player9Stack)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Raiser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RaiseTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(623, 432);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1001, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(737, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Players in Game";
            // 
            // NumOfPlayers
            // 
            this.NumOfPlayers.Location = new System.Drawing.Point(745, 64);
            this.NumOfPlayers.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.NumOfPlayers.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NumOfPlayers.Name = "NumOfPlayers";
            this.NumOfPlayers.Size = new System.Drawing.Size(80, 20);
            this.NumOfPlayers.TabIndex = 3;
            this.NumOfPlayers.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.NumOfPlayers.ValueChanged += new System.EventHandler(this.NumOfPlayers_ValueChanged);
            // 
            // Player9
            // 
            this.Player9.AutoSize = true;
            this.Player9.Location = new System.Drawing.Point(478, 352);
            this.Player9.Name = "Player9";
            this.Player9.Size = new System.Drawing.Size(42, 13);
            this.Player9.TabIndex = 4;
            this.Player9.Text = "Player9";
            this.Player9.Click += new System.EventHandler(this.Player9_Click);
            // 
            // Player8
            // 
            this.Player8.AutoSize = true;
            this.Player8.Location = new System.Drawing.Point(556, 259);
            this.Player8.Name = "Player8";
            this.Player8.Size = new System.Drawing.Size(42, 13);
            this.Player8.TabIndex = 5;
            this.Player8.Text = "Player8";
            this.Player8.Click += new System.EventHandler(this.Player8_Click);
            // 
            // Player7
            // 
            this.Player7.AutoSize = true;
            this.Player7.Location = new System.Drawing.Point(556, 138);
            this.Player7.Name = "Player7";
            this.Player7.Size = new System.Drawing.Size(42, 13);
            this.Player7.TabIndex = 6;
            this.Player7.Text = "Player7";
            this.Player7.Click += new System.EventHandler(this.Player7_Click);
            // 
            // Player6
            // 
            this.Player6.AutoSize = true;
            this.Player6.Location = new System.Drawing.Point(391, 87);
            this.Player6.Name = "Player6";
            this.Player6.Size = new System.Drawing.Size(42, 13);
            this.Player6.TabIndex = 7;
            this.Player6.Text = "Player6";
            this.Player6.Click += new System.EventHandler(this.Player6_Click);
            // 
            // Player5
            // 
            this.Player5.AutoSize = true;
            this.Player5.Location = new System.Drawing.Point(204, 87);
            this.Player5.Name = "Player5";
            this.Player5.Size = new System.Drawing.Size(42, 13);
            this.Player5.TabIndex = 8;
            this.Player5.Text = "Player5";
            this.Player5.Click += new System.EventHandler(this.Player5_Click);
            // 
            // Player4
            // 
            this.Player4.AutoSize = true;
            this.Player4.Location = new System.Drawing.Point(26, 138);
            this.Player4.Name = "Player4";
            this.Player4.Size = new System.Drawing.Size(42, 13);
            this.Player4.TabIndex = 9;
            this.Player4.Text = "Player4";
            this.Player4.Click += new System.EventHandler(this.Player4_Click);
            // 
            // Player3
            // 
            this.Player3.AutoSize = true;
            this.Player3.Location = new System.Drawing.Point(26, 259);
            this.Player3.Name = "Player3";
            this.Player3.Size = new System.Drawing.Size(42, 13);
            this.Player3.TabIndex = 10;
            this.Player3.Text = "Player3";
            this.Player3.Click += new System.EventHandler(this.Player3_Click);
            // 
            // Player2
            // 
            this.Player2.AutoSize = true;
            this.Player2.Location = new System.Drawing.Point(138, 352);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(42, 13);
            this.Player2.TabIndex = 11;
            this.Player2.Text = "Player2";
            this.Player2.Click += new System.EventHandler(this.Player2_Click);
            // 
            // Player1
            // 
            this.Player1.AutoSize = true;
            this.Player1.Location = new System.Drawing.Point(302, 352);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(42, 13);
            this.Player1.TabIndex = 12;
            this.Player1.Text = "Player1";
            this.Player1.Click += new System.EventHandler(this.Player1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(755, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Blinds";
            // 
            // Player3Stack
            // 
            this.Player3Stack.Location = new System.Drawing.Point(12, 275);
            this.Player3Stack.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.Player3Stack.Name = "Player3Stack";
            this.Player3Stack.Size = new System.Drawing.Size(68, 20);
            this.Player3Stack.TabIndex = 17;
            this.Player3Stack.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // Player4Stack
            // 
            this.Player4Stack.Location = new System.Drawing.Point(12, 156);
            this.Player4Stack.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.Player4Stack.Name = "Player4Stack";
            this.Player4Stack.Size = new System.Drawing.Size(68, 20);
            this.Player4Stack.TabIndex = 18;
            this.Player4Stack.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // Player5Stack
            // 
            this.Player5Stack.Location = new System.Drawing.Point(198, 103);
            this.Player5Stack.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.Player5Stack.Name = "Player5Stack";
            this.Player5Stack.Size = new System.Drawing.Size(60, 20);
            this.Player5Stack.TabIndex = 19;
            this.Player5Stack.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // Player6Stack
            // 
            this.Player6Stack.Location = new System.Drawing.Point(380, 103);
            this.Player6Stack.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.Player6Stack.Name = "Player6Stack";
            this.Player6Stack.Size = new System.Drawing.Size(70, 20);
            this.Player6Stack.TabIndex = 20;
            this.Player6Stack.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // Player7Stack
            // 
            this.Player7Stack.Location = new System.Drawing.Point(534, 156);
            this.Player7Stack.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.Player7Stack.Name = "Player7Stack";
            this.Player7Stack.Size = new System.Drawing.Size(72, 20);
            this.Player7Stack.TabIndex = 21;
            this.Player7Stack.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // Player8Stack
            // 
            this.Player8Stack.Location = new System.Drawing.Point(534, 275);
            this.Player8Stack.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.Player8Stack.Name = "Player8Stack";
            this.Player8Stack.Size = new System.Drawing.Size(72, 20);
            this.Player8Stack.TabIndex = 22;
            this.Player8Stack.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // Player2Stack
            // 
            this.Player2Stack.Location = new System.Drawing.Point(130, 368);
            this.Player2Stack.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.Player2Stack.Name = "Player2Stack";
            this.Player2Stack.Size = new System.Drawing.Size(50, 20);
            this.Player2Stack.TabIndex = 23;
            this.Player2Stack.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // Player1Stack
            // 
            this.Player1Stack.Location = new System.Drawing.Point(295, 368);
            this.Player1Stack.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.Player1Stack.Name = "Player1Stack";
            this.Player1Stack.Size = new System.Drawing.Size(49, 20);
            this.Player1Stack.TabIndex = 24;
            this.Player1Stack.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // BigBlind
            // 
            this.BigBlind.Location = new System.Drawing.Point(783, 116);
            this.BigBlind.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.BigBlind.Name = "BigBlind";
            this.BigBlind.Size = new System.Drawing.Size(67, 20);
            this.BigBlind.TabIndex = 25;
            this.BigBlind.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.BigBlind.ValueChanged += new System.EventHandler(this.BigBlind_ValueChanged);
            // 
            // SmallBlind
            // 
            this.SmallBlind.Location = new System.Drawing.Point(683, 116);
            this.SmallBlind.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.SmallBlind.Name = "SmallBlind";
            this.SmallBlind.Size = new System.Drawing.Size(80, 20);
            this.SmallBlind.TabIndex = 26;
            this.SmallBlind.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // Player9Stack
            // 
            this.Player9Stack.Location = new System.Drawing.Point(467, 368);
            this.Player9Stack.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.Player9Stack.Name = "Player9Stack";
            this.Player9Stack.Size = new System.Drawing.Size(64, 20);
            this.Player9Stack.TabIndex = 28;
            this.Player9Stack.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // Hero
            // 
            this.Hero.AutoSize = true;
            this.Hero.Checked = true;
            this.Hero.Location = new System.Drawing.Point(6, 19);
            this.Hero.Name = "Hero";
            this.Hero.Size = new System.Drawing.Size(48, 17);
            this.Hero.TabIndex = 29;
            this.Hero.TabStop = true;
            this.Hero.Text = "Hero";
            this.Hero.UseVisualStyleBackColor = true;
            // 
            // Dealer
            // 
            this.Dealer.AutoSize = true;
            this.Dealer.Location = new System.Drawing.Point(6, 42);
            this.Dealer.Name = "Dealer";
            this.Dealer.Size = new System.Drawing.Size(56, 17);
            this.Dealer.TabIndex = 30;
            this.Dealer.Text = "Dealer";
            this.Dealer.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DealerLabel);
            this.groupBox1.Controls.Add(this.HeroLabel);
            this.groupBox1.Controls.Add(this.Hero);
            this.groupBox1.Controls.Add(this.Dealer);
            this.groupBox1.Location = new System.Drawing.Point(683, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // DealerLabel
            // 
            this.DealerLabel.AutoSize = true;
            this.DealerLabel.Location = new System.Drawing.Point(107, 46);
            this.DealerLabel.Name = "DealerLabel";
            this.DealerLabel.Size = new System.Drawing.Size(35, 13);
            this.DealerLabel.TabIndex = 32;
            this.DealerLabel.Text = "label4";
            // 
            // HeroLabel
            // 
            this.HeroLabel.AutoSize = true;
            this.HeroLabel.Location = new System.Drawing.Point(107, 23);
            this.HeroLabel.Name = "HeroLabel";
            this.HeroLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HeroLabel.Size = new System.Drawing.Size(35, 13);
            this.HeroLabel.TabIndex = 31;
            this.HeroLabel.Text = "label3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(715, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "Choose Hero Cards";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FoldButton
            // 
            this.FoldButton.Location = new System.Drawing.Point(624, 352);
            this.FoldButton.Name = "FoldButton";
            this.FoldButton.Size = new System.Drawing.Size(75, 23);
            this.FoldButton.TabIndex = 33;
            this.FoldButton.Text = "Fold";
            this.FoldButton.UseVisualStyleBackColor = true;
            this.FoldButton.Visible = false;
            this.FoldButton.Click += new System.EventHandler(this.FoldButton_Click);
            // 
            // CallButton
            // 
            this.CallButton.Location = new System.Drawing.Point(745, 352);
            this.CallButton.Name = "CallButton";
            this.CallButton.Size = new System.Drawing.Size(75, 23);
            this.CallButton.TabIndex = 34;
            this.CallButton.Text = "Call";
            this.CallButton.UseVisualStyleBackColor = true;
            this.CallButton.Visible = false;
            this.CallButton.Click += new System.EventHandler(this.CallButton_Click);
            // 
            // RaiseButton
            // 
            this.RaiseButton.Location = new System.Drawing.Point(850, 352);
            this.RaiseButton.Name = "RaiseButton";
            this.RaiseButton.Size = new System.Drawing.Size(75, 23);
            this.RaiseButton.TabIndex = 35;
            this.RaiseButton.Text = "Raise";
            this.RaiseButton.UseVisualStyleBackColor = true;
            this.RaiseButton.Visible = false;
            this.RaiseButton.Click += new System.EventHandler(this.RaiseButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(663, 398);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(114, 80);
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(815, 398);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "label3";
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(624, 308);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(75, 23);
            this.next.TabIndex = 38;
            this.next.Text = "Next";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // Pot
            // 
            this.Pot.AutoSize = true;
            this.Pot.Location = new System.Drawing.Point(300, 222);
            this.Pot.Name = "Pot";
            this.Pot.Size = new System.Drawing.Size(13, 13);
            this.Pot.TabIndex = 39;
            this.Pot.Text = "0";
            // 
            // Player3Bet
            // 
            this.Player3Bet.AutoSize = true;
            this.Player3Bet.Location = new System.Drawing.Point(95, 259);
            this.Player3Bet.Name = "Player3Bet";
            this.Player3Bet.Size = new System.Drawing.Size(10, 13);
            this.Player3Bet.TabIndex = 40;
            this.Player3Bet.Text = " ";
            // 
            // Player4Bet
            // 
            this.Player4Bet.AutoSize = true;
            this.Player4Bet.Location = new System.Drawing.Point(95, 158);
            this.Player4Bet.Name = "Player4Bet";
            this.Player4Bet.Size = new System.Drawing.Size(10, 13);
            this.Player4Bet.TabIndex = 41;
            this.Player4Bet.Text = " ";
            // 
            // Player5Bet
            // 
            this.Player5Bet.AutoSize = true;
            this.Player5Bet.Location = new System.Drawing.Point(204, 132);
            this.Player5Bet.Name = "Player5Bet";
            this.Player5Bet.Size = new System.Drawing.Size(10, 13);
            this.Player5Bet.TabIndex = 42;
            this.Player5Bet.Text = " ";
            // 
            // Player6Bet
            // 
            this.Player6Bet.AutoSize = true;
            this.Player6Bet.Location = new System.Drawing.Point(391, 132);
            this.Player6Bet.Name = "Player6Bet";
            this.Player6Bet.Size = new System.Drawing.Size(10, 13);
            this.Player6Bet.TabIndex = 43;
            this.Player6Bet.Text = " ";
            // 
            // Player7Bet
            // 
            this.Player7Bet.AutoSize = true;
            this.Player7Bet.Location = new System.Drawing.Point(478, 163);
            this.Player7Bet.Name = "Player7Bet";
            this.Player7Bet.Size = new System.Drawing.Size(10, 13);
            this.Player7Bet.TabIndex = 44;
            this.Player7Bet.Text = " ";
            // 
            // Player8Bet
            // 
            this.Player8Bet.AutoSize = true;
            this.Player8Bet.Location = new System.Drawing.Point(479, 259);
            this.Player8Bet.Name = "Player8Bet";
            this.Player8Bet.Size = new System.Drawing.Size(10, 13);
            this.Player8Bet.TabIndex = 45;
            this.Player8Bet.Text = " ";
            // 
            // Player9Bet
            // 
            this.Player9Bet.AutoSize = true;
            this.Player9Bet.Location = new System.Drawing.Point(478, 318);
            this.Player9Bet.Name = "Player9Bet";
            this.Player9Bet.Size = new System.Drawing.Size(10, 13);
            this.Player9Bet.TabIndex = 46;
            this.Player9Bet.Text = " ";
            // 
            // Player2Bet
            // 
            this.Player2Bet.AutoSize = true;
            this.Player2Bet.Location = new System.Drawing.Point(139, 318);
            this.Player2Bet.Name = "Player2Bet";
            this.Player2Bet.Size = new System.Drawing.Size(10, 13);
            this.Player2Bet.TabIndex = 47;
            this.Player2Bet.Text = " ";
            // 
            // Player1Bet
            // 
            this.Player1Bet.AutoSize = true;
            this.Player1Bet.Location = new System.Drawing.Point(303, 323);
            this.Player1Bet.Name = "Player1Bet";
            this.Player1Bet.Size = new System.Drawing.Size(10, 13);
            this.Player1Bet.TabIndex = 48;
            this.Player1Bet.Text = " ";
            // 
            // Raiser
            // 
            this.Raiser.Location = new System.Drawing.Point(874, 311);
            this.Raiser.Name = "Raiser";
            this.Raiser.Size = new System.Drawing.Size(51, 20);
            this.Raiser.TabIndex = 49;
            this.Raiser.Visible = false;
            this.Raiser.ValueChanged += new System.EventHandler(this.Raiser_ValueChanged);
            // 
            // RaiseTrackBar
            // 
            this.RaiseTrackBar.Location = new System.Drawing.Point(705, 304);
            this.RaiseTrackBar.Name = "RaiseTrackBar";
            this.RaiseTrackBar.Size = new System.Drawing.Size(163, 45);
            this.RaiseTrackBar.TabIndex = 50;
            this.RaiseTrackBar.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 516);
            this.Controls.Add(this.RaiseTrackBar);
            this.Controls.Add(this.Raiser);
            this.Controls.Add(this.Player1Bet);
            this.Controls.Add(this.Player2Bet);
            this.Controls.Add(this.Player9Bet);
            this.Controls.Add(this.Player8Bet);
            this.Controls.Add(this.Player7Bet);
            this.Controls.Add(this.Player6Bet);
            this.Controls.Add(this.Player5Bet);
            this.Controls.Add(this.Player4Bet);
            this.Controls.Add(this.Player3Bet);
            this.Controls.Add(this.Pot);
            this.Controls.Add(this.next);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.RaiseButton);
            this.Controls.Add(this.CallButton);
            this.Controls.Add(this.FoldButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Player9Stack);
            this.Controls.Add(this.SmallBlind);
            this.Controls.Add(this.BigBlind);
            this.Controls.Add(this.Player1Stack);
            this.Controls.Add(this.Player2Stack);
            this.Controls.Add(this.Player8Stack);
            this.Controls.Add(this.Player7Stack);
            this.Controls.Add(this.Player6Stack);
            this.Controls.Add(this.Player5Stack);
            this.Controls.Add(this.Player4Stack);
            this.Controls.Add(this.Player3Stack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Player1);
            this.Controls.Add(this.Player2);
            this.Controls.Add(this.Player3);
            this.Controls.Add(this.Player4);
            this.Controls.Add(this.Player5);
            this.Controls.Add(this.Player6);
            this.Controls.Add(this.Player7);
            this.Controls.Add(this.Player8);
            this.Controls.Add(this.Player9);
            this.Controls.Add(this.NumOfPlayers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumOfPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player3Stack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player4Stack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player5Stack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player6Stack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player7Stack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player8Stack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2Stack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1Stack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BigBlind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SmallBlind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player9Stack)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Raiser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RaiseTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown NumOfPlayers;
        private System.Windows.Forms.Label Player9;
        private System.Windows.Forms.Label Player8;
        private System.Windows.Forms.Label Player7;
        private System.Windows.Forms.Label Player6;
        private System.Windows.Forms.Label Player5;
        private System.Windows.Forms.Label Player4;
        private System.Windows.Forms.Label Player3;
        private System.Windows.Forms.Label Player2;
        private System.Windows.Forms.Label Player1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Player3Stack;
        private System.Windows.Forms.NumericUpDown Player4Stack;
        private System.Windows.Forms.NumericUpDown Player5Stack;
        private System.Windows.Forms.NumericUpDown Player6Stack;
        private System.Windows.Forms.NumericUpDown Player7Stack;
        private System.Windows.Forms.NumericUpDown Player8Stack;
        private System.Windows.Forms.NumericUpDown Player2Stack;
        private System.Windows.Forms.NumericUpDown Player1Stack;
        private System.Windows.Forms.NumericUpDown BigBlind;
        private System.Windows.Forms.NumericUpDown SmallBlind;
        private System.Windows.Forms.NumericUpDown Player9Stack;
        private System.Windows.Forms.RadioButton Hero;
        private System.Windows.Forms.RadioButton Dealer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button FoldButton;
        private System.Windows.Forms.Button CallButton;
        private System.Windows.Forms.Button RaiseButton;
        private System.Windows.Forms.Label DealerLabel;
        private System.Windows.Forms.Label HeroLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Pot;
        private System.Windows.Forms.Label Player3Bet;
        private System.Windows.Forms.Label Player4Bet;
        private System.Windows.Forms.Label Player5Bet;
        private System.Windows.Forms.Label Player6Bet;
        private System.Windows.Forms.Label Player7Bet;
        private System.Windows.Forms.Label Player8Bet;
        private System.Windows.Forms.Label Player9Bet;
        private System.Windows.Forms.Label Player2Bet;
        private System.Windows.Forms.Label Player1Bet;
        private System.Windows.Forms.NumericUpDown Raiser;
        private System.Windows.Forms.TrackBar RaiseTrackBar;
        public System.Windows.Forms.Button next;
    }
}

