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
    public partial class CalisanSilForm : Form
    {
        public CalisanSilForm()
        {
            InitializeComponent();
        }

        int secilenId;

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

        private void CalisanSilForm_Load(object sender, EventArgs e)
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

        private void calisanSilbtn_Click(object sender, EventArgs e)
        {
            try
            {
                //int secilenId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                con.Open();
                SqlCommand com = new SqlCommand("SP_Calisanlar_Delete", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.Add("@calisan_id", secilenId);
                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Başarıyla Silindi");
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
