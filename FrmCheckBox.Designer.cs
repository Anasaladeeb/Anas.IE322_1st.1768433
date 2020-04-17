namespace IE322_1st
{
    partial class FrmCheckBox
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
            this.BtnShow.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BtnShow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnShow.Font = new System.Drawing.Font("Viner Hand ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnShow.Location = new System.Drawing.Point(12, 8);
            this.BtnShow.Name = "BtnShow";
            this.BtnShow.Size = new System.Drawing.Size(286, 44);
            this.BtnShow.TabIndex = 0;
            this.BtnShow.Text = "Show";
            this.BtnShow.UseVisualStyleBackColor = false;
            this.BtnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // checkBoxCoffee
            // 
            this.checkBoxCoffee.AutoSize = true;
            this.checkBoxCoffee.Location = new System.Drawing.Point(107, 33);
            this.checkBoxCoffee.Name = "checkBoxCoffee";
            this.checkBoxCoffee.Size = new System.Drawing.Size(79, 28);
            this.checkBoxCoffee.TabIndex = 1;
            this.checkBoxCoffee.Text = "Coffee";
            this.checkBoxCoffee.UseVisualStyleBackColor = true;
            // 
            // CheckBoxDonut
            // 
            this.CheckBoxDonut.AutoSize = true;
            this.CheckBoxDonut.Location = new System.Drawing.Point(107, 60);
            this.CheckBoxDonut.Name = "CheckBoxDonut";
            this.CheckBoxDonut.Size = new System.Drawing.Size(81, 28);
            this.CheckBoxDonut.TabIndex = 2;
            this.CheckBoxDonut.Text = "Donut";
            this.CheckBoxDonut.UseVisualStyleBackColor = true;
            // 
            // checkBoxBrownie
            // 
            this.checkBoxBrownie.AutoSize = true;
            this.checkBoxBrownie.Location = new System.Drawing.Point(107, 87);
            this.checkBoxBrownie.Name = "checkBoxBrownie";
            this.checkBoxBrownie.Size = new System.Drawing.Size(95, 28);
            this.checkBoxBrownie.TabIndex = 3;
            this.checkBoxBrownie.Text = "Brownie";
            this.checkBoxBrownie.UseVisualStyleBackColor = true;
            // 
            // BtnBackCheckBox
            // 
            this.BtnBackCheckBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.BtnBackCheckBox.Font = new System.Drawing.Font("Viner Hand ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBackCheckBox.Location = new System.Drawing.Point(12, 288);
            this.BtnBackCheckBox.Name = "BtnBackCheckBox";
            this.BtnBackCheckBox.Size = new System.Drawing.Size(286, 27);
            this.BtnBackCheckBox.TabIndex = 4;
            this.BtnBackCheckBox.Text = "Back";
            this.BtnBackCheckBox.UseVisualStyleBackColor = false;
            this.BtnBackCheckBox.Click += new System.EventHandler(this.BtnBackCheckBox_Click);
            // 
            // groupBoxChk
            // 
            this.groupBoxChk.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBoxChk.Controls.Add(this.checkBoxBrownie);
            this.groupBoxChk.Controls.Add(this.CheckBoxDonut);
            this.groupBoxChk.Controls.Add(this.checkBoxCoffee);
            this.groupBoxChk.Font = new System.Drawing.Font("Viner Hand ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxChk.Location = new System.Drawing.Point(12, 68);
            this.groupBoxChk.Name = "groupBoxChk";
            this.groupBoxChk.Size = new System.Drawing.Size(286, 167);
            this.groupBoxChk.TabIndex = 5;
            this.groupBoxChk.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
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