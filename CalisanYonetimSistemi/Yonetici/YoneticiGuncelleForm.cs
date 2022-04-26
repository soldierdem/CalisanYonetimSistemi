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
    public partial class YoneticiGuncelleForm : Form
    {
        public YoneticiGuncelleForm()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-TO2M1MR;Initial Catalog=CalisanYonetim;Integrated Security=True");

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

        private void YoneticiGuncelleForm_Load(object sender, EventArgs e)
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

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                yoneticiAdtxt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                yoneticiSoyadtxt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

                if (dataGridView1.CurrentRow.Cells[3].Value.ToString().Equals("E"))
                {
                    radioE.Checked = true;
                }
                else
                {
                    radioK.Checked = true;
                }

                yoneticiTCtxt.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                yoneticiTeltxt.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                yoneticiMailtxt.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                yoneticiMaastxt.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                yoneticiMaastxt.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                yoneticiMaastxt.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                yoneticiKullaniciAdtxt.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                yoneticiSifretxt.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            }
            catch (Exception exp)
            {
                Console.WriteLine("Bir hata oldu");
            }
            
        }

        private void yoneticiGuncellebtn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                int secilenId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                string cinsiyet = "";
                if (radioE.Checked == true)
                {
                    cinsiyet = "E";
                }
                else if (radioK.Checked == true)
                {
                    cinsiyet = "K";
                }

                SqlCommand com = new SqlCommand("SP_Yoneticiler_Update", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Add("@yonetici_id", secilenId);
                com.Parameters.Add("@yonetici_ad", yoneticiAdtxt.Text);
                com.Parameters.Add("@yonetici_soyad", yoneticiSoyadtxt.Text);
                com.Parameters.Add("@yonetici_cinsiyet", cinsiyet);
                com.Parameters.Add("@yonetici_tc", yoneticiTCtxt.Text);
                com.Parameters.Add("@yonetici_tel", yoneticiTeltxt.Text);
                com.Parameters.Add("@yonetici_mail", yoneticiMailtxt.Text);
                com.Parameters.Add("@yonetici_maas", yoneticiMaastxt.Text);
                com.Parameters.Add("@yonetici_kullaniciAd", yoneticiKullaniciAdtxt.Text);
                com.Parameters.Add("@yonetici_sifre", yoneticiSifretxt.Text);

                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Başarıyla Güncellendir");
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
