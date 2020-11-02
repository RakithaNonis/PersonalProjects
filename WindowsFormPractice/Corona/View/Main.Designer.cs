namespace Corona.View
{
    partial class Main
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
            this.phnLblTxt = new System.Windows.Forms.TextBox();
            this.phnLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(545, 273);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(107, 41);
            this.btnOk.TabIndex = 13;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // phnLblTxt
            // 
            this.phnLblTxt.Location = new System.Drawing.Point(348, 141);
            this.phnLblTxt.Name = "phnLblTxt";
            this.phnLblTxt.Size = new System.Drawing.Size(274, 22);
            this.phnLblTxt.TabIndex = 12;
            // 
            // phnLbl
            // 
            this.phnLbl.AutoSize = true;
            this.phnLbl.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phnLbl.Location = new System.Drawing.Point(148, 137);
            this.phnLbl.Name = "phnLbl";
            this.phnLbl.Size = new System.Drawing.Size(164, 27);
            this.phnLbl.TabIndex = 11;
            this.phnLbl.Text = "Phone number :";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.phnLblTxt);
            this.Controls.Add(this.phnLbl);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox phnLblTxt;
        private System.Windows.Forms.Label phnLbl;
    }
}