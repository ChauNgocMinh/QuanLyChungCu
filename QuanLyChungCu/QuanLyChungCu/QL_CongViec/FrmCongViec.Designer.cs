﻿namespace QuanLyChungCu.QL_CongViec
{
    partial class FrmCongViec
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Tab_DanhSach = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dtgvCongViec = new System.Windows.Forms.DataGridView();
            this.MaCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tab_CongViec = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.Tab_DanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCongViec)).BeginInit();
            this.Tab_CongViec.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Tab_DanhSach);
            this.tabControl1.Controls.Add(this.Tab_CongViec);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1517, 650);
            this.tabControl1.TabIndex = 0;
            // 
            // Tab_DanhSach
            // 
            this.Tab_DanhSach.Controls.Add(this.textBox1);
            this.Tab_DanhSach.Controls.Add(this.btnTim);
            this.Tab_DanhSach.Controls.Add(this.btnThem);
            this.Tab_DanhSach.Controls.Add(this.btnXoa);
            this.Tab_DanhSach.Controls.Add(this.dtgvCongViec);
            this.Tab_DanhSach.Location = new System.Drawing.Point(4, 25);
            this.Tab_DanhSach.Name = "Tab_DanhSach";
            this.Tab_DanhSach.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_DanhSach.Size = new System.Drawing.Size(1509, 621);
            this.Tab_DanhSach.TabIndex = 0;
            this.Tab_DanhSach.Text = "Danh sách công việc";
            this.Tab_DanhSach.UseVisualStyleBackColor = true;
            this.Tab_DanhSach.Click += new System.EventHandler(this.Tab_DanhSach_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1282, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(221, 22);
            this.textBox1.TabIndex = 4;
            // 
            // btnTim
            // 
            this.btnTim.ForeColor = System.Drawing.Color.Black;
            this.btnTim.Location = new System.Drawing.Point(1114, 11);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(124, 32);
            this.btnTim.TabIndex = 3;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.Location = new System.Drawing.Point(967, 11);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(124, 32);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.ForeColor = System.Drawing.Color.Black;
            this.btnXoa.Location = new System.Drawing.Point(815, 11);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(124, 32);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // dtgvCongViec
            // 
            this.dtgvCongViec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCongViec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCV,
            this.TenCV,
            this.NoiDung,
            this.NgayBD,
            this.NgayKT});
            this.dtgvCongViec.Location = new System.Drawing.Point(6, 54);
            this.dtgvCongViec.Name = "dtgvCongViec";
            this.dtgvCongViec.RowHeadersWidth = 51;
            this.dtgvCongViec.RowTemplate.Height = 24;
            this.dtgvCongViec.Size = new System.Drawing.Size(1497, 561);
            this.dtgvCongViec.TabIndex = 0;
            // 
            // MaCV
            // 
            this.MaCV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MaCV.HeaderText = "Mã công việc";
            this.MaCV.MinimumWidth = 6;
            this.MaCV.Name = "MaCV";
            // 
            // TenCV
            // 
            this.TenCV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenCV.HeaderText = "Tên công việc";
            this.TenCV.MinimumWidth = 6;
            this.TenCV.Name = "TenCV";
            // 
            // NoiDung
            // 
            this.NoiDung.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NoiDung.HeaderText = "Nội dung";
            this.NoiDung.MinimumWidth = 6;
            this.NoiDung.Name = "NoiDung";
            // 
            // NgayBD
            // 
            this.NgayBD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayBD.HeaderText = "Ngày bắt đầu";
            this.NgayBD.MinimumWidth = 6;
            this.NgayBD.Name = "NgayBD";
            // 
            // NgayKT
            // 
            this.NgayKT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NgayKT.HeaderText = "Ngày kết thúc";
            this.NgayKT.MinimumWidth = 6;
            this.NgayKT.Name = "NgayKT";
            // 
            // Tab_CongViec
            // 
            this.Tab_CongViec.Controls.Add(this.label1);
            this.Tab_CongViec.Location = new System.Drawing.Point(4, 25);
            this.Tab_CongViec.Name = "Tab_CongViec";
            this.Tab_CongViec.Padding = new System.Windows.Forms.Padding(3);
            this.Tab_CongViec.Size = new System.Drawing.Size(1509, 621);
            this.Tab_CongViec.TabIndex = 1;
            this.Tab_CongViec.Text = "CV001";
            this.Tab_CongViec.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thông tin công việc CV0001";
            // 
            // FrmCongViec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1541, 674);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmCongViec";
            this.tabControl1.ResumeLayout(false);
            this.Tab_DanhSach.ResumeLayout(false);
            this.Tab_DanhSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCongViec)).EndInit();
            this.Tab_CongViec.ResumeLayout(false);
            this.Tab_CongViec.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Tab_DanhSach;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dtgvCongViec;
        private System.Windows.Forms.TabPage Tab_CongViec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKT;
    }
}