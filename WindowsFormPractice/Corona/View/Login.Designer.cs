namespace Corona.View
{
    partial class Login
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
            this.btnOk = new System.Windows.Forms.Button();
            this.htlLblDrop = new System.Windows.Forms.ComboBox();
            this.tblLblTxt = new System.Windows.Forms.TextBox();
            this.htlLbl = new System.Windows.Forms.Label();
            this.tblLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(566, 324);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(107, 41);
            this.btnOk.TabIndex = 11;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // htlLblDrop
            // 
            this.htlLblDrop.FormattingEnabled = true;
            this.htlLblDrop.Location = new System.Drawing.Point(328, 153);
            this.htlLblDrop.Name = "htlLblDrop";
            this.htlLblDrop.Size = new System.Drawing.Size(274, 24);
            this.htlLblDrop.TabIndex = 10;
            // 
            // tblLblTxt
            // 
            this.tblLblTxt.Location = new System.Drawing.Point(328, 91);
            this.tblLblTxt.Name = "tblLblTxt";
            this.tblLblTxt.Size = new System.Drawing.Size(274, 22);
            this.tblLblTxt.TabIndex = 9;
            // 
            // htlLbl
            // 
            this.htlLbl.AutoSize = true;
            this.htlLbl.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.htlLbl.Location = new System.Drawing.Point(128, 152);
            this.htlLbl.Name = "htlLbl";
            this.htlLbl.Size = new System.Drawing.Size(133, 27);
            this.htlLbl.TabIndex = 8;
            this.htlLbl.Text = "Hotel name :";
            // 
            // tblLbl
            // 
            this.tblLbl.AutoSize = true;
            this.tblLbl.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblLbl.Location = new System.Drawing.Point(128, 86);
            this.tblLbl.Name = "tblLbl";
            this.tblLbl.Size = new System.Drawing.Size(187, 27);
            this.tblLbl.TabIndex = 7;
            this.tblLbl.Text = "Reservation Num :";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.htlLblDrop);
            this.Controls.Add(this.tblLblTxt);
            this.Controls.Add(this.htlLbl);
            this.Controls.Add(this.tblLbl);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ComboBox htlLblDrop;
        private System.Windows.Forms.TextBox tblLblTxt;
        private System.Windows.Forms.Label htlLbl;
        private System.Windows.Forms.Label tblLbl;
    }
}