
namespace OopLabApp
{
    partial class Ayarlar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mavicheck = new System.Windows.Forms.CheckBox();
            this.kırmızıcheck = new System.Windows.Forms.CheckBox();
            this.Morcheck = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Kaydetbtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CustomCol = new System.Windows.Forms.TextBox();
            this.CustomRow = new System.Windows.Forms.TextBox();
            this.CustomRadio = new System.Windows.Forms.RadioButton();
            this.ZorRadio = new System.Windows.Forms.RadioButton();
            this.Ortaradio = new System.Windows.Forms.RadioButton();
            this.Kolayradio = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Dairebtn = new System.Windows.Forms.Button();
            this.Üçgenbtn = new System.Windows.Forms.Button();
            this.Karebtn = new System.Windows.Forms.Button();
            this.helpbtn = new System.Windows.Forms.Button();
            this.Aboutbtn = new System.Windows.Forms.Button();
            this.oynabtn = new System.Windows.Forms.Button();
            this.Karechk = new System.Windows.Forms.CheckBox();
            this.Üçgenchk = new System.Windows.Forms.CheckBox();
            this.Dairechk = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mavicheck
            // 
            this.mavicheck.AutoSize = true;
            this.mavicheck.Location = new System.Drawing.Point(37, 57);
            this.mavicheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mavicheck.Name = "mavicheck";
            this.mavicheck.Size = new System.Drawing.Size(59, 21);
            this.mavicheck.TabIndex = 0;
            this.mavicheck.Text = "Mavi";
            this.mavicheck.UseVisualStyleBackColor = true;
            this.mavicheck.CheckedChanged += new System.EventHandler(this.sarıcheck_CheckedChanged);
            this.mavicheck.Leave += new System.EventHandler(this.sarıcheck_CheckedChanged);
            // 
            // kırmızıcheck
            // 
            this.kırmızıcheck.AutoSize = true;
            this.kırmızıcheck.Location = new System.Drawing.Point(37, 84);
            this.kırmızıcheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.kırmızıcheck.Name = "kırmızıcheck";
            this.kırmızıcheck.Size = new System.Drawing.Size(71, 21);
            this.kırmızıcheck.TabIndex = 1;
            this.kırmızıcheck.Text = "Kırmızı";
            this.kırmızıcheck.UseVisualStyleBackColor = true;
            this.kırmızıcheck.CheckedChanged += new System.EventHandler(this.kırmızıcheck_CheckedChanged);
            // 
            // Morcheck
            // 
            this.Morcheck.AutoSize = true;
            this.Morcheck.Location = new System.Drawing.Point(37, 112);
            this.Morcheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Morcheck.Name = "Morcheck";
            this.Morcheck.Size = new System.Drawing.Size(54, 21);
            this.Morcheck.TabIndex = 2;
            this.Morcheck.Text = "Mor";
            this.Morcheck.UseVisualStyleBackColor = true;
            this.Morcheck.CheckedChanged += new System.EventHandler(this.Morcheck_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.mavicheck);
            this.panel1.Controls.Add(this.kırmızıcheck);
            this.panel1.Controls.Add(this.Morcheck);
            this.panel1.Location = new System.Drawing.Point(59, 33);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(229, 161);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Renk Seçimi";
            // 
            // Kaydetbtn
            // 
            this.Kaydetbtn.Location = new System.Drawing.Point(341, 198);
            this.Kaydetbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Kaydetbtn.Name = "Kaydetbtn";
            this.Kaydetbtn.Size = new System.Drawing.Size(75, 30);
            this.Kaydetbtn.TabIndex = 4;
            this.Kaydetbtn.Text = "Kaydet";
            this.Kaydetbtn.UseVisualStyleBackColor = true;
            this.Kaydetbtn.Click += new System.EventHandler(this.RenkSec_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.CustomCol);
            this.panel2.Controls.Add(this.CustomRow);
            this.panel2.Controls.Add(this.CustomRadio);
            this.panel2.Controls.Add(this.ZorRadio);
            this.panel2.Controls.Add(this.Ortaradio);
            this.panel2.Controls.Add(this.Kolayradio);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(483, 33);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 167);
            this.panel2.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(107, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "5 Puan";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(159, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "2 Puan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "3 Puan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "1 Puan";
            // 
            // CustomCol
            // 
            this.CustomCol.Location = new System.Drawing.Point(132, 138);
            this.CustomCol.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CustomCol.Name = "CustomCol";
            this.CustomCol.Size = new System.Drawing.Size(21, 22);
            this.CustomCol.TabIndex = 9;
            this.CustomCol.TextChanged += new System.EventHandler(this.CustomCol_TextChanged);
            this.CustomCol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CustomCol_KeyPress);
            // 
            // CustomRow
            // 
            this.CustomRow.Location = new System.Drawing.Point(105, 138);
            this.CustomRow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CustomRow.Name = "CustomRow";
            this.CustomRow.Size = new System.Drawing.Size(21, 22);
            this.CustomRow.TabIndex = 8;
            this.CustomRow.TextChanged += new System.EventHandler(this.CustomRow_TextChanged);
            this.CustomRow.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CustomRow_KeyPress);
            // 
            // CustomRadio
            // 
            this.CustomRadio.AutoSize = true;
            this.CustomRadio.Location = new System.Drawing.Point(21, 139);
            this.CustomRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CustomRadio.Name = "CustomRadio";
            this.CustomRadio.Size = new System.Drawing.Size(76, 21);
            this.CustomRadio.TabIndex = 7;
            this.CustomRadio.TabStop = true;
            this.CustomRadio.Text = "Custom";
            this.CustomRadio.UseVisualStyleBackColor = true;
            // 
            // ZorRadio
            // 
            this.ZorRadio.AutoSize = true;
            this.ZorRadio.Location = new System.Drawing.Point(21, 112);
            this.ZorRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ZorRadio.Name = "ZorRadio";
            this.ZorRadio.Size = new System.Drawing.Size(51, 21);
            this.ZorRadio.TabIndex = 6;
            this.ZorRadio.TabStop = true;
            this.ZorRadio.Text = "Zor";
            this.ZorRadio.UseVisualStyleBackColor = true;
            // 
            // Ortaradio
            // 
            this.Ortaradio.AutoSize = true;
            this.Ortaradio.Location = new System.Drawing.Point(21, 84);
            this.Ortaradio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Ortaradio.Name = "Ortaradio";
            this.Ortaradio.Size = new System.Drawing.Size(57, 21);
            this.Ortaradio.TabIndex = 5;
            this.Ortaradio.TabStop = true;
            this.Ortaradio.Text = "Orta";
            this.Ortaradio.UseVisualStyleBackColor = true;
            // 
            // Kolayradio
            // 
            this.Kolayradio.AutoSize = true;
            this.Kolayradio.Location = new System.Drawing.Point(21, 57);
            this.Kolayradio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Kolayradio.Name = "Kolayradio";
            this.Kolayradio.Size = new System.Drawing.Size(64, 21);
            this.Kolayradio.TabIndex = 4;
            this.Kolayradio.TabStop = true;
            this.Kolayradio.Text = "Kolay";
            this.Kolayradio.UseVisualStyleBackColor = true;
            this.Kolayradio.CheckedChanged += new System.EventHandler(this.Kolayradio_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Zorluk Seçimi";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Dairechk);
            this.groupBox1.Controls.Add(this.Üçgenchk);
            this.groupBox1.Controls.Add(this.Karechk);
            this.groupBox1.Controls.Add(this.Dairebtn);
            this.groupBox1.Controls.Add(this.Üçgenbtn);
            this.groupBox1.Controls.Add(this.Karebtn);
            this.groupBox1.Location = new System.Drawing.Point(59, 239);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(229, 142);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Şekil";
            // 
            // Dairebtn
            // 
            this.Dairebtn.Location = new System.Drawing.Point(22, 89);
            this.Dairebtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dairebtn.Name = "Dairebtn";
            this.Dairebtn.Size = new System.Drawing.Size(75, 30);
            this.Dairebtn.TabIndex = 2;
            this.Dairebtn.Text = "Daire";
            this.Dairebtn.UseVisualStyleBackColor = true;
            // 
            // Üçgenbtn
            // 
            this.Üçgenbtn.Location = new System.Drawing.Point(22, 55);
            this.Üçgenbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Üçgenbtn.Name = "Üçgenbtn";
            this.Üçgenbtn.Size = new System.Drawing.Size(75, 30);
            this.Üçgenbtn.TabIndex = 1;
            this.Üçgenbtn.Text = "Üçgen";
            this.Üçgenbtn.UseVisualStyleBackColor = true;
            // 
            // Karebtn
            // 
            this.Karebtn.Location = new System.Drawing.Point(21, 23);
            this.Karebtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Karebtn.Name = "Karebtn";
            this.Karebtn.Size = new System.Drawing.Size(75, 28);
            this.Karebtn.TabIndex = 0;
            this.Karebtn.Text = "Kare";
            this.Karebtn.UseVisualStyleBackColor = true;
            // 
            // helpbtn
            // 
            this.helpbtn.Location = new System.Drawing.Point(341, 163);
            this.helpbtn.Name = "helpbtn";
            this.helpbtn.Size = new System.Drawing.Size(75, 30);
            this.helpbtn.TabIndex = 7;
            this.helpbtn.Text = "Help";
            this.helpbtn.UseVisualStyleBackColor = true;
            this.helpbtn.Click += new System.EventHandler(this.helpbtn_Click);
            // 
            // Aboutbtn
            // 
            this.Aboutbtn.Location = new System.Drawing.Point(341, 233);
            this.Aboutbtn.Name = "Aboutbtn";
            this.Aboutbtn.Size = new System.Drawing.Size(75, 30);
            this.Aboutbtn.TabIndex = 8;
            this.Aboutbtn.Text = "About";
            this.Aboutbtn.UseVisualStyleBackColor = true;
            this.Aboutbtn.Click += new System.EventHandler(this.aboutbtn_Click);
            // 
            // oynabtn
            // 
            this.oynabtn.Location = new System.Drawing.Point(341, 127);
            this.oynabtn.Name = "oynabtn";
            this.oynabtn.Size = new System.Drawing.Size(75, 30);
            this.oynabtn.TabIndex = 9;
            this.oynabtn.Text = "Oyna";
            this.oynabtn.UseVisualStyleBackColor = true;
            this.oynabtn.Click += new System.EventHandler(this.oynabtn_Click);
            // 
            // Karechk
            // 
            this.Karechk.AutoSize = true;
            this.Karechk.Location = new System.Drawing.Point(114, 30);
            this.Karechk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Karechk.Name = "Karechk";
            this.Karechk.Size = new System.Drawing.Size(60, 21);
            this.Karechk.TabIndex = 3;
            this.Karechk.Text = "Kare";
            this.Karechk.UseVisualStyleBackColor = true;
            this.Karechk.CheckedChanged += new System.EventHandler(this.Karechk_CheckedChanged);
            // 
            // Üçgenchk
            // 
            this.Üçgenchk.AutoSize = true;
            this.Üçgenchk.Location = new System.Drawing.Point(114, 61);
            this.Üçgenchk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Üçgenchk.Name = "Üçgenchk";
            this.Üçgenchk.Size = new System.Drawing.Size(71, 21);
            this.Üçgenchk.TabIndex = 4;
            this.Üçgenchk.Text = "Üçgen";
            this.Üçgenchk.UseVisualStyleBackColor = true;
            // 
            // Dairechk
            // 
            this.Dairechk.AutoSize = true;
            this.Dairechk.Location = new System.Drawing.Point(114, 95);
            this.Dairechk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dairechk.Name = "Dairechk";
            this.Dairechk.Size = new System.Drawing.Size(64, 21);
            this.Dairechk.TabIndex = 5;
            this.Dairechk.Text = "Daire";
            this.Dairechk.UseVisualStyleBackColor = true;
            // 
            // Ayarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.oynabtn);
            this.Controls.Add(this.Aboutbtn);
            this.Controls.Add(this.helpbtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Kaydetbtn);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Ayarlar";
            this.Text = "Ayarlar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Ayarlar_FormClosing);
            this.Load += new System.EventHandler(this.Ayarlar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox mavicheck;
        private System.Windows.Forms.CheckBox kırmızıcheck;
        private System.Windows.Forms.CheckBox Morcheck;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Kaydetbtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CustomCol;
        private System.Windows.Forms.TextBox CustomRow;
        private System.Windows.Forms.RadioButton CustomRadio;
        private System.Windows.Forms.RadioButton ZorRadio;
        private System.Windows.Forms.RadioButton Ortaradio;
        private System.Windows.Forms.RadioButton Kolayradio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Dairebtn;
        private System.Windows.Forms.Button Üçgenbtn;
        private System.Windows.Forms.Button Karebtn;
        private System.Windows.Forms.Button helpbtn;
        private System.Windows.Forms.Button Aboutbtn;
        private System.Windows.Forms.Button oynabtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox Dairechk;
        private System.Windows.Forms.CheckBox Üçgenchk;
        private System.Windows.Forms.CheckBox Karechk;
    }
}