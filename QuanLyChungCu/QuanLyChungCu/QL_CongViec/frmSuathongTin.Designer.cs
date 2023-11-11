namespace QuanLyChungCu.QL_CongViec
{
    partial class frmSuathongTin
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
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.txtNoiDung = new System.Windows.Forms.RichTextBox();
            this.dtNgayKT = new System.Windows.Forms.DateTimePicker();
            this.dtNgayBd = new System.Windows.Forms.DateTimePicker();
            this.txtTenCv = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.maCongViec = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(549, 134);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(2);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(85, 30);
            this.btnLuu.TabIndex = 21;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(449, 134);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(85, 30);
            this.btnHuy.TabIndex = 20;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // txtNoiDung
            // 
            this.txtNoiDung.Location = new System.Drawing.Point(364, 11);
            this.txtNoiDung.Margin = new System.Windows.Forms.Padding(2);
            this.txtNoiDung.Name = "txtNoiDung";
            this.txtNoiDung.Size = new System.Drawing.Size(194, 91);
            this.txtNoiDung.TabIndex = 19;
            this.txtNoiDung.Text = "";
            // 
            // dtNgayKT
            // 
            this.dtNgayKT.Location = new System.Drawing.Point(97, 83);
            this.dtNgayKT.Margin = new System.Windows.Forms.Padding(2);
            this.dtNgayKT.Name = "dtNgayKT";
            this.dtNgayKT.Size = new System.Drawing.Size(151, 20);
            this.dtNgayKT.TabIndex = 18;
            // 
            // dtNgayBd
            // 
            this.dtNgayBd.Location = new System.Drawing.Point(97, 48);
            this.dtNgayBd.Margin = new System.Windows.Forms.Padding(2);
            this.dtNgayBd.Name = "dtNgayBd";
            this.dtNgayBd.Size = new System.Drawing.Size(151, 20);
            this.dtNgayBd.TabIndex = 17;
            // 
            // txtTenCv
            // 
            this.txtTenCv.Location = new System.Drawing.Point(93, 11);
            this.txtTenCv.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenCv.Name = "txtTenCv";
            this.txtTenCv.Size = new System.Drawing.Size(192, 20);
            this.txtTenCv.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(306, 16);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Nội dung:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Ngày kết thúc:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ngày bắt đầu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tên công việc:";
            // 
            // maCongViec
            // 
            this.maCongViec.AutoSize = true;
            this.maCongViec.ForeColor = System.Drawing.Color.White;
            this.maCongViec.Location = new System.Drawing.Point(70, 134);
            this.maCongViec.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.maCongViec.Name = "maCongViec";
            this.maCongViec.Size = new System.Drawing.Size(28, 13);
            this.maCongViec.TabIndex = 22;
            this.maCongViec.Text = "xnxx";
            // 
            // frmSuathongTin
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(643, 173);
            this.Controls.Add(this.maCongViec);
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
            this.Name = "frmSuathongTin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnLuu;
        public System.Windows.Forms.Button btnHuy;
        public System.Windows.Forms.RichTextBox txtNoiDung;
        public System.Windows.Forms.DateTimePicker dtNgayKT;
        public System.Windows.Forms.DateTimePicker dtNgayBd;
        public System.Windows.Forms.TextBox txtTenCv;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label maCongViec;
    }
}