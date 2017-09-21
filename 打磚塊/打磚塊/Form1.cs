using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data; 
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 打磚塊
{
    public partial class Form1 : Form
    {
        public int speed_left=4;
        public int speed_top = 4;
        public int scores = 0;
        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
            Cursor.Hide();
            this.FormBorderStyle = FormBorderStyle.None;
            this.TopMost = true;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            Racket.Top = playground.Bottom - (playground.Bottom / 10);
            label.Left = (playground.Width / 2) - (label.Width / 2);
            label.Top = (playground.Height / 2) - (label.Height / 2);
            label.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Racket.Left = Cursor.Position.X - (Racket.Width / 2);
            Ball.Left += speed_left;
            Ball.Top += speed_top;
            if(Ball.Bottom>=Racket.Top&&Ball.Bottom<=Racket.Bottom&&Ball.Left>=Racket.Left&&Ball.Right<=Racket.Right)
            {
                speed_left += 2;
                speed_top+=2;
                speed_top = -speed_top;
                scores += 1;
                p.Text = scores.ToString();
                Random r=new Random();
                playground.BackColor = Color.FromArgb(r.Next(150, 250), r.Next(150, 250), r.Next(150, 250));
            }
            if(Ball.Left<=playground.Left)
            {
                speed_left = -speed_left;
            }
            if (Ball.Right>=playground.Right)
            {
                speed_left = -speed_left;
            }
            if (Ball.Top <= playground.Top)
            {
                speed_top = -speed_top;
            }
            if (Ball.Bottom >=playground.Bottom)
            {
                timer1.Enabled = false;
                label.Visible = true;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();
            if(e.KeyCode==Keys.F1)
            {
                Ball.Top = 50;
                Ball.Left = 50;
                speed_left = 4;
                speed_top = 4;
                scores = 0;
                p.Text = "0";
                timer1.Enabled = true;
                label.Visible = false;
                playground.BackColor = Color.White;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
    }
}
