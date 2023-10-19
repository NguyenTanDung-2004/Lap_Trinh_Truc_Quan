namespace Student_Management_Application
{
    partial class Tim_Sinh_Vien
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Xac_Nhan_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("MV Boli", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(414, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(702, 272);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm Sinh Viên trong trường";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "1. Theo Tên.",
            "2. Theo MSSV."});
            this.comboBox2.Location = new System.Drawing.Point(670, 396);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(275, 45);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.SelectedValueChanged += new System.EventHandler(this.comboBox2_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(367, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 104);
            this.label2.TabIndex = 3;
            this.label2.Text = "Chức Năng";
            // 
            // Xac_Nhan_Button
            // 
            this.Xac_Nhan_Button.BackColor = System.Drawing.Color.Cyan;
            this.Xac_Nhan_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Xac_Nhan_Button.Location = new System.Drawing.Point(607, 575);
            this.Xac_Nhan_Button.Name = "Xac_Nhan_Button";
            this.Xac_Nhan_Button.Size = new System.Drawing.Size(283, 73);
            this.Xac_Nhan_Button.TabIndex = 4;
            this.Xac_Nhan_Button.Text = "Xác Nhận";
            this.Xac_Nhan_Button.UseVisualStyleBackColor = false;
            this.Xac_Nhan_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Tim_Sinh_Vien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1579, 915);
            this.Controls.Add(this.Xac_Nhan_Button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label1);
            this.Name = "Tim_Sinh_Vien";
            this.Text = "Tim_Sinh_Vien";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Xac_Nhan_Button;
    }
}