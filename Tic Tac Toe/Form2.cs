using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public partial class Form2 : Form
    {

        Form1 parent;
        public Form2(Form1 parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void p1_TextChanged(object sender, EventArgs e)
        {

        }

        private void p2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            parent.setPlayernames(P1.Text, P2.Text);
            this.Close();
        }
        private void P2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.ToString() == "\r")
            {
                button1.PerformClick();
            }
        }
    }
}
