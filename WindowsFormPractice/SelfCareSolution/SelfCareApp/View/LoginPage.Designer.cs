namespace SelfCareApp
{
    partial class Log
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
            this.BtnLog = new System.Windows.Forms.Button();
            this.GhtlDrop = new System.Windows.Forms.ComboBox();
            this.Ghtl = new System.Windows.Forms.Label();
            this.GphnTxt = new System.Windows.Forms.TextBox();
            this.Gphn = new System.Windows.Forms.Label();
            this.GtblTxt = new System.Windows.Forms.TextBox();
            this.Gtbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnLog
            // 
            this.BtnLog.Location = new System.Drawing.Point(558, 319);
            this.BtnLog.Name = "BtnLog";
            this.BtnLog.Size = new System.Drawing.Size(103, 39);
            this.BtnLog.TabIndex = 14;
            this.BtnLog.Text = "OK";
            this.BtnLog.UseVisualStyleBackColor = true;
            this.BtnLog.Click += new System.EventHandler(this.BtnLog_Click);
            // 
            // GhtlDrop
            // 
            this.GhtlDrop.FormattingEnabled = true;
            this.GhtlDrop.Location = new System.Drawing.Point(351, 215);
            this.GhtlDrop.Name = "GhtlDrop";
            this.GhtlDrop.Size = new System.Drawing.Size(281, 24);
            this.GhtlDrop.TabIndex = 13;
            // 
            // Ghtl
            // 
            this.Ghtl.AutoSize = true;
            this.Ghtl.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ghtl.Location = new System.Drawing.Point(140, 215);
            this.Ghtl.Name = "Ghtl";
            this.Ghtl.Size = new System.Drawing.Size(136, 27);
            this.Ghtl.TabIndex = 12;
            this.Ghtl.Text = "Hotel Select :";
            // 
            // GphnTxt
            // 
            this.GphnTxt.Location = new System.Drawing.Point(351, 97);
            this.GphnTxt.Name = "GphnTxt";
            this.GphnTxt.Size = new System.Drawing.Size(281, 22);
            this.GphnTxt.TabIndex = 11;
            // 
            // Gphn
            // 
            this.Gphn.AutoSize = true;
            this.Gphn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gphn.Location = new System.Drawing.Point(140, 92);
            this.Gphn.Name = "Gphn";
            this.Gphn.Size = new System.Drawing.Size(168, 27);
            this.Gphn.TabIndex = 10;
            this.Gphn.Text = "Phone Number :";
            // 
            // GtblTxt
            // 
            this.GtblTxt.Location = new System.Drawing.Point(351, 160);
            this.GtblTxt.Name = "GtblTxt";
            this.GtblTxt.Size = new System.Drawing.Size(281, 22);
            this.GtblTxt.TabIndex = 16;
            // 
            // Gtbl
            // 
            this.Gtbl.AutoSize = true;
            this.Gtbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gtbl.Location = new System.Drawing.Point(140, 155);
            this.Gtbl.Name = "Gtbl";
            this.Gtbl.Size = new System.Drawing.Size(159, 27);
            this.Gtbl.TabIndex = 15;
            this.Gtbl.Text = "Table Number :";
            // 
            // Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GtblTxt);
            this.Controls.Add(this.Gtbl);
            this.Controls.Add(this.BtnLog);
            this.Controls.Add(this.GhtlDrop);
            this.Controls.Add(this.Ghtl);
            this.Controls.Add(this.GphnTxt);
            this.Controls.Add(this.Gphn);
            this.Name = "Log";
            this.Text = "LoginPage";
            this.Load += new System.EventHandler(this.Log_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnLog;
        private System.Windows.Forms.ComboBox GhtlDrop;
        private System.Windows.Forms.Label Ghtl;
        private System.Windows.Forms.TextBox GphnTxt;
        private System.Windows.Forms.Label Gphn;
        private System.Windows.Forms.TextBox GtblTxt;
        private System.Windows.Forms.Label Gtbl;
    }
}

