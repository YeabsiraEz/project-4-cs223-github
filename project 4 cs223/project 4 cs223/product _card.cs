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

        private string _price;

        public string price
        {
            get { return _price; }
            set { _price = value; label1.Text = value; }
            
        }

        
    }
}
