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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 frm = new Form1();
            frm.Show();
        }

        private void Level1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form3 frm = new Form3();
            frm.Show();
        }

        private void Level2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form4 frm = new Form4();
            frm.Show();
        }

        private void Level3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form5 frm = new Form5();
            frm.Show();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show();
        }

        private void Level4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form6 frm = new Form6();
            frm.Show();
        }
    }
}
