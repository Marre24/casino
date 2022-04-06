using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casino
{
    class SceneClass
    {
        
        public void StartScene(Label Lbl_password, Label Lbl_username, Button Btn_Login, Button Btn_CreateLogin, CostomTextBox Tb_Password, CostomTextBox Tb_UserName)
        {
            Lbl_password.Text = "Enter your Password";
            Lbl_username.Text = "Enter your Username";
            Lbl_password.Show();
            Lbl_username.Show();
            Btn_Login.Show();
            Btn_CreateLogin.Show();
            Tb_Password.Show();
            Tb_UserName.Show();
        }

        public void LobbyScene(PictureBox Pb_Background, string lobbyImage)
        {

            Pb_Background.Image = Image.FromFile(lobbyImage);


        }

        public void UsercreateScene(Label Lbl_password, Label Lbl_username, Button Btn_Return, Button Btn_NewLoginInformation, CostomTextBox Tb_Password, CostomTextBox Tb_UserName)
        {
            Lbl_password.Text = "Select new Password";
            Lbl_username.Text = "Select new Username";
            Lbl_password.Show();
            Lbl_username.Show();

            Tb_UserName.Show();
            Tb_Password.Show();

            Btn_NewLoginInformation.Show();
            Btn_Return.Show();
        }

        public void AcconutMangementScene(Label Lbl_AccontBalance, Label Lbl_PasswordInfo, Label Lbl_UsernameInfo, Button Btn_GoToLobby, string username, string password, int balance, Button Btn_LogOut)
        {
            Lbl_UsernameInfo.Show();
            Lbl_PasswordInfo.Show();
            Lbl_AccontBalance.Show();
            Btn_GoToLobby.Show();
            Lbl_UsernameInfo.Text = "Username: " + username;
            Lbl_PasswordInfo.Text = "Password: " + password;
            Lbl_AccontBalance.Text = "Balance: " + balance.ToString();
            Btn_LogOut.Show();
        }


    }
}
