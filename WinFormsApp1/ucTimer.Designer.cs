
namespace MainProgram
{
    partial class ucTimer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucTimer));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.nudSecond = new System.Windows.Forms.NumericUpDown();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.nudHour = new System.Windows.Forms.NumericUpDown();
            this.txtCustomText = new System.Windows.Forms.TextBox();
            this.cbCustomText = new System.Windows.Forms.CheckBox();
            this.nudMinute = new System.Windows.Forms.NumericUpDown();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.lblMilisec = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbMessageBox = new System.Windows.Forms.CheckBox();
            this.cbNotification = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinute)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Seconds";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Minutes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Hour";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold);
            this.lblTime.Location = new System.Drawing.Point(-5, -8);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(293, 86);
            this.lblTime.TabIndex = 18;
            this.lblTime.Text = "00:00:00";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Location = new System.Drawing.Point(205, 127);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(57, 33);
            this.btnReset.TabIndex = 30;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_click);
            // 
            // nudSecond
            // 
            this.nudSecond.Location = new System.Drawing.Point(141, 101);
            this.nudSecond.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudSecond.Name = "nudSecond";
            this.nudSecond.Size = new System.Drawing.Size(58, 20);
            this.nudSecond.TabIndex = 21;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Lime;
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnStart.Location = new System.Drawing.Point(15, 127);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(185, 33);
            this.btnStart.TabIndex = 23;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnSet
            // 
            this.btnSet.BackColor = System.Drawing.Color.White;
            this.btnSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSet.Location = new System.Drawing.Point(206, 101);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(57, 20);
            this.btnSet.TabIndex = 22;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = false;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // nudHour
            // 
            this.nudHour.Location = new System.Drawing.Point(15, 101);
            this.nudHour.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nudHour.Name = "nudHour";
            this.nudHour.Size = new System.Drawing.Size(58, 20);
            this.nudHour.TabIndex = 19;
            // 
            // txtCustomText
            // 
            this.txtCustomText.Enabled = false;
            this.txtCustomText.Location = new System.Drawing.Point(10, 295);
            this.txtCustomText.Multiline = true;
            this.txtCustomText.Name = "txtCustomText";
            this.txtCustomText.Size = new System.Drawing.Size(252, 66);
            this.txtCustomText.TabIndex = 28;
            // 
            // cbCustomText
            // 
            this.cbCustomText.AutoSize = true;
            this.cbCustomText.Location = new System.Drawing.Point(10, 273);
            this.cbCustomText.Name = "cbCustomText";
            this.cbCustomText.Size = new System.Drawing.Size(110, 17);
            this.cbCustomText.TabIndex = 29;
            this.cbCustomText.Text = "With Custom Text";
            this.cbCustomText.UseVisualStyleBackColor = true;
            this.cbCustomText.CheckedChanged += new System.EventHandler(this.cbCustomText_CheckedChanged);
            // 
            // nudMinute
            // 
            this.nudMinute.Location = new System.Drawing.Point(78, 101);
            this.nudMinute.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudMinute.Name = "nudMinute";
            this.nudMinute.Size = new System.Drawing.Size(58, 20);
            this.nudMinute.TabIndex = 20;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon";
            this.notifyIcon1.Visible = true;
            // 
            // lblMilisec
            // 
            this.lblMilisec.AutoSize = true;
            this.lblMilisec.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblMilisec.Location = new System.Drawing.Point(244, 63);
            this.lblMilisec.Name = "lblMilisec";
            this.lblMilisec.Size = new System.Drawing.Size(21, 15);
            this.lblMilisec.TabIndex = 34;
            this.lblMilisec.Text = "00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "When timer end";
            // 
            // cbMessageBox
            // 
            this.cbMessageBox.AutoSize = true;
            this.cbMessageBox.Checked = true;
            this.cbMessageBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbMessageBox.Location = new System.Drawing.Point(10, 229);
            this.cbMessageBox.Name = "cbMessageBox";
            this.cbMessageBox.Size = new System.Drawing.Size(120, 17);
            this.cbMessageBox.TabIndex = 36;
            this.cbMessageBox.Text = "Show Message Box";
            this.cbMessageBox.UseVisualStyleBackColor = true;
            // 
            // cbNotification
            // 
            this.cbNotification.AutoSize = true;
            this.cbNotification.Location = new System.Drawing.Point(10, 243);
            this.cbNotification.Name = "cbNotification";
            this.cbNotification.Size = new System.Drawing.Size(109, 17);
            this.cbNotification.TabIndex = 37;
            this.cbNotification.Text = "Show Notification";
            this.cbNotification.UseVisualStyleBackColor = true;
            // 
            // ucTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbNotification);
            this.Controls.Add(this.cbMessageBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblMilisec);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.nudSecond);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.nudHour);
            this.Controls.Add(this.txtCustomText);
            this.Controls.Add(this.cbCustomText);
            this.Controls.Add(this.nudMinute);
            this.Name = "ucTimer";
            this.Size = new System.Drawing.Size(276, 374);
            this.Load += new System.EventHandler(this.ucTimer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSecond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinute)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.NumericUpDown nudSecond;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.NumericUpDown nudHour;
        private System.Windows.Forms.TextBox txtCustomText;
        private System.Windows.Forms.CheckBox cbCustomText;
        private System.Windows.Forms.NumericUpDown nudMinute;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label lblMilisec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbMessageBox;
        private System.Windows.Forms.CheckBox cbNotification;
    }
}
