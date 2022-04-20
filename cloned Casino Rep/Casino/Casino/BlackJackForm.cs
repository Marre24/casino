using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casino
{
    public partial class BlackJackForm : Form
    {
        List<Player> activePlayers = new List<Player>();
        private readonly int deckCount = 6;
        Deck deck = new Deck();
        SceneClass scene = new SceneClass();
        List<Player> undealtPlayers = new List<Player>();
        List<int> player1CardValues = new List<int>();
        List<int> player2CardValues = new List<int>();
        List<int> player3CardValues = new List<int>();
        List<int> player4CardValues = new List<int>();
        public bool player1GetPrice = false;
        public bool player2GetPrice = false;
        public bool player3GetPrice = false;
        public bool player4GetPrice = false;

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

            if (activePlayers.Count == 0)
            {
                MessageBox.Show("you do not have any active players");
                return;
            }
            scene.RoundScene(activePlayers, Pb_DealerLeftCard, Pb_DealerRightCard, Pb_Player1LeftCard, Pb_Player1RightCard, Pb_Player2LeftCard, Pb_Player2RightCard, Pb_Player3LeftCard, Pb_Player3RightCard, Pb_Player4LeftCard, Pb_Player4RightCard, Tb_Player1SumValue, Tb_Player2SumValue, Tb_Player3SumValue, Tb_Player4SumValue);
            undealtPlayers = activePlayers;

            Card c = deck.DrawCard();
            Pb_DealerLeftCard.Image = GetCardPic(c);
            c = deck.DrawCard();
            Pb_DealerRightCard.Image = GetCardPic(c);

            while (undealtPlayers.Count > 0)
            {
                GiveCards();

            }
            Btn_startRound.Hide();
        }

        private void CalcSums(int activePlayer, Card c)
        {
            if (activePlayer == 1)
            {
                player1CardValues.Add((int)c.value);

                if (c.value > CardValue.ten)
                    c.value = CardValue.ten;

                if (c.value == CardValue.ace)
                    c.value = CardValue.jack;

                Tb_Player1SumValue.Texts = Convert.ToString(int.Parse(Tb_Player1SumValue.Texts) + (int)c.value);
                if (player1CardValues.Contains((int)CardValue.ace) && int.Parse(Tb_Player1SumValue.Texts) > 21)
                {
                    player1CardValues.Remove((int)CardValue.ace);
                    Tb_Player1SumValue.Texts = Convert.ToString(int.Parse(Tb_Player1SumValue.Texts) - 11);
                }
            }
            if (activePlayer == 2)
            {
                player2CardValues.Add((int)c.value);

                if (c.value > CardValue.ten)
                    c.value = CardValue.ten;

                if (c.value == CardValue.ace)
                    c.value = CardValue.jack;

                Tb_Player2SumValue.Texts = Convert.ToString(int.Parse(Tb_Player2SumValue.Texts) + (int)c.value);
                if (player2CardValues.Contains((int)CardValue.ace) && int.Parse(Tb_Player2SumValue.Texts) > 21)
                {
                    player2CardValues.Remove((int)CardValue.ace);
                    Tb_Player2SumValue.Texts = Convert.ToString(int.Parse(Tb_Player2SumValue.Texts) - 11);
                }
            }
            if (activePlayer == 3)
            {
                player3CardValues.Add((int)c.value);

                if (c.value > CardValue.ten)
                    c.value = CardValue.ten;

                if (c.value == CardValue.ace)
                    c.value = CardValue.jack;

                Tb_Player3SumValue.Texts = Convert.ToString(int.Parse(Tb_Player3SumValue.Texts) + (int)c.value);
                if (player3CardValues.Contains((int)CardValue.ace) && int.Parse(Tb_Player3SumValue.Texts) > 21)
                {
                    player3CardValues.Remove((int)CardValue.ace);
                    Tb_Player3SumValue.Texts = Convert.ToString(int.Parse(Tb_Player3SumValue.Texts) - 11);
                }
            }
            if (activePlayer == 4)
            {
                player4CardValues.Add((int)c.value);

                if (c.value > CardValue.ten)
                    c.value = CardValue.ten;

                if (c.value == CardValue.ace)
                    c.value = CardValue.jack;

                Tb_Player4SumValue.Texts = Convert.ToString(int.Parse(Tb_Player4SumValue.Texts) + (int)c.value);
                if (player4CardValues.Contains((int)CardValue.ace) && int.Parse(Tb_Player4SumValue.Texts) > 21)
                {
                    player4CardValues.Remove((int)CardValue.ace);
                    Tb_Player4SumValue.Texts = Convert.ToString(int.Parse(Tb_Player4SumValue.Texts) - 11);
                }
            }
        }

        public void CheckStatus()
        {
            if (int.Parse(Tb_Player1SumValue.Texts) > 21)
            {
                scene.BustScene(Btn_Player1Hit, Btn_Player1Stand);
            }
            if (int.Parse(Tb_Player2SumValue.Texts) > 21)
            {
                scene.BustScene(Btn_Player2Hit, Btn_Player2Stand);
            }
            if (int.Parse(Tb_Player3SumValue.Texts) > 21)
            {
                scene.BustScene(Btn_Player3Hit, Btn_Player3Stand);
            }
            if (int.Parse(Tb_Player4SumValue.Texts) > 21)
            {
                scene.BustScene(Btn_Player4Hit, Btn_Player4Stand);
            }


            if (int.Parse(Tb_Player1SumValue.Texts) == 21)
            {
                scene.StandScene(Btn_Player1Hit, Btn_Player1Stand);
                player1GetPrice = true;

            }
            if (int.Parse(Tb_Player2SumValue.Texts) == 21)
            {
                scene.StandScene(Btn_Player2Hit, Btn_Player2Stand);
                player2GetPrice = true;

            }
            if (int.Parse(Tb_Player3SumValue.Texts) == 21)
            {
                scene.StandScene(Btn_Player3Hit, Btn_Player3Stand);
                player3GetPrice = true;

            }
            if (int.Parse(Tb_Player4SumValue.Texts) == 21)
            {
                scene.StandScene(Btn_Player4Hit, Btn_Player4Stand);
                player4GetPrice = true;

            }


            if (player1CardValues.Count != player1CardValues.Distinct().Count())
            {
                Btn_Player1Split.Show();
            }
            if (player2CardValues.Count != player2CardValues.Distinct().Count())
            {
                Btn_Player2Split.Show();
            }
            if (player3CardValues.Count != player3CardValues.Distinct().Count())
            {
                Btn_Player3Split.Show();
            }
            if (player4CardValues.Count != player4CardValues.Distinct().Count())
            {
                Btn_Player4Split.Show();
            }
        }

        private int x;
        private int y;

        public void Hit(PictureBox Pb_old,int x ,int y , int activePlayer)
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Name = "Pb_NewCard";
            pictureBox.Size = Pb_old.Size;
            pictureBox.Location = (Point)(x,y);
            pictureBox.Visible = true;
            pictureBox.Show();
            this.Controls.Add(pictureBox);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            Controls.SetChildIndex(pictureBox, 0);
            Card c = deck.DrawCard();
            pictureBox.Image = GetCardPic(c);
            CalcSums(activePlayer, c);
            CheckStatus();
        }

        public void GiveCards()
        {
            if (undealtPlayers.Count == 1)
            {
                Card c = deck.DrawCard();

                Pb_Player1LeftCard.Image = GetCardPic(c);
                CalcSums(1, c);
                c = deck.DrawCard();
                Pb_Player1RightCard.Image = GetCardPic(c);
                CalcSums(1, c);
                undealtPlayers.RemoveAt(0);
                return;
            }
            if (undealtPlayers.Count == 2)
            {
                Card c = deck.DrawCard();

                Pb_Player2LeftCard.Image = GetCardPic(c);
                CalcSums(2, c);
                c = deck.DrawCard();
                Pb_Player2RightCard.Image = GetCardPic(c);
                CalcSums(2, c);
                undealtPlayers.RemoveAt(1);
                return;
            }
            if (undealtPlayers.Count == 3)
            {
                Card c = deck.DrawCard();

                Pb_Player3LeftCard.Image = GetCardPic(c);
                CalcSums(3, c);
                c = deck.DrawCard();
                Pb_Player3RightCard.Image = GetCardPic(c);
                CalcSums(3, c);
                undealtPlayers.RemoveAt(2);
                return;
            }
            if (undealtPlayers.Count == 4)
            {
                Card c = deck.DrawCard();

                Pb_Player4LeftCard.Image = GetCardPic(c);
                CalcSums(4, c);
                c = deck.DrawCard();
                Pb_Player4RightCard.Image = GetCardPic(c);
                CalcSums(4, c);
                undealtPlayers.RemoveAt(3);
                return;
            }
            CheckStatus();
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
            scene.ShowPlayerComponents(Btn_Player1Hit, Btn_Player1Join, Btn_Player1Stand, Tb_Player1Username);
            activePlayers.Add(new Player());

        }

        private void Btn_Player2Join_Click(object sender, EventArgs e)
        {
            scene.ShowPlayerComponents(Btn_Player2Hit, Btn_Player2Join, Btn_Player2Stand, Tb_Player2Username);
            activePlayers.Add(new Player());
        }

        private void Btn_Player3Join_Click(object sender, EventArgs e)
        {
            scene.ShowPlayerComponents(Btn_Player3Hit, Btn_Player3Join, Btn_Player3Stand, Tb_Player3Username);
            activePlayers.Add(new Player());

        }

        private void Btn_Player4Join_Click(object sender, EventArgs e)
        {
            scene.ShowPlayerComponents(Btn_Player4Hit, Btn_Player4Join, Btn_Player4Stand, Tb_Player4Username);
            activePlayers.Add(new Player());
        }

        private void Btn_Player1Hit_Click(object sender, EventArgs e)
        {
            x += Pb_Player1RightCard.Location.X;
            y = Pb_Player1RightCard.Location.Y;

            Hit(Pb_Player1RightCard, x, y, 1);

        }

        private void Btn_Player1Stand_Click(object sender, EventArgs e)
        {
            scene.StandScene(Btn_Player1Hit, Btn_Player1Stand);
        }

        private void Btn_Player2Hit_Click(object sender, EventArgs e)
        {
            Hit(Pb_Player2RightCard, 2);
        }

        private void Btn_Player3Hit_Click(object sender, EventArgs e)
        {
            Hit(Pb_Player3RightCard, 3);
        }

        private void Btn_Player4Hit_Click(object sender, EventArgs e)
        {
            Hit(Pb_Player4RightCard, 4);
        }
    }
}
