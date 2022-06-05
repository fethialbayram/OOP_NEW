
namespace OopLabApp
{
    partial class FormUser
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Usertxt = new System.Windows.Forms.TextBox();
            this.Userpsw = new System.Windows.Forms.TextBox();
            this.Userlogin = new System.Windows.Forms.Button();
            this.checkBox_User = new System.Windows.Forms.CheckBox();
            this.uyebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(128, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 14);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(128, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 14);
            this.label1.TabIndex = 8;
            this.label1.Text = "Username";
            // 
            // Usertxt
            // 
            this.Usertxt.Location = new System.Drawing.Point(230, 91);
            this.Usertxt.Margin = new System.Windows.Forms.Padding(2);
            this.Usertxt.Name = "Usertxt";
            this.Usertxt.Size = new System.Drawing.Size(160, 20);
            this.Usertxt.TabIndex = 0;
            this.Usertxt.TextChanged += new System.EventHandler(this.Usertxt_TextChanged);
            this.Usertxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Usertxt_KeyPress);
            // 
            // Userpsw
            // 
            this.Userpsw.Location = new System.Drawing.Point(230, 132);
            this.Userpsw.Margin = new System.Windows.Forms.Padding(2);
            this.Userpsw.Name = "Userpsw";
            this.Userpsw.PasswordChar = '*';
            this.Userpsw.Size = new System.Drawing.Size(160, 20);
            this.Userpsw.TabIndex = 6;
            this.Userpsw.TextChanged += new System.EventHandler(this.Userpsw_TextChanged);
            // 
            // Userlogin
            // 
            this.Userlogin.Location = new System.Drawing.Point(230, 190);
            this.Userlogin.Margin = new System.Windows.Forms.Padding(2);
            this.Userlogin.Name = "Userlogin";
            this.Userlogin.Size = new System.Drawing.Size(160, 24);
            this.Userlogin.TabIndex = 10;
            this.Userlogin.Text = "Login";
            this.Userlogin.UseVisualStyleBackColor = true;
            this.Userlogin.Click += new System.EventHandler(this.Userlogin_Click);
            // 
            // checkBox_User
            // 
            this.checkBox_User.AutoSize = true;
            this.checkBox_User.Location = new System.Drawing.Point(230, 157);
            this.checkBox_User.Name = "checkBox_User";
            this.checkBox_User.Size = new System.Drawing.Size(102, 17);
            this.checkBox_User.TabIndex = 11;
            this.checkBox_User.Text = "Show Password";
            this.checkBox_User.UseVisualStyleBackColor = true;
            this.checkBox_User.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // uyebtn
            // 
            this.uyebtn.Location = new System.Drawing.Point(230, 231);
            this.uyebtn.Name = "uyebtn";
            this.uyebtn.Size = new System.Drawing.Size(160, 23);
            this.uyebtn.TabIndex = 12;
            this.uyebtn.Text = "Sign Up";
            this.uyebtn.UseVisualStyleBackColor = true;
            this.uyebtn.Click += new System.EventHandler(this.uyebtn_Click);
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.uyebtn);
            this.Controls.Add(this.checkBox_User);
            this.Controls.Add(this.Userlogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Usertxt);
            this.Controls.Add(this.Userpsw);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormUser";
            this.Text = "FormUser";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormUser_FormClosing);
            this.Load += new System.EventHandler(this.FormUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Usertxt;
        private System.Windows.Forms.TextBox Userpsw;
        private System.Windows.Forms.Button Userlogin;
        private System.Windows.Forms.CheckBox checkBox_User;
        private System.Windows.Forms.Button uyebtn;
    }
}