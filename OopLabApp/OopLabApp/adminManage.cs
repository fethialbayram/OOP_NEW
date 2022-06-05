using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Security.Cryptography;
using System.Data.SqlClient;

namespace OopLabApp
{
    public partial class adminManage : Form
    {

        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter da;

        void kullaniciGetir()
        {

            baglanti = new SqlConnection("Data Source=FETHI-OMEN;Initial Catalog=OOP_LAB;Integrated Security=True");
            baglanti.Open();
            da = new SqlDataAdapter("SELECT * FROM kullanici", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();

        }


        public adminManage()
        {
            InitializeComponent();
        }
       

        private void Kaydolbtn_Click(object sender, EventArgs e)
        {

            SHA256Managed SHA256 = new SHA256Managed();

            byte[] sifreleme = Encoding.UTF8.GetBytes(textBox2.Text);

            sifreleme = SHA256.ComputeHash(sifreleme);

            StringBuilder sb = new StringBuilder();

            foreach (byte b in sifreleme)
            {
                sb.Append(b.ToString("X2"));
            }

            textBox2.Text = sb.ToString();

            baglanti = new SqlConnection("Data Source=FETHI-OMEN;Initial Catalog=OOP_LAB;Integrated Security=True");
            string sorgu = "INSERT INTO kullanici(USERNAME, PASSWORD, NAME_SURNAME, PHONE, ADDRESS, CITY, COUNTRY, EMAIL) VALUES (@USERNAME,@PASSWORD,@NAME_SURNAME,@PHONE,@ADDRESS,@CITY,@COUNTRY,@EMAIL)";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@USERNAME", textBox1.Text);
            komut.Parameters.AddWithValue("@PASSWORD", textBox2.Text);
            komut.Parameters.AddWithValue("@NAME_SURNAME", textBox3.Text);
            komut.Parameters.AddWithValue("@PHONE", textBox4.Text);
            komut.Parameters.AddWithValue("@ADDRESS", textBox5.Text);
            komut.Parameters.AddWithValue("@CITY", textBox6.Text);
            komut.Parameters.AddWithValue("@COUNTRY", textBox7.Text);
            komut.Parameters.AddWithValue("@EMAIL", textBox8.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();


   
        }

        private void Silbtn_Click(object sender, EventArgs e)
        {
            string sorgu = "DELETE FROM kullanici WHERE USERID=@USERID";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@USERID", Convert.ToInt32(textusrid.Text));
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            kullaniciGetir();
        }

        private void Gnclbtn_Click(object sender, EventArgs e)
        {
            baglanti = new SqlConnection("Data Source=FETHI-OMEN;Initial Catalog=OOP_LAB;Integrated Security=True");
            string sorgu = "UPDATE kullanici SET NAME_SURNAME=@NAME_SURNAME,PHONE=@PHONE,ADDRESS=@ADDRESS,CITY=@CITY,COUNTRY=@COUNTRY,EMAIL=@EMAIL WHERE USERID=@USERID";
            komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@USERID", Convert.ToInt32(textusrid.Text));
            komut.Parameters.AddWithValue("@NAME_SURNAME",textBox3.Text);
            komut.Parameters.AddWithValue("@PHONE",textBox4.Text);
            komut.Parameters.AddWithValue("@ADDRESS",textBox5.Text);
            komut.Parameters.AddWithValue("@CITY",textBox6.Text);
            komut.Parameters.AddWithValue("@COUNTRY",textBox7.Text);
            komut.Parameters.AddWithValue("@EMAIL",textBox8.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            kullaniciGetir();
        }

        private void adminManage_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void adminManage_Load(object sender, EventArgs e)
        {
            kullaniciGetir();
        }

        private void sha256btn_Click(object sender, EventArgs e)
        {

        }

        private void gosterbtn_Click(object sender, EventArgs e)
        {
            kullaniciGetir();

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            textusrid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBox8.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }   
    }
}
