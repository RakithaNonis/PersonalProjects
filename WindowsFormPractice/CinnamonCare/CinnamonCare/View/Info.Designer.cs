namespace CinnamonCare.View
{
    partial class Info
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
            this.nameLbl = new System.Windows.Forms.Label();
            this.ttlLbl = new System.Windows.Forms.Label();
            this.ctryLbl = new System.Windows.Forms.Label();
            this.ctryLblDrop = new System.Windows.Forms.ComboBox();
            this.ttlLblDrop = new System.Windows.Forms.ComboBox();
            this.nameLblTxt = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.Location = new System.Drawing.Point(112, 111);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(80, 27);
            this.nameLbl.TabIndex = 1;
            this.nameLbl.Text = "Name :";
            // 
            // ttlLbl
            // 
            this.ttlLbl.AutoSize = true;
            this.ttlLbl.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ttlLbl.Location = new System.Drawing.Point(112, 51);
            this.ttlLbl.Name = "ttlLbl";
            this.ttlLbl.Size = new System.Drawing.Size(68, 27);
            this.ttlLbl.TabIndex = 2;
            this.ttlLbl.Text = "Title : ";
            // 
            // ctryLbl
            // 
            this.ctryLbl.AutoSize = true;
            this.ctryLbl.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctryLbl.Location = new System.Drawing.Point(112, 174);
            this.ctryLbl.Name = "ctryLbl";
            this.ctryLbl.Size = new System.Drawing.Size(99, 27);
            this.ctryLbl.TabIndex = 3;
            this.ctryLbl.Text = "Country :";
            // 
            // ctryLblDrop
            // 
            this.ctryLblDrop.FormattingEnabled = true;
            this.ctryLblDrop.Location = new System.Drawing.Point(243, 174);
            this.ctryLblDrop.Name = "ctryLblDrop";
            this.ctryLblDrop.Size = new System.Drawing.Size(274, 24);
            this.ctryLblDrop.TabIndex = 6;
            // 
            // ttlLblDrop
            // 
            this.ttlLblDrop.FormattingEnabled = true;
            this.ttlLblDrop.Location = new System.Drawing.Point(243, 56);
            this.ttlLblDrop.Name = "ttlLblDrop";
            this.ttlLblDrop.Size = new System.Drawing.Size(274, 24);
            this.ttlLblDrop.TabIndex = 7;
            // 
            // nameLblTxt
            // 
            this.nameLblTxt.Location = new System.Drawing.Point(243, 116);
            this.nameLblTxt.Name = "nameLblTxt";
            this.nameLblTxt.Size = new System.Drawing.Size(274, 22);
            this.nameLblTxt.TabIndex = 8;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(483, 363);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(107, 41);
            this.btnNext.TabIndex = 9;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // Info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 504);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.nameLblTxt);
            this.Controls.Add(this.ttlLblDrop);
            this.Controls.Add(this.ctryLblDrop);
            this.Controls.Add(this.ctryLbl);
            this.Controls.Add(this.ttlLbl);
            this.Controls.Add(this.nameLbl);
            this.Name = "Info";
            this.Text = "Info";
            this.Load += new System.EventHandler(this.Info_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label ttlLbl;
        private System.Windows.Forms.Label ctryLbl;
        private System.Windows.Forms.ComboBox ctryLblDrop;
        private System.Windows.Forms.ComboBox ttlLblDrop;
        private System.Windows.Forms.TextBox nameLblTxt;
        private System.Windows.Forms.Button btnNext;
    }
}