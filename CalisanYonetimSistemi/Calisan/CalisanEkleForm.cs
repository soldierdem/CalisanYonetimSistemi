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

namespace CalisanYonetimSistemi.Calisan
{
    public partial class CalisanEkleForm : Form
    {
        public CalisanEkleForm()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-TO2M1MR;Initial Catalog=CalisanYonetim;Integrated Security=True");

        private void calisanEklebtn_Click(object sender, EventArgs e)
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
                SqlCommand com = new SqlCommand("SP_Calisanlar_Insert", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Add("@calisan_ad", calisanAdtxt.Text);
                com.Parameters.Add("@calisan_soyad", calisanSoyadtxt.Text);
                com.Parameters.Add("@calisan_cinsiyet", cinsiyet);
                com.Parameters.Add("@calisan_tc", calisanTCtxt.Text);
                com.Parameters.Add("@calisan_tel", calisanTeltxt.Text);
                com.Parameters.Add("@calisan_mail", calisanMailtxt.Text);
                com.Parameters.Add("@calisan_maas", calisanMaastxt.Text);
                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Başarıyla eklendi");
                Listele();
            }
            catch (Exception exp)
            {
                Console.WriteLine("Hatalı bilgi girildi");
            }
            
        }

        public void Listele()
        {
            try
            {
                SqlCommand com = new SqlCommand("exec dbo.SP_Calisanlar_View", con);
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

        private void CalisanEkleForm_Load(object sender, EventArgs e)
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

        private void calisanArabtn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand com = new SqlCommand("exec dbo.SP_Calisanlar_Search '" + int.Parse(calisanAraIDtxt.Text) + "'", con);
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
