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
    public partial class Form4 : Form
    {
        
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            MoveToStart();
        }

        private void FinishLabel_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Congratulations!!");
          
            this.Close();
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

        private void timer1_Tick(object sender, EventArgs e)
        {
                
                    if (tick1.Visible == true)
                    {
                        tick1.Visible = false;
                    }
                    else tick1.Visible = true;


                    if (tick2.Visible == true)
                    {
                        tick2.Visible = false;
                    }
                    else tick2.Visible = true;


                    if (tick3.Visible == true)
                    {
                        tick3.Visible = false;
                    }
                    else tick3.Visible = true;


                    if (tick4.Visible == true)
                    {
                        tick4.Visible = false;
                    }
                    else tick4.Visible = true;


                    if (tick5.Visible == true)
                    {
                        tick5.Visible = false;
                    }
                    else tick5.Visible = true;


                    if (tick6.Visible == true)
                    {
                        tick6.Visible = false;
                    }
                    else tick6.Visible = true;


                    if (tick7.Visible == true)
                    {
                        tick7.Visible = false;
                    }
                    else tick7.Visible = true;

        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }
    }
}
