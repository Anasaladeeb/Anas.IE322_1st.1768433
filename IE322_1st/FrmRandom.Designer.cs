namespace IE322_1st
{
    partial class FrmRandom
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
            this.BtnGenerate = new System.Windows.Forms.Button();
            this.BtnBackRandom = new System.Windows.Forms.Button();
            this.LblRgb = new System.Windows.Forms.Label();
            this.BtnRandomNum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnGenerate
            // 
            this.BtnGenerate.Location = new System.Drawing.Point(12, 12);
            this.BtnGenerate.Name = "BtnGenerate";
            this.BtnGenerate.Size = new System.Drawing.Size(419, 68);
            this.BtnGenerate.TabIndex = 0;
            this.BtnGenerate.Text = "Generate Random Color";
            this.BtnGenerate.UseVisualStyleBackColor = true;
            this.BtnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // BtnBackRandom
            // 
            this.BtnBackRandom.Location = new System.Drawing.Point(353, 279);
            this.BtnBackRandom.Name = "BtnBackRandom";
            this.BtnBackRandom.Size = new System.Drawing.Size(78, 27);
            this.BtnBackRandom.TabIndex = 1;
            this.BtnBackRandom.Text = "Back";
            this.BtnBackRandom.UseVisualStyleBackColor = true;
            this.BtnBackRandom.Click += new System.EventHandler(this.BtnBackRandom_Click);
            // 
            // LblRgb
            // 
            this.LblRgb.AutoSize = true;
            this.LblRgb.Location = new System.Drawing.Point(196, 103);
            this.LblRgb.Name = "LblRgb";
            this.LblRgb.Size = new System.Drawing.Size(39, 17);
            this.LblRgb.TabIndex = 2;
            this.LblRgb.Text = "r-g-b";
            this.LblRgb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblRgb.Click += new System.EventHandler(this.LblRgb_Click);
            // 
            // BtnRandomNum
            // 
            this.BtnRandomNum.Location = new System.Drawing.Point(12, 189);
            this.BtnRandomNum.Name = "BtnRandomNum";
            this.BtnRandomNum.Size = new System.Drawing.Size(166, 35);
            this.BtnRandomNum.TabIndex = 3;
            this.BtnRandomNum.Text = "Random Number";
            this.BtnRandomNum.UseVisualStyleBackColor = true;
            this.BtnRandomNum.Click += new System.EventHandler(this.BtnRandomNum_Click);
            // 
            // FrmRandom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 318);
            this.Controls.Add(this.BtnRandomNum);
            this.Controls.Add(this.LblRgb);
            this.Controls.Add(this.BtnBackRandom);
            this.Controls.Add(this.BtnGenerate);
            this.Name = "FrmRandom";
            this.Text = "Random";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGenerate;
        private System.Windows.Forms.Button BtnBackRandom;
        private System.Windows.Forms.Label LblRgb;
        private System.Windows.Forms.Button BtnRandomNum;
    }
}