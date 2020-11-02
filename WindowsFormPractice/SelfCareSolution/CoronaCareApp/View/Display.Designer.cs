namespace CoronaCareApp.View
{
    partial class Display
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
            this.ConGphnTxt = new System.Windows.Forms.Label();
            this.ConGphn = new System.Windows.Forms.Label();
            this.ConGhotelName = new System.Windows.Forms.Label();
            this.ConGHotelnameTxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ConGphnTxt
            // 
            this.ConGphnTxt.AutoSize = true;
            this.ConGphnTxt.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConGphnTxt.Location = new System.Drawing.Point(328, 99);
            this.ConGphnTxt.Name = "ConGphnTxt";
            this.ConGphnTxt.Size = new System.Drawing.Size(152, 27);
            this.ConGphnTxt.TabIndex = 4;
            this.ConGphnTxt.Text = "............................";
            // 
            // ConGphn
            // 
            this.ConGphn.AutoSize = true;
            this.ConGphn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConGphn.Location = new System.Drawing.Point(101, 99);
            this.ConGphn.Name = "ConGphn";
            this.ConGphn.Size = new System.Drawing.Size(193, 27);
            this.ConGphn.TabIndex = 3;
            this.ConGphn.Text = "Phone Number =>";
            this.ConGphn.Click += new System.EventHandler(this.ConGphn_Click);
            // 
            // ConGhotelName
            // 
            this.ConGhotelName.AutoSize = true;
            this.ConGhotelName.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConGhotelName.Location = new System.Drawing.Point(101, 164);
            this.ConGhotelName.Name = "ConGhotelName";
            this.ConGhotelName.Size = new System.Drawing.Size(168, 27);
            this.ConGhotelName.TabIndex = 5;
            this.ConGhotelName.Text = " Hotel Name =>";
            this.ConGhotelName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ConGhotelName.Click += new System.EventHandler(this.label1_Click);
            // 
            // ConGHotelnameTxt
            // 
            this.ConGHotelnameTxt.AutoSize = true;
            this.ConGHotelnameTxt.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConGHotelnameTxt.Location = new System.Drawing.Point(328, 164);
            this.ConGHotelnameTxt.Name = "ConGHotelnameTxt";
            this.ConGHotelnameTxt.Size = new System.Drawing.Size(152, 27);
            this.ConGHotelnameTxt.TabIndex = 6;
            this.ConGHotelnameTxt.Text = "............................";
            // 
            // Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ConGHotelnameTxt);
            this.Controls.Add(this.ConGhotelName);
            this.Controls.Add(this.ConGphnTxt);
            this.Controls.Add(this.ConGphn);
            this.Name = "Display";
            this.Text = "Display";
            this.Load += new System.EventHandler(this.Display_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ConGphnTxt;
        private System.Windows.Forms.Label ConGphn;
        private System.Windows.Forms.Label ConGhotelName;
        private System.Windows.Forms.Label ConGHotelnameTxt;
    }
}