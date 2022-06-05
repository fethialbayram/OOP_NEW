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
    public partial class Uyeol : Form
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

        public Uyeol()
        {
            InitializeComponent();
        }

        
        private void Uyeol_Load(object sender, EventArgs e)
        {
            kullaniciGetir();
        }

        private void Uyeol_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Kaydolbtn_Click(object sender, EventArgs e)
        {
            SHA256Managed SHA256 = new SHA256Managed();

            byte[] sifreleme = Encoding.UTF8.GetBytes(textBox3.Text);

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
            kullaniciGetir();


        }

        private void dataGridView1_AutoSizeColumnsModeChanged(object sender, DataGridViewAutoSizeColumnsModeEventArgs e)
        {

        }        
    }
}
