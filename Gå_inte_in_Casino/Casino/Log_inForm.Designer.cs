
namespace Casino
{
    partial class Log_inForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Tb_UserName = new System.Windows.Forms.TextBox();
            this.Tb_Password = new System.Windows.Forms.TextBox();
            this.Lbl_username = new System.Windows.Forms.Label();
            this.Lbl_password = new System.Windows.Forms.Label();
            this.Btn_Login = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_CreateLogin = new System.Windows.Forms.Button();
            this.Btn_NewLoginInformation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Tb_UserName
            // 
            this.Tb_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_UserName.Location = new System.Drawing.Point(607, 244);
            this.Tb_UserName.Name = "Tb_UserName";
            this.Tb_UserName.Size = new System.Drawing.Size(260, 38);
            this.Tb_UserName.TabIndex = 0;
            // 
            // Tb_Password
            // 
            this.Tb_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_Password.Location = new System.Drawing.Point(607, 317);
            this.Tb_Password.Name = "Tb_Password";
            this.Tb_Password.Size = new System.Drawing.Size(260, 38);
            this.Tb_Password.TabIndex = 1;
            // 
            // Lbl_username
            // 
            this.Lbl_username.AutoSize = true;
            this.Lbl_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_username.Location = new System.Drawing.Point(335, 244);
            this.Lbl_username.Name = "Lbl_username";
            this.Lbl_username.Size = new System.Drawing.Size(266, 31);
            this.Lbl_username.TabIndex = 2;
            this.Lbl_username.Text = "Enter your username";
            // 
            // Lbl_password
            // 
            this.Lbl_password.AutoSize = true;
            this.Lbl_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_password.Location = new System.Drawing.Point(338, 317);
            this.Lbl_password.Name = "Lbl_password";
            this.Lbl_password.Size = new System.Drawing.Size(263, 31);
            this.Lbl_password.TabIndex = 3;
            this.Lbl_password.Text = "Enter your password";
            // 
            // Btn_Login
            // 
            this.Btn_Login.Location = new System.Drawing.Point(929, 244);
            this.Btn_Login.Name = "Btn_Login";
            this.Btn_Login.Size = new System.Drawing.Size(108, 104);
            this.Btn_Login.TabIndex = 4;
            this.Btn_Login.Text = "Login";
            this.Btn_Login.UseVisualStyleBackColor = true;
            this.Btn_Login.Click += new System.EventHandler(this.Btn_Login_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(659, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // Btn_CreateLogin
            // 
            this.Btn_CreateLogin.Location = new System.Drawing.Point(1077, 244);
            this.Btn_CreateLogin.Name = "Btn_CreateLogin";
            this.Btn_CreateLogin.Size = new System.Drawing.Size(108, 104);
            this.Btn_CreateLogin.TabIndex = 6;
            this.Btn_CreateLogin.Text = "Create new login";
            this.Btn_CreateLogin.UseVisualStyleBackColor = true;
            this.Btn_CreateLogin.Click += new System.EventHandler(this.Btn_CreateLogin_Click);
            // 
            // Btn_NewLoginInformation
            // 
            this.Btn_NewLoginInformation.Location = new System.Drawing.Point(929, 266);
            this.Btn_NewLoginInformation.Name = "Btn_NewLoginInformation";
            this.Btn_NewLoginInformation.Size = new System.Drawing.Size(256, 61);
            this.Btn_NewLoginInformation.TabIndex = 7;
            this.Btn_NewLoginInformation.Text = "create new user";
            this.Btn_NewLoginInformation.UseVisualStyleBackColor = true;
            this.Btn_NewLoginInformation.Click += new System.EventHandler(this.Btn_NewLoginInformation_Click);
            // 
            // Log_inForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1484, 711);
            this.Controls.Add(this.Btn_NewLoginInformation);
            this.Controls.Add(this.Btn_CreateLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Btn_Login);
            this.Controls.Add(this.Lbl_password);
            this.Controls.Add(this.Lbl_username);
            this.Controls.Add(this.Tb_Password);
            this.Controls.Add(this.Tb_UserName);
            this.Name = "Log_inForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Tb_UserName;
        private System.Windows.Forms.TextBox Tb_Password;
        private System.Windows.Forms.Label Lbl_username;
        private System.Windows.Forms.Label Lbl_password;
        private System.Windows.Forms.Button Btn_Login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_CreateLogin;
        private System.Windows.Forms.Button Btn_NewLoginInformation;
    }
}

