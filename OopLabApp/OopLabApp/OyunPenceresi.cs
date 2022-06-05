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
    public partial class OyunPenceresi : Form
    {
        public OyunPenceresi()
        {
            InitializeComponent();
        }

        private void OyunPenceresi_Load(object sender, EventArgs e)
        {

        }

        private void OyunPenceresi_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void difficToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void customToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ayarlar ayarlarpencere = new Ayarlar();
            ayarlarpencere.Show(); //ayarlarpenceresini göster.

        }
    }
}