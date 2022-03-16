using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    class SceneClass
    {
        public void UsercreateScene()
        {
            Lbl_password.Text = "Select new Password";
            Lbl_username.Text = "Select new Username";
            Btn_Login.Hide();
            Btn_CreateLogin.Text = "Confirm";
        }




    }
}
