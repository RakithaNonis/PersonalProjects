namespace CoronaCareApp.View
{
    partial class Infors
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
            this.GnameTxt = new System.Windows.Forms.TextBox();
            this.Gname = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GnameTxt
            // 
            this.GnameTxt.Location = new System.Drawing.Point(276, 64);
            this.GnameTxt.Name = "GnameTxt";
            this.GnameTxt.Size = new System.Drawing.Size(281, 22);
            this.GnameTxt.TabIndex = 8;
            // 
            // Gname
            // 
            this.Gname.AutoSize = true;
            this.Gname.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gname.Location = new System.Drawing.Point(65, 59);
            this.Gname.Name = "Gname";
            this.Gname.Size = new System.Drawing.Size(140, 27);
            this.Gname.TabIndex = 7;
            this.Gname.Text = "Guest Name :";
            // 
            // Infors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 557);
            this.Controls.Add(this.GnameTxt);
            this.Controls.Add(this.Gname);
            this.Name = "Infors";
            this.Text = "Infors";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox GnameTxt;
        private System.Windows.Forms.Label Gname;
    }
}