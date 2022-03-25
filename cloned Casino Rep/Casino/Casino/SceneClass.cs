using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casino
{
    class SceneClass
    {
        public void StartScene(Label Lbl_password, Label Lbl_username, Button Btn_Login, Button Btn_CreateLogin, TextBox Tb_Password, TextBox Tb_UserName)
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
        public void UsercreateScene(Label Lbl_password, Label Lbl_username, Button Btn_Return, Button Btn_NewLoginInformation, TextBox Tb_Password, TextBox Tb_UserName)
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

        public void AcconutMangementScene()
        {

        }


    }
}
