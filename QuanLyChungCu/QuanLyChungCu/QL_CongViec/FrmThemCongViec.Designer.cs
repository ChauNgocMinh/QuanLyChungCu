﻿namespace QuanLyChungCu.QL_CongViec
{
    partial class FrmThemCongViec
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenCv = new System.Windows.Forms.TextBox();
            this.dtNgayBd = new System.Windows.Forms.DateTimePicker();
            this.dtNgayKT = new System.Windows.Forms.DateTimePicker();
            this.txtNoiDung = new System.Windows.Forms.RichTextBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên công việc:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày bắt đầu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ngày kết thúc:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(417, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nội dung:";
            // 
            // txtTenCv
            // 
            this.txtTenCv.Location = new System.Drawing.Point(134, 16);
            this.txtTenCv.Name = "txtTenCv";
            this.txtTenCv.Size = new System.Drawing.Size(254, 22);
            this.txtTenCv.TabIndex = 6;
            // 
            // dtNgayBd
            // 
            this.dtNgayBd.Location = new System.Drawing.Point(138, 61);
            this.dtNgayBd.Name = "dtNgayBd";
            this.dtNgayBd.Size = new System.Drawing.Size(200, 22);
            this.dtNgayBd.TabIndex = 7;
            // 
            // dtNgayKT
            // 
            this.dtNgayKT.Location = new System.Drawing.Point(138, 105);
            this.dtNgayKT.Name = "dtNgayKT";
            this.dtNgayKT.Size = new System.Drawing.Size(200, 22);
            this.dtNgayKT.TabIndex = 8;
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(495, 16);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(257, 111);
            this.txtNoiDung.TabIndex = 9;
            this.txtNoiDung.Text = "";
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(608, 167);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(113, 37);
            this.btnHuy.TabIndex = 10;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(741, 167);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(113, 37);
            this.btnLuu.TabIndex = 11;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // FrmThemCongViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 216);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.txtNoiDung);
            this.Controls.Add(this.dtNgayKT);
            this.Controls.Add(this.dtNgayBd);
            this.Controls.Add(this.txtTenCv);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmThemCongViec";
            this.Text = "Thêm công việc mới";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenCv;
        private System.Windows.Forms.DateTimePicker dtNgayBd;
        private System.Windows.Forms.DateTimePicker dtNgayKT;
        private System.Windows.Forms.RichTextBox txtNoiDung;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
    }
}