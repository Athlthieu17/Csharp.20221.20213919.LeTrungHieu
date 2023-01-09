namespace ProcessGUI
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
            this.txbLog = new System.Windows.Forms.TextBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnHiden = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbLog
            // 
            this.txbLog.Location = new System.Drawing.Point(12, 12);
            this.txbLog.Multiline = true;
            this.txbLog.Name = "txbLog";
            this.txbLog.Size = new System.Drawing.Size(169, 194);
            this.txbLog.TabIndex = 0;
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(195, 12);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(98, 23);
            this.btnProcess.TabIndex = 1;
            this.btnProcess.Text = "GET Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(195, 63);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(98, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start Process";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnHiden
            // 
            this.btnHiden.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnHiden.Location = new System.Drawing.Point(195, 113);
            this.btnHiden.Name = "btnHiden";
            this.btnHiden.Size = new System.Drawing.Size(98, 23);
            this.btnHiden.TabIndex = 3;
            this.btnHiden.Text = "Hiden";
            this.btnHiden.UseVisualStyleBackColor = true;
            this.btnHiden.Click += new System.EventHandler(this.btnHiden_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 285);
            this.Controls.Add(this.btnHiden);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.txbLog);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txbLog;
        private Button btnProcess;
        private Button btnStart;
        private Button btnHiden;
    }
}