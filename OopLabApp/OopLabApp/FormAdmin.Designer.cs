
namespace OopLabApp
{
    partial class FormAdmin
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
            this.Adminlgn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Admintxt = new System.Windows.Forms.TextBox();
            this.Adminpsw = new System.Windows.Forms.TextBox();
            this.checkBox_Admin = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // Adminlgn
            // 
            this.Adminlgn.Location = new System.Drawing.Point(230, 190);
            this.Adminlgn.Margin = new System.Windows.Forms.Padding(2);
            this.Adminlgn.Name = "Adminlgn";
            this.Adminlgn.Size = new System.Drawing.Size(160, 24);
            this.Adminlgn.TabIndex = 15;
            this.Adminlgn.Text = "Login";
            this.Adminlgn.UseVisualStyleBackColor = true;
            this.Adminlgn.Click += new System.EventHandler(this.Adminlgn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(128, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 14);
            this.label2.TabIndex = 14;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(128, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 14);
            this.label1.TabIndex = 13;
            this.label1.Text = "Username";
            // 
            // Admintxt
            // 
            this.Admintxt.Location = new System.Drawing.Point(230, 91);
            this.Admintxt.Margin = new System.Windows.Forms.Padding(2);
            this.Admintxt.Name = "Admintxt";
            this.Admintxt.Size = new System.Drawing.Size(160, 20);
            this.Admintxt.TabIndex = 0;
            this.Admintxt.TextChanged += new System.EventHandler(this.Admintxt_TextChanged);
            this.Admintxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Admintxt_KeyPress);
            // 
            // Adminpsw
            // 
            this.Adminpsw.Location = new System.Drawing.Point(230, 132);
            this.Adminpsw.Margin = new System.Windows.Forms.Padding(2);
            this.Adminpsw.Name = "Adminpsw";
            this.Adminpsw.PasswordChar = '*';
            this.Adminpsw.Size = new System.Drawing.Size(160, 20);
            this.Adminpsw.TabIndex = 11;
            this.Adminpsw.TextChanged += new System.EventHandler(this.Adminpsw_TextChanged);
            // 
            // checkBox_Admin
            // 
            this.checkBox_Admin.AutoSize = true;
            this.checkBox_Admin.Location = new System.Drawing.Point(230, 157);
            this.checkBox_Admin.Name = "checkBox_Admin";
            this.checkBox_Admin.Size = new System.Drawing.Size(102, 17);
            this.checkBox_Admin.TabIndex = 16;
            this.checkBox_Admin.Text = "Show Password";
            this.checkBox_Admin.UseVisualStyleBackColor = true;
            this.checkBox_Admin.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.checkBox_Admin);
            this.Controls.Add(this.Adminlgn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Admintxt);
            this.Controls.Add(this.Adminpsw);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAdmin_FormClosing);
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Adminlgn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Admintxt;
        private System.Windows.Forms.TextBox Adminpsw;
        private System.Windows.Forms.CheckBox checkBox_Admin;
    }
}