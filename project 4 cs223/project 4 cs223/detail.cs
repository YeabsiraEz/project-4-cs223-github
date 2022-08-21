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
    public partial class detail : Form
    {
        public detail()
        {
            InitializeComponent();
        }
        public String title
        {
            get { return lbl_tit.Text; }
            set { lbl_tit.Text = value; }
        }
        public String price
        {
            get { return lbl_price.Text; }
            set { lbl_price.Text = value; }

        }
        public String date
        {
            get { return lbl_dat.Text; }
            set { lbl_dat.Text = value; }
        }
        public string number
        {
            get { return lbl_num.Text; }
            set { lbl_num.Text = value; }
        }
        public string inventoryNumber
        {
            get { return lbl_Inv.Text; }
            set { lbl_Inv.Text = value; }
        }
        public string count
        {
            get { return lbl_cnt.Text; }
            set { lbl_cnt.Text = value; }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
