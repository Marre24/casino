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
        readonly SceneClass Scene = new SceneClass();
        public int starterMoney = 2000;                                                 //sett värde
        public int activeIndex;

        readonly string users = "users.txt";

        public List<string> usernameList = new List<string>();
        public List<string> passwordList = new List<string>();
        public List<int> balanceList = new List<int>();


        public Log_inForm()
        {
            InitializeComponent();
            HideAllComponents();
            Scene.StartScene(Lbl_password, Lbl_username, Btn_Login, Btn_CreateLogin, Tb_Password, Tb_UserName);

            List<PlayerAccount> players = LoadUsers();

            balanceList = players.Select(p => p.balance).ToList();
            usernameList = players.Select(p => p.username).ToList();
            passwordList = players.Select(p => p.password).ToList();

            BlackJackForm BlackJack = new BlackJackForm();
            BlackJack.Show();
        }
        private List<PlayerAccount> LoadUsers()
        {
            List<PlayerAccount> players = new List<PlayerAccount>();

            foreach (string userData in System.IO.File.ReadLines(users))
            {
                PlayerAccount p = new PlayerAccount(userData);

                players.Add(p);
            }


            return players;
        }


        private void Btn_Login_Click(object sender, EventArgs e)
        {
            if (!usernameList.Contains(Tb_UserName.Texts))
            {
                MessageBox.Show("Username not found");
                return;
            }
            if (!passwordList.Contains(Tb_Password.Texts))
            {
                MessageBox.Show("Password not found");
                return;
            }
            int counter = 0;
            foreach (string user in usernameList)
            {
                if (Tb_UserName.Texts == usernameList[counter])
                {
                    activeIndex = counter;
                }
                counter++;
            }
            if (passwordList[activeIndex] != Tb_Password.Texts)
            {
                MessageBox.Show("Wrong password");
                return;
            }
            HideAllComponents();
            Scene.AcconutMangementScene(Lbl_AccontBalance, Lbl_PasswordInfo, Lbl_UsernameInfo, Btn_GoToLobby, Tb_UserName.Texts, Tb_Password.Texts, balanceList[activeIndex], Btn_LogOut);
        }

        private void Btn_CreateLogin_Click(object sender, EventArgs e)
        {
            HideAllComponents();
            Scene.UsercreateScene(Lbl_password, Lbl_username, Btn_Return, Btn_NewLoginInformation, Tb_Password, Tb_UserName);
        }
        private void AddUserInformationToTextFile(string username, string password, string starterBalance)
        {
            using (StreamWriter sw = new StreamWriter(users, true))
            {
                sw.WriteLine(username + ";" + password + ";" + starterBalance + ";");
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
            if (usernameList.Contains(Tb_UserName.Texts))
            {
                MessageBox.Show("Your username is in use");
                return;
            }
            AddUserInformationToTextFile(Tb_UserName.Texts, Tb_Password.Texts, starterMoney.ToString());

            HideAllComponents();
            Scene.AcconutMangementScene(Lbl_AccontBalance, Lbl_PasswordInfo, Lbl_UsernameInfo, Btn_GoToLobby, Tb_UserName.Texts, Tb_Password.Texts, balanceList[activeIndex], Btn_LogOut);
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

        private void Btn_LogOut_Click(object sender, EventArgs e)
        {
            Tb_UserName.Texts = "";
            Tb_Password.Texts = "";
            HideAllComponents();
            activeIndex = 0;
            Scene.StartScene(Lbl_password, Lbl_username, Btn_Login, Btn_CreateLogin, Tb_Password, Tb_UserName);
        }


    }
}
