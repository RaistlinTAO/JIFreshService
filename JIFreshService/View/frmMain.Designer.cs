namespace JIFreshService.View
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.cmdStart = new System.Windows.Forms.Button();
            this.lstLog = new System.Windows.Forms.ListBox();
            this.cmdStop = new System.Windows.Forms.Button();
            this.cmdExit = new System.Windows.Forms.Button();
            this.cmdMin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdStart
            // 
            this.cmdStart.Location = new System.Drawing.Point(12, 335);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(151, 23);
            this.cmdStart.TabIndex = 0;
            this.cmdStart.Text = "Start Service";
            this.cmdStart.UseVisualStyleBackColor = true;
            this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);
            // 
            // lstLog
            // 
            this.lstLog.BackColor = System.Drawing.Color.Black;
            this.lstLog.ForeColor = System.Drawing.Color.GreenYellow;
            this.lstLog.FormattingEnabled = true;
            this.lstLog.Location = new System.Drawing.Point(12, 34);
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new System.Drawing.Size(743, 290);
            this.lstLog.TabIndex = 1;
            // 
            // cmdStop
            // 
            this.cmdStop.Location = new System.Drawing.Point(211, 335);
            this.cmdStop.Name = "cmdStop";
            this.cmdStop.Size = new System.Drawing.Size(151, 23);
            this.cmdStop.TabIndex = 2;
            this.cmdStop.Text = "Stop Service";
            this.cmdStop.UseVisualStyleBackColor = true;
            // 
            // cmdExit
            // 
            this.cmdExit.Location = new System.Drawing.Point(604, 335);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(151, 23);
            this.cmdExit.TabIndex = 3;
            this.cmdExit.Text = "EXIT";
            this.cmdExit.UseVisualStyleBackColor = true;
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // cmdMin
            // 
            this.cmdMin.Location = new System.Drawing.Point(411, 335);
            this.cmdMin.Name = "cmdMin";
            this.cmdMin.Size = new System.Drawing.Size(151, 23);
            this.cmdMin.TabIndex = 4;
            this.cmdMin.Text = "Minimal";
            this.cmdMin.UseVisualStyleBackColor = true;
            this.cmdMin.Click += new System.EventHandler(this.cmdMin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "JIFresh Order Service";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(543, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(767, 370);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmdMin);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.cmdStop);
            this.Controls.Add(this.lstLog);
            this.Controls.Add(this.cmdStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdStart;
        private System.Windows.Forms.ListBox lstLog;
        private System.Windows.Forms.Button cmdStop;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.Button cmdMin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}