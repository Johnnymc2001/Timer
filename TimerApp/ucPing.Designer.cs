
namespace MultiTool
{
    partial class ucPing
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMin = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.lblLastPing = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPing = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHostname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(259, 156);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(34, 15);
            this.lblMin.TabIndex = 22;
            this.lblMin.Text = "-1ms";
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Location = new System.Drawing.Point(259, 141);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(34, 15);
            this.lblAverage.TabIndex = 21;
            this.lblAverage.Text = "-1ms";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(259, 126);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(34, 15);
            this.lblMax.TabIndex = 20;
            this.lblMax.Text = "-1ms";
            // 
            // lblLastPing
            // 
            this.lblLastPing.AutoSize = true;
            this.lblLastPing.Location = new System.Drawing.Point(80, 126);
            this.lblLastPing.Name = "lblLastPing";
            this.lblLastPing.Size = new System.Drawing.Size(34, 15);
            this.lblLastPing.TabIndex = 19;
            this.lblLastPing.Text = "-1ms";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(195, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Min:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(195, 126);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Max:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(16, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "Last Ping:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(195, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 15;
            this.label5.Text = "Average:";
            // 
            // btnPing
            // 
            this.btnPing.BackColor = System.Drawing.Color.White;
            this.btnPing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPing.Location = new System.Drawing.Point(16, 77);
            this.btnPing.Name = "btnPing";
            this.btnPing.Size = new System.Drawing.Size(291, 30);
            this.btnPing.TabIndex = 14;
            this.btnPing.Text = "Ping";
            this.btnPing.UseVisualStyleBackColor = false;
            this.btnPing.Click += new System.EventHandler(this.btnPing_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Host";
            // 
            // txtHostname
            // 
            this.txtHostname.Location = new System.Drawing.Point(15, 47);
            this.txtHostname.Name = "txtHostname";
            this.txtHostname.Size = new System.Drawing.Size(292, 23);
            this.txtHostname.TabIndex = 12;
            // 
            // ucPing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblLastPing);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnPing);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHostname);
            this.Name = "ucPing";
            this.Size = new System.Drawing.Size(322, 432);
            this.Load += new System.EventHandler(this.ucPing_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Label lblLastPing;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPing;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHostname;
    }
}
