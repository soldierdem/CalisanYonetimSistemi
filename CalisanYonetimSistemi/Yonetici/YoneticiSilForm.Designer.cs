namespace CalisanYonetimSistemi.Yonetici
{
    partial class YoneticiSilForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YoneticiSilForm));
            this.yoneticiSilbtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.yoneticiAraIDtxt = new System.Windows.Forms.TextBox();
            this.yoneticiArabtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // yoneticiSilbtn
            // 
            this.yoneticiSilbtn.BackColor = System.Drawing.Color.IndianRed;
            this.yoneticiSilbtn.Image = ((System.Drawing.Image)(resources.GetObject("yoneticiSilbtn.Image")));
            this.yoneticiSilbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.yoneticiSilbtn.Location = new System.Drawing.Point(12, 12);
            this.yoneticiSilbtn.Name = "yoneticiSilbtn";
            this.yoneticiSilbtn.Size = new System.Drawing.Size(136, 90);
            this.yoneticiSilbtn.TabIndex = 2;
            this.yoneticiSilbtn.Text = "SİL";
            this.yoneticiSilbtn.UseVisualStyleBackColor = false;
            this.yoneticiSilbtn.Click += new System.EventHandler(this.yoneticiSilbtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(172, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(616, 426);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(12, 315);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 24);
            this.label8.TabIndex = 25;
            this.label8.Text = "Yonetici ID";
            // 
            // yoneticiAraIDtxt
            // 
            this.yoneticiAraIDtxt.Location = new System.Drawing.Point(12, 350);
            this.yoneticiAraIDtxt.Name = "yoneticiAraIDtxt";
            this.yoneticiAraIDtxt.Size = new System.Drawing.Size(122, 20);
            this.yoneticiAraIDtxt.TabIndex = 24;
            // 
            // yoneticiArabtn
            // 
            this.yoneticiArabtn.BackColor = System.Drawing.Color.IndianRed;
            this.yoneticiArabtn.Image = ((System.Drawing.Image)(resources.GetObject("yoneticiArabtn.Image")));
            this.yoneticiArabtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.yoneticiArabtn.Location = new System.Drawing.Point(12, 383);
            this.yoneticiArabtn.Name = "yoneticiArabtn";
            this.yoneticiArabtn.Size = new System.Drawing.Size(108, 55);
            this.yoneticiArabtn.TabIndex = 23;
            this.yoneticiArabtn.Text = "         ARA";
            this.yoneticiArabtn.UseVisualStyleBackColor = false;
            this.yoneticiArabtn.Click += new System.EventHandler(this.yoneticiArabtn_Click);
            // 
            // YoneticiSilForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.yoneticiAraIDtxt);
            this.Controls.Add(this.yoneticiArabtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.yoneticiSilbtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "YoneticiSilForm";
            this.Text = "YoneticiSilForm";
            this.Load += new System.EventHandler(this.YoneticiSilForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button yoneticiSilbtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox yoneticiAraIDtxt;
        private System.Windows.Forms.Button yoneticiArabtn;
    }
}