using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows;
using System.Diagnostics;

namespace Casino
{

    public partial class Log_inForm : Form
    {
        readonly string MyFilename = "UserInformation.txt";
        public List<string> UserInformation;
        readonly SceneClass Scene = new SceneClass();
        public int starterMoney = 2000;                                                 //sett värde
        public Log_inForm()
        {
            InitializeComponent();
            HideAllComponents();
            Scene.StartScene(Lbl_password, Lbl_username, Btn_Login, Btn_CreateLogin, Tb_Password, Tb_UserName);
        }
        private void Btn_Login_Click(object sender, EventArgs e)                      //måste kunna logga in 
        {
            
        }
        private void Btn_CreateLogin_Click(object sender, EventArgs e)
        {
            HideAllComponents();
            Scene.UsercreateScene(Lbl_password, Lbl_username, Btn_Return, Btn_NewLoginInformation, Tb_Password, Tb_UserName);
            //CheckTextfile(Tb_Password.Text);
        }
        private void AddUserInformationToTextFile(string information)
        {
            using (StreamWriter sw = new StreamWriter(MyFilename, true))
            {
                sw.WriteLine(information);
                sw.Close();
            }
        }
        private void Btn_NewLoginInformation_Click(object sender, EventArgs e)
        {
            if (Tb_Password.Text == "" || Tb_UserName.Text == "")
            {
                MessageBox.Show("Your new username or password not filled in");
                return;
            }
            AddUserInformationToTextFile(Tb_UserName.Text);
            AddUserInformationToTextFile(Tb_Password.Text);
            AddUserInformationToTextFile(starterMoney.ToString());
            HideAllComponents();
            Scene.AcconutMangementScene();
        }
        private void Btn_Return_Click(object sender, EventArgs e)
        {
            HideAllComponents();
            Scene.StartScene(Lbl_password, Lbl_username, Btn_Login, Btn_CreateLogin, Tb_Password, Tb_UserName);
        }
        private Size oldSize;
        private void Log_inForm_Load(object sender, EventArgs e) => oldSize = base.Size;

        protected override void OnResize(System.EventArgs e)
        {
            base.OnResize(e);

            foreach (Control cnt in this.Controls)
                ResizeAll(cnt, base.Size);

            oldSize = base.Size;
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

        private void Btn_GoToLobby_Click(object sender, EventArgs e)
        {
            CasinoLobby casinoLobby = new CasinoLobby();
            casinoLobby.Show();
        }

        public void HideAllComponents()
        {
            foreach (Control cnt in this.Controls)
            {
                if (cnt != Btn_Exit)
                {
                    cnt.Hide();
                }
            }
        }
    }
}
