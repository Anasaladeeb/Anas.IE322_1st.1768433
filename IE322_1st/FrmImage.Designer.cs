namespace IE322_1st
{
    partial class FrmImage
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
            this.TryImage = new System.Windows.Forms.PictureBox();
            this.BtnLoadImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TryImage)).BeginInit();
            this.SuspendLayout();
            // 
            // TryImage
            // 
            this.TryImage.Location = new System.Drawing.Point(96, 70);
            this.TryImage.Name = "TryImage";
            this.TryImage.Size = new System.Drawing.Size(179, 168);
            this.TryImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TryImage.TabIndex = 0;
            this.TryImage.TabStop = false;
            this.TryImage.Click += new System.EventHandler(this.TryImage_Click);
            // 
            // BtnLoadImage
            // 
            this.BtnLoadImage.Location = new System.Drawing.Point(133, 12);
            this.BtnLoadImage.Name = "BtnLoadImage";
            this.BtnLoadImage.Size = new System.Drawing.Size(84, 52);
            this.BtnLoadImage.TabIndex = 1;
            this.BtnLoadImage.Text = "Load Image";
            this.BtnLoadImage.UseVisualStyleBackColor = true;
            this.BtnLoadImage.Click += new System.EventHandler(this.BtnLoadImage_Click);
            // 
            // FrmImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 281);
            this.Controls.Add(this.BtnLoadImage);
            this.Controls.Add(this.TryImage);
            this.Name = "FrmImage";
            this.Text = "Image";
            ((System.ComponentModel.ISupportInitialize)(this.TryImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox TryImage;
        private System.Windows.Forms.Button BtnLoadImage;
    }
}