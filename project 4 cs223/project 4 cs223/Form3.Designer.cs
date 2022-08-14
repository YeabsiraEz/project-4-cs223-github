
namespace project_4_cs223
{
    partial class Form3
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
            this.product__card2 = new project_4_cs223.product__card();
            this.product__card1 = new project_4_cs223.product__card();
            this.product__card3 = new project_4_cs223.product__card();
            this.SuspendLayout();
            // 
            // product__card2
            // 
            this.product__card2.discription = "ll";
            this.product__card2.Location = new System.Drawing.Point(367, 12);
            this.product__card2.Name = "product__card2";
            this.product__card2.price = "pr";
            this.product__card2.Size = new System.Drawing.Size(311, 204);
            this.product__card2.TabIndex = 1;
            this.product__card2.title = null;
            // 
            // product__card1
            // 
            this.product__card1.discription = "ll";
            this.product__card1.Location = new System.Drawing.Point(12, 12);
            this.product__card1.Name = "product__card1";
            this.product__card1.price = "ll";
            this.product__card1.Size = new System.Drawing.Size(311, 204);
            this.product__card1.TabIndex = 0;
            this.product__card1.title = "ll";
            this.product__card1.Load += new System.EventHandler(this.product__card1_Load);
            // 
            // product__card3
            // 
            this.product__card3.discription = "";
            this.product__card3.Location = new System.Drawing.Point(384, 211);
            this.product__card3.Name = "product__card3";
            this.product__card3.price = "ll";
            this.product__card3.Size = new System.Drawing.Size(311, 204);
            this.product__card3.TabIndex = 2;
            this.product__card3.title = "ll";
            this.product__card3.Load += new System.EventHandler(this.product__card3_Load);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.product__card3);
            this.Controls.Add(this.product__card2);
            this.Controls.Add(this.product__card1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private product__card product__card1;
        private product__card product__card2;
        private product__card product__card3;
    }
}