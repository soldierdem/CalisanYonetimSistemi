namespace CalisanYonetimSistemi.Calisan
{
    partial class CalisanSilForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalisanSilForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.calisanSilbtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.calisanAraIDtxt = new System.Windows.Forms.TextBox();
            this.calisanArabtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(172, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(616, 426);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // calisanSilbtn
            // 
            this.calisanSilbtn.BackColor = System.Drawing.Color.IndianRed;
            this.calisanSilbtn.Image = ((System.Drawing.Image)(resources.GetObject("calisanSilbtn.Image")));
            this.calisanSilbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.calisanSilbtn.Location = new System.Drawing.Point(12, 12);
            this.calisanSilbtn.Name = "calisanSilbtn";
            this.calisanSilbtn.Size = new System.Drawing.Size(136, 90);
            this.calisanSilbtn.TabIndex = 1;
            this.calisanSilbtn.Text = "SİL";
            this.calisanSilbtn.UseVisualStyleBackColor = false;
            this.calisanSilbtn.Click += new System.EventHandler(this.calisanSilbtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(8, 315);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 24);
            this.label8.TabIndex = 22;
            this.label8.Text = "Calisan ID";
            // 
            // calisanAraIDtxt
            // 
            this.calisanAraIDtxt.Location = new System.Drawing.Point(8, 350);
            this.calisanAraIDtxt.Name = "calisanAraIDtxt";
            this.calisanAraIDtxt.Size = new System.Drawing.Size(122, 20);
            this.calisanAraIDtxt.TabIndex = 21;
            // 
            // calisanArabtn
            // 
            this.calisanArabtn.BackColor = System.Drawing.Color.IndianRed;
            this.calisanArabtn.Image = ((System.Drawing.Image)(resources.GetObject("calisanArabtn.Image")));
            this.calisanArabtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.calisanArabtn.Location = new System.Drawing.Point(8, 383);
            this.calisanArabtn.Name = "calisanArabtn";
            this.calisanArabtn.Size = new System.Drawing.Size(108, 55);
            this.calisanArabtn.TabIndex = 20;
            this.calisanArabtn.Text = "         ARA";
            this.calisanArabtn.UseVisualStyleBackColor = false;
            this.calisanArabtn.Click += new System.EventHandler(this.calisanArabtn_Click);
            // 
            // CalisanSilForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.calisanAraIDtxt);
            this.Controls.Add(this.calisanArabtn);
            this.Controls.Add(this.calisanSilbtn);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CalisanSilForm";
            this.Text = "CalisanSilForm";
            this.Load += new System.EventHandler(this.CalisanSilForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button calisanSilbtn;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox calisanAraIDtxt;
        private System.Windows.Forms.Button calisanArabtn;
    }
}