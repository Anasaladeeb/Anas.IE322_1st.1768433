namespace IE322_1st
{
    partial class FrmCombo
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
            this.components = new System.ComponentModel.Container();
            this.BtnShowSM1 = new System.Windows.Forms.Button();
            this.BtnShowSM2 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CmbDays = new System.Windows.Forms.ComboBox();
            this.BtnRemoveByIndex = new System.Windows.Forms.Button();
            this.BtnRemoveByName = new System.Windows.Forms.Button();
            this.BtnRemoveLastItem = new System.Windows.Forms.Button();
            this.BtnRemove2ndLastItem = new System.Windows.Forms.Button();
            this.BtnBackCombo = new System.Windows.Forms.Button();
            this.LblDays = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnShowSM1
            // 
            this.BtnShowSM1.Location = new System.Drawing.Point(12, 12);
            this.BtnShowSM1.Name = "BtnShowSM1";
            this.BtnShowSM1.Size = new System.Drawing.Size(132, 70);
            this.BtnShowSM1.TabIndex = 0;
            this.BtnShowSM1.Text = "Show Selected Method 1";
            this.BtnShowSM1.UseVisualStyleBackColor = true;
            this.BtnShowSM1.Click += new System.EventHandler(this.BtnShowSM1_Click);
            // 
            // BtnShowSM2
            // 
            this.BtnShowSM2.Location = new System.Drawing.Point(141, 12);
            this.BtnShowSM2.Name = "BtnShowSM2";
            this.BtnShowSM2.Size = new System.Drawing.Size(132, 70);
            this.BtnShowSM2.TabIndex = 1;
            this.BtnShowSM2.Text = "Show Selected Method 2";
            this.BtnShowSM2.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // CmbDays
            // 
            this.CmbDays.FormattingEnabled = true;
            this.CmbDays.Location = new System.Drawing.Point(76, 114);
            this.CmbDays.Name = "CmbDays";
            this.CmbDays.Size = new System.Drawing.Size(197, 24);
            this.CmbDays.TabIndex = 3;
            this.CmbDays.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // BtnRemoveByIndex
            // 
            this.BtnRemoveByIndex.Location = new System.Drawing.Point(12, 257);
            this.BtnRemoveByIndex.Name = "BtnRemoveByIndex";
            this.BtnRemoveByIndex.Size = new System.Drawing.Size(115, 69);
            this.BtnRemoveByIndex.TabIndex = 4;
            this.BtnRemoveByIndex.Text = "Remove By Index";
            this.BtnRemoveByIndex.UseVisualStyleBackColor = true;
            this.BtnRemoveByIndex.Click += new System.EventHandler(this.BtnRemoveByIndex_Click);
            // 
            // BtnRemoveByName
            // 
            this.BtnRemoveByName.Location = new System.Drawing.Point(158, 257);
            this.BtnRemoveByName.Name = "BtnRemoveByName";
            this.BtnRemoveByName.Size = new System.Drawing.Size(115, 69);
            this.BtnRemoveByName.TabIndex = 5;
            this.BtnRemoveByName.Text = "Remove By Name";
            this.BtnRemoveByName.UseVisualStyleBackColor = true;
            this.BtnRemoveByName.Click += new System.EventHandler(this.BtnRemoveByName_Click);
            // 
            // BtnRemoveLastItem
            // 
            this.BtnRemoveLastItem.Location = new System.Drawing.Point(384, 69);
            this.BtnRemoveLastItem.Name = "BtnRemoveLastItem";
            this.BtnRemoveLastItem.Size = new System.Drawing.Size(115, 69);
            this.BtnRemoveLastItem.TabIndex = 6;
            this.BtnRemoveLastItem.Text = "Remove Last Item";
            this.BtnRemoveLastItem.UseVisualStyleBackColor = true;
            this.BtnRemoveLastItem.Click += new System.EventHandler(this.BtnRemoveLastItem_Click);
            // 
            // BtnRemove2ndLastItem
            // 
            this.BtnRemove2ndLastItem.Location = new System.Drawing.Point(384, 144);
            this.BtnRemove2ndLastItem.Name = "BtnRemove2ndLastItem";
            this.BtnRemove2ndLastItem.Size = new System.Drawing.Size(115, 69);
            this.BtnRemove2ndLastItem.TabIndex = 7;
            this.BtnRemove2ndLastItem.Text = "Remove 2nd Last Item";
            this.BtnRemove2ndLastItem.UseVisualStyleBackColor = true;
            this.BtnRemove2ndLastItem.Click += new System.EventHandler(this.BtnRemove2ndLastItem_Click);
            // 
            // BtnBackCombo
            // 
            this.BtnBackCombo.Location = new System.Drawing.Point(399, 384);
            this.BtnBackCombo.Name = "BtnBackCombo";
            this.BtnBackCombo.Size = new System.Drawing.Size(100, 31);
            this.BtnBackCombo.TabIndex = 8;
            this.BtnBackCombo.Text = "Back";
            this.BtnBackCombo.UseVisualStyleBackColor = true;
            this.BtnBackCombo.Click += new System.EventHandler(this.BtnBackCombo_Click);
            // 
            // LblDays
            // 
            this.LblDays.AutoSize = true;
            this.LblDays.Location = new System.Drawing.Point(22, 117);
            this.LblDays.Name = "LblDays";
            this.LblDays.Size = new System.Drawing.Size(39, 17);
            this.LblDays.TabIndex = 9;
            this.LblDays.Text = "Days";
            // 
            // FrmCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 421);
            this.Controls.Add(this.LblDays);
            this.Controls.Add(this.BtnBackCombo);
            this.Controls.Add(this.BtnRemove2ndLastItem);
            this.Controls.Add(this.BtnRemoveLastItem);
            this.Controls.Add(this.BtnRemoveByName);
            this.Controls.Add(this.BtnRemoveByIndex);
            this.Controls.Add(this.CmbDays);
            this.Controls.Add(this.BtnShowSM2);
            this.Controls.Add(this.BtnShowSM1);
            this.Name = "FrmCombo";
            this.Text = "Combo";
            this.Load += new System.EventHandler(this.FrmCombo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnShowSM1;
        private System.Windows.Forms.Button BtnShowSM2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox CmbDays;
        private System.Windows.Forms.Button BtnRemoveByIndex;
        private System.Windows.Forms.Button BtnRemoveByName;
        private System.Windows.Forms.Button BtnRemoveLastItem;
        private System.Windows.Forms.Button BtnRemove2ndLastItem;
        private System.Windows.Forms.Button BtnBackCombo;
        private System.Windows.Forms.Label LblDays;
    }
}