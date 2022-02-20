namespace Poker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonDeck = new System.Windows.Forms.Button();
            this.Player1Card1 = new System.Windows.Forms.PictureBox();
            this.Player1Card3 = new System.Windows.Forms.PictureBox();
            this.Player1Card4 = new System.Windows.Forms.PictureBox();
            this.Player1Card5 = new System.Windows.Forms.PictureBox();
            this.Player1Card2 = new System.Windows.Forms.PictureBox();
            this.Shuffle = new System.Windows.Forms.Button();
            this.Player2Card2 = new System.Windows.Forms.PictureBox();
            this.Player2Card5 = new System.Windows.Forms.PictureBox();
            this.Player2Card4 = new System.Windows.Forms.PictureBox();
            this.Player2Card3 = new System.Windows.Forms.PictureBox();
            this.Player2Card1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PLayer2Points = new System.Windows.Forms.TextBox();
            this.PLayer1Points = new System.Windows.Forms.TextBox();
            this.CheckWinner = new System.Windows.Forms.Button();
            this.BackgroundImage = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Player1Card1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1Card3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1Card4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1Card5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1Card2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2Card2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2Card5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2Card4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2Card3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2Card1)).BeginInit();
            this.BackgroundImage.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonDeck
            // 
            this.ButtonDeck.Image = global::Poker.Properties.Resources.CardBack;
            this.ButtonDeck.Location = new System.Drawing.Point(35, 246);
            this.ButtonDeck.Name = "ButtonDeck";
            this.ButtonDeck.Size = new System.Drawing.Size(150, 201);
            this.ButtonDeck.TabIndex = 3;
            this.ButtonDeck.UseVisualStyleBackColor = true;
            this.ButtonDeck.Click += new System.EventHandler(this.ButtonDeck_Click);
            // 
            // Player1Card1
            // 
            this.Player1Card1.BackColor = System.Drawing.SystemColors.Control;
            this.Player1Card1.InitialImage = global::Poker.Properties.Resources.CardBack;
            this.Player1Card1.Location = new System.Drawing.Point(210, 3);
            this.Player1Card1.Name = "Player1Card1";
            this.Player1Card1.Size = new System.Drawing.Size(139, 198);
            this.Player1Card1.TabIndex = 4;
            this.Player1Card1.TabStop = false;
            // 
            // Player1Card3
            // 
            this.Player1Card3.Location = new System.Drawing.Point(500, 3);
            this.Player1Card3.Name = "Player1Card3";
            this.Player1Card3.Size = new System.Drawing.Size(139, 198);
            this.Player1Card3.TabIndex = 5;
            this.Player1Card3.TabStop = false;
            // 
            // Player1Card4
            // 
            this.Player1Card4.Location = new System.Drawing.Point(645, 3);
            this.Player1Card4.Name = "Player1Card4";
            this.Player1Card4.Size = new System.Drawing.Size(139, 198);
            this.Player1Card4.TabIndex = 6;
            this.Player1Card4.TabStop = false;
            // 
            // Player1Card5
            // 
            this.Player1Card5.Location = new System.Drawing.Point(790, 3);
            this.Player1Card5.Name = "Player1Card5";
            this.Player1Card5.Size = new System.Drawing.Size(139, 198);
            this.Player1Card5.TabIndex = 7;
            this.Player1Card5.TabStop = false;
            // 
            // Player1Card2
            // 
            this.Player1Card2.InitialImage = global::Poker.Properties.Resources.KingDiamonds1;
            this.Player1Card2.Location = new System.Drawing.Point(355, 3);
            this.Player1Card2.Name = "Player1Card2";
            this.Player1Card2.Size = new System.Drawing.Size(139, 198);
            this.Player1Card2.TabIndex = 8;
            this.Player1Card2.TabStop = false;
            // 
            // Shuffle
            // 
            this.Shuffle.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Shuffle.Font = new System.Drawing.Font("Vivaldi", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Shuffle.ForeColor = System.Drawing.Color.Olive;
            this.Shuffle.Location = new System.Drawing.Point(211, 286);
            this.Shuffle.Name = "Shuffle";
            this.Shuffle.Size = new System.Drawing.Size(283, 64);
            this.Shuffle.TabIndex = 9;
            this.Shuffle.Text = "New Game/Shuffle";
            this.Shuffle.UseVisualStyleBackColor = false;
            this.Shuffle.Click += new System.EventHandler(this.Shuffle_Click);
            // 
            // Player2Card2
            // 
            this.Player2Card2.Location = new System.Drawing.Point(355, 471);
            this.Player2Card2.Name = "Player2Card2";
            this.Player2Card2.Size = new System.Drawing.Size(139, 198);
            this.Player2Card2.TabIndex = 14;
            this.Player2Card2.TabStop = false;
            // 
            // Player2Card5
            // 
            this.Player2Card5.Location = new System.Drawing.Point(790, 470);
            this.Player2Card5.Name = "Player2Card5";
            this.Player2Card5.Size = new System.Drawing.Size(139, 198);
            this.Player2Card5.TabIndex = 13;
            this.Player2Card5.TabStop = false;
            // 
            // Player2Card4
            // 
            this.Player2Card4.Location = new System.Drawing.Point(645, 471);
            this.Player2Card4.Name = "Player2Card4";
            this.Player2Card4.Size = new System.Drawing.Size(139, 198);
            this.Player2Card4.TabIndex = 12;
            this.Player2Card4.TabStop = false;
            // 
            // Player2Card3
            // 
            this.Player2Card3.Location = new System.Drawing.Point(500, 470);
            this.Player2Card3.Name = "Player2Card3";
            this.Player2Card3.Size = new System.Drawing.Size(139, 198);
            this.Player2Card3.TabIndex = 11;
            this.Player2Card3.TabStop = false;
            // 
            // Player2Card1
            // 
            this.Player2Card1.InitialImage = global::Poker.Properties.Resources.CardBack;
            this.Player2Card1.Location = new System.Drawing.Point(211, 471);
            this.Player2Card1.Name = "Player2Card1";
            this.Player2Card1.Size = new System.Drawing.Size(139, 198);
            this.Player2Card1.TabIndex = 10;
            this.Player2Card1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Vivaldi", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Olive;
            this.label1.Location = new System.Drawing.Point(973, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 42);
            this.label1.TabIndex = 15;
            this.label1.Text = "Player1Points";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Vivaldi", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Olive;
            this.label2.Location = new System.Drawing.Point(973, 576);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 42);
            this.label2.TabIndex = 16;
            this.label2.Text = "Player2Points";
            // 
            // PLayer2Points
            // 
            this.PLayer2Points.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.PLayer2Points.Font = new System.Drawing.Font("Vivaldi", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.PLayer2Points.ForeColor = System.Drawing.Color.Olive;
            this.PLayer2Points.Location = new System.Drawing.Point(973, 534);
            this.PLayer2Points.Name = "PLayer2Points";
            this.PLayer2Points.Size = new System.Drawing.Size(197, 43);
            this.PLayer2Points.TabIndex = 17;
            // 
            // PLayer1Points
            // 
            this.PLayer1Points.BackColor = System.Drawing.SystemColors.MenuText;
            this.PLayer1Points.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PLayer1Points.Font = new System.Drawing.Font("Vivaldi", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.PLayer1Points.ForeColor = System.Drawing.Color.Olive;
            this.PLayer1Points.Location = new System.Drawing.Point(973, 60);
            this.PLayer1Points.Name = "PLayer1Points";
            this.PLayer1Points.Size = new System.Drawing.Size(197, 36);
            this.PLayer1Points.TabIndex = 18;
            // 
            // CheckWinner
            // 
            this.CheckWinner.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CheckWinner.Enabled = false;
            this.CheckWinner.Font = new System.Drawing.Font("Vivaldi", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.CheckWinner.ForeColor = System.Drawing.Color.Olive;
            this.CheckWinner.Location = new System.Drawing.Point(240, 356);
            this.CheckWinner.Name = "CheckWinner";
            this.CheckWinner.Size = new System.Drawing.Size(233, 50);
            this.CheckWinner.TabIndex = 19;
            this.CheckWinner.Text = "Check for A Winner";
            this.CheckWinner.UseVisualStyleBackColor = false;
            this.CheckWinner.Click += new System.EventHandler(this.CheckWinner_Click);
            // 
            // BackgroundImage
            // 
            this.BackgroundImage.BackgroundImage = global::Poker.Properties.Resources.before_shuffle1;
            this.BackgroundImage.Controls.Add(this.label3);
            this.BackgroundImage.Controls.Add(this.Player1Card5);
            this.BackgroundImage.Controls.Add(this.Player1Card2);
            this.BackgroundImage.Controls.Add(this.Player2Card1);
            this.BackgroundImage.Controls.Add(this.Player2Card2);
            this.BackgroundImage.Controls.Add(this.Player1Card1);
            this.BackgroundImage.Controls.Add(this.PLayer2Points);
            this.BackgroundImage.Controls.Add(this.Player2Card3);
            this.BackgroundImage.Controls.Add(this.Player2Card4);
            this.BackgroundImage.Controls.Add(this.Player2Card5);
            this.BackgroundImage.Controls.Add(this.PLayer1Points);
            this.BackgroundImage.Controls.Add(this.label2);
            this.BackgroundImage.Controls.Add(this.CheckWinner);
            this.BackgroundImage.Controls.Add(this.Shuffle);
            this.BackgroundImage.Controls.Add(this.label1);
            this.BackgroundImage.Controls.Add(this.ButtonDeck);
            this.BackgroundImage.Controls.Add(this.Player1Card4);
            this.BackgroundImage.Controls.Add(this.Player1Card3);
            this.BackgroundImage.Location = new System.Drawing.Point(-1, -3);
            this.BackgroundImage.Name = "BackgroundImage";
            this.BackgroundImage.Size = new System.Drawing.Size(1204, 671);
            this.BackgroundImage.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Vivaldi", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Olive;
            this.label3.Location = new System.Drawing.Point(992, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 200);
            this.label3.TabIndex = 20;
            this.label3.Text = "Point System:\r\nPair = 1 pt.\r\nTwo Pair = 2 pt.\r\nThree of a kind = 3 pt.\r\nFour of a" +
    " kind = 4 pt.\r\nFlush = 8 point\r\nStraight = 10 point\r\nFull House = 12 pt.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 694);
            this.Controls.Add(this.BackgroundImage);
            this.Name = "Form1";
            this.Text = "``";
            ((System.ComponentModel.ISupportInitialize)(this.Player1Card1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1Card3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1Card4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1Card5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1Card2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2Card2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2Card5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2Card4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2Card3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2Card1)).EndInit();
            this.BackgroundImage.ResumeLayout(false);
            this.BackgroundImage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Button ButtonDeck;
        private PictureBox Player1Card1;
        private PictureBox Player1Card3;
        private PictureBox Player1Card4;
        private PictureBox Player1Card5;
        private PictureBox Player1Card2;
        private Button Shuffle;
        private PictureBox Player2Card2;
        private PictureBox Player2Card5;
        private PictureBox Player2Card4;
        private PictureBox Player2Card3;
        private PictureBox Player2Card1;
        private Label label1;
        private Label label2;
        private TextBox PLayer2Points;
        private TextBox PLayer1Points;
        private Button CheckWinner;
        private Panel BackgroundImage;
        private Label label3;
    }
}