using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq.Mapping;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyChungCu.QL_CongViec
{
    public partial class FrmCongViec : Form
    {
        public event EventHandler FormClosedEvent;

        public FrmCongViec()
        {
            InitializeComponent();
            FillTable();
        }
        public void FillTable()
        {
            try {
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                string query = "select * from CongViec";
                using (SqlConnection sqlConnection = ConnectDb.GetConnection())
                {
                    sqlConnection.Open();
                    adapter = new SqlDataAdapter(query, sqlConnection);
                    adapter.Fill(table);
                    sqlConnection.Close();
                }
                dtgvCongViec.Columns["MaCV"].DataPropertyName = "MaCV";
                dtgvCongViec.Columns["TenCV"].DataPropertyName = "TenCV";
                dtgvCongViec.Columns["NgayBD"].DataPropertyName = "NgayBatDau";
                dtgvCongViec.Columns["NgayKT"].DataPropertyName = "NgayKetThuc";

                dtgvCongViec.Columns["NoiDung"].DataPropertyName = "NoiDung";
                dtgvCongViec.DataSource = null;
                dtgvCongViec.DefaultCellStyle.ForeColor = Color.Black;
                dtgvCongViec.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dtgvCongViec.MultiSelect = false;
                dtgvCongViec.DataSource = table;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        private void Tab_DanhSach_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FrmThemCongViec newFrm = new FrmThemCongViec();
            newFrm.ShowDialog();
        }
        private void FrmThemCongViec_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Kích hoạt sự kiện FormClosedEvent khi form đã đóng
            FormClosedEvent?.Invoke(this, EventArgs.Empty);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string macv = txtTenCV.Text.ToString();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string query = "";
            if (macv != "")
            {
                query = "SELECT * from CongViec WHERE TenCV like N'"+ macv +"';";
            }
            else
            {
                query = "select * from CongViec";
            }
            
            using (SqlConnection sqlConnection = ConnectDb.GetConnection())
            {
                sqlConnection.Open();
                adapter = new SqlDataAdapter(query, sqlConnection);
                adapter.Fill(table);
                sqlConnection.Close();
            }
            dtgvCongViec.Columns["MaCV"].DataPropertyName = "MaCV";
            dtgvCongViec.Columns["TenCV"].DataPropertyName = "TenCV";
            dtgvCongViec.Columns["NgayBD"].DataPropertyName = "NgayBatDau";
            dtgvCongViec.Columns["NgayKT"].DataPropertyName = "NgayKetThuc";
            dtgvCongViec.Columns["NoiDung"].DataPropertyName = "NoiDung";
            dtgvCongViec.DataSource = table;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dtgvCongViec.SelectedRows.Count > 0)
            {
                
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa hàng được chọn?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    DataGridViewRow selectedRow = dtgvCongViec.SelectedRows[0];
                    string idToDelete = selectedRow.Cells["MaCV"].Value.ToString();
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    DataTable table = new DataTable();
                    string query = "DELETE FROM CongViec WHERE MaCV like N'" + idToDelete + "';";
                    using (SqlConnection sqlConnection = ConnectDb.GetConnection())
                    {
                        sqlConnection.Open();
                        adapter = new SqlDataAdapter(query, sqlConnection);
                        adapter.Fill(table);
                        sqlConnection.Close();
                    }
                    MessageBox.Show("Xóa thành công!!");
                    FillTable();
                }
                else
                {

                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa.");
            }
        }

        private void dtgvCongViec_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dtgvCongViec.Rows.Count)
            {
                if (e.RowIndex >= 0 && e.RowIndex < dtgvCongViec.Rows.Count)
                {
                    string maCongViec = dtgvCongViec.Rows[e.RowIndex].Cells["MaCV"].Value?.ToString();
                    string tenCongViec = dtgvCongViec.Rows[e.RowIndex].Cells["TenCV"].Value?.ToString();
                    DateTime NgayKT = DateTime.Parse(dtgvCongViec.Rows[e.RowIndex].Cells["NgayKT"].Value?.ToString());
                    DateTime NgayBD = DateTime.Parse(dtgvCongViec.Rows[e.RowIndex].Cells["NgayBD"].Value?.ToString());
                    string NoiDung = dtgvCongViec.Rows[e.RowIndex].Cells["NoiDung"].Value?.ToString();
                     
                    if (!string.IsNullOrEmpty(maCongViec))
                    {
                        TabPage existingTab = tabControl1.TabPages.Cast<TabPage>().FirstOrDefault(tab => tab.Text == maCongViec);

                        if (existingTab != null)
                        {
                            // Tab đã tồn tại, chuyển đến Tab đó
                            tabControl1.SelectedTab = existingTab;
                        }
                        else
                        {
                            // Tạo một TabPage mới và thêm vào TabControl
                            TabPage newTabPage = new TabPage(maCongViec);
                            tabControl1.TabPages.Add(newTabPage);
                            newTabPage.BackColor = Color.White;
                            // Thêm controls của tam vào TabPage mới
                            DataGridView dtgvNhanVien = new DataGridView();
                            dtgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                            dtgvNhanVien.Columns.AddRange(
                                new DataGridViewTextBoxColumn() { HeaderText = "Mã nhân viên", Name = "MaNV", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill },
                                new DataGridViewTextBoxColumn() { HeaderText = "Họ tên", Name = "HoTen", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill },
                                new DataGridViewTextBoxColumn() { HeaderText = "Ngày sinh", Name = "NgaySinh", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill },
                                new DataGridViewTextBoxColumn() { HeaderText = "Quê quán", Name = "QueQuan", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill },
                                new DataGridViewTextBoxColumn() { HeaderText = "Email", Name = "Email", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill },
                                new DataGridViewTextBoxColumn() { HeaderText = "Số điện thoại", Name = "SDT", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill },
                                new DataGridViewTextBoxColumn() { HeaderText = "Chức vụ", Name = "ChucVu", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill }
                            );
                            dtgvNhanVien.Location = new Point(6, 165);
                            dtgvNhanVien.Name = "dtgvNhanVien";
                            dtgvNhanVien.Size = new Size(1127, 342);
                            dtgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                            dtgvNhanVien.MultiSelect = false;
                            dtgvNhanVien.DefaultCellStyle.ForeColor = Color.Black;
                            dtgvNhanVien.AllowUserToResizeColumns = false;
                            dtgvNhanVien.AllowUserToResizeRows = false;

                            //  Đổ data vào datagridview
                            SqlDataAdapter adapter = new SqlDataAdapter();
                            DataTable table = new DataTable();
                            string query = "SELECT NhanVien.* FROM NhanVien JOIN PhanCong ON NhanVien.MaNV = PhanCong.MaNV WHERE PhanCong.MaCV = '" + maCongViec + "'; ";
                            using (SqlConnection sqlConnection = ConnectDb.GetConnection())
                            {
                                sqlConnection.Open();
                                adapter = new SqlDataAdapter(query, sqlConnection);
                                adapter.Fill(table);
                                sqlConnection.Close();
                            }
                            dtgvNhanVien.Columns["MaNV"].DataPropertyName = "MaNV";
                            dtgvNhanVien.Columns["HoTen"].DataPropertyName = "HoTen";
                            dtgvNhanVien.Columns["NgaySinh"].DataPropertyName = "NgaySinh";
                            dtgvNhanVien.Columns["QueQuan"].DataPropertyName = "QueQuan";
                            dtgvNhanVien.Columns["Email"].DataPropertyName = "Email";
                            dtgvNhanVien.Columns["SDT"].DataPropertyName = "SoDienThoai";
                            dtgvNhanVien.Columns["ChucVu"].DataPropertyName = "ChucVu";
                            dtgvNhanVien.DataSource = null;
                            dtgvNhanVien.DataSource = table;

                            RichTextBox txtNoiDung = new RichTextBox();
                            txtNoiDung.Location = new Point(816, 59);
                            txtNoiDung.Margin = new Padding(2);
                            txtNoiDung.Name = "txtNoiDung";
                            txtNoiDung.Text = NoiDung;
                            txtNoiDung.Size = new Size(197, 69);
                            txtNoiDung.Enabled = false;
                            txtNoiDung.BackColor = Color.White;

                            TextBox txtTenCV = new TextBox();
                            txtTenCV.Location = new Point(126, 107);
                            txtTenCV.Text = tenCongViec;
                            txtTenCV.Margin = new Padding(2);
                            txtTenCV.Name = "txtTenCV";
                            txtTenCV.Size = new Size(145, 20);
                            txtTenCV.Enabled = false;
                            txtTenCV.BackColor = Color.White;

                            DateTimePicker dtNgayKT = new DateTimePicker();
                            dtNgayKT.Location = new Point(478, 108);
                            dtNgayKT.Margin = new Padding(2);
                            dtNgayKT.Name = "dtNgayKT";
                            dtNgayKT.Size = new Size(151, 20);
                            dtNgayKT.Value = NgayKT;
                            dtNgayKT.Enabled = false;

                            DateTimePicker dtNgayBd = new DateTimePicker();
                            dtNgayBd.Location = new Point(478, 58);
                            dtNgayBd.Margin = new Padding(2);
                            dtNgayBd.Name = "dtNgayBd";
                            dtNgayBd.Size = new Size(151, 20);
                            dtNgayBd.Enabled = false;
                            dtNgayBd.Value = NgayBD;

                            Label labMaCV = new Label();
                            labMaCV.Text = "Mã công việc:";
                            labMaCV.Location = new Point(29, 64);
                            labMaCV.ForeColor = Color.Black;
                            
                            Label labTenCV = new Label();
                            labTenCV.Text = "Tên công việc:";
                            labTenCV.Location = new Point(29, 114);
                            labTenCV.ForeColor = Color.Black;
                            
                            Label labNgayBD = new Label();
                            labNgayBD.Text = "Ngày bắt đầu";
                            labNgayBD.Location = new Point(394, 62);
                            labNgayBD.ForeColor = Color.Black;
                            
                            Label labNgayKT = new Label();
                            labNgayKT.Text = "Ngày kết thúc";
                            labNgayKT.Location = new Point(394, 112);
                            labNgayKT.ForeColor = Color.Black;
                            
                            Label labNoiDung = new Label();
                            labNoiDung.Text = "Nội dung";
                            labNoiDung.Location = new Point(758, 64);
                            labNoiDung.ForeColor = Color.Black;
                            
                            Label labGrid = new Label();
                            labGrid.Text = "Danh sách nhân viên được giao";
                            labGrid.Location = new Point(6, 150);
                            labGrid.ForeColor = Color.Black;
                            labGrid.AutoSize = true;

                            TextBox txtMaCV = new TextBox();
                            txtMaCV.Location = new Point(126, 57);
                            txtMaCV.Margin = new Padding(2);
                            txtMaCV.Name = "txtMaCV";
                            txtMaCV.Size = new Size(145, 20);
                            txtMaCV.Enabled = false;
                            txtMaCV.Text = maCongViec;
                            txtMaCV.BackColor = Color.White;

                            Button btnDong = new Button();
                            btnDong.Location = new Point(440, 13);
                            btnDong.Name = "btnDong";
                            btnDong.Text = "Đóng";
                            btnDong.Size = new Size(75, 23);
                            btnDong.ForeColor = Color.Black;
                            btnDong.Click += btnDong_Click;

                            Button btnChinhSua = new Button();
                            btnChinhSua.Location = new Point(320, 13);
                            btnChinhSua.Name = "btnChinhSua";
                            btnChinhSua.Text = "Chỉnh sửa thông tin";
                            btnChinhSua.Size = new Size(108, 23);
                            btnChinhSua.ForeColor = Color.Black;
                            btnChinhSua.Click += btnChinhSua_Click;

                            Button btnXoa = new Button();
                            btnXoa.Location = new Point(1000, 140);
                            btnXoa.Name = "btnXoa1";
                            btnXoa.Text = "Xóa";
                            btnXoa.Size = new Size(90, 23);
                            btnXoa.ForeColor = Color.Black;
                            btnXoa.Click += btnXoa1_Click;

                            Button btnThem = new Button();
                            btnThem.Location = new Point(900, 140);
                            btnThem.Name = "btnThem1";
                            btnThem.Text = "Thêm";
                            btnThem.Size = new Size(90, 23);
                            btnThem.ForeColor = Color.Black;
                            btnThem.Click += btnThem1_Click;

                            Label label1 = new Label();
                            label1.AutoSize = true;
                            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
                            label1.ForeColor = Color.Black;
                            label1.Location = new Point(28, 10);
                            label1.Name = "label1";
                            label1.Text = "Thông tin công việc " + maCongViec + " ";
                            label1.Size = new Size(212, 24);

                            // Thêm các control vào TabPage mới
                            newTabPage.Controls.Add(dtgvNhanVien);
                            newTabPage.Controls.Add(txtNoiDung);
                            newTabPage.Controls.Add(txtTenCV);
                            newTabPage.Controls.Add(dtNgayKT);
                            newTabPage.Controls.Add(dtNgayBd);
                            newTabPage.Controls.Add(txtMaCV);
                            newTabPage.Controls.Add(btnXoa);
                            newTabPage.Controls.Add(btnDong);
                            newTabPage.Controls.Add(btnChinhSua);
                            newTabPage.Controls.Add(btnThem);
                            newTabPage.Controls.Add(label1);
                            newTabPage.Controls.Add(labMaCV);
                            newTabPage.Controls.Add(labTenCV);
                            newTabPage.Controls.Add(labNgayBD);
                            newTabPage.Controls.Add(labNgayKT);
                            newTabPage.Controls.Add(labNoiDung);
                            newTabPage.Controls.Add(labGrid);

                            tabControl1.SelectedTab = newTabPage;
                        }
                    }
                }
            }
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có Tab được chọn hay không
            if (tabControl1.SelectedTab != null)
            {
                // Đóng Tab hiện tại
                tabControl1.TabPages.Remove(tabControl1.SelectedTab);
            }
        }
        public string maCongViec = "";
        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            var IdCongViec = tabControl1.SelectedTab;
            maCongViec = IdCongViec.Text;
            frmSuathongTin newFrm = new frmSuathongTin();
            newFrm.Text = "Chỉnh sửa thông tin công việc " + IdCongViec.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string query = "select * from CongViec where MaCV = N'" + IdCongViec.Text + "';";
            using (SqlConnection sqlConnection = ConnectDb.GetConnection())
            {
                sqlConnection.Open();
                adapter = new SqlDataAdapter(query, sqlConnection);
                adapter.Fill(table);
                sqlConnection.Close();
            }
            newFrm.maCongViec.Text = table.Rows[0]["MaCV"].ToString();
            newFrm.txtTenCv.Text = table.Rows[0]["TenCV"].ToString();
            newFrm.txtNoiDung.Text = table.Rows[0]["NoiDung"].ToString();
            newFrm.dtNgayBd.Value = DateTime.Parse(table.Rows[0]["NgayBatDau"].ToString());
            newFrm.dtNgayKT.Value = DateTime.Parse(table.Rows[0]["NgayKetThuc"].ToString());
            newFrm.ShowDialog();
        }
        private void btnXoa1_Click(object sender, EventArgs e)
        {
            DataGridView dtgvNhanVien = new DataGridView();
            var IdCongViec = tabControl1.SelectedTab;
            if (dtgvNhanVien.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa hàng được chọn?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    DataGridViewRow selectedRow = dtgvNhanVien.SelectedRows[0];
                    string idToDelete = selectedRow.Cells["MaNV"].Value.ToString();
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    string query = "DELETE FROM PhanCong WHERE MaNV = '"+ idToDelete +"' AND MaCV = '"+ IdCongViec + "';";
                    using (SqlConnection sqlConnection = ConnectDb.GetConnection())
                    {
                        sqlConnection.Open();
                        adapter = new SqlDataAdapter(query, sqlConnection);
                        sqlConnection.Close();
                    }
                    MessageBox.Show("Xóa thành công!!");
                }
                else
                {

                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa.");
            }
        }
        private void btnThem1_Click(object sender, EventArgs e)
        {
            var IdCongViec = tabControl1.SelectedTab;
            FrmPhanCong frmPhanCong = new FrmPhanCong();
            frmPhanCong.Text = "Phân công nhân viên mới cho công việc " + IdCongViec.Text;
            frmPhanCong.ShowDialog();
        }
    }
}
