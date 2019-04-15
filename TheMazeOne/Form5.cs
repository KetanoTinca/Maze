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
    public partial class Form5 : Form
    {
        
        public Form5()
        {
            InitializeComponent();
           
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Congratulations");
            this.Close();
        }
        public int go1 = 0;
        public int go2 = 1;
        public int y1 = 308, y2=282 ,top= 270;

        private void timer1_Tick(object sender, EventArgs e)
        {    
           if((y1<= 308) && (go1 == 0))
            {
                y1 = y1 - 2;
                move1.Location = new Point(288, y1);
                if(y1 <= top)
                {
                    go1=1;
                }
            }
            if((y1 >= top) && (go1 == 1))
            {
                y1 = y1 + 2;
                move1.Location = new Point(288, y1);
                if(y1 >= 308)
                {
                    go1 = 0;
                }
            }

            if ((y2 <= 308) && (go1 == 0))
            {
                y2 = y2 - 2;
                move2.Location = new Point(364, y2);
                if (y2 <= top)
                {
                    go2 = 1;
                }
            }
            if ((y2 >= top) && (go2 == 1))
            {
                y2 = y2 + 2;
                move2.Location = new Point(364, y2);
                if (y2 >= 308)
                {
                    go2 = 0;
                }
            }

        }

        private void MoveToStart()
        {
            Point StartingPoint = panel1.Location;
            StartingPoint.Offset(10, 10);
            Cursor.Position = PointToScreen(StartingPoint);
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            MoveToStart();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            MoveToStart();
        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }
    }
}
