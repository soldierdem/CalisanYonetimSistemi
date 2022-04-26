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
    public partial class CalisanGuncelleForm : Form
    {
        public CalisanGuncelleForm()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-TO2M1MR;Initial Catalog=CalisanYonetim;Integrated Security=True");

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

        private void CalisanGuncelleForm_Load(object sender, EventArgs e)
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
                calisanAdtxt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                calisanSoyadtxt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

                if (dataGridView1.CurrentRow.Cells[3].Value.ToString().Equals("E"))
                {
                    radioE.Checked = true;
                }
                else
                {
                    radioK.Checked = true;
                }

                calisanTCtxt.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                calisanTeltxt.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                calisanMailtxt.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                calisanMaastxt.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            }
            catch (Exception exp)
            {
                Console.WriteLine("Bir hata oldu");
            }
            
        }

        private void calisanGuncellebtn_Click(object sender, EventArgs e)
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
                SqlCommand com = new SqlCommand("SP_Calisanlar_Update",con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Add("@calisan_id",secilenId);
                com.Parameters.Add("@calisan_ad", calisanAdtxt.Text);
                com.Parameters.Add("@calisan_soyad", calisanSoyadtxt.Text);
                com.Parameters.Add("@calisan_cinsiyet", cinsiyet);
                com.Parameters.Add("@calisan_tc", calisanTCtxt.Text);
                com.Parameters.Add("@calisan_tel", calisanTeltxt.Text);
                com.Parameters.Add("@calisan_mail", calisanMailtxt.Text);
                com.Parameters.Add("@calisan_maas", calisanMaastxt.Text);
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
