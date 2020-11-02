namespace WindowsForms
{
    partial class Confirmation
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
            this.TopText = new System.Windows.Forms.Label();
            this.LblConFname = new System.Windows.Forms.Label();
            this.TxtConFname = new System.Windows.Forms.Label();
            this.TxtConLname = new System.Windows.Forms.Label();
            this.LblConLname = new System.Windows.Forms.Label();
            this.TxtConEmail = new System.Windows.Forms.Label();
            this.LblConEmail = new System.Windows.Forms.Label();
            this.LblConInfo = new System.Windows.Forms.Label();
            this.LblSelSms = new System.Windows.Forms.Label();
            this.LblSelTrans = new System.Windows.Forms.Label();
            this.LblSelReports = new System.Windows.Forms.Label();
            this.TxtConSms = new System.Windows.Forms.Label();
            this.TxtConTrans = new System.Windows.Forms.Label();
            this.TxtConRepo = new System.Windows.Forms.Label();
            this.BtnOkay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TopText
            // 
            this.TopText.AutoSize = true;
            this.TopText.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopText.Location = new System.Drawing.Point(243, 29);
            this.TopText.Name = "TopText";
            this.TopText.Size = new System.Drawing.Size(424, 27);
            this.TopText.TabIndex = 0;
            this.TopText.Text = "Thanks for sign in...We will catch you soon..";
            // 
            // LblConFname
            // 
            this.LblConFname.AutoSize = true;
            this.LblConFname.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblConFname.Location = new System.Drawing.Point(200, 96);
            this.LblConFname.Name = "LblConFname";
            this.LblConFname.Size = new System.Drawing.Size(111, 27);
            this.LblConFname.TabIndex = 1;
            this.LblConFname.Text = "First name";
            this.LblConFname.Click += new System.EventHandler(this.LblConFname_Click);
            // 
            // TxtConFname
            // 
            this.TxtConFname.AutoSize = true;
            this.TxtConFname.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtConFname.Location = new System.Drawing.Point(452, 96);
            this.TxtConFname.Name = "TxtConFname";
            this.TxtConFname.Size = new System.Drawing.Size(164, 27);
            this.TxtConFname.TabIndex = 2;
            this.TxtConFname.Text = "Your first name ";
            this.TxtConFname.Click += new System.EventHandler(this.TxtConFname_Click);
            // 
            // TxtConLname
            // 
            this.TxtConLname.AutoSize = true;
            this.TxtConLname.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtConLname.Location = new System.Drawing.Point(452, 145);
            this.TxtConLname.Name = "TxtConLname";
            this.TxtConLname.Size = new System.Drawing.Size(160, 27);
            this.TxtConLname.TabIndex = 4;
            this.TxtConLname.Text = "Your last name ";
            // 
            // LblConLname
            // 
            this.LblConLname.AutoSize = true;
            this.LblConLname.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblConLname.Location = new System.Drawing.Point(200, 145);
            this.LblConLname.Name = "LblConLname";
            this.LblConLname.Size = new System.Drawing.Size(108, 27);
            this.LblConLname.TabIndex = 3;
            this.LblConLname.Text = "Last name";
            // 
            // TxtConEmail
            // 
            this.TxtConEmail.AutoSize = true;
            this.TxtConEmail.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtConEmail.Location = new System.Drawing.Point(452, 189);
            this.TxtConEmail.Name = "TxtConEmail";
            this.TxtConEmail.Size = new System.Drawing.Size(114, 27);
            this.TxtConEmail.TabIndex = 6;
            this.TxtConEmail.Text = "Your Email";
            this.TxtConEmail.Click += new System.EventHandler(this.label3_Click);
            // 
            // LblConEmail
            // 
            this.LblConEmail.AutoSize = true;
            this.LblConEmail.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblConEmail.Location = new System.Drawing.Point(200, 189);
            this.LblConEmail.Name = "LblConEmail";
            this.LblConEmail.Size = new System.Drawing.Size(63, 27);
            this.LblConEmail.TabIndex = 5;
            this.LblConEmail.Text = "Email";
            // 
            // LblConInfo
            // 
            this.LblConInfo.AutoSize = true;
            this.LblConInfo.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblConInfo.Location = new System.Drawing.Point(243, 289);
            this.LblConInfo.Name = "LblConInfo";
            this.LblConInfo.Size = new System.Drawing.Size(307, 27);
            this.LblConInfo.TabIndex = 7;
            this.LblConInfo.Text = "You have chosen these items...!";
            // 
            // LblSelSms
            // 
            this.LblSelSms.AutoSize = true;
            this.LblSelSms.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSelSms.Location = new System.Drawing.Point(358, 355);
            this.LblSelSms.Name = "LblSelSms";
            this.LblSelSms.Size = new System.Drawing.Size(56, 27);
            this.LblSelSms.TabIndex = 8;
            this.LblSelSms.Text = "SMS";
            // 
            // LblSelTrans
            // 
            this.LblSelTrans.AutoSize = true;
            this.LblSelTrans.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSelTrans.Location = new System.Drawing.Point(358, 463);
            this.LblSelTrans.Name = "LblSelTrans";
            this.LblSelTrans.Size = new System.Drawing.Size(121, 27);
            this.LblSelTrans.TabIndex = 9;
            this.LblSelTrans.Text = "Transaction";
            // 
            // LblSelReports
            // 
            this.LblSelReports.AutoSize = true;
            this.LblSelReports.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSelReports.Location = new System.Drawing.Point(358, 410);
            this.LblSelReports.Name = "LblSelReports";
            this.LblSelReports.Size = new System.Drawing.Size(86, 27);
            this.LblSelReports.TabIndex = 10;
            this.LblSelReports.Text = "Reports";
            // 
            // TxtConSms
            // 
            this.TxtConSms.AutoSize = true;
            this.TxtConSms.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtConSms.Location = new System.Drawing.Point(576, 355);
            this.TxtConSms.Name = "TxtConSms";
            this.TxtConSms.Size = new System.Drawing.Size(19, 23);
            this.TxtConSms.TabIndex = 11;
            this.TxtConSms.Text = "x";
            this.TxtConSms.Click += new System.EventHandler(this.TxtConSms_Click);
            // 
            // TxtConTrans
            // 
            this.TxtConTrans.AutoSize = true;
            this.TxtConTrans.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtConTrans.Location = new System.Drawing.Point(576, 466);
            this.TxtConTrans.Name = "TxtConTrans";
            this.TxtConTrans.Size = new System.Drawing.Size(19, 23);
            this.TxtConTrans.TabIndex = 12;
            this.TxtConTrans.Text = "x";
            // 
            // TxtConRepo
            // 
            this.TxtConRepo.AutoSize = true;
            this.TxtConRepo.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtConRepo.Location = new System.Drawing.Point(576, 413);
            this.TxtConRepo.Name = "TxtConRepo";
            this.TxtConRepo.Size = new System.Drawing.Size(19, 23);
            this.TxtConRepo.TabIndex = 13;
            this.TxtConRepo.Text = "x";
            // 
            // BtnOkay
            // 
            this.BtnOkay.Location = new System.Drawing.Point(746, 562);
            this.BtnOkay.Name = "BtnOkay";
            this.BtnOkay.Size = new System.Drawing.Size(111, 41);
            this.BtnOkay.TabIndex = 14;
            this.BtnOkay.Text = "OK";
            this.BtnOkay.UseVisualStyleBackColor = true;
            this.BtnOkay.Click += new System.EventHandler(this.BtnOkay_Click);
            // 
            // Confirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 637);
            this.Controls.Add(this.BtnOkay);
            this.Controls.Add(this.TxtConRepo);
            this.Controls.Add(this.TxtConTrans);
            this.Controls.Add(this.TxtConSms);
            this.Controls.Add(this.LblSelReports);
            this.Controls.Add(this.LblSelTrans);
            this.Controls.Add(this.LblSelSms);
            this.Controls.Add(this.LblConInfo);
            this.Controls.Add(this.TxtConEmail);
            this.Controls.Add(this.LblConEmail);
            this.Controls.Add(this.TxtConLname);
            this.Controls.Add(this.LblConLname);
            this.Controls.Add(this.TxtConFname);
            this.Controls.Add(this.LblConFname);
            this.Controls.Add(this.TopText);
            this.Name = "Confirmation";
            this.Text = "Confirmation";
            this.Load += new System.EventHandler(this.Confirmation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TopText;
        private System.Windows.Forms.Label LblConFname;
        private System.Windows.Forms.Label TxtConFname;
        private System.Windows.Forms.Label TxtConLname;
        private System.Windows.Forms.Label LblConLname;
        private System.Windows.Forms.Label TxtConEmail;
        private System.Windows.Forms.Label LblConEmail;
        private System.Windows.Forms.Label LblConInfo;
        private System.Windows.Forms.Label LblSelSms;
        private System.Windows.Forms.Label LblSelTrans;
        private System.Windows.Forms.Label LblSelReports;
        private System.Windows.Forms.Label TxtConSms;
        private System.Windows.Forms.Label TxtConTrans;
        private System.Windows.Forms.Label TxtConRepo;
        private System.Windows.Forms.Button BtnOkay;
    }
}