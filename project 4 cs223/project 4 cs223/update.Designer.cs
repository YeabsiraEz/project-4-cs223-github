
namespace project_4_cs223
{
    partial class update
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Oname = new System.Windows.Forms.Label();
            this.txt_oname = new System.Windows.Forms.TextBox();
            this.Search_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_price1 = new System.Windows.Forms.Label();
            this.lbl_count1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_in = new System.Windows.Forms.Label();
            this.txt_num1 = new System.Windows.Forms.TextBox();
            this.txt_IN = new System.Windows.Forms.TextBox();
            this.txt_objectName = new System.Windows.Forms.TextBox();
            this.txt_count1 = new System.Windows.Forms.TextBox();
            this.txt_price1 = new System.Windows.Forms.TextBox();
            this.btn_update = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Oname
            // 
            this.lbl_Oname.AutoSize = true;
            this.lbl_Oname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Oname.Location = new System.Drawing.Point(22, 43);
            this.lbl_Oname.Name = "lbl_Oname";
            this.lbl_Oname.Size = new System.Drawing.Size(98, 16);
            this.lbl_Oname.TabIndex = 0;
            this.lbl_Oname.Text = "Object Name";
            this.lbl_Oname.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_oname
            // 
            this.txt_oname.Location = new System.Drawing.Point(126, 42);
            this.txt_oname.Name = "txt_oname";
            this.txt_oname.Size = new System.Drawing.Size(204, 20);
            this.txt_oname.TabIndex = 1;
            // 
            // Search_btn
            // 
            this.Search_btn.Location = new System.Drawing.Point(171, 84);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(75, 23);
            this.Search_btn.TabIndex = 2;
            this.Search_btn.Text = "Search";
            this.Search_btn.UseVisualStyleBackColor = true;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 299);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(801, 150);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(419, 52);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(368, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(351, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Number";
            // 
            // lbl_price1
            // 
            this.lbl_price1.AutoSize = true;
            this.lbl_price1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price1.Location = new System.Drawing.Point(612, 94);
            this.lbl_price1.Name = "lbl_price1";
            this.lbl_price1.Size = new System.Drawing.Size(44, 16);
            this.lbl_price1.TabIndex = 9;
            this.lbl_price1.Text = "Price";
            this.lbl_price1.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl_count1
            // 
            this.lbl_count1.AutoSize = true;
            this.lbl_count1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_count1.Location = new System.Drawing.Point(362, 139);
            this.lbl_count1.Name = "lbl_count1";
            this.lbl_count1.Size = new System.Drawing.Size(47, 16);
            this.lbl_count1.TabIndex = 11;
            this.lbl_count1.Text = "Count";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(368, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Object Name";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // lbl_in
            // 
            this.lbl_in.AutoSize = true;
            this.lbl_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_in.Location = new System.Drawing.Point(527, 139);
            this.lbl_in.Name = "lbl_in";
            this.lbl_in.Size = new System.Drawing.Size(129, 16);
            this.lbl_in.TabIndex = 15;
            this.lbl_in.Text = "Inventory Number";
            this.lbl_in.Click += new System.EventHandler(this.label6_Click);
            // 
            // txt_num1
            // 
            this.txt_num1.Location = new System.Drawing.Point(419, 87);
            this.txt_num1.Name = "txt_num1";
            this.txt_num1.Size = new System.Drawing.Size(100, 20);
            this.txt_num1.TabIndex = 16;
            // 
            // txt_IN
            // 
            this.txt_IN.Location = new System.Drawing.Point(668, 135);
            this.txt_IN.Name = "txt_IN";
            this.txt_IN.Size = new System.Drawing.Size(100, 20);
            this.txt_IN.TabIndex = 18;
            // 
            // txt_objectName
            // 
            this.txt_objectName.Location = new System.Drawing.Point(493, 195);
            this.txt_objectName.Name = "txt_objectName";
            this.txt_objectName.Size = new System.Drawing.Size(183, 20);
            this.txt_objectName.TabIndex = 20;
            // 
            // txt_count1
            // 
            this.txt_count1.Location = new System.Drawing.Point(419, 135);
            this.txt_count1.Name = "txt_count1";
            this.txt_count1.Size = new System.Drawing.Size(100, 20);
            this.txt_count1.TabIndex = 22;
            // 
            // txt_price1
            // 
            this.txt_price1.Location = new System.Drawing.Point(668, 87);
            this.txt_price1.Name = "txt_price1";
            this.txt_price1.Size = new System.Drawing.Size(100, 20);
            this.txt_price1.TabIndex = 24;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(530, 239);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 25;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.txt_price1);
            this.Controls.Add(this.txt_count1);
            this.Controls.Add(this.txt_objectName);
            this.Controls.Add(this.txt_IN);
            this.Controls.Add(this.txt_num1);
            this.Controls.Add(this.lbl_in);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_count1);
            this.Controls.Add(this.lbl_price1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Search_btn);
            this.Controls.Add(this.txt_oname);
            this.Controls.Add(this.lbl_Oname);
            this.Name = "update";
            this.Text = "update";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Oname;
        private System.Windows.Forms.TextBox txt_oname;
        private System.Windows.Forms.Button Search_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_price1;
        private System.Windows.Forms.Label lbl_count1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_in;
        private System.Windows.Forms.TextBox txt_num1;
        private System.Windows.Forms.TextBox txt_IN;
        private System.Windows.Forms.TextBox txt_objectName;
        private System.Windows.Forms.TextBox txt_count1;
        private System.Windows.Forms.TextBox txt_price1;
        private System.Windows.Forms.Button btn_update;
    }
}