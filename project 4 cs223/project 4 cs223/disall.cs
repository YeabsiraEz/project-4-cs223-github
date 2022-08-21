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
           
            
            
                
               

            
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void disall_Load(object sender, EventArgs e)
        {
          
            flowLayoutPanel1.Controls.Clear();
            foreach (var item in save.getallproducts())
            {
                product__card p = new product__card(item.objectname, item.number, item.price);
                p.Click += (object o, EventArgs e2) =>
                {
                   
                    detail d = new detail();
                    d.title = item.objectname;
                    d.date = item.date.ToString();
                    d.price = item.price.ToString();
                    d.number = item.number.ToString();
                    d.count = item.count.ToString();
                    d.inventoryNumber = item.inventoryNumber.ToString();
                    d.Show();
                };



                flowLayoutPanel1.Controls.Add(p);
            }
        }
        private void custom (object o, EventArgs e)
        {
            
            MessageBox.Show("clicked");
        }
    }
}
