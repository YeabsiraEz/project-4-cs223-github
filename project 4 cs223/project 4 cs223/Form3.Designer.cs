
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
            this.product__card1 = new project_4_cs223.product__card();
            this.product__card2 = new project_4_cs223.product__card();
            this.SuspendLayout();
            // 
            // product__card1
            // 
            this.product__card1.Location = new System.Drawing.Point(12, 12);
            this.product__card1.Name = "product__card1";
            this.product__card1.price = null;
            this.product__card1.Size = new System.Drawing.Size(311, 204);
            this.product__card1.TabIndex = 0;
            this.product__card1.Load += new System.EventHandler(this.product__card1_Load);
            // 
            // product__card2
            // 
            this.product__card2.Location = new System.Drawing.Point(367, 12);
            this.product__card2.Name = "product__card2";
            this.product__card2.price = "price";
            this.product__card2.Size = new System.Drawing.Size(311, 204);
            this.product__card2.TabIndex = 1;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.product__card2);
            this.Controls.Add(this.product__card1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private product__card product__card1;
        private product__card product__card2;
    }
}