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
    public partial class CasinoLobby : Form
    {
        readonly SceneClass Scene = new SceneClass();
        public CasinoLobby()
        {
            InitializeComponent();
            string lobbyImage = "LobbyPicV2.PNG";
            Scene.LobbyScene(Pb_Background, lobbyImage);
            Pb_Background.Dock = DockStyle.Fill;
            HideAllComponents();
            Scene.LobbyStartScene(Btn_BlackJack, Btn_Poker, Btn_Slots, Pb_Background);

        }

        private Size oldSize;
        private void Log_inForm_Load(object sender, EventArgs e) => oldSize = base.Size;

        protected override void OnResize(System.EventArgs e)
        {
            base.OnResize(e);

            foreach (Control cnt in this.Controls)
                ResizeAll(cnt, base.Size);

            oldSize = base.Size;
            this.Pb_Background.SizeMode = PictureBoxSizeMode.Zoom;
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
        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }
        private void Btn_BlackJack_Click(object sender, EventArgs e)
        {
            Pb_Background.Image = Image.FromFile("EmptyTable.PNG");

            HideAllComponents();
            Scene.BalanceSelectScene(Btn_GoToGame, Tb_Balance, Tb_MoneyChosen, Pb_Background, Sb_Money);

        }
        public void HideAllComponents()
        {
            foreach (Control cnt in this.Controls)
            {
                if (cnt != Btn_exit)
                {
                    cnt.Hide();
                }
            }
        }
        private void Btn_GoToGame_Click(object sender, EventArgs e)
        {
            BlackJackForm BlackJack = new BlackJackForm();
            BlackJack.Show();
        }

        private void Tb_MoneyChosen__TextChanged(object sender, EventArgs e)
        {
            if (Tb_MoneyChosen.Texts != "")
            {
                if (!IsOnlyNums(Tb_MoneyChosen.Texts))
                {
                    MessageBox.Show("The input does not only contain numbers");
                    Tb_MoneyChosen.Texts = "";
                    return;
                }
                //if (int.Parse(Tb_MoneyChosen.Texts))
                //{

                //}

                Sb_Money.Value = int.Parse(Tb_MoneyChosen.Texts);
            }

        }

        private bool IsOnlyNums(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }

        private void Sb_Money_Scroll(object sender, ScrollEventArgs e)
        {
            Tb_MoneyChosen.Texts = Sb_Money.Value.ToString();
        }
    }
}
