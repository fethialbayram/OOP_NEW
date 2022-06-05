using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OopLabApp
{
    public partial class Ayarlar : Form
    {
        public Ayarlar()
        {
            InitializeComponent();
            this.TopMost = false;
        }

        private void RenkSec_Click(object sender, EventArgs e)
        {
            TextWriter textWriter = new StreamWriter("./save.txt");

            if (mavicheck.Checked == true)
            {
                textWriter.WriteLine("Mavi");
            }
            if (kırmızıcheck.Checked == true)
            {
                textWriter.WriteLine("Kırmızı");
            }
            if (Morcheck.Checked == true)
            {
                textWriter.WriteLine("Mor");
            }
             if (Kolayradio.Checked==true)
            {
                textWriter.WriteLine("kolay");
            }
             if(Ortaradio.Checked==true)
            {
                textWriter.WriteLine("orta");
            }
             if(ZorRadio.Checked==true)
            {
                textWriter.WriteLine("zor");
            }
             if(mavicheck.Checked==true)
            {
                textWriter.WriteLine("Mavi");
            }
            if (kırmızıcheck.Checked == true)
            {
                textWriter.WriteLine("Kırmızı");
            }
            if (Morcheck.Checked == true)
            {
                textWriter.WriteLine("Mor");
            }
            if (Karechk.Checked == true)
            {
                textWriter.WriteLine("Kare");
            }
            if (Üçgenchk.Checked == true)
            {
                textWriter.WriteLine("Üçgen");
            }
            if (Dairechk.Checked == true)
            {
                textWriter.WriteLine("Daire");
            }

            textWriter.Close();


        }
        private void Ayarlar_Load(object sender, EventArgs e)
        {
            FileStream text = new FileStream("./save.txt", FileMode.Open, FileAccess.Read);

            StreamReader sw = new StreamReader(text);
            string obj = sw.ReadToEnd();


            if (obj.Contains("Kırmızı"))
            {
                kırmızıcheck.Checked = true;
            }
            if (obj.Contains("Sarı"))
            {
                mavicheck.Checked = true;
            }
            if (obj.Contains("Mor"))
            {
                Morcheck.Checked = true;
            }
             if(obj.Contains("kolay"))
            {
                Kolayradio.Checked = true;
            }
             if (obj.Contains("orta"))
            {
                Ortaradio.Checked = true;
            }
             if (obj.Contains("zor"))
            {
                ZorRadio.Checked = true;
            }
           if(obj.Contains("Mor"))
            {
                Morcheck.Checked = true;
            }
            if (obj.Contains("Mavi"))
            {
                mavicheck.Checked = true;
            }
            if (obj.Contains("Kırmızı"))
            {
                kırmızıcheck.Checked = true;
            }
            if(obj.Contains("Kare"))
            {
                Karechk.Checked = true;
            }
            if(obj.Contains("Üçgen"))
            {
                Üçgenchk.Checked = true;
            }
            if(obj.Contains("Daire"))
            {
                Dairechk.Checked = true;
            }

            text.Close();
        }

        private void sarıcheck_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void kırmızıcheck_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void Morcheck_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void Ayarlar_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CustomCol_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void CustomRow_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void CustomRow_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            
        }

        private void CustomCol_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            
        }

        private void helpbtn_Click(object sender, EventArgs e)
        {
            Help helpscreen = new Help();
            helpscreen.Show();
            this.Hide();
        }

        private void aboutbtn_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
            this.Hide();
        }

        private void oynabtn_Click(object sender, EventArgs e)
        {
            Oyna oyna = new Oyna();
            oyna.Show();
            this.Hide();
        }

        private void Kolayradio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Karechk_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
