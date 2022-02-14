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
            this.DeckTest = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TestButton = new System.Windows.Forms.Button();
            this.ButtonDeck = new System.Windows.Forms.Button();
            this.Player1Card1 = new System.Windows.Forms.PictureBox();
            this.Player1Card3 = new System.Windows.Forms.PictureBox();
            this.Player1Card4 = new System.Windows.Forms.PictureBox();
            this.Player1Card5 = new System.Windows.Forms.PictureBox();
            this.Player1Card2 = new System.Windows.Forms.PictureBox();
            this.Shuffle = new System.Windows.Forms.Button();
            this.test2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Player1Card1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1Card3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1Card4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1Card5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1Card2)).BeginInit();
            this.SuspendLayout();
            // 
            // DeckTest
            // 
            this.DeckTest.Location = new System.Drawing.Point(737, 12);
            this.DeckTest.Multiline = true;
            this.DeckTest.Name = "DeckTest";
            this.DeckTest.Size = new System.Drawing.Size(199, 890);
            this.DeckTest.TabIndex = 0;
            this.DeckTest.TextChanged += new System.EventHandler(this.DeckTest_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(560, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cards in deck:";
            // 
            // TestButton
            // 
            this.TestButton.Location = new System.Drawing.Point(647, 134);
            this.TestButton.Name = "TestButton";
            this.TestButton.Size = new System.Drawing.Size(75, 23);
            this.TestButton.TabIndex = 2;
            this.TestButton.Text = "Test";
            this.TestButton.UseVisualStyleBackColor = true;
            this.TestButton.Click += new System.EventHandler(this.TestButton_Click);
            // 
            // ButtonDeck
            // 
            this.ButtonDeck.Image = global::Poker.Properties.Resources.CardBack;
            this.ButtonDeck.Location = new System.Drawing.Point(54, 34);
            this.ButtonDeck.Name = "ButtonDeck";
            this.ButtonDeck.Size = new System.Drawing.Size(150, 201);
            this.ButtonDeck.TabIndex = 3;
            this.ButtonDeck.UseVisualStyleBackColor = true;
            this.ButtonDeck.Click += new System.EventHandler(this.ButtonDeck_Click);
            // 
            // Player1Card1
            // 
            this.Player1Card1.InitialImage = global::Poker.Properties.Resources.CardBack;
            this.Player1Card1.Location = new System.Drawing.Point(12, 440);
            this.Player1Card1.Name = "Player1Card1";
            this.Player1Card1.Size = new System.Drawing.Size(139, 198);
            this.Player1Card1.TabIndex = 4;
            this.Player1Card1.TabStop = false;
            // 
            // Player1Card3
            // 
            this.Player1Card3.Location = new System.Drawing.Point(302, 440);
            this.Player1Card3.Name = "Player1Card3";
            this.Player1Card3.Size = new System.Drawing.Size(139, 198);
            this.Player1Card3.TabIndex = 5;
            this.Player1Card3.TabStop = false;
            // 
            // Player1Card4
            // 
            this.Player1Card4.Location = new System.Drawing.Point(447, 440);
            this.Player1Card4.Name = "Player1Card4";
            this.Player1Card4.Size = new System.Drawing.Size(139, 198);
            this.Player1Card4.TabIndex = 6;
            this.Player1Card4.TabStop = false;
            // 
            // Player1Card5
            // 
            this.Player1Card5.Location = new System.Drawing.Point(592, 440);
            this.Player1Card5.Name = "Player1Card5";
            this.Player1Card5.Size = new System.Drawing.Size(139, 198);
            this.Player1Card5.TabIndex = 7;
            this.Player1Card5.TabStop = false;
            // 
            // Player1Card2
            // 
            this.Player1Card2.Location = new System.Drawing.Point(157, 440);
            this.Player1Card2.Name = "Player1Card2";
            this.Player1Card2.Size = new System.Drawing.Size(139, 198);
            this.Player1Card2.TabIndex = 8;
            this.Player1Card2.TabStop = false;
            // 
            // Shuffle
            // 
            this.Shuffle.Location = new System.Drawing.Point(248, 123);
            this.Shuffle.Name = "Shuffle";
            this.Shuffle.Size = new System.Drawing.Size(75, 23);
            this.Shuffle.TabIndex = 9;
            this.Shuffle.Text = "Shuffle";
            this.Shuffle.UseVisualStyleBackColor = true;
            this.Shuffle.Click += new System.EventHandler(this.Shuffle_Click);
            // 
            // test2
            // 
            this.test2.Location = new System.Drawing.Point(633, 203);
            this.test2.Name = "test2";
            this.test2.Size = new System.Drawing.Size(75, 23);
            this.test2.TabIndex = 10;
            this.test2.Text = "test2";
            this.test2.UseVisualStyleBackColor = true;
            this.test2.Click += new System.EventHandler(this.test2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 914);
            this.Controls.Add(this.test2);
            this.Controls.Add(this.Shuffle);
            this.Controls.Add(this.Player1Card2);
            this.Controls.Add(this.Player1Card5);
            this.Controls.Add(this.Player1Card4);
            this.Controls.Add(this.Player1Card3);
            this.Controls.Add(this.Player1Card1);
            this.Controls.Add(this.ButtonDeck);
            this.Controls.Add(this.TestButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeckTest);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Player1Card1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1Card3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1Card4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1Card5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player1Card2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox DeckTest;
        private Label label1;
        private Button TestButton;
        private Button ButtonDeck;
        private PictureBox Player1Card1;
        private PictureBox Player1Card3;
        private PictureBox Player1Card4;
        private PictureBox Player1Card5;
        private PictureBox Player1Card2;
        private Button Shuffle;
        private Button test2;
    }
}