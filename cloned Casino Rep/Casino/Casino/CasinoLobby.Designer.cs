
namespace Casino
{
    partial class CasinoLobby
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
            this.Pb_Background = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Background)).BeginInit();
            this.SuspendLayout();
            // 
            // Pb_Background
            // 
            this.Pb_Background.Location = new System.Drawing.Point(1, 0);
            this.Pb_Background.Name = "Pb_Background";
            this.Pb_Background.Size = new System.Drawing.Size(1500, 750);
            this.Pb_Background.TabIndex = 0;
            this.Pb_Background.TabStop = false;
            // 
            // CasinoLobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1400, 673);
            this.Controls.Add(this.Pb_Background);
            this.Name = "CasinoLobby";
            this.Text = "CasinoLobby";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.Pb_Background)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Pb_Background;
    }
}