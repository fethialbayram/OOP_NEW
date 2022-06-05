﻿using System;
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
        string square = " ", round = " ", triangle = " ", red = " ", blue = " ", purple = " ";

        static FileStream  text = new FileStream("./save.txt", FileMode.Open, FileAccess.Read);

        static StreamReader sw = new StreamReader(text);
        string vs = sw.ReadToEnd();

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

        void BtnRenk()
        {
            for (int i = 0; i < 3; i++)
            {
            A:;
                Random random = new Random();
                int sayi = random.Next(buttonList.Count);
                
                Random random1 = new Random();
                int renk = random1.Next(1,4);
                if (vs.Contains("Kırmızı") && renk == 1)
                {
                    buttonList[sayi].BackColor = Color.Red;
                }
                else if (vs.Contains("Mavi") && renk == 2)
                {
                    buttonList[sayi].BackColor = Color.Blue;
                }
                else if (vs.Contains("Mor") && renk == 3)
                {
                    buttonList[sayi].BackColor = Color.Purple;

                }
                else goto A;
            }   
        }
        void BtnResim()
        {
            foreach (Button button in buttonList)
            {
                if (button.Tag == "Kare" && button.BackColor != Color.Blue
                   && button.BackColor != Color.Black && button.BackColor != Color.Red)
                {
                A:;
                    Random rnd = new Random();
                    int renk = rnd.Next(3);
                    if (renk == 0 && blue == "Mavi") button.BackColor = Color.Blue;
                    else if (renk == 1 && red == "Kırmızı") button.BackColor = Color.Red;
                    else if (renk == 2 && purple == "Mor") button.BackColor = Color.Black;
                    else goto A;
                }
                else if (button.Tag == "Daire" && button.BackColor != Color.Blue
                    && button.BackColor != Color.Black && button.BackColor != Color.Red)
                {
                B:;

                    Random rnd = new Random();
                    int renk = rnd.Next(3);
                    if (renk == 0 && blue == "Mavi") button.BackColor = Color.Blue;
                    else if (renk == 1 && red == "Kırmızı") button.BackColor = Color.Red;
                    else if (renk == 2 && purple == "Mor") button.BackColor = Color.Black;
                    else goto B;
                }
                else if (button.Tag == "Üçgen" && button.BackColor != Color.Blue
                    && button.BackColor != Color.Black && button.BackColor != Color.Red)
                {
                C:;

                    Random rnd = new Random();
                    int renk = rnd.Next(3);
                    if (renk == 0 && blue == "Mavi") button.BackColor = Color.Blue;
                    else if (renk == 1 && red == "Kırmızı") button.BackColor = Color.Red;
                    else if (renk == 2 && purple == "Mor") button.BackColor = Color.Black;
                    else goto C;
                }

            }
        }
        void ReadSave()
        {
           

            if (vs.Contains("Kırmızı"))
            {
                red = "Kırmızı";
            }
            if (vs.Contains("Mavi"))
            {
                blue = "Mavi";
            }
            if (vs.Contains("Mor"))
            {
                purple = "Mor";
            }
            if (vs.Contains("Kare"))
            {
                square = "Kare";
            }
            if (vs.Contains("Üçgen"))
            {
                triangle = "Üçgen";
            }
            if (vs.Contains("Daire"))
            {
                round = "Daire";
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
         //   BtnResim();
            BtnRenk();
        }
        private void Oyna_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
