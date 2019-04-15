using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheMazeOne
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        private void MoveToStart()
        {
            Point StartingPoint = panel1.Location;
            StartingPoint.Offset(10, 10);
            Cursor.Position = PointToScreen(StartingPoint);
        }

        private void label42_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Congratulations!");
            this.Close();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            MoveToStart();
        }
        public int count = 0;
        public int y = 164, top = 152, go = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            if (count == 20)
            {
                if (blink1.Visible == true)
                {
                    blink1.Visible = false;
                }
                else
                {
                    blink1.Visible = true;
                }
                count = 0;
            }
            if ((y <= 176) && (go == 0))
            {
                y = y - 1;
                move1.Location = new Point(111, y);
                if (y <= top)
                {
                    go = 1;
                }
            }
            if ((y >= top) && (go == 1))
            {
                y = y + 1;
                move1.Location = new Point(111, y);
                if (y >= 176)
                {
                    go = 0;
                }
            }
        }

        private void Form6_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }

        private void move1_MouseEnter(object sender, EventArgs e)
        {
            MoveToStart();
        }


        
    }
}
