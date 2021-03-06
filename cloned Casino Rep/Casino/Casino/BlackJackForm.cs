using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using PlayerId = System.Int32;



namespace Casino
{
    
    public partial class BlackJackForm : Form
    {
        readonly List<Player> activePlayers = new List<Player>();
        private static readonly int deckCount = 6;
        readonly Deck deck = new Deck(deckCount);
        readonly SceneClass scene = new SceneClass();
        public bool player1GetPrice = false;
        readonly Dictionary<Player, Hand> hands = new Dictionary<Player, Hand>();
        readonly BlackJackDealer dealer = new BlackJackDealer();

        public BlackJackForm()
        {
            InitializeComponent();
            HideAllComponents();
            scene.BlackJackScene(Btn_Player1Join, Btn_Player2Join, Btn_Player3Join, Btn_Player4Join, Btn_startRound);
            deck.CreateDecks(deckCount);
            deck.ShuffleDeck();
        }
        public Image GetCardPic(Card c)
        {
            CardValue value = c.value;
            CardColor color = c.color;
            if (CardValue.ace < value && value <= CardValue.ten)
            {
                string valueString = ((int)value).ToString();
                return Image.FromFile($"{valueString}_of_{color}.PNG");
            }
            if (value == CardValue.ace)
            {
                return Image.FromFile($"{value}_of_{color}.PNG");
            }
            return Image.FromFile($"{value}_of_{color}2.PNG");
        }

        private void Btn_startRound_Click(object sender, EventArgs e)
        {
            HideAllComponents();
            scene.ShowPlayerComponents(Btn_Player1Hit, Btn_Player1Join, Btn_Player1Stand, Tb_Player1Username);
            if (activePlayers.Count == 0)
            {
                MessageBox.Show("you do not have any active players");
                return;
            }
            scene.RoundScene(activePlayers, Pb_DealerLeftCard, Pb_DealerRightCard, Pb_Player1LeftCard, Pb_Player1RightCard, Pb_Player2LeftCard, Pb_Player2RightCard, Pb_Player3LeftCard, Pb_Player3RightCard, Pb_Player4LeftCard, Pb_Player4RightCard, Tb_Player1SumValue, Tb_Player2SumValue, Tb_Player3SumValue, Tb_Player4SumValue);



            foreach (Player p in activePlayers)
            {
                if (p.WaitingForCard())
                {
                    dealer.GiveCards(deck,p);
                    //Pb_Player1LeftCard.Image = p.hand.leftImage;
                    //Pb_Player1RightCard.Image = p.hand.rightImage;
                    CalcSums(p);
                    CheckHandsFor(p);
                }
            }
            Btn_startRound.Hide();
        }

        private void CalcSums(Player activePlayer)
        {
            Tb_Player1SumValue.Texts = hands[activePlayer].Value().ToString();
        }

        private void CheckHandsFor(Player player)
        {
            if (player.hand.Value() > 21)
            {
                scene.BustScene(Btn_Player1Hit, Btn_Player1Stand);
            }

            if (player.hand.Value() == 21)
            {
                scene.StandScene(Btn_Player1Hit, Btn_Player1Stand);

                player1GetPrice = true;

            }
            

            int counter = 0;

            foreach (Player p in activePlayers)
            {
                if (p.HasStopped())
                {
                    counter++;
                    if (activePlayers.Count == counter)
                        scene.EndRoundScene();
                }
            }
        }

        private int x;
        private int y;

        private void Hit(PictureBox Pb_old,int oldX ,int oldY , Player activePlayer)
        {
            PictureBox pictureBox = new PictureBox
            {
                Name = "Pb_NewCard",
                Size = Pb_old.Size
            };
            Point point = new Point(oldX + pictureBox.Size.Width + 30, oldY);
            pictureBox.Location = point;
            pictureBox.Visible = true;
            pictureBox.Show();
            this.Controls.Add(pictureBox);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            Controls.SetChildIndex(pictureBox, 0);

            Card c = deck.DrawCard();
            activePlayer.hand.AddCard(c);
            pictureBox.Image = GetCardPic(c);
            CalcSums(activePlayer);
            CheckHandsFor(activePlayer);
        }

        

        private Size oldSize;
        private void Log_inForm_Load(object sender, EventArgs e) => oldSize = base.Size;

        protected override void OnResize(System.EventArgs e)
        {
            base.OnResize(e);

            foreach (Control cnt in this.Controls)
                ResizeAll(cnt, base.Size);

            oldSize = base.Size;
            this.Pb_EmpyTable.SizeMode = PictureBoxSizeMode.Zoom;
        }
        private void ResizeAll(Control control, Size newSize)
        {
            int width = newSize.Width - oldSize.Width;
            control.Left += (control.Left * width) / oldSize.Width;
            control.Width += (control.Width * width) / oldSize.Width;

            int height = newSize.Height - oldSize.Height;
            control.Top += (control.Top * height) / oldSize.Height;
            control.Height += (control.Height * height) / oldSize.Height;

        }

        private void Btn_exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        public void HideAllComponents()
        {
            foreach (Control cnt in this.Controls)
            {
                if (cnt != Btn_exit)
                {
                    if (cnt != Pb_EmpyTable)
                    {
                        cnt.Hide();

                    }
                }
            }
        }

        private void Btn_Player1Join_Click(object sender, EventArgs e)
        {
            scene.BettingScene(Pb_ChipBlack, Pb_ChipBlue, Pb_ChipPink, Pb_ChipRed, Btn_ClearBet, Tb_100, Tb_1000, Tb_500 , Tb_2000, Tb_BetText, Tb_Bet);
            Player player = new Player();
            activePlayers.Add(player);
            hands.Add(player, player.hand);
            player.StartPlaying();
        }

        private void Btn_Player2Join_Click(object sender, EventArgs e)
        {
            //scene.ShowPlayerComponents(Btn_Player2Hit, Btn_Player2Join, Btn_Player2Stand, Tb_Player2Username);
            //activePlayers.Add(new Player());
        }

        private void Btn_Player3Join_Click(object sender, EventArgs e)
        {
            //scene.ShowPlayerComponents(Btn_Player3Hit, Btn_Player3Join, Btn_Player3Stand, Tb_Player3Username);
            //activePlayers.Add(new Player());

        }

        private void Btn_Player4Join_Click(object sender, EventArgs e)
        {
            //scene.ShowPlayerComponents(Btn_Player4Hit, Btn_Player4Join, Btn_Player4Stand, Tb_Player4Username);
            
        }

        private void Btn_Player1Hit_Click(object sender, EventArgs e)
        {
            if (x == Pb_Player1RightCard.Location.X)
            {
                x += Pb_Player1RightCard.Size.Width + 30;
                Hit(Pb_Player1RightCard,x , y, activePlayers[0]);
                return;
            }
            x = Pb_Player1RightCard.Location.X;
            y = Pb_Player1RightCard.Location.Y;
            Hit(Pb_Player1RightCard, x, y, activePlayers[0]);

        }

        private void Btn_Player1Stand_Click(object sender, EventArgs e)
        {
            scene.StandScene(Btn_Player1Hit, Btn_Player1Stand);
            CheckHandsFor(new Player());
        }

        private void Btn_Player2Hit_Click(object sender, EventArgs e)
        {
            //Hit(Pb_Player2RightCard, 2);
        }

        private void Btn_Player3Hit_Click(object sender, EventArgs e)
        {
           // Hit(Pb_Player3RightCard, 3);
        }

        private void Btn_Player4Hit_Click(object sender, EventArgs e)
        {
            //Hit(Pb_Player4RightCard, 4);
        }

        private void Pb_ChipPink_Click(object sender, EventArgs e)
        {
            Tb_Bet.Texts = (int.Parse(Tb_Bet.Texts) + 2000).ToString();
        }

        private void Pb_ChipBlack_Click(object sender, EventArgs e)
        {
            Tb_Bet.Texts = (int.Parse(Tb_Bet.Texts) + 1000).ToString();
        }

        private void Pb_ChipBlue_Click(object sender, EventArgs e)
        {
            Tb_Bet.Texts = (int.Parse(Tb_Bet.Texts) + 500).ToString();
        }

        private void Pb_ChipRed_Click(object sender, EventArgs e)
        {
            Tb_Bet.Texts = (int.Parse(Tb_Bet.Texts) + 100).ToString();
        }
    }
}
