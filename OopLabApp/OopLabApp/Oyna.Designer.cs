
namespace OopLabApp
{
    partial class Oyna
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
            this.components = new System.ComponentModel.Container();
            this.scoretxt = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // scoretxt
            // 
            this.scoretxt.Location = new System.Drawing.Point(628, 12);
            this.scoretxt.Multiline = true;
            this.scoretxt.Name = "scoretxt";
            this.scoretxt.Size = new System.Drawing.Size(185, 67);
            this.scoretxt.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Oyna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 470);
            this.Controls.Add(this.scoretxt);
            this.Name = "Oyna";
            this.Text = "Oyna";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Oyna_FormClosing);
            this.Load += new System.EventHandler(this.Oyna_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox scoretxt;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}