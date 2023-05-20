using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MiniSQLEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=LAPTOP-ONATSOFT\ONATSOFT;Initial Catalog=RehberDB;Integrated Security=True");
        string sorgu;

        void Execute()
        {
            SqlDataAdapter da = new SqlDataAdapter(sorgu, baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            sorgu = richTextBox1.Text;
            try
            {
                Execute();
            }
            catch (Exception)
            {
                MessageBox.Show("Yazdığınız sorgu hatalı. Lütfen sorgunuzu kontrol ediniz!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnİslem_Click(object sender, EventArgs e)
        {
            sorgu = richTextBox1.Text;
            try
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand(sorgu, baglanti);
                cmd.ExecuteNonQuery();
                baglanti.Close();

                SqlDataAdapter da = new SqlDataAdapter("select * from Kisiler", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception)
            {
                MessageBox.Show("Yazdığınız sorgu hatalı. Lütfen sorgunuzu kontrol ediniz!", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnYardim_Click(object sender, EventArgs e)
        {
            richTextBox1.BackColor = Color.FromArgb(255, 192, 128);

            richTextBox1.Text = "YARDIM MESAJI\nBu editör sisteminde SQL Server altyapısını kullanarak bir tabloya ait " +
                "SQL sorguları ve ekleme, silme, güncelleme komutlarını yazabilmeyi sunar.\n" +
                "Kullanılan varsayılan veritabanı adı ve tablo: RehberDB // Kisiler\n" +
                "'select * from Kisiler' sorgusunu yazarak tüm verileri listeleyebilirsiniz.\n\n\n" +
                "Made by EchoSoft. Web Site: www.osomerr.cf";
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.BackColor = Color.White;
        }
    }
}
