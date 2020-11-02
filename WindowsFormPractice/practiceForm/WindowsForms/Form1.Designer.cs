namespace WindowsForms
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
            this.FNameLbl = new System.Windows.Forms.Label();
            this.FNameTxt = new System.Windows.Forms.TextBox();
            this.EmailTxt = new System.Windows.Forms.TextBox();
            this.EmailLbl = new System.Windows.Forms.Label();
            this.LNameTxt = new System.Windows.Forms.TextBox();
            this.LNameLbl = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.transLbl = new System.Windows.Forms.Label();
            this.Transcheck = new System.Windows.Forms.CheckBox();
            this.ReportLbl = new System.Windows.Forms.Label();
            this.Reportcheck = new System.Windows.Forms.CheckBox();
            this.SMSlbl = new System.Windows.Forms.Label();
            this.SMScheck = new System.Windows.Forms.CheckBox();
            this.SignupBtn = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // FNameLbl
            // 
            this.FNameLbl.AutoSize = true;
            this.FNameLbl.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FNameLbl.Location = new System.Drawing.Point(64, 64);
            this.FNameLbl.Name = "FNameLbl";
            this.FNameLbl.Size = new System.Drawing.Size(145, 31);
            this.FNameLbl.TabIndex = 0;
            this.FNameLbl.Text = "First Name";
            this.FNameLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // FNameTxt
            // 
            this.FNameTxt.Location = new System.Drawing.Point(234, 73);
            this.FNameTxt.Name = "FNameTxt";
            this.FNameTxt.Size = new System.Drawing.Size(363, 22);
            this.FNameTxt.TabIndex = 1;
            this.FNameTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // EmailTxt
            // 
            this.EmailTxt.Location = new System.Drawing.Point(234, 173);
            this.EmailTxt.Name = "EmailTxt";
            this.EmailTxt.Size = new System.Drawing.Size(363, 22);
            this.EmailTxt.TabIndex = 3;
            // 
            // EmailLbl
            // 
            this.EmailLbl.AutoSize = true;
            this.EmailLbl.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLbl.Location = new System.Drawing.Point(64, 164);
            this.EmailLbl.Name = "EmailLbl";
            this.EmailLbl.Size = new System.Drawing.Size(80, 31);
            this.EmailLbl.TabIndex = 2;
            this.EmailLbl.Text = "Email";
            // 
            // LNameTxt
            // 
            this.LNameTxt.Location = new System.Drawing.Point(234, 123);
            this.LNameTxt.Name = "LNameTxt";
            this.LNameTxt.Size = new System.Drawing.Size(363, 22);
            this.LNameTxt.TabIndex = 5;
            // 
            // LNameLbl
            // 
            this.LNameLbl.AutoSize = true;
            this.LNameLbl.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNameLbl.Location = new System.Drawing.Point(64, 114);
            this.LNameLbl.Name = "LNameLbl";
            this.LNameLbl.Size = new System.Drawing.Size(142, 31);
            this.LNameLbl.TabIndex = 4;
            this.LNameLbl.Text = "Last Name";
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.transLbl);
            this.groupBox.Controls.Add(this.Transcheck);
            this.groupBox.Controls.Add(this.ReportLbl);
            this.groupBox.Controls.Add(this.Reportcheck);
            this.groupBox.Controls.Add(this.SMSlbl);
            this.groupBox.Controls.Add(this.SMScheck);
            this.groupBox.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.Location = new System.Drawing.Point(70, 271);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(671, 232);
            this.groupBox.TabIndex = 6;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Services";
            this.groupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // transLbl
            // 
            this.transLbl.AutoSize = true;
            this.transLbl.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transLbl.Location = new System.Drawing.Point(329, 133);
            this.transLbl.Name = "transLbl";
            this.transLbl.Size = new System.Drawing.Size(41, 20);
            this.transLbl.TabIndex = 5;
            this.transLbl.Text = "........";
            // 
            // Transcheck
            // 
            this.Transcheck.AutoSize = true;
            this.Transcheck.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Transcheck.Location = new System.Drawing.Point(52, 130);
            this.Transcheck.Name = "Transcheck";
            this.Transcheck.Size = new System.Drawing.Size(132, 28);
            this.Transcheck.TabIndex = 4;
            this.Transcheck.Text = "Transaction";
            this.Transcheck.UseVisualStyleBackColor = true;
            this.Transcheck.CheckedChanged += new System.EventHandler(this.Transcheck_CheckedChanged);
            // 
            // ReportLbl
            // 
            this.ReportLbl.AutoSize = true;
            this.ReportLbl.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportLbl.Location = new System.Drawing.Point(329, 99);
            this.ReportLbl.Name = "ReportLbl";
            this.ReportLbl.Size = new System.Drawing.Size(41, 20);
            this.ReportLbl.TabIndex = 3;
            this.ReportLbl.Text = "........";
            // 
            // Reportcheck
            // 
            this.Reportcheck.AutoSize = true;
            this.Reportcheck.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reportcheck.Location = new System.Drawing.Point(52, 96);
            this.Reportcheck.Name = "Reportcheck";
            this.Reportcheck.Size = new System.Drawing.Size(90, 28);
            this.Reportcheck.TabIndex = 2;
            this.Reportcheck.Text = "Report";
            this.Reportcheck.UseVisualStyleBackColor = true;
            this.Reportcheck.CheckedChanged += new System.EventHandler(this.Reportcheck_CheckedChanged);
            // 
            // SMSlbl
            // 
            this.SMSlbl.AutoSize = true;
            this.SMSlbl.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SMSlbl.Location = new System.Drawing.Point(329, 62);
            this.SMSlbl.Name = "SMSlbl";
            this.SMSlbl.Size = new System.Drawing.Size(41, 20);
            this.SMSlbl.TabIndex = 1;
            this.SMSlbl.Text = "........";
            this.SMSlbl.Click += new System.EventHandler(this.SMSlbl_Click);
            // 
            // SMScheck
            // 
            this.SMScheck.AutoSize = true;
            this.SMScheck.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SMScheck.Location = new System.Drawing.Point(52, 62);
            this.SMScheck.Name = "SMScheck";
            this.SMScheck.Size = new System.Drawing.Size(173, 28);
            this.SMScheck.TabIndex = 0;
            this.SMScheck.Text = "SMS notification";
            this.SMScheck.UseVisualStyleBackColor = true;
            this.SMScheck.CheckedChanged += new System.EventHandler(this.SMScheck_CheckedChanged);
            // 
            // SignupBtn
            // 
            this.SignupBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignupBtn.Location = new System.Drawing.Point(668, 531);
            this.SignupBtn.Name = "SignupBtn";
            this.SignupBtn.Size = new System.Drawing.Size(103, 38);
            this.SignupBtn.TabIndex = 7;
            this.SignupBtn.Text = "Sign Up";
            this.SignupBtn.UseVisualStyleBackColor = true;
            this.SignupBtn.Click += new System.EventHandler(this.SignupBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 592);
            this.Controls.Add(this.SignupBtn);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.LNameTxt);
            this.Controls.Add(this.LNameLbl);
            this.Controls.Add(this.EmailTxt);
            this.Controls.Add(this.EmailLbl);
            this.Controls.Add(this.FNameTxt);
            this.Controls.Add(this.FNameLbl);
            this.Name = "Form1";
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FNameLbl;
        private System.Windows.Forms.TextBox FNameTxt;
        private System.Windows.Forms.TextBox EmailTxt;
        private System.Windows.Forms.Label EmailLbl;
        private System.Windows.Forms.TextBox LNameTxt;
        private System.Windows.Forms.Label LNameLbl;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label transLbl;
        private System.Windows.Forms.CheckBox Transcheck;
        private System.Windows.Forms.Label ReportLbl;
        private System.Windows.Forms.CheckBox Reportcheck;
        private System.Windows.Forms.Label SMSlbl;
        private System.Windows.Forms.CheckBox SMScheck;
        private System.Windows.Forms.Button SignupBtn;
    }
}