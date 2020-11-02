namespace DateTimePicker
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
            this.Calender = new System.Windows.Forms.DateTimePicker();
            this.LblDate = new System.Windows.Forms.Label();
            this.LblDateShort = new System.Windows.Forms.Label();
            this.LblDateLong = new System.Windows.Forms.Label();
            this.LblTimeShort = new System.Windows.Forms.Label();
            this.LblTimeLong = new System.Windows.Forms.Label();
            this.Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Calender
            // 
            this.Calender.Location = new System.Drawing.Point(227, 60);
            this.Calender.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Calender.Name = "Calender";
            this.Calender.Size = new System.Drawing.Size(362, 33);
            this.Calender.TabIndex = 0;
            this.Calender.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDate.Location = new System.Drawing.Point(157, 155);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(67, 25);
            this.LblDate.TabIndex = 1;
            this.LblDate.Text = "label1";
            this.LblDate.Click += new System.EventHandler(this.LblDate_Click);
            // 
            // LblDateShort
            // 
            this.LblDateShort.AutoSize = true;
            this.LblDateShort.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDateShort.Location = new System.Drawing.Point(157, 205);
            this.LblDateShort.Name = "LblDateShort";
            this.LblDateShort.Size = new System.Drawing.Size(67, 25);
            this.LblDateShort.TabIndex = 2;
            this.LblDateShort.Text = "label1";
            this.LblDateShort.Click += new System.EventHandler(this.label1_Click);
            // 
            // LblDateLong
            // 
            this.LblDateLong.AutoSize = true;
            this.LblDateLong.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDateLong.Location = new System.Drawing.Point(157, 255);
            this.LblDateLong.Name = "LblDateLong";
            this.LblDateLong.Size = new System.Drawing.Size(67, 25);
            this.LblDateLong.TabIndex = 3;
            this.LblDateLong.Text = "label1";
            // 
            // LblTimeShort
            // 
            this.LblTimeShort.AutoSize = true;
            this.LblTimeShort.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTimeShort.Location = new System.Drawing.Point(157, 301);
            this.LblTimeShort.Name = "LblTimeShort";
            this.LblTimeShort.Size = new System.Drawing.Size(67, 25);
            this.LblTimeShort.TabIndex = 4;
            this.LblTimeShort.Text = "label1";
            // 
            // LblTimeLong
            // 
            this.LblTimeLong.AutoSize = true;
            this.LblTimeLong.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTimeLong.Location = new System.Drawing.Point(157, 349);
            this.LblTimeLong.Name = "LblTimeLong";
            this.LblTimeLong.Size = new System.Drawing.Size(67, 25);
            this.LblTimeLong.TabIndex = 5;
            this.LblTimeLong.Text = "label1";
            // 
            // Btn
            // 
            this.Btn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn.Location = new System.Drawing.Point(633, 440);
            this.Btn.Name = "Btn";
            this.Btn.Size = new System.Drawing.Size(90, 37);
            this.Btn.TabIndex = 6;
            this.Btn.Text = "Show";
            this.Btn.UseVisualStyleBackColor = true;
            this.Btn.Click += new System.EventHandler(this.Btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 517);
            this.Controls.Add(this.Btn);
            this.Controls.Add(this.LblTimeLong);
            this.Controls.Add(this.LblTimeShort);
            this.Controls.Add(this.LblDateLong);
            this.Controls.Add(this.LblDateShort);
            this.Controls.Add(this.LblDate);
            this.Controls.Add(this.Calender);
            this.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker Calender;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.Label LblDateShort;
        private System.Windows.Forms.Label LblDateLong;
        private System.Windows.Forms.Label LblTimeShort;
        private System.Windows.Forms.Label LblTimeLong;
        private System.Windows.Forms.Button Btn;
    }
}

