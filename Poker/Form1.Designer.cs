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
            this.SuspendLayout();
            // 
            // ButtonDeck
            // 
            this.ButtonDeck.Image = global::Poker.Properties.Resources.CardBack;
            this.ButtonDeck.Location = new System.Drawing.Point(22, 173);
            this.ButtonDeck.Name = "ButtonDeck";
            this.ButtonDeck.Size = new System.Drawing.Size(150, 201);
            this.ButtonDeck.TabIndex = 3;
            this.ButtonDeck.UseVisualStyleBackColor = true;
            this.ButtonDeck.Click += new System.EventHandler(this.ButtonDeck_Click);
            // 
            // Player1Card1
            // 
            this.Player1Card1.InitialImage = global::Poker.Properties.Resources.CardBack;
            this.Player1Card1.Location = new System.Drawing.Point(209, 57);
            this.Player1Card1.Name = "Player1Card1";
            this.Player1Card1.Size = new System.Drawing.Size(139, 198);
            this.Player1Card1.TabIndex = 4;
            this.Player1Card1.TabStop = false;
            // 
            // Player1Card3
            // 
            this.Player1Card3.Location = new System.Drawing.Point(499, 57);
            this.Player1Card3.Name = "Player1Card3";
            this.Player1Card3.Size = new System.Drawing.Size(139, 198);
            this.Player1Card3.TabIndex = 5;
            this.Player1Card3.TabStop = false;
            // 
            // Player1Card4
            // 
            this.Player1Card4.Location = new System.Drawing.Point(644, 57);
            this.Player1Card4.Name = "Player1Card4";
            this.Player1Card4.Size = new System.Drawing.Size(139, 198);
            this.Player1Card4.TabIndex = 6;
            this.Player1Card4.TabStop = false;
            // 
            // Player1Card5
            // 
            this.Player1Card5.Location = new System.Drawing.Point(789, 57);
            this.Player1Card5.Name = "Player1Card5";
            this.Player1Card5.Size = new System.Drawing.Size(139, 198);
            this.Player1Card5.TabIndex = 7;
            this.Player1Card5.TabStop = false;
            // 
            // Player1Card2
            // 
            this.Player1Card2.InitialImage = global::Poker.Properties.Resources.KingDiamonds1;
            this.Player1Card2.Location = new System.Drawing.Point(354, 57);
            this.Player1Card2.Name = "Player1Card2";
            this.Player1Card2.Size = new System.Drawing.Size(139, 198);
            this.Player1Card2.TabIndex = 8;
            this.Player1Card2.TabStop = false;
            // 
            // Shuffle
            // 
            this.Shuffle.Location = new System.Drawing.Point(57, 380);
            this.Shuffle.Name = "Shuffle";
            this.Shuffle.Size = new System.Drawing.Size(75, 23);
            this.Shuffle.TabIndex = 9;
            this.Shuffle.Text = "Shuffle";
            this.Shuffle.UseVisualStyleBackColor = true;
            this.Shuffle.Click += new System.EventHandler(this.Shuffle_Click);
            // 
            // Player2Card2
            // 
            this.Player2Card2.Location = new System.Drawing.Point(354, 380);
            this.Player2Card2.Name = "Player2Card2";
            this.Player2Card2.Size = new System.Drawing.Size(139, 198);
            this.Player2Card2.TabIndex = 14;
            this.Player2Card2.TabStop = false;
            // 
            // Player2Card5
            // 
            this.Player2Card5.Location = new System.Drawing.Point(789, 380);
            this.Player2Card5.Name = "Player2Card5";
            this.Player2Card5.Size = new System.Drawing.Size(139, 198);
            this.Player2Card5.TabIndex = 13;
            this.Player2Card5.TabStop = false;
            // 
            // Player2Card4
            // 
            this.Player2Card4.Location = new System.Drawing.Point(644, 380);
            this.Player2Card4.Name = "Player2Card4";
            this.Player2Card4.Size = new System.Drawing.Size(139, 198);
            this.Player2Card4.TabIndex = 12;
            this.Player2Card4.TabStop = false;
            // 
            // Player2Card3
            // 
            this.Player2Card3.Location = new System.Drawing.Point(499, 380);
            this.Player2Card3.Name = "Player2Card3";
            this.Player2Card3.Size = new System.Drawing.Size(139, 198);
            this.Player2Card3.TabIndex = 11;
            this.Player2Card3.TabStop = false;
            // 
            // Player2Card1
            // 
            this.Player2Card1.InitialImage = global::Poker.Properties.Resources.CardBack;
            this.Player2Card1.Location = new System.Drawing.Point(209, 380);
            this.Player2Card1.Name = "Player2Card1";
            this.Player2Card1.Size = new System.Drawing.Size(139, 198);
            this.Player2Card1.TabIndex = 10;
            this.Player2Card1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 914);
            this.Controls.Add(this.Player2Card2);
            this.Controls.Add(this.Player2Card5);
            this.Controls.Add(this.Player2Card4);
            this.Controls.Add(this.Player2Card3);
            this.Controls.Add(this.Player2Card1);
            this.Controls.Add(this.Shuffle);
            this.Controls.Add(this.Player1Card2);
            this.Controls.Add(this.Player1Card5);
            this.Controls.Add(this.Player1Card4);
            this.Controls.Add(this.Player1Card3);
            this.Controls.Add(this.Player1Card1);
            this.Controls.Add(this.ButtonDeck);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}