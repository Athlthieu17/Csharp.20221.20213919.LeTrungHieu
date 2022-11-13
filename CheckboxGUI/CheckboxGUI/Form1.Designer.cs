namespace CheckboxGUI
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
            this.checkBoxMan = new System.Windows.Forms.CheckBox();
            this.btnClick = new System.Windows.Forms.Button();
            this.txbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBoxMan
            // 
            this.checkBoxMan.AutoSize = true;
            this.checkBoxMan.Location = new System.Drawing.Point(176, 90);
            this.checkBoxMan.Name = "checkBoxMan";
            this.checkBoxMan.Size = new System.Drawing.Size(50, 19);
            this.checkBoxMan.TabIndex = 0;
            this.checkBoxMan.Text = "Man";
            this.checkBoxMan.ThreeState = true;
            this.checkBoxMan.UseVisualStyleBackColor = true;
            this.checkBoxMan.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.checkBoxMan.CheckStateChanged += new System.EventHandler(this.checkBox1_CheckStateChanged);
            this.checkBoxMan.Click += new System.EventHandler(this.checkBox1_Click);
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(176, 115);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(75, 23);
            this.btnClick.TabIndex = 1;
            this.btnClick.Text = "Click";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(176, 61);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(100, 23);
            this.txbName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.checkBoxMan);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxMan;
        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label label1;
    }
}
