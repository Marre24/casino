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
        public void UsercreateScene(Label Lbl_password, Label Lbl_username, Button Btn_Login, Button Btn_CreateLogin)
        {
            Lbl_password.Text = "Select new Password";
            Lbl_username.Text = "Select new Username";
            Btn_Login.Hide();
            Btn_CreateLogin.Text = "Confirm";
        }




    }
}
