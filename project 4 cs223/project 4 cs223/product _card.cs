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
    public partial class product__card : UserControl
    {
        public product__card()
        {
            InitializeComponent();
        }

        private string _price,_dis,_title;

        public string price
        {
            get { return _price; }
            set { _price = value; label1.Text =value; }

        }
        

        public string discription
        {
            get { return _dis; }
            set { _dis = value; label2.Text = value; }
        }
      

        public string title
        {
            get { return _title; }
            set { _title = value; label3.Text = value; }
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void product__card_Load(object sender, EventArgs e)
        {

        }
        public product__card(string title, string discription, string price)
        {
            InitializeComponent();
            this.title = price;
            this.discription = discription;
            this.price = title;
            


        }
    }
}
