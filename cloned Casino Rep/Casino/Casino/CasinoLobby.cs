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

        }

        private void Btn_GoToGame_Click(object sender, EventArgs e)
        {
            BlackJackForm BlackJack = new BlackJackForm();
            BlackJack.Show();
        }
    }
}
