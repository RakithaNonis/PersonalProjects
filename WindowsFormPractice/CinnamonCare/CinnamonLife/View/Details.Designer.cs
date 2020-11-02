namespace CinnamonLife.View
{
    partial class Details
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
            this.VehLbl = new System.Windows.Forms.Label();
            this.VehDrop = new System.Windows.Forms.ComboBox();
            this.BrdLbl = new System.Windows.Forms.Label();
            this.BrdTxt = new System.Windows.Forms.TextBox();
            this.OwLbl = new System.Windows.Forms.Label();
            this.OwTxt = new System.Windows.Forms.TextBox();
            this.PrLbl = new System.Windows.Forms.Label();
            this.PrTxt = new System.Windows.Forms.TextBox();
            this.DBtn = new System.Windows.Forms.Button();
            this.ReBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // VehLbl
            // 
            this.VehLbl.AutoSize = true;
            this.VehLbl.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VehLbl.Location = new System.Drawing.Point(34, 44);
            this.VehLbl.Name = "VehLbl";
            this.VehLbl.Size = new System.Drawing.Size(231, 27);
            this.VehLbl.TabIndex = 1;
            this.VehLbl.Text = "Enter The vehicle type :";
            // 
            // VehDrop
            // 
            this.VehDrop.FormattingEnabled = true;
            this.VehDrop.Location = new System.Drawing.Point(332, 45);
            this.VehDrop.Name = "VehDrop";
            this.VehDrop.Size = new System.Drawing.Size(174, 24);
            this.VehDrop.TabIndex = 2;
            // 
            // BrdLbl
            // 
            this.BrdLbl.AutoSize = true;
            this.BrdLbl.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BrdLbl.Location = new System.Drawing.Point(34, 118);
            this.BrdLbl.Name = "BrdLbl";
            this.BrdLbl.Size = new System.Drawing.Size(143, 27);
            this.BrdLbl.TabIndex = 3;
            this.BrdLbl.Text = "Brand Name :";
            // 
            // BrdTxt
            // 
            this.BrdTxt.Location = new System.Drawing.Point(332, 118);
            this.BrdTxt.Name = "BrdTxt";
            this.BrdTxt.Size = new System.Drawing.Size(282, 22);
            this.BrdTxt.TabIndex = 4;
            // 
            // OwLbl
            // 
            this.OwLbl.AutoSize = true;
            this.OwLbl.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OwLbl.Location = new System.Drawing.Point(34, 200);
            this.OwLbl.Name = "OwLbl";
            this.OwLbl.Size = new System.Drawing.Size(149, 27);
            this.OwLbl.TabIndex = 5;
            this.OwLbl.Text = "Owner Name :";
            // 
            // OwTxt
            // 
            this.OwTxt.Location = new System.Drawing.Point(332, 200);
            this.OwTxt.Name = "OwTxt";
            this.OwTxt.Size = new System.Drawing.Size(282, 22);
            this.OwTxt.TabIndex = 6;
            // 
            // PrLbl
            // 
            this.PrLbl.AutoSize = true;
            this.PrLbl.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrLbl.Location = new System.Drawing.Point(34, 280);
            this.PrLbl.Name = "PrLbl";
            this.PrLbl.Size = new System.Drawing.Size(69, 27);
            this.PrLbl.TabIndex = 7;
            this.PrLbl.Text = "Price :";
            // 
            // PrTxt
            // 
            this.PrTxt.Location = new System.Drawing.Point(332, 280);
            this.PrTxt.Name = "PrTxt";
            this.PrTxt.Size = new System.Drawing.Size(282, 22);
            this.PrTxt.TabIndex = 8;
            // 
            // DBtn
            // 
            this.DBtn.Location = new System.Drawing.Point(332, 427);
            this.DBtn.Name = "DBtn";
            this.DBtn.Size = new System.Drawing.Size(88, 39);
            this.DBtn.TabIndex = 9;
            this.DBtn.Text = "Next";
            this.DBtn.UseVisualStyleBackColor = true;
            this.DBtn.Click += new System.EventHandler(this.DBtn_Click);
            // 
            // ReBtn
            // 
            this.ReBtn.Location = new System.Drawing.Point(514, 427);
            this.ReBtn.Name = "ReBtn";
            this.ReBtn.Size = new System.Drawing.Size(88, 39);
            this.ReBtn.TabIndex = 10;
            this.ReBtn.Text = "Reset";
            this.ReBtn.UseVisualStyleBackColor = true;
            // 
            // Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 569);
            this.Controls.Add(this.ReBtn);
            this.Controls.Add(this.DBtn);
            this.Controls.Add(this.PrTxt);
            this.Controls.Add(this.PrLbl);
            this.Controls.Add(this.OwTxt);
            this.Controls.Add(this.OwLbl);
            this.Controls.Add(this.BrdTxt);
            this.Controls.Add(this.BrdLbl);
            this.Controls.Add(this.VehDrop);
            this.Controls.Add(this.VehLbl);
            this.Name = "Details";
            this.Text = "Details";
            this.Load += new System.EventHandler(this.Details_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label VehLbl;
        private System.Windows.Forms.ComboBox VehDrop;
        private System.Windows.Forms.Label BrdLbl;
        private System.Windows.Forms.TextBox BrdTxt;
        private System.Windows.Forms.Label OwLbl;
        private System.Windows.Forms.TextBox OwTxt;
        private System.Windows.Forms.Label PrLbl;
        private System.Windows.Forms.TextBox PrTxt;
        private System.Windows.Forms.Button DBtn;
        private System.Windows.Forms.Button ReBtn;
    }
}