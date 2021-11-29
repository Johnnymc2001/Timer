
namespace MultiTool
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
            this.btnHalf = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.nudSecond = new System.Windows.Forms.NumericUpDown();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.nudHour = new System.Windows.Forms.NumericUpDown();
            this.txtCustomText = new System.Windows.Forms.TextBox();
            this.btnSleep = new System.Windows.Forms.Button();
            this.btnFull = new System.Windows.Forms.Button();
            this.cbCustomText = new System.Windows.Forms.CheckBox();
            this.nudMinute = new System.Windows.Forms.NumericUpDown();
            this.btnGame = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudSecond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinute)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 33;
            this.label3.Text = "Seconds";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 15);
            this.label2.TabIndex = 32;
            this.label2.Text = "Minutes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 15);
            this.label1.TabIndex = 31;
            this.label1.Text = "Hour";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTime.Location = new System.Drawing.Point(14, 12);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(293, 86);
            this.lblTime.TabIndex = 18;
            this.lblTime.Text = "00:00:00";
            // 
            // btnHalf
            // 
            this.btnHalf.BackColor = System.Drawing.Color.White;
            this.btnHalf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHalf.Location = new System.Drawing.Point(164, 278);
            this.btnHalf.Name = "btnHalf";
            this.btnHalf.Size = new System.Drawing.Size(142, 31);
            this.btnHalf.TabIndex = 27;
            this.btnHalf.Text = "Half";
            this.btnHalf.UseVisualStyleBackColor = false;
            this.btnHalf.Click += new System.EventHandler(this.btnHalf_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Location = new System.Drawing.Point(239, 146);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(67, 38);
            this.btnReset.TabIndex = 30;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_click);
            // 
            // nudSecond
            // 
            this.nudSecond.Location = new System.Drawing.Point(165, 117);
            this.nudSecond.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudSecond.Name = "nudSecond";
            this.nudSecond.Size = new System.Drawing.Size(68, 23);
            this.nudSecond.TabIndex = 21;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Lime;
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnStart.Location = new System.Drawing.Point(17, 146);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(216, 38);
            this.btnStart.TabIndex = 23;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnSet
            // 
            this.btnSet.BackColor = System.Drawing.Color.White;
            this.btnSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSet.Location = new System.Drawing.Point(240, 117);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(67, 23);
            this.btnSet.TabIndex = 22;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = false;
            // 
            // nudHour
            // 
            this.nudHour.Location = new System.Drawing.Point(17, 117);
            this.nudHour.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nudHour.Name = "nudHour";
            this.nudHour.Size = new System.Drawing.Size(68, 23);
            this.nudHour.TabIndex = 19;
            // 
            // txtCustomText
            // 
            this.txtCustomText.Enabled = false;
            this.txtCustomText.Location = new System.Drawing.Point(15, 340);
            this.txtCustomText.Multiline = true;
            this.txtCustomText.Name = "txtCustomText";
            this.txtCustomText.Size = new System.Drawing.Size(293, 76);
            this.txtCustomText.TabIndex = 28;
            // 
            // btnSleep
            // 
            this.btnSleep.BackColor = System.Drawing.Color.White;
            this.btnSleep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSleep.Location = new System.Drawing.Point(14, 243);
            this.btnSleep.Name = "btnSleep";
            this.btnSleep.Size = new System.Drawing.Size(142, 29);
            this.btnSleep.TabIndex = 24;
            this.btnSleep.Text = "Sleep";
            this.btnSleep.UseVisualStyleBackColor = false;
            this.btnSleep.Click += new System.EventHandler(this.btnSleep_Click);
            // 
            // btnFull
            // 
            this.btnFull.BackColor = System.Drawing.Color.White;
            this.btnFull.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFull.Location = new System.Drawing.Point(14, 278);
            this.btnFull.Name = "btnFull";
            this.btnFull.Size = new System.Drawing.Size(142, 31);
            this.btnFull.TabIndex = 26;
            this.btnFull.Text = "Full";
            this.btnFull.UseVisualStyleBackColor = false;
            this.btnFull.Click += new System.EventHandler(this.btnSleep_Click);
            // 
            // cbCustomText
            // 
            this.cbCustomText.AutoSize = true;
            this.cbCustomText.Location = new System.Drawing.Point(15, 315);
            this.cbCustomText.Name = "cbCustomText";
            this.cbCustomText.Size = new System.Drawing.Size(120, 19);
            this.cbCustomText.TabIndex = 29;
            this.cbCustomText.Text = "With Custom Text";
            this.cbCustomText.UseVisualStyleBackColor = true;
            this.cbCustomText.CheckedChanged += new System.EventHandler(this.cbCustomText_CheckedChanged);
            // 
            // nudMinute
            // 
            this.nudMinute.Location = new System.Drawing.Point(91, 117);
            this.nudMinute.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudMinute.Name = "nudMinute";
            this.nudMinute.Size = new System.Drawing.Size(68, 23);
            this.nudMinute.TabIndex = 20;
            // 
            // btnGame
            // 
            this.btnGame.BackColor = System.Drawing.Color.White;
            this.btnGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGame.Location = new System.Drawing.Point(164, 243);
            this.btnGame.Name = "btnGame";
            this.btnGame.Size = new System.Drawing.Size(142, 29);
            this.btnGame.TabIndex = 25;
            this.btnGame.Text = "Game";
            this.btnGame.UseVisualStyleBackColor = false;
            this.btnGame.Click += new System.EventHandler(this.btnGame_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon";
            this.notifyIcon1.Visible = true;
            // 
            // ucTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnHalf);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.nudSecond);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnSet);
            this.Controls.Add(this.nudHour);
            this.Controls.Add(this.txtCustomText);
            this.Controls.Add(this.btnSleep);
            this.Controls.Add(this.btnFull);
            this.Controls.Add(this.cbCustomText);
            this.Controls.Add(this.nudMinute);
            this.Controls.Add(this.btnGame);
            this.Name = "ucTimer";
            this.Size = new System.Drawing.Size(322, 432);
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
        private System.Windows.Forms.Button btnHalf;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.NumericUpDown nudSecond;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.NumericUpDown nudHour;
        private System.Windows.Forms.TextBox txtCustomText;
        private System.Windows.Forms.Button btnSleep;
        private System.Windows.Forms.Button btnFull;
        private System.Windows.Forms.CheckBox cbCustomText;
        private System.Windows.Forms.NumericUpDown nudMinute;
        private System.Windows.Forms.Button btnGame;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}
