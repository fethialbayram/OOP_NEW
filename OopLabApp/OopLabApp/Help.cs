using System;
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
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
            this.TopMost = false;
        }

        private void Help_Load(object sender, EventArgs e)
        {

        }

        private void Aboutscreenbtn_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
            this.Hide();
            
        }
    }
}
