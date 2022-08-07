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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_userName.Text = "";
            txt_password.Text = "";
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txt_userName.Text;
            string password = txt_password.Text;

            if (username == "admin" && password == "admin")
            {
                Form1 screen = new Form1();
                screen.Show();
                Hide();
                
            }
            else
                MessageBox.Show("incorrect password");

                
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
