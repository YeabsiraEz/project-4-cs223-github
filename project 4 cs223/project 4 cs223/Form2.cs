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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void addNewProductToolStripMenuItem_Click(object sender, EventArgs e)
        {


            if (ActiveMdiChild != null) 
            {
                ActiveMdiChild.Close();
            }
            
            
            Form1 form = new Form1();
            form.MdiParent = this;
            form.Show();
        }

        private void productToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void updateProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
             if (ActiveMdiChild != null) 
            {
                ActiveMdiChild.Close();
            }
            
            
            update form = new update();
            form.MdiParent = this;
            form.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }


            delete form = new delete();
            form.MdiParent = this;
            form.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }


            disall form = new disall();
            form.MdiParent = this;
            form.Show();
        }
    }
}
