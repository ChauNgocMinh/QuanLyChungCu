namespace QuanLyChungCu.QL_CongViec
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Tab_DanhSach = new System.Windows.Forms.TabPage();
            this.txtTenCV = new System.Windows.Forms.TextBox();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.dtgvCongViec = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.MaCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tab_DanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCongViec)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tab_DanhSach
            // 
            this.Tab_DanhSach.Controls.Add(this.txtTenCV);
            this.Tab_DanhSach.Controls.Add(this.btnTim);
            this.Tab_DanhSach.Controls.Add(this.btnThem);
            this.Tab_DanhSach.Controls.Add(this.btnXoa);
            this.Tab_DanhSach.Controls.Add(this.dtgvCongViec);
            this.Tab_DanhSach.Location = new System.Drawing.Point(4, 25);
            this.Tab_DanhSach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tab_DanhSach.Name = "Tab_DanhSach";
            this.Tab_DanhSach.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Tab_DanhSach.Size = new System.Drawing.Size(1509, 621);
            this.Tab_DanhSach.TabIndex = 0;
            this.Tab_DanhSach.Text = "Danh sách công việc";
            this.Tab_DanhSach.UseVisualStyleBackColor = true;
            this.Tab_DanhSach.Click += new System.EventHandler(this.Tab_DanhSach_Click);
            // 
            // txtTenCV
            // 
            this.txtTenCV.Location = new System.Drawing.Point(1283, 16);
            this.txtTenCV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenCV.Name = "txtTenCV";
            this.txtTenCV.Size = new System.Drawing.Size(221, 22);
            this.txtTenCV.TabIndex = 4;
            // 
            // btnTim
            // 
            this.btnTim.ForeColor = System.Drawing.Color.Black;
            this.btnTim.Location = new System.Drawing.Point(1115, 11);
            this.btnTim.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(124, 32);
            this.btnTim.TabIndex = 3;
            this.btnTim.Text = "Tìm kiếm";
            this.btnTim.UseVisualStyleBackColor = true;
            this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
            // 
            // btnThem
            // 
            this.btnThem.ForeColor = System.Drawing.Color.Black;
            this.btnThem.Location = new System.Drawing.Point(967, 11);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(124, 32);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // dtgvCongViec
            // 
            this.dtgvCongViec.AllowUserToResizeColumns = false;
            this.dtgvCongViec.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dtgvCongViec.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgvCongViec.BackgroundColor = System.Drawing.Color.White;
            this.dtgvCongViec.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgvCongViec.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgvCongViec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCongViec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCV,
            this.TenCV,
            this.NoiDung,
            this.NgayBD,
            this.NgayKT});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgvCongViec.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgvCongViec.GridColor = System.Drawing.Color.Black;
            this.dtgvCongViec.Location = new System.Drawing.Point(5, 54);
            this.dtgvCongViec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtgvCongViec.Name = "dtgvCongViec";
            this.dtgvCongViec.RowHeadersVisible = false;
            this.dtgvCongViec.RowHeadersWidth = 51;
            this.dtgvCongViec.RowTemplate.Height = 24;
            this.dtgvCongViec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvCongViec.Size = new System.Drawing.Size(1497, 561);
            this.dtgvCongViec.TabIndex = 0;
            this.dtgvCongViec.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvCongViec_CellDoubleClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Tab_DanhSach);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1517, 650);
            this.tabControl1.TabIndex = 0;
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
            this.NgayKT.HeaderText = "Ngày kết thúc";
            this.NgayKT.MinimumWidth = 6;
            this.NgayKT.Name = "NgayKT";
            this.NgayKT.Width = 125;
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
            this.Tab_DanhSach.ResumeLayout(false);
            this.Tab_DanhSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCongViec)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage Tab_DanhSach;
        private System.Windows.Forms.TextBox txtTenCV;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridView dtgvCongViec;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaCV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenCV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoiDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayBD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKT;
    }
}