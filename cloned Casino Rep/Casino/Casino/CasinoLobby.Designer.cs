
namespace Casino
{
    partial class CasinoLobby
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
            this.Pb_Background = new System.Windows.Forms.PictureBox();
            this.Btn_exit = new Casino.CostomButtons();
            this.costomButtons3 = new Casino.CostomButtons();
            this.Btn_Poker = new Casino.CostomButtons();
            this.Btn_BlackJack = new Casino.CostomButtons();
            this.Sb_Money = new System.Windows.Forms.HScrollBar();
            this.Tb_MoneyChosen = new Casino.CostomTextBox();
            this.Btn_GoToGame = new Casino.CostomButtons();
            this.Tb_Balance = new Casino.CostomTextBox();
            this.Btn_return = new Casino.CostomButtons();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Background)).BeginInit();
            this.SuspendLayout();
            // 
            // Pb_Background
            // 
            this.Pb_Background.Image = global::Casino.Properties.Resources.LobbyPicV2;
            this.Pb_Background.InitialImage = null;
            this.Pb_Background.Location = new System.Drawing.Point(0, 0);
            this.Pb_Background.Name = "Pb_Background";
            this.Pb_Background.Size = new System.Drawing.Size(1500, 750);
            this.Pb_Background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pb_Background.TabIndex = 0;
            this.Pb_Background.TabStop = false;
            // 
            // Btn_exit
            // 
            this.Btn_exit.BackColor = System.Drawing.Color.Blue;
            this.Btn_exit.BackgroundColor = System.Drawing.Color.Blue;
            this.Btn_exit.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Btn_exit.BorderRadius = 30;
            this.Btn_exit.BorderSize = 0;
            this.Btn_exit.FlatAppearance.BorderSize = 0;
            this.Btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_exit.Font = new System.Drawing.Font("MV Boli", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_exit.ForeColor = System.Drawing.Color.White;
            this.Btn_exit.Location = new System.Drawing.Point(1129, 506);
            this.Btn_exit.Name = "Btn_exit";
            this.Btn_exit.Size = new System.Drawing.Size(220, 91);
            this.Btn_exit.TabIndex = 4;
            this.Btn_exit.Text = "EXIT";
            this.Btn_exit.TextColor = System.Drawing.Color.White;
            this.Btn_exit.UseVisualStyleBackColor = false;
            this.Btn_exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // costomButtons3
            // 
            this.costomButtons3.BackColor = System.Drawing.Color.Red;
            this.costomButtons3.BackgroundColor = System.Drawing.Color.Red;
            this.costomButtons3.BorderColor = System.Drawing.Color.Black;
            this.costomButtons3.BorderRadius = 50;
            this.costomButtons3.BorderSize = 5;
            this.costomButtons3.FlatAppearance.BorderSize = 0;
            this.costomButtons3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.costomButtons3.Font = new System.Drawing.Font("MV Boli", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costomButtons3.ForeColor = System.Drawing.Color.White;
            this.costomButtons3.Location = new System.Drawing.Point(924, 154);
            this.costomButtons3.Name = "costomButtons3";
            this.costomButtons3.Size = new System.Drawing.Size(167, 49);
            this.costomButtons3.TabIndex = 3;
            this.costomButtons3.Text = "Slots";
            this.costomButtons3.TextColor = System.Drawing.Color.White;
            this.costomButtons3.UseVisualStyleBackColor = false;
            // 
            // Btn_Poker
            // 
            this.Btn_Poker.BackColor = System.Drawing.Color.Red;
            this.Btn_Poker.BackgroundColor = System.Drawing.Color.Red;
            this.Btn_Poker.BorderColor = System.Drawing.Color.Black;
            this.Btn_Poker.BorderRadius = 50;
            this.Btn_Poker.BorderSize = 5;
            this.Btn_Poker.FlatAppearance.BorderSize = 0;
            this.Btn_Poker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Poker.Font = new System.Drawing.Font("MV Boli", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Poker.ForeColor = System.Drawing.Color.White;
            this.Btn_Poker.Location = new System.Drawing.Point(684, 154);
            this.Btn_Poker.Name = "Btn_Poker";
            this.Btn_Poker.Size = new System.Drawing.Size(167, 49);
            this.Btn_Poker.TabIndex = 2;
            this.Btn_Poker.Text = "Poker";
            this.Btn_Poker.TextColor = System.Drawing.Color.White;
            this.Btn_Poker.UseVisualStyleBackColor = false;
            // 
            // Btn_BlackJack
            // 
            this.Btn_BlackJack.BackColor = System.Drawing.Color.Red;
            this.Btn_BlackJack.BackgroundColor = System.Drawing.Color.Red;
            this.Btn_BlackJack.BorderColor = System.Drawing.Color.Black;
            this.Btn_BlackJack.BorderRadius = 50;
            this.Btn_BlackJack.BorderSize = 5;
            this.Btn_BlackJack.FlatAppearance.BorderSize = 0;
            this.Btn_BlackJack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_BlackJack.Font = new System.Drawing.Font("MV Boli", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_BlackJack.ForeColor = System.Drawing.Color.White;
            this.Btn_BlackJack.Location = new System.Drawing.Point(442, 154);
            this.Btn_BlackJack.Name = "Btn_BlackJack";
            this.Btn_BlackJack.Size = new System.Drawing.Size(167, 49);
            this.Btn_BlackJack.TabIndex = 1;
            this.Btn_BlackJack.Text = "BlackJack";
            this.Btn_BlackJack.TextColor = System.Drawing.Color.White;
            this.Btn_BlackJack.UseVisualStyleBackColor = false;
            this.Btn_BlackJack.Click += new System.EventHandler(this.Btn_BlackJack_Click);
            // 
            // Sb_Money
            // 
            this.Sb_Money.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sb_Money.Location = new System.Drawing.Point(640, 220);
            this.Sb_Money.Name = "Sb_Money";
            this.Sb_Money.Size = new System.Drawing.Size(256, 17);
            this.Sb_Money.TabIndex = 5;
            // 
            // Tb_MoneyChosen
            // 
            this.Tb_MoneyChosen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(92)))), ((int)(((byte)(30)))));
            this.Tb_MoneyChosen.BorderColor = System.Drawing.Color.Yellow;
            this.Tb_MoneyChosen.BorderFocusColor = System.Drawing.Color.Crimson;
            this.Tb_MoneyChosen.BorderSize = 2;
            this.Tb_MoneyChosen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_MoneyChosen.ForeColor = System.Drawing.Color.White;
            this.Tb_MoneyChosen.Location = new System.Drawing.Point(640, 154);
            this.Tb_MoneyChosen.Margin = new System.Windows.Forms.Padding(4);
            this.Tb_MoneyChosen.Multiline = false;
            this.Tb_MoneyChosen.Name = "Tb_MoneyChosen";
            this.Tb_MoneyChosen.Padding = new System.Windows.Forms.Padding(7);
            this.Tb_MoneyChosen.PasswordChar = false;
            this.Tb_MoneyChosen.Size = new System.Drawing.Size(250, 31);
            this.Tb_MoneyChosen.TabIndex = 6;
            this.Tb_MoneyChosen.Texts = "";
            this.Tb_MoneyChosen.UnderlinedStyle = true;
            // 
            // Btn_GoToGame
            // 
            this.Btn_GoToGame.BackColor = System.Drawing.Color.Red;
            this.Btn_GoToGame.BackgroundColor = System.Drawing.Color.Red;
            this.Btn_GoToGame.BorderColor = System.Drawing.Color.Black;
            this.Btn_GoToGame.BorderRadius = 50;
            this.Btn_GoToGame.BorderSize = 5;
            this.Btn_GoToGame.FlatAppearance.BorderSize = 0;
            this.Btn_GoToGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_GoToGame.Font = new System.Drawing.Font("MV Boli", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_GoToGame.ForeColor = System.Drawing.Color.White;
            this.Btn_GoToGame.Location = new System.Drawing.Point(442, 136);
            this.Btn_GoToGame.Name = "Btn_GoToGame";
            this.Btn_GoToGame.Size = new System.Drawing.Size(167, 49);
            this.Btn_GoToGame.TabIndex = 7;
            this.Btn_GoToGame.TextColor = System.Drawing.Color.White;
            this.Btn_GoToGame.UseVisualStyleBackColor = false;
            this.Btn_GoToGame.Click += new System.EventHandler(this.Btn_GoToGame_Click);
            // 
            // Tb_Balance
            // 
            this.Tb_Balance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(92)))), ((int)(((byte)(30)))));
            this.Tb_Balance.BorderColor = System.Drawing.Color.Yellow;
            this.Tb_Balance.BorderFocusColor = System.Drawing.Color.Crimson;
            this.Tb_Balance.BorderSize = 2;
            this.Tb_Balance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_Balance.ForeColor = System.Drawing.Color.White;
            this.Tb_Balance.Location = new System.Drawing.Point(910, 154);
            this.Tb_Balance.Margin = new System.Windows.Forms.Padding(4);
            this.Tb_Balance.Multiline = false;
            this.Tb_Balance.Name = "Tb_Balance";
            this.Tb_Balance.Padding = new System.Windows.Forms.Padding(7);
            this.Tb_Balance.PasswordChar = false;
            this.Tb_Balance.Size = new System.Drawing.Size(250, 31);
            this.Tb_Balance.TabIndex = 8;
            this.Tb_Balance.Texts = "";
            this.Tb_Balance.UnderlinedStyle = false;
            // 
            // Btn_return
            // 
            this.Btn_return.BackColor = System.Drawing.Color.Red;
            this.Btn_return.BackgroundColor = System.Drawing.Color.Red;
            this.Btn_return.BorderColor = System.Drawing.Color.Black;
            this.Btn_return.BorderRadius = 50;
            this.Btn_return.BorderSize = 5;
            this.Btn_return.FlatAppearance.BorderSize = 0;
            this.Btn_return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_return.Font = new System.Drawing.Font("MV Boli", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_return.ForeColor = System.Drawing.Color.White;
            this.Btn_return.Location = new System.Drawing.Point(993, 220);
            this.Btn_return.Name = "Btn_return";
            this.Btn_return.Size = new System.Drawing.Size(167, 49);
            this.Btn_return.TabIndex = 9;
            this.Btn_return.TextColor = System.Drawing.Color.White;
            this.Btn_return.UseVisualStyleBackColor = false;
            // 
            // CasinoLobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(35)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(1501, 711);
            this.Controls.Add(this.Btn_return);
            this.Controls.Add(this.Tb_Balance);
            this.Controls.Add(this.Btn_GoToGame);
            this.Controls.Add(this.Tb_MoneyChosen);
            this.Controls.Add(this.Sb_Money);
            this.Controls.Add(this.Btn_exit);
            this.Controls.Add(this.costomButtons3);
            this.Controls.Add(this.Btn_Poker);
            this.Controls.Add(this.Btn_BlackJack);
            this.Controls.Add(this.Pb_Background);
            this.Name = "CasinoLobby";
            this.Text = "CasinoLobby";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Background)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Pb_Background;
        private CostomButtons Btn_BlackJack;
        private CostomButtons Btn_Poker;
        private CostomButtons costomButtons3;
        private CostomButtons Btn_exit;
        private System.Windows.Forms.HScrollBar Sb_Money;
        private CostomTextBox Tb_MoneyChosen;
        private CostomButtons Btn_GoToGame;
        private CostomTextBox Tb_Balance;
        private CostomButtons Btn_return;
    }
}