using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OopLabApp
{
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();
        }

        private void FormUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void Userlogin_Click(object sender, EventArgs e)
        {
            if (Usertxt.Text == "user" && Userpsw.Text == "user")
            {
                OyunPenceresi oyunPenceresi = new OyunPenceresi();
                oyunPenceresi.Show(); //Oyunpenceresini göster.
                this.Hide(); //Formuseri sakla.

                

            }
            else if (Usertxt.Text == "" || Userpsw.Text == "")
            {
                string message = "Belirli alanlar boş bırakılamaz";
                string title = "Hata";
                MessageBox.Show(message, title);
            }
            else
            {
                string message = "Kullanıcı adı veya parola hatalı";
                string title = "Hata";
                MessageBox.Show(message, title);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Usertxt_TextChanged(object sender, EventArgs e)
        {
           
            Usertxt.Select();
            this.AcceptButton = Userlogin; //userform'da username textbox'inda enter tusu ile login yapma
  
        }
       



        private void FormUser_Load(object sender, EventArgs e)
        {

       
            Usertxt.Focus(); //user login ekrani ilk acildiginda username textbox'ina focus ol
           

        }

        private void Userpsw_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = Userlogin; //userform'da password textbox'inda enter tusu ile login yapma
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Userpsw.PasswordChar = checkBox_User.Checked ? '\0' : '*';
        }

        private void Usertxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void uyebtn_Click(object sender, EventArgs e)
        {
            Uyeol uyeol = new Uyeol();
            uyeol.Show(); //Uyeol göster.
            this.Hide(); //FormUseri Sakla.
        }
    }
}