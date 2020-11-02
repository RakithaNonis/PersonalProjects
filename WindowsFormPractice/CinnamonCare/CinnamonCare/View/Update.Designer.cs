namespace CinnamonCare.View
{
    partial class Update
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
            this.UptempLblTxt = new System.Windows.Forms.TextBox();
            this.UptempLbl = new System.Windows.Forms.Label();
            this.btnUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UptempLblTxt
            // 
            this.UptempLblTxt.Location = new System.Drawing.Point(317, 122);
            this.UptempLblTxt.Name = "UptempLblTxt";
            this.UptempLblTxt.Size = new System.Drawing.Size(274, 22);
            this.UptempLblTxt.TabIndex = 11;
            // 
            // UptempLbl
            // 
            this.UptempLbl.AutoSize = true;
            this.UptempLbl.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UptempLbl.Location = new System.Drawing.Point(131, 117);
            this.UptempLbl.Name = "UptempLbl";
            this.UptempLbl.Size = new System.Drawing.Size(145, 27);
            this.UptempLbl.TabIndex = 10;
            this.UptempLbl.Text = "Temperature :";
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(520, 307);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(107, 41);
            this.btnUp.TabIndex = 12;
            this.btnUp.Text = "Update";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.UptempLblTxt);
            this.Controls.Add(this.UptempLbl);
            this.Name = "Update";
            this.Text = "Update";
            this.Load += new System.EventHandler(this.Update_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UptempLblTxt;
        private System.Windows.Forms.Label UptempLbl;
        private System.Windows.Forms.Button btnUp;
    }
}