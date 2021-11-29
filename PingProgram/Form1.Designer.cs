
namespace PingProgram
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPing = new System.Windows.Forms.Button();
            this.lblPing = new System.Windows.Forms.Label();
            this.cbHost = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnPing
            // 
            this.btnPing.Location = new System.Drawing.Point(212, 12);
            this.btnPing.Name = "btnPing";
            this.btnPing.Size = new System.Drawing.Size(75, 23);
            this.btnPing.TabIndex = 2;
            this.btnPing.Text = "Ping";
            this.btnPing.UseVisualStyleBackColor = true;
            this.btnPing.Click += new System.EventHandler(this.btnPing_Click);
            // 
            // lblPing
            // 
            this.lblPing.AutoSize = true;
            this.lblPing.Location = new System.Drawing.Point(3, 49);
            this.lblPing.Name = "lblPing";
            this.lblPing.Size = new System.Drawing.Size(32, 15);
            this.lblPing.TabIndex = 3;
            this.lblPing.Text = "Host";
            // 
            // cbHost
            // 
            this.cbHost.FormattingEnabled = true;
            this.cbHost.Items.AddRange(new object[] {
            "steamcommunity.com",
            "garena.vn"});
            this.cbHost.Location = new System.Drawing.Point(3, 12);
            this.cbHost.Name = "cbHost";
            this.cbHost.Size = new System.Drawing.Size(203, 23);
            this.cbHost.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 73);
            this.Controls.Add(this.cbHost);
            this.Controls.Add(this.lblPing);
            this.Controls.Add(this.btnPing);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Ping";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPing;
        private System.Windows.Forms.Label lblPing;
        private System.Windows.Forms.ComboBox cbHost;
    }
}

