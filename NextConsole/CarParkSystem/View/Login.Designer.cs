namespace CarParkSystem.View
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
            this.RegLblTxt = new System.Windows.Forms.TextBox();
            this.NextBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RegLbl
            // 
            this.RegLbl.AutoSize = true;
            this.RegLbl.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegLbl.Location = new System.Drawing.Point(106, 153);
            this.RegLbl.Name = "RegLbl";
            this.RegLbl.Size = new System.Drawing.Size(267, 31);
            this.RegLbl.TabIndex = 0;
            this.RegLbl.Text = "Registration Number :";
            // 
            // RegLblTxt
            // 
            this.RegLblTxt.Location = new System.Drawing.Point(207, 247);
            this.RegLblTxt.Name = "RegLblTxt";
            this.RegLblTxt.Size = new System.Drawing.Size(440, 22);
            this.RegLblTxt.TabIndex = 1;
            // 
            // NextBtn
            // 
            this.NextBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextBtn.Location = new System.Drawing.Point(593, 398);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(96, 32);
            this.NextBtn.TabIndex = 2;
            this.NextBtn.Text = "Next";
            this.NextBtn.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 512);
            this.Controls.Add(this.NextBtn);
            this.Controls.Add(this.RegLblTxt);
            this.Controls.Add(this.RegLbl);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RegLbl;
        private System.Windows.Forms.TextBox RegLblTxt;
        private System.Windows.Forms.Button NextBtn;
    }
}