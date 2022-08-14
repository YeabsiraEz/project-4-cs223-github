using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using project_4_cs223.model;

namespace project_4_cs223
{
    public partial class disall : Form
    {
        public disall()
        {
            InitializeComponent();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            product__card p = new product__card();
           flowLayoutPanel1.Controls.Clear();
            foreach (var item in save.getallproducts())
            {


                p.price = item.objectname;
                p.discription = item.number;
                p.title = item.price;

                flowLayoutPanel1.Controls.Add(p);
            }
            
            
                
               

            
        }
    }
}
