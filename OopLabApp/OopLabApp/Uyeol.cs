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

namespace OopLabApp
{
    public partial class Uyeol : Form
    {
        public Uyeol()
        {
            InitializeComponent();
        }

        void Yukle()
        {
            XmlDocument x = new XmlDocument();
            DataSet ds = new DataSet();
            XmlReader xmlFile;
            xmlFile = XmlReader.Create(@"veri.xml", new XmlReaderSettings());
            ds.ReadXml(xmlFile);    
            dataGridView1.DataSource = ds.Tables[0];
            xmlFile.Close(); 
        }
        private void Uyeol_Load(object sender, EventArgs e)
        {
            Yukle();
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

            byte[] sifreleme = Encoding.UTF8.GetBytes(textBox2.Text);

            sifreleme = SHA256.ComputeHash(sifreleme);

            StringBuilder sb = new StringBuilder();

            foreach (byte b in sifreleme)
            {
                sb.Append(b.ToString("X2"));
            }

            textBox2.Text = sb.ToString();

            XDocument x = XDocument.Load(@"veri.xml");
            x.Element("Kullanicilar").Add(
                new XElement("User",
                new XElement("Username", textBox1.Text),
                new XElement("Password", textBox2.Text),
                new XElement("Name-Surname", textBox3.Text),
                new XElement("Phone-Number", textBox4.Text),
                new XElement("Address", textBox5.Text),
                new XElement("City", textBox6.Text),
                new XElement("Country", textBox7.Text),
                new XElement("E-mail", textBox8.Text))
                );
            x.Save(@"veri.xml");
            Yukle();
        }

        private void dataGridView1_AutoSizeColumnsModeChanged(object sender, DataGridViewAutoSizeColumnsModeEventArgs e)
        {

        }

        private void Gnclbtn_Click(object sender, EventArgs e)
        {
            XDocument x = XDocument.Load(@"veri.xml");
            XElement node = x.Element("Kullanicilar").Elements("User").FirstOrDefault(a => a.Element("Username").Value.Trim() == textBox1.Text);
            if (node != null)
            {
                node.SetElementValue("Username", textBox1.Text);
                node.SetElementValue("Password", textBox2.Text);
                node.SetElementValue("Name-Surname", textBox3.Text);
                node.SetElementValue("Phone-Number", textBox4.Text);
                node.SetElementValue("Adress", textBox5.Text);
                node.SetElementValue("City", textBox6.Text);
                node.SetElementValue("Country", textBox7.Text);
                node.SetElementValue("E-mail", textBox8.Text);
                x.Save(@"veri.xml");
                Yukle();
            }
        }

        private void Silbtn_Click(object sender, EventArgs e)
        {
            XDocument x = XDocument.Load(@"veri.xml");
            x.Root.Elements().Where(a => a.Element("Username").Value == textBox1.Text).Remove();
            x.Save(@"veri.xml");
            Yukle();
        }
    }
}
