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
using System.Text.RegularExpressions;


namespace project_4_cs223
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {


        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_num.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            txt_iNum.Text = "";
            txt_objName.Text = "";
            txt_count.Text = "";
            txt_price.Text = "";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

            string message = "";
            foreach (var item in chk_option.CheckedItems) 
            {
                message += item.ToString(); 
            }
            MessageBox.Show(message);
            
            Regex num_error   = new Regex(@"[0-9]{" + txt_num.Text.Length + @"}");
            Regex inv_error   = new Regex(@"[0-9]{" + txt_iNum.Text.Length + @"}");
            Regex obj_error   = new Regex(@"[A-Z a-z]{" + txt_objName.Text.Length + @"}");
            Regex count_error = new Regex(@"[0-9]{" + txt_count.Text.Length + @"}");
            Regex price_error = new Regex(@"[0-9]{" + txt_price.Text.Length + @"}");


            errorProvider1.SetError(txt_price, null);
            errorProvider1.SetError(txt_count, null);
            errorProvider1.SetError(txt_objName, null);
            errorProvider1.SetError(txt_iNum, null);
            errorProvider1.SetError(txt_num, null);

            if (string.IsNullOrEmpty(txt_num.Text))
            {
                errorProvider1.SetError(txt_num, "please provide a number ");

            }

            else if (num_error.IsMatch(txt_num.Text) == false)
            {
                errorProvider1.SetError(txt_num, "please enter a number only ");
            }

            if (string.IsNullOrEmpty(txt_iNum.Text))
            {
                errorProvider1.SetError(txt_iNum, "enter a number ");


            }
            else if (inv_error.IsMatch(txt_iNum.Text) == false)
            {
                errorProvider1.SetError(txt_iNum, "please enter numbers only ");
            }

            if (string.IsNullOrEmpty(txt_objName.Text))
            {
                errorProvider1.SetError(txt_objName, "please provide a name ");


            }
            else if (obj_error.IsMatch(txt_objName.Text) == false)
            {
                errorProvider1.SetError(txt_objName, "please enter letters only ");
            }

            if (string.IsNullOrEmpty(txt_count.Text))
            {
                errorProvider1.SetError(txt_count, "please provide a number ");


            }
            else if (count_error.IsMatch(txt_count.Text) == false)
            {

                errorProvider1.SetError(txt_count, "please enter a number only ");
            }

            if (string.IsNullOrEmpty(txt_price.Text))
            {
                errorProvider1.SetError(txt_price, "please provide a number ");


            }
            else if (price_error.IsMatch(txt_price.Text) == false)
            {
                errorProvider1.SetError(txt_price, "please enter a number only ");
            }
            else
            {
                save s = new save
                {


                    number = txt_num.Text,
                    date = dateTimePicker1.Value,
                    inventoryNumber = txt_iNum.Text,
                    objectname = txt_objName.Text,
                    count = txt_count.Text,
                    price = txt_price.Text,
                    Availble = chk_isAva.Checked,
                    
                };
                s.Save();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = save.getAllSave();
            }

            


           







        }

        private void txt_num_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void chk_isAva_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chk_option_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lbl_user_Click(object sender, EventArgs e)
        {

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            login screen = new login();
            screen.Show();
            Hide();
        }
    }
    }
