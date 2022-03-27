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
        private void Btn_Login_Click(object sender, EventArgs e)                      
        {
            int usernameLine = CheckUsername(Tb_UserName.Texts);
            if (usernameLine == 0)
            {
                MessageBox.Show("Username not found");
                return;
            }
            if (!IsPassword(usernameLine, Tb_Password.Texts))
            {
                MessageBox.Show("Password not found");
                return;
            }
            HideAllComponents();
            Scene.AcconutMangementScene(Lbl_AccontBalance, Lbl_PasswordInfo, Lbl_UsernameInfo, Btn_GoToLobby, Tb_UserName.Texts, Tb_Password.Texts, GetAccountBalance(usernameLine));
        }

        private int GetAccountBalance(int usernameLine)
        {
            int accountBalance = int.Parse(File.ReadLines(MyFilename).Skip(usernameLine + 1).Take(1).First());
            return accountBalance;
            
        }

        private bool IsPassword(int usernameline, string password)
        {
            if (password == File.ReadLines(MyFilename).Skip(usernameline).Take(1).First())
            {
                return true;
            }
            return false;
        }

        private int CheckUsername(string username)
        {
            int counter = 0;

            foreach (string line in System.IO.File.ReadLines(MyFilename))
            {
                counter++;
                if (line == username)
                {
                    return counter;
                }
            }
            return 0;
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
            if (Tb_Password.Texts == "" || Tb_UserName.Texts == "")
            {
                MessageBox.Show("Your new username or password not filled in");
                return;
            }
            if (CheckUsername(Tb_UserName.Texts) != 0)
            {
                MessageBox.Show("Your username is in use");
                return;
            }
            AddUserInformationToTextFile(Tb_UserName.Texts);
            AddUserInformationToTextFile(Tb_Password.Texts);
            AddUserInformationToTextFile(starterMoney.ToString());
            HideAllComponents();
            Scene.AcconutMangementScene(Lbl_AccontBalance, Lbl_PasswordInfo, Lbl_UsernameInfo, Btn_GoToLobby, Tb_UserName.Texts, Tb_Password.Texts, GetAccountBalance(CheckUsername(Tb_UserName.Texts)));
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
