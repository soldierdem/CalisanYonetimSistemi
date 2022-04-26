namespace CalisanYonetimSistemi
{
    partial class Login
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.yoneticiAdGiristxt = new System.Windows.Forms.TextBox();
            this.yoneticiSifreGiristxt = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.yoneticiGirisbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yönetici Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 263);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yönetici Şifresi:";
            // 
            // yoneticiAdGiristxt
            // 
            this.yoneticiAdGiristxt.Location = new System.Drawing.Point(186, 209);
            this.yoneticiAdGiristxt.Name = "yoneticiAdGiristxt";
            this.yoneticiAdGiristxt.Size = new System.Drawing.Size(100, 20);
            this.yoneticiAdGiristxt.TabIndex = 2;
            // 
            // yoneticiSifreGiristxt
            // 
            this.yoneticiSifreGiristxt.Location = new System.Drawing.Point(186, 256);
            this.yoneticiSifreGiristxt.Name = "yoneticiSifreGiristxt";
            this.yoneticiSifreGiristxt.PasswordChar = '*';
            this.yoneticiSifreGiristxt.Size = new System.Drawing.Size(100, 20);
            this.yoneticiSifreGiristxt.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(148, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // yoneticiGirisbtn
            // 
            this.yoneticiGirisbtn.Location = new System.Drawing.Point(166, 324);
            this.yoneticiGirisbtn.Name = "yoneticiGirisbtn";
            this.yoneticiGirisbtn.Size = new System.Drawing.Size(90, 36);
            this.yoneticiGirisbtn.TabIndex = 5;
            this.yoneticiGirisbtn.Text = "Giriş";
            this.yoneticiGirisbtn.UseVisualStyleBackColor = true;
            this.yoneticiGirisbtn.Click += new System.EventHandler(this.yoneticiGirisbtn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(396, 426);
            this.Controls.Add(this.yoneticiGirisbtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.yoneticiSifreGiristxt);
            this.Controls.Add(this.yoneticiAdGiristxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giris";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox yoneticiAdGiristxt;
        private System.Windows.Forms.TextBox yoneticiSifreGiristxt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button yoneticiGirisbtn;
    }
}

