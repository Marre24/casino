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
        public Card c;
        private readonly int deckCount = 6;
        List<Image> cardPics = new List<Image>();
        Deck deck = new Deck();
        SceneClass scene = new SceneClass();
        public BlackJackForm()
        {
            InitializeComponent();
            HideAllComponents();
            scene.BlackJackScene(Btn_Player1Join, Btn_Player2Join, Btn_Player3Join, Btn_Player4Join, Btn_startRound);
            deck.CreateDecks(deckCount);
            deck.ShuffleDeck();
            
        }
        public Image GetCardPic(string value, string color)
        {
            if (1 < c.GetIndex(value) && c.GetIndex(value) <= 10)
            {
                
                value = c.GetIndex(value).ToString();
                return Image.FromFile($"{value}_of_{color}.PNG");

            }
            if (c.GetIndex(value) == 1)
            {
                return Image.FromFile($"{value}_of_{color}.PNG");
            }
            color += "2";
            return Image.FromFile($"{value}_of_{color}.PNG");
        }

        private void Btn_startRound_Click(object sender, EventArgs e)
        {
            c = deck.DrawCard();
            Pb_EmpyTable.Image = GetCardPic(c.value.ToString(), c.color.ToString());
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
                if (cnt != Btn_exit )
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
        }

        private void Btn_Player2Join_Click(object sender, EventArgs e)
        {
            scene.ShowPlayerComponents(Btn_Player2Hit, Btn_Player2Join, Btn_Player2Stand, Tb_Player2Username);
        }

        private void Btn_Player3Join_Click(object sender, EventArgs e)
        {
            scene.ShowPlayerComponents(Btn_Player3Hit, Btn_Player3Join, Btn_Player3Stand, Tb_Player3Username);
        }

        private void Btn_Player4Join_Click(object sender, EventArgs e)
        {
            scene.ShowPlayerComponents(Btn_Player4Hit, Btn_Player4Join, Btn_Player4Stand, Tb_Player4Username);
        }
    }
}
