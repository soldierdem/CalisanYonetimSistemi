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

namespace CalisanYonetimSistemi.Yonetici
{
    public partial class YoneticiEkleForm : Form
    {
        public YoneticiEkleForm()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-TO2M1MR;Initial Catalog=CalisanYonetim;Integrated Security=True");

        private void yoneticiEklebtn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string cinsiyet = "";
                if (radioE.Checked == true)
                {
                    cinsiyet = radioE.Text;
                }
                else
                {
                    cinsiyet = radioK.Text;
                }
                SqlCommand com = new SqlCommand("SP_Yoneticiler_Insert", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Add("@yonetici_ad", yoneticiAdtxt.Text);
                com.Parameters.Add("@yonetici_soyad", yoneticiSoyadtxt.Text);
                com.Parameters.Add("@yonetici_cinsiyet", cinsiyet);
                com.Parameters.Add("@yonetici_tc", yoneticiTCtxt.Text);
                com.Parameters.Add("@yonetici_tel", yoneticiTeltxt.Text);
                com.Parameters.Add("@yonetici_mail", yoneticiMailtxt.Text);
                com.Parameters.Add("@yonetici_maas", yoneticiMaastxt.Text);
                com.Parameters.Add("@yonetici_kullaniciAd", yoneticiKullaniciAdtxt.Text);
                com.Parameters.Add("@yonetici_sifre", float.Parse(yoneticiSifretxt.Text));
                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Başarıyla eklendi");
                Listele();
            }
            catch (Exception exp)
            {
                Console.WriteLine("Bir hata oldu");
            }
            
        }

        public void Listele()
        {
            try
            {
                SqlCommand com = new SqlCommand("exec dbo.SP_Yoneticiler_View", con);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception exp)
            {
                Console.WriteLine("Bir hata oldu");
            }
            
        }

        private void YoneticiEkleForm_Load(object sender, EventArgs e)
        {
            try
            {
                Listele();
            }
            catch (Exception exp)
            {
                Console.WriteLine("Bir hata oldu");
            }
        }

        private void yoneticiArabtn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand com = new SqlCommand("exec dbo.SP_Yoneticiler_Search '" + int.Parse(yoneticiAraIDtxt.Text) + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception exp)
            {
                Console.WriteLine("Bir hata oldu");
            }
            
        }
    }
}
