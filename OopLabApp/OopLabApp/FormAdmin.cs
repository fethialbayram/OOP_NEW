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
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void Adminlgn_Click(object sender, EventArgs e)
        {
            if (Admintxt.Text == "admin" && Adminpsw.Text == "admin")
            {
                adminManage adminManage = new adminManage();
                adminManage.Show(); //Oyunpenceresini göster
                this.Hide(); //FormAdmini gizle
            }
            else if (Admintxt.Text == "" || Adminpsw.Text == "")
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

        private void FormAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Admintxt_TextChanged(object sender, EventArgs e) {

        
            Admintxt.Focus(); //admin login penceresi acildiginda username textbox'ina focus ol
            this.AcceptButton = Adminlgn; //adminform'da username textbox'inda enter tusu ile login yapma
            
            
        }

        private void Adminpsw_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = Adminlgn; //adminform'da password textbox'inda enter tusu ile login yapma
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {
           
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Adminpsw.PasswordChar = checkBox_Admin.Checked ? '\0' : '*';
        }

        private void Admintxt_KeyPress(object sender, KeyPressEventArgs e) //admin penceresinde username kısmına yalnızca harf girilmesine izin verir
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }
    }
}