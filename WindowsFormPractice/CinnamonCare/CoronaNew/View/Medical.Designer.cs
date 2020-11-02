namespace CoronaNew.View
{
    partial class Medical
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
            this.btnSub = new System.Windows.Forms.Button();
            this.symLblChk = new System.Windows.Forms.CheckedListBox();
            this.tempLblTxt = new System.Windows.Forms.TextBox();
            this.symLbl = new System.Windows.Forms.Label();
            this.tempLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(578, 330);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(107, 41);
            this.btnSub.TabIndex = 16;
            this.btnSub.Text = "Submit";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // symLblChk
            // 
            this.symLblChk.FormattingEnabled = true;
            this.symLblChk.Location = new System.Drawing.Point(302, 151);
            this.symLblChk.Name = "symLblChk";
            this.symLblChk.Size = new System.Drawing.Size(274, 123);
            this.symLblChk.TabIndex = 15;
            // 
            // tempLblTxt
            // 
            this.tempLblTxt.Location = new System.Drawing.Point(302, 84);
            this.tempLblTxt.Name = "tempLblTxt";
            this.tempLblTxt.Size = new System.Drawing.Size(274, 22);
            this.tempLblTxt.TabIndex = 14;
            // 
            // symLbl
            // 
            this.symLbl.AutoSize = true;
            this.symLbl.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.symLbl.Location = new System.Drawing.Point(116, 153);
            this.symLbl.Name = "symLbl";
            this.symLbl.Size = new System.Drawing.Size(113, 27);
            this.symLbl.TabIndex = 13;
            this.symLbl.Text = "Symtoms :";
            // 
            // tempLbl
            // 
            this.tempLbl.AutoSize = true;
            this.tempLbl.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempLbl.Location = new System.Drawing.Point(116, 79);
            this.tempLbl.Name = "tempLbl";
            this.tempLbl.Size = new System.Drawing.Size(145, 27);
            this.tempLbl.TabIndex = 12;
            this.tempLbl.Text = "Temperature :";
            // 
            // Medical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.symLblChk);
            this.Controls.Add(this.tempLblTxt);
            this.Controls.Add(this.symLbl);
            this.Controls.Add(this.tempLbl);
            this.Name = "Medical";
            this.Text = "Medical";
            this.Load += new System.EventHandler(this.Medical_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.CheckedListBox symLblChk;
        private System.Windows.Forms.TextBox tempLblTxt;
        private System.Windows.Forms.Label symLbl;
        private System.Windows.Forms.Label tempLbl;
    }
}