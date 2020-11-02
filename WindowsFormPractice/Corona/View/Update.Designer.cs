namespace Corona.View
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
            this.btnUp = new System.Windows.Forms.Button();
            this.UptempLblTxt = new System.Windows.Forms.TextBox();
            this.UptempLbl = new System.Windows.Forms.Label();
            this.UphtlLblDrop = new System.Windows.Forms.ComboBox();
            this.UphtlLbl = new System.Windows.Forms.Label();
            this.UptblLblTxt = new System.Windows.Forms.TextBox();
            this.UptblLbl = new System.Windows.Forms.Label();
            this.UpsymLblChk = new System.Windows.Forms.CheckedListBox();
            this.UpsymLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(596, 496);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(107, 41);
            this.btnUp.TabIndex = 15;
            this.btnUp.Text = "Update";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // UptempLblTxt
            // 
            this.UptempLblTxt.Location = new System.Drawing.Point(338, 115);
            this.UptempLblTxt.Name = "UptempLblTxt";
            this.UptempLblTxt.Size = new System.Drawing.Size(274, 22);
            this.UptempLblTxt.TabIndex = 14;
            // 
            // UptempLbl
            // 
            this.UptempLbl.AutoSize = true;
            this.UptempLbl.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UptempLbl.Location = new System.Drawing.Point(152, 110);
            this.UptempLbl.Name = "UptempLbl";
            this.UptempLbl.Size = new System.Drawing.Size(145, 27);
            this.UptempLbl.TabIndex = 13;
            this.UptempLbl.Text = "Temperature :";
            // 
            // UphtlLblDrop
            // 
            this.UphtlLblDrop.FormattingEnabled = true;
            this.UphtlLblDrop.Location = new System.Drawing.Point(352, 218);
            this.UphtlLblDrop.Name = "UphtlLblDrop";
            this.UphtlLblDrop.Size = new System.Drawing.Size(274, 24);
            this.UphtlLblDrop.TabIndex = 17;
            // 
            // UphtlLbl
            // 
            this.UphtlLbl.AutoSize = true;
            this.UphtlLbl.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UphtlLbl.Location = new System.Drawing.Point(152, 217);
            this.UphtlLbl.Name = "UphtlLbl";
            this.UphtlLbl.Size = new System.Drawing.Size(133, 27);
            this.UphtlLbl.TabIndex = 16;
            this.UphtlLbl.Text = "Hotel name :";
            // 
            // UptblLblTxt
            // 
            this.UptblLblTxt.Location = new System.Drawing.Point(352, 168);
            this.UptblLblTxt.Name = "UptblLblTxt";
            this.UptblLblTxt.Size = new System.Drawing.Size(274, 22);
            this.UptblLblTxt.TabIndex = 19;
            // 
            // UptblLbl
            // 
            this.UptblLbl.AutoSize = true;
            this.UptblLbl.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UptblLbl.Location = new System.Drawing.Point(152, 163);
            this.UptblLbl.Name = "UptblLbl";
            this.UptblLbl.Size = new System.Drawing.Size(183, 27);
            this.UptblLbl.TabIndex = 18;
            this.UptblLbl.Text = "Reservation num :";
            // 
            // UpsymLblChk
            // 
            this.UpsymLblChk.FormattingEnabled = true;
            this.UpsymLblChk.Location = new System.Drawing.Point(338, 288);
            this.UpsymLblChk.Name = "UpsymLblChk";
            this.UpsymLblChk.Size = new System.Drawing.Size(274, 123);
            this.UpsymLblChk.TabIndex = 21;
            this.UpsymLblChk.SelectedIndexChanged += new System.EventHandler(this.UpsymLblChk_SelectedIndexChanged);
            // 
            // UpsymLbl
            // 
            this.UpsymLbl.AutoSize = true;
            this.UpsymLbl.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpsymLbl.Location = new System.Drawing.Point(152, 290);
            this.UpsymLbl.Name = "UpsymLbl";
            this.UpsymLbl.Size = new System.Drawing.Size(113, 27);
            this.UpsymLbl.TabIndex = 20;
            this.UpsymLbl.Text = "Symtoms :";
            this.UpsymLbl.Click += new System.EventHandler(this.symLbl_Click);
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 612);
            this.Controls.Add(this.UpsymLblChk);
            this.Controls.Add(this.UpsymLbl);
            this.Controls.Add(this.UptblLblTxt);
            this.Controls.Add(this.UptblLbl);
            this.Controls.Add(this.UphtlLblDrop);
            this.Controls.Add(this.UphtlLbl);
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

        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.TextBox UptempLblTxt;
        private System.Windows.Forms.Label UptempLbl;
        private System.Windows.Forms.ComboBox UphtlLblDrop;
        private System.Windows.Forms.Label UphtlLbl;
        private System.Windows.Forms.TextBox UptblLblTxt;
        private System.Windows.Forms.Label UptblLbl;
        private System.Windows.Forms.CheckedListBox UpsymLblChk;
        private System.Windows.Forms.Label UpsymLbl;
    }
}