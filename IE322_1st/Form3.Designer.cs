namespace IE322_1st
{
    partial class Form3
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
            this.BtnShow = new System.Windows.Forms.Button();
            this.checkBoxCoffee = new System.Windows.Forms.CheckBox();
            this.CheckBoxDonut = new System.Windows.Forms.CheckBox();
            this.checkBoxBrownie = new System.Windows.Forms.CheckBox();
            this.BtnBackCheckBox = new System.Windows.Forms.Button();
            this.groupBoxChk = new System.Windows.Forms.GroupBox();
            this.groupBoxChk.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnShow
            // 
            this.BtnShow.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BtnShow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnShow.Location = new System.Drawing.Point(12, 12);
            this.BtnShow.Name = "BtnShow";
            this.BtnShow.Size = new System.Drawing.Size(75, 23);
            this.BtnShow.TabIndex = 0;
            this.BtnShow.Text = "Show";
            this.BtnShow.UseVisualStyleBackColor = false;
            this.BtnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // checkBoxCoffee
            // 
            this.checkBoxCoffee.AutoSize = true;
            this.checkBoxCoffee.Location = new System.Drawing.Point(27, 36);
            this.checkBoxCoffee.Name = "checkBoxCoffee";
            this.checkBoxCoffee.Size = new System.Drawing.Size(69, 21);
            this.checkBoxCoffee.TabIndex = 1;
            this.checkBoxCoffee.Text = "Coffee";
            this.checkBoxCoffee.UseVisualStyleBackColor = true;
            // 
            // CheckBoxDonut
            // 
            this.CheckBoxDonut.AutoSize = true;
            this.CheckBoxDonut.Location = new System.Drawing.Point(27, 73);
            this.CheckBoxDonut.Name = "CheckBoxDonut";
            this.CheckBoxDonut.Size = new System.Drawing.Size(69, 21);
            this.CheckBoxDonut.TabIndex = 2;
            this.CheckBoxDonut.Text = "Donut";
            this.CheckBoxDonut.UseVisualStyleBackColor = true;
            // 
            // checkBoxBrownie
            // 
            this.checkBoxBrownie.AutoSize = true;
            this.checkBoxBrownie.Location = new System.Drawing.Point(27, 110);
            this.checkBoxBrownie.Name = "checkBoxBrownie";
            this.checkBoxBrownie.Size = new System.Drawing.Size(78, 21);
            this.checkBoxBrownie.TabIndex = 3;
            this.checkBoxBrownie.Text = "Brownie";
            this.checkBoxBrownie.UseVisualStyleBackColor = true;
            // 
            // BtnBackCheckBox
            // 
            this.BtnBackCheckBox.Location = new System.Drawing.Point(223, 292);
            this.BtnBackCheckBox.Name = "BtnBackCheckBox";
            this.BtnBackCheckBox.Size = new System.Drawing.Size(75, 23);
            this.BtnBackCheckBox.TabIndex = 4;
            this.BtnBackCheckBox.Text = "Back";
            this.BtnBackCheckBox.UseVisualStyleBackColor = true;
            this.BtnBackCheckBox.Click += new System.EventHandler(this.BtnBackCheckBox_Click);
            // 
            // groupBoxChk
            // 
            this.groupBoxChk.Controls.Add(this.checkBoxBrownie);
            this.groupBoxChk.Controls.Add(this.CheckBoxDonut);
            this.groupBoxChk.Controls.Add(this.checkBoxCoffee);
            this.groupBoxChk.Location = new System.Drawing.Point(12, 72);
            this.groupBoxChk.Name = "groupBoxChk";
            this.groupBoxChk.Size = new System.Drawing.Size(200, 152);
            this.groupBoxChk.TabIndex = 5;
            this.groupBoxChk.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 327);
            this.Controls.Add(this.groupBoxChk);
            this.Controls.Add(this.BtnBackCheckBox);
            this.Controls.Add(this.BtnShow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form3";
            this.Text = "CheckBox Form";
            this.groupBoxChk.ResumeLayout(false);
            this.groupBoxChk.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnShow;
        private System.Windows.Forms.CheckBox checkBoxCoffee;
        private System.Windows.Forms.CheckBox CheckBoxDonut;
        private System.Windows.Forms.CheckBox checkBoxBrownie;
        private System.Windows.Forms.Button BtnBackCheckBox;
        private System.Windows.Forms.GroupBox groupBoxChk;
    }
}