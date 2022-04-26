using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalisanYonetimSistemi
{
    public partial class Login : Form
    {
        
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-TO2M1MR;Initial Catalog=CalisanYonetim;Integrated Security=True");

        public Login()
        {
            InitializeComponent();
        }

        private void yoneticiGirisbtn_Click(object sender, EventArgs e)
        {
                con.Open();
                SqlCommand com = new SqlCommand("SP_Yoneticiler_Login", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Add("@yonetici_kullaniciAd", yoneticiAdGiristxt.Text);
                com.Parameters.Add("@yonetici_sifre", yoneticiSifreGiristxt.Text);
                com.ExecuteNonQuery();
                int status;
                status = Convert.ToInt32(com.ExecuteScalar());
                if(status == 1)
                {
                    MessageBox.Show("Giriş başarılı");
                    YonetimPaneli yonetimPaneli = new YonetimPaneli();
                    yonetimPaneli.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Hatalı giriş");
                }
                con.Close();
        }
    }
}
