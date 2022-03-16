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
        readonly string MyFilename = @"I:\rbk\Elevmappar\PROG1222120\Maximilian Ellnestam M TE2 20 SBÅ\Personligt\Casino\Casino\UserInformation.txt";

        readonly SceneClass Scene = new SceneClass();
        public Log_inForm()
        {
            InitializeComponent();

        }
        private void Btn_Login_Click(object sender, EventArgs e)
        {
            
        }
        /*
        private async void ReadTextFile()
        {

            char[] result;
            StringBuilder builder = new StringBuilder();

            using (StreamReader reader = File.OpenText(MyFilename))
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
        }*/

        private void CheckTextfile(string input)
        {
            var keyword = input ?? "";  
            using (var sr = new StreamReader(MyFilename))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine();
                    if (String.IsNullOrEmpty(line)) continue;
                    if (line.IndexOf(keyword, StringComparison.CurrentCultureIgnoreCase) >= 0)
                    {
                        label3.Text = line;
                    }
                }
            }
        }

        public void SetUserinformation(string input)
        {
            int line_to_edit = 2;

            string lineToWrite = input;
            using (StreamReader reader = new StreamReader(MyFilename))
            {
                for (int i = 1; i <= line_to_edit; ++i)
                    lineToWrite = reader.ReadLine();
            }

            if (lineToWrite == null)
                throw new InvalidDataException("Line does not exist in " + MyFilename);

            // Read the old file.
            string[] lines = File.ReadAllLines(MyFilename);

            // Write the new file over the old file.
            using (StreamWriter writer = new StreamWriter(MyFilename))
            {
                for (int currentLine = 1; currentLine <= lines.Length; ++currentLine)
                {
                    if (currentLine == line_to_edit)
                    {
                        writer.WriteLine(lineToWrite);
                    }
                    else
                    {
                        writer.WriteLine(lines[currentLine - 1]);
                    }
                }
            }
        }


        private void Btn_CreateLogin_Click(object sender, EventArgs e)
        {
            Scene.UsercreateScene(Lbl_password, Lbl_username, Btn_Login, Btn_CreateLogin);
            CheckTextfile(Tb_Password.Text);
        }

        private void Btn_NewLoginInformation_Click(object sender, EventArgs e)
        {

        }
    }
}
