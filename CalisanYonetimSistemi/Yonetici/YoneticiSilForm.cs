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
    public partial class YoneticiSilForm : Form
    {
        public YoneticiSilForm()
        {
            InitializeComponent();
        }

        int secilenId;

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

        private void YoneticiSilForm_Load(object sender, EventArgs e)
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
                secilenId = (int)dataGridView1.CurrentRow.Cells[0].Value;

            }
            catch (Exception exp)
            {
                Console.WriteLine("Bir hata oldu");
            }

        }

        private void yoneticiSilbtn_Click(object sender, EventArgs e)
        {
            try
            {
                //int secilenId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                con.Open();
                SqlCommand com = new SqlCommand("SP_Yoneticiler_Delete", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Add("@yonetici_id", secilenId);
                com.ExecuteNonQuery();
                int status;
                status = Convert.ToInt32(com.ExecuteScalar());
                if (status == 1)
                {
                    MessageBox.Show("Başarıyla Silindi");
                    Listele();
                }
                else
                {
                    MessageBox.Show("Sistemde en az bir yönetici bulunmalıdır.");
                    Listele();
                }
                con.Close();
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
