
namespace OopLabApp
{
    partial class OyunPenceresi
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
            this.settingsbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // settingsbtn
            // 
            this.settingsbtn.Location = new System.Drawing.Point(211, 134);
            this.settingsbtn.Margin = new System.Windows.Forms.Padding(2);
            this.settingsbtn.Name = "settingsbtn";
            this.settingsbtn.Size = new System.Drawing.Size(147, 105);
            this.settingsbtn.TabIndex = 0;
            this.settingsbtn.Text = "Settings";
            this.settingsbtn.UseVisualStyleBackColor = true;
            this.settingsbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // OyunPenceresi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.settingsbtn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OyunPenceresi";
            this.Text = "OyunPenceresi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OyunPenceresi_FormClosing);
            this.Load += new System.EventHandler(this.OyunPenceresi_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button settingsbtn;
    }
}