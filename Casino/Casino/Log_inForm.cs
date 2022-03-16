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

namespace Casino
{
    public partial class Log_inForm : Form
    {
        public Log_inForm()
        {
            InitializeComponent();
        }
        private void Btn_Login_Click(object sender, EventArgs e)
        {
            
        }

        private async void ReadTextFile()
        {
            string filename = @"I:\rbk\Elevmappar\PROG1222120\Maximilian Ellnestam M TE2 20 SBÅ\Personligt\Casino\Casino\UserInformation.txt";

            char[] result;
            StringBuilder builder = new StringBuilder();

            using (StreamReader reader = File.OpenText(filename))
            {
                result = new char[reader.BaseStream.Length];
                await reader.ReadAsync(result, 0, (int)reader.BaseStream.Length);
            }

            foreach (char c in result)
            {
                if (char.IsLetterOrDigit(c) || char.IsWhiteSpace(c))
                {
                    builder.Append(c);
                }
            }
            builder.ToString();
        }

        private void Btn_CreateLogin_Click(object sender, EventArgs e)
        {
      

        }

        private void Btn_NewLoginInformation_Click(object sender, EventArgs e)
        {

        }
    }
}
