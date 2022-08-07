using project_4_cs223.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using project_4_cs223;

namespace project_4_cs223
{
    public partial class update : Form
    {
        public int selectedRow = 0;

        public update()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Search_btn_Click(object sender, EventArgs e)
        {
             save s = new save();

            

        
            string name = txt_oname.Text;

            dataGridView1.DataSource = save.findbyname(name);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedRow = e.RowIndex;
            txt_num1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_objectName.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_count1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_price1.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txt_IN.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            save s = new save();
            DataGridViewRow newdata = dataGridView1.Rows[selectedRow];
            newdata.Cells[0].Value = txt_num1.Text;
            newdata.Cells[1].Value = dateTimePicker1.Value;
            newdata.Cells[2].Value = txt_IN.Text;
            newdata.Cells[3].Value = txt_objectName.Text;
            newdata.Cells[4].Value = txt_count1.Text;
            newdata.Cells[5].Value = txt_price1.Text;
        }
    }
}
