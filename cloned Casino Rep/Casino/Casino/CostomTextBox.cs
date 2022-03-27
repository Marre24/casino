using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casino
{
    public partial class CostomTextBox : UserControl
    {
        //Metoder kommer inte att funka, om du vill så får du kolla på videon igen ungefär vid 15.00  https://www.youtube.com/watch?v=CkpUQYzYCC8&t=108s&ab_channel=RJCodeAdvanceEN

        //Fields
        private Color borderColor = Color.MediumSlateBlue;
        private int borderSize = 2;
        private bool underlinedStyle = false;
        private Color borderFocusColor = Color.HotPink;
        private bool isFocused = false;

        //Constructor
        public CostomTextBox()
        {
            InitializeComponent();
        }

        //properties
        [Category("TextboxExtra")]
        public Color BorderColor {
            get 
            {
                return borderColor; 
            } 
            set 
            { 
                borderColor = value;
                this.Invalidate(); 
            }
        }
        [Category("TextboxExtra")]
        public int BorderSize 
        {
            get
            { 
                return borderSize;
            } 
            set 
            { borderSize = value; 
                this.Invalidate();
            }
        }
        [Category("TextboxExtra")]
        public bool UnderlinedStyle { get
            {
                return underlinedStyle;
            }
            set
            {
                underlinedStyle = value;
                this.Invalidate();
            }  
        }
        [Category("TextboxExtra")]
        public bool PasswordChar
        {
            get { return textBox1.UseSystemPasswordChar; }
            set { textBox1.UseSystemPasswordChar = value; }
        }
        [Category("TextboxExtra")]
        public bool Multiline
        {
            get { return textBox1.Multiline; }
            set { textBox1.Multiline = value; }
        }
        [Category("TextboxExtra")]
        public override Color BackColor { get 
            {
                return base.BackColor; 
            }
            set 
            {
                base.BackColor = value; 
                textBox1.BackColor = value;
            }
        }
        [Category("TextboxExtra")]
        public override Color ForeColor 
        {
            get
            {
                return base.ForeColor;
            }
            set
            {
                base.ForeColor = value;
                textBox1.ForeColor = value;
            }
        }
        [Category("TextboxExtra")]
        public override Font Font
        {
            get
            {
                return base.Font;
            }
            set
            {
                base.Font = value;
                textBox1.Font = value;
                if (this.DesignMode)
                {
                    UpdateControlHeight();
                }
            }
        }
        [Category ("TextboxExtra")]
        public string Texts
        {
            get
            {
                return textBox1.Text;
            }
            set
            {
                textBox1.Text = value;
            }
        }
        [Category("TextboxExtra")]
        public Color BorderFocusColor { get => borderFocusColor; set => borderFocusColor = value; }

        //overridden methods
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;

            //draw Border
            using (Pen penBorder = new Pen(borderColor, borderSize))
            {
                penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;

                if (!isFocused)
                {
                    if (underlinedStyle)
                        g.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    else
                        g.DrawRectangle(penBorder, 0, 0, this.Width - 0.5f, this.Height - 0.5f);
                }
                else
                {
                    penBorder.Color = borderFocusColor;

                    if (underlinedStyle)
                        g.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    else
                        g.DrawRectangle(penBorder, 0, 0, this.Width - 0.5f, this.Height - 0.5f);
                }
            }
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            UpdateControlHeight();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }
        private void UpdateControlHeight()
        {
            if (textBox1.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize =  new Size(0, txtHeight);
                textBox1.Multiline = false;

                this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            isFocused = true;
            this.Invalidate();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            isFocused= false;
            this.Invalidate();
        }
    }
}
