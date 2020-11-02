namespace SelfCare.View
{
    partial class DisplayForm
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
            this.ConGphn = new System.Windows.Forms.Label();
            this.ConGphnTxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ConGphn
            // 
            this.ConGphn.AutoSize = true;
            this.ConGphn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConGphn.Location = new System.Drawing.Point(96, 85);
            this.ConGphn.Name = "ConGphn";
            this.ConGphn.Size = new System.Drawing.Size(193, 27);
            this.ConGphn.TabIndex = 1;
            this.ConGphn.Text = "Phone Number =>";
            // 
            // ConGphnTxt
            // 
            this.ConGphnTxt.AutoSize = true;
            this.ConGphnTxt.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConGphnTxt.Location = new System.Drawing.Point(323, 85);
            this.ConGphnTxt.Name = "ConGphnTxt";
            this.ConGphnTxt.Size = new System.Drawing.Size(152, 27);
            this.ConGphnTxt.TabIndex = 2;
            this.ConGphnTxt.Text = "............................";
            // 
            // DisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ConGphnTxt);
            this.Controls.Add(this.ConGphn);
            this.Name = "DisplayForm";
            this.Text = "DisplayForm";
            this.Load += new System.EventHandler(this.DisplayForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ConGphn;
        private System.Windows.Forms.Label ConGphnTxt;
    }
}