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
    public partial class Oyna : Form
    {
        int size, x, y;
        string sq = " ", rd = " ", tr = " ", red = " ", blue = " ", black = " ";

        List<Button> buttonList = new List<Button>();
        public Oyna()
        {
            InitializeComponent();
        }

        
        void ButtonOluştur()
        {
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j <y; j++)
                {
                    Button btn = new Button();
                    btn.Width = size;
                    btn.Height = size;
                    btn.Location = new Point(size * i, size * j); // satır ve sütünları ayarlama                     
                    buttonList.Add(btn);
                }
            }
        }
        void BtnEkle()
        {
            foreach (Button btn in buttonList)
            {
                this.Controls.Add(btn);
            }
        }

        void BtnResim()
        {
            foreach (Button button in buttonList)
            {
                if (button.Tag == "square" && button.BackColor != Color.Blue
                   && button.BackColor != Color.Black && button.BackColor != Color.Red)
                {
                A:;
                    Random rnd = new Random();
                    int renk = rnd.Next(3);
                    if (renk == 0 && blue == "Blue") button.BackColor = Color.Blue;
                    else if (renk == 1 && red == "Red") button.BackColor = Color.Red;
                    else if (renk == 2 && black == "Black") button.BackColor = Color.Black;
                    else goto A;
                }
                else if (button.Tag == "round" && button.BackColor != Color.Blue
                    && button.BackColor != Color.Black && button.BackColor != Color.Red)
                {
                B:;

                    Random rnd = new Random();
                    int renk = rnd.Next(3);
                    if (renk == 0 && blue == "Blue") button.BackColor = Color.Blue;
                    else if (renk == 1 && red == "Red") button.BackColor = Color.Red;
                    else if (renk == 2 && black == "Black") button.BackColor = Color.Black;
                    else goto B;
                }
                else if (button.Tag == "triangle" && button.BackColor != Color.Blue
                    && button.BackColor != Color.Black && button.BackColor != Color.Red)
                {
                C:;

                    Random rnd = new Random();
                    int renk = rnd.Next(3);
                    if (renk == 0 && blue == "Blue") button.BackColor = Color.Blue;
                    else if (renk == 1 && red == "Red") button.BackColor = Color.Red;
                    else if (renk == 2 && black == "Black") button.BackColor = Color.Black;
                    else goto C;
                }

            }
        }
        void ReadSave()
        {
            FileStream text = new FileStream("./save.txt", FileMode.Open, FileAccess.Read);

            StreamReader sw = new StreamReader(text);
            string vs = sw.ReadToEnd();

            if (vs.Contains("Kırmızı"))
            {
                red = "Red";
            }
            if (vs.Contains("Mavi"))
            {
                blue = "Blue";
            }
            if (vs.Contains("Siyah"))
            {
                black = "Black";
            }
            if (vs.Contains("Square"))
            {
                sq = "Square";
            }
            if (vs.Contains("Triangle"))
            {
                tr = "Triangle";
            }
            if (vs.Contains("Round"))
            {
                rd = "Round";
            }
            if (vs.Contains("kolay"))
            {
                size = 34;
                x = 15;
                y = 15;
            }
            if (vs.Contains("orta"))
            {
                size = 34;
                x = 9;
                y = 9;
            }
            if (vs.Contains("zor"))
            {
                size = 34;
                x = 6;
                y = 6;
            }
        }

        private void Oyna_Load(object sender, EventArgs e)
        {
            ReadSave();
            ButtonOluştur();
            BtnEkle();

        }
        private void Oyna_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
