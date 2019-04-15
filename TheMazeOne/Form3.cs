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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
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

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }




    

        
    }
}
