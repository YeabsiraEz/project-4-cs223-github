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
    public partial class delete : Form
    {
        int selectedRow = 0;
        public delete()
        {
            InitializeComponent();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            save s = new save();
            DataGridViewRow newdata = dataGridView1.Rows[selectedRow];
            newdata.Cells[0].Value = "";
            newdata.Cells[1].Value = "";
            newdata.Cells[2].Value = "";
            newdata.Cells[3].Value = "";
            newdata.Cells[4].Value = "";
            newdata.Cells[5].Value = "";
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = save.findbyname(obj_txt.Text);
        }
    }
}
