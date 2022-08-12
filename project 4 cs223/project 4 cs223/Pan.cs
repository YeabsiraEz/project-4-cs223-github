using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_4_cs223
{
    public partial class Pan : Form
    {
        public Pan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Green;
            panel3.Top = 161;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Yellow;
            panel3.Top = 210;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Red;
            panel3.Top = 258;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
