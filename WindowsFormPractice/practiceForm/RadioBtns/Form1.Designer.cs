namespace RadioBtns
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
            this.Radio1 = new System.Windows.Forms.RadioButton();
            this.Radio3 = new System.Windows.Forms.RadioButton();
            this.Radio2 = new System.Windows.Forms.RadioButton();
            this.BtnSub = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Radio1
            // 
            this.Radio1.AutoSize = true;
            this.Radio1.Location = new System.Drawing.Point(271, 84);
            this.Radio1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Radio1.Name = "Radio1";
            this.Radio1.Size = new System.Drawing.Size(160, 29);
            this.Radio1.TabIndex = 0;
            this.Radio1.TabStop = true;
            this.Radio1.Text = "Rakitha Nonis";
            this.Radio1.UseVisualStyleBackColor = true;
            // 
            // Radio3
            // 
            this.Radio3.AutoSize = true;
            this.Radio3.Location = new System.Drawing.Point(271, 210);
            this.Radio3.Margin = new System.Windows.Forms.Padding(4);
            this.Radio3.Name = "Radio3";
            this.Radio3.Size = new System.Drawing.Size(144, 29);
            this.Radio3.TabIndex = 1;
            this.Radio3.TabStop = true;
            this.Radio3.Text = "Scooby Doo";
            this.Radio3.UseVisualStyleBackColor = true;
            // 
            // Radio2
            // 
            this.Radio2.AutoSize = true;
            this.Radio2.Location = new System.Drawing.Point(271, 149);
            this.Radio2.Margin = new System.Windows.Forms.Padding(4);
            this.Radio2.Name = "Radio2";
            this.Radio2.Size = new System.Drawing.Size(145, 29);
            this.Radio2.TabIndex = 2;
            this.Radio2.TabStop = true;
            this.Radio2.Text = "Harry Potter";
            this.Radio2.UseVisualStyleBackColor = true;
            // 
            // BtnSub
            // 
            this.BtnSub.Location = new System.Drawing.Point(502, 374);
            this.BtnSub.Name = "BtnSub";
            this.BtnSub.Size = new System.Drawing.Size(104, 41);
            this.BtnSub.TabIndex = 3;
            this.BtnSub.Text = "Submit";
            this.BtnSub.UseVisualStyleBackColor = true;
            this.BtnSub.Click += new System.EventHandler(this.BtnSub_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 482);
            this.Controls.Add(this.BtnSub);
            this.Controls.Add(this.Radio2);
            this.Controls.Add(this.Radio3);
            this.Controls.Add(this.Radio1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Radio1;
        private System.Windows.Forms.RadioButton Radio3;
        private System.Windows.Forms.RadioButton Radio2;
        private System.Windows.Forms.Button BtnSub;
    }
}

