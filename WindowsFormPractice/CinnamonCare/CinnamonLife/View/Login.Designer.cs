namespace CinnamonLife.View
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
            this.RegLbl = new System.Windows.Forms.Label();
            this.RegTxt = new System.Windows.Forms.TextBox();
            this.RejBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RegLbl
            // 
            this.RegLbl.AutoSize = true;
            this.RegLbl.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegLbl.Location = new System.Drawing.Point(119, 130);
            this.RegLbl.Name = "RegLbl";
            this.RegLbl.Size = new System.Drawing.Size(222, 27);
            this.RegLbl.TabIndex = 0;
            this.RegLbl.Text = "Registration Number :";
            this.RegLbl.Click += new System.EventHandler(this.RegLbl_Click);
            // 
            // RegTxt
            // 
            this.RegTxt.Location = new System.Drawing.Point(256, 200);
            this.RegTxt.Name = "RegTxt";
            this.RegTxt.Size = new System.Drawing.Size(312, 22);
            this.RegTxt.TabIndex = 1;
            this.RegTxt.TextChanged += new System.EventHandler(this.RegTxt_TextChanged);
            // 
            // RejBtn
            // 
            this.RejBtn.Location = new System.Drawing.Point(533, 325);
            this.RejBtn.Name = "RejBtn";
            this.RejBtn.Size = new System.Drawing.Size(75, 34);
            this.RejBtn.TabIndex = 2;
            this.RejBtn.Text = "Next";
            this.RejBtn.UseVisualStyleBackColor = true;
            this.RejBtn.Click += new System.EventHandler(this.RejBtn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RejBtn);
            this.Controls.Add(this.RegTxt);
            this.Controls.Add(this.RegLbl);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RegLbl;
        private System.Windows.Forms.TextBox RegTxt;
        private System.Windows.Forms.Button RejBtn;
    }
}