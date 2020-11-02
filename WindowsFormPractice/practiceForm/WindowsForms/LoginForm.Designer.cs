namespace WindowsForms
{
    partial class LoginForm
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
            this.UserLbl = new System.Windows.Forms.Label();
            this.TxtUserid = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.PassLbl = new System.Windows.Forms.Label();
            this.btLog = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserLbl
            // 
            this.UserLbl.AutoSize = true;
            this.UserLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLbl.Location = new System.Drawing.Point(186, 102);
            this.UserLbl.Name = "UserLbl";
            this.UserLbl.Size = new System.Drawing.Size(105, 29);
            this.UserLbl.TabIndex = 0;
            this.UserLbl.Text = "User ID :";
            this.UserLbl.Click += new System.EventHandler(this.UserLbl_Click);
            // 
            // TxtUserid
            // 
            this.TxtUserid.Location = new System.Drawing.Point(328, 109);
            this.TxtUserid.Name = "TxtUserid";
            this.TxtUserid.Size = new System.Drawing.Size(507, 22);
            this.TxtUserid.TabIndex = 1;
            this.TxtUserid.TextChanged += new System.EventHandler(this.TxtUserid_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(328, 191);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(507, 22);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // PassLbl
            // 
            this.PassLbl.AutoSize = true;
            this.PassLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassLbl.Location = new System.Drawing.Point(186, 184);
            this.PassLbl.Name = "PassLbl";
            this.PassLbl.Size = new System.Drawing.Size(136, 29);
            this.PassLbl.TabIndex = 2;
            this.PassLbl.Text = "PassWord :";
            // 
            // btLog
            // 
            this.btLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLog.Location = new System.Drawing.Point(215, 387);
            this.btLog.Name = "btLog";
            this.btLog.Size = new System.Drawing.Size(136, 48);
            this.btLog.TabIndex = 4;
            this.btLog.Text = "Login";
            this.btLog.UseVisualStyleBackColor = true;
            this.btLog.Click += new System.EventHandler(this.button1_Click);
            // 
            // btReset
            // 
            this.btReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReset.Location = new System.Drawing.Point(445, 387);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(136, 48);
            this.btReset.TabIndex = 5;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 558);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.btLog);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.PassLbl);
            this.Controls.Add(this.TxtUserid);
            this.Controls.Add(this.UserLbl);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UserLbl;
        private System.Windows.Forms.TextBox TxtUserid;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label PassLbl;
        private System.Windows.Forms.Button btLog;
        private System.Windows.Forms.Button btReset;
    }
}