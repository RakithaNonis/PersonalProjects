namespace WindowsForms
{
    partial class Form2
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
            this.LBLhello = new System.Windows.Forms.Label();
            this.BtnSet = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnLogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBLhello
            // 
            this.LBLhello.AutoSize = true;
            this.LBLhello.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLhello.Location = new System.Drawing.Point(242, 77);
            this.LBLhello.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBLhello.Name = "LBLhello";
            this.LBLhello.Size = new System.Drawing.Size(115, 38);
            this.LBLhello.TabIndex = 0;
            this.LBLhello.Text = "label1";
            this.LBLhello.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // BtnSet
            // 
            this.BtnSet.Location = new System.Drawing.Point(218, 541);
            this.BtnSet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnSet.Name = "BtnSet";
            this.BtnSet.Size = new System.Drawing.Size(114, 47);
            this.BtnSet.TabIndex = 1;
            this.BtnSet.Text = "Set ";
            this.BtnSet.UseVisualStyleBackColor = true;
            this.BtnSet.Click += new System.EventHandler(this.BtnSet_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(427, 541);
            this.BtnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(114, 47);
            this.BtnCancel.TabIndex = 2;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnLogOut
            // 
            this.BtnLogOut.Location = new System.Drawing.Point(1026, 541);
            this.BtnLogOut.Margin = new System.Windows.Forms.Padding(4);
            this.BtnLogOut.Name = "BtnLogOut";
            this.BtnLogOut.Size = new System.Drawing.Size(114, 47);
            this.BtnLogOut.TabIndex = 3;
            this.BtnLogOut.Text = "Logout";
            this.BtnLogOut.UseVisualStyleBackColor = true;
            this.BtnLogOut.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1624, 848);
            this.Controls.Add(this.BtnLogOut);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSet);
            this.Controls.Add(this.LBLhello);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLhello;
        private System.Windows.Forms.Button BtnSet;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnLogOut;
    }
}

