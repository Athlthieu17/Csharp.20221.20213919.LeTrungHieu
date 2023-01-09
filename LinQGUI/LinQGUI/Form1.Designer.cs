namespace LinQGUI
{
    partial class Form1
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
            this.cbData = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txbKey = new System.Windows.Forms.TextBox();
            this.cbResult = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cbData
            // 
            this.cbData.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbData.FormattingEnabled = true;
            this.cbData.Location = new System.Drawing.Point(12, 46);
            this.cbData.Name = "cbData";
            this.cbData.Size = new System.Drawing.Size(134, 215);
            this.cbData.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(118, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Filter";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txbKey
            // 
            this.txbKey.Location = new System.Drawing.Point(12, 12);
            this.txbKey.Name = "txbKey";
            this.txbKey.Size = new System.Drawing.Size(100, 20);
            this.txbKey.TabIndex = 2;
            // 
            // cbResult
            // 
            this.cbResult.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbResult.FormattingEnabled = true;
            this.cbResult.Location = new System.Drawing.Point(152, 46);
            this.cbResult.Name = "cbResult";
            this.cbResult.Size = new System.Drawing.Size(120, 215);
            this.cbResult.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cbResult);
            this.Controls.Add(this.txbKey);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.cbData);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbData;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txbKey;
        private System.Windows.Forms.ComboBox cbResult;
        private EventHandler btnSearch_Click;
    }
}

