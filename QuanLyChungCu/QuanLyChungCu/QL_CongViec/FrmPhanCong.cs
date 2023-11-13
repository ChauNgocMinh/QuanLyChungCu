using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyChungCu.QL_CongViec
{
    public partial class FrmPhanCong : Form
    {
        public FrmPhanCong()
        {
            InitializeComponent();
            FillTableNhanVien();
        }
        public void FillTableNhanVien()
        {
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();

                string formTitle = this.Text;
                int length = formTitle.Length;
                string MaCV = formTitle.Substring(length - 8);

                string query = "SELECT * FROM NhanVien WHERE NOT EXISTS ( SELECT 1 FROM PhanCong WHERE PhanCong.MaNV = NhanVien.MaNV AND PhanCong.MaCV = '"+ MaCV + "' );";
                using (SqlConnection sqlConnection = ConnectDb.GetConnection())
                {
                    sqlConnection.Open();
                    adapter = new SqlDataAdapter(query, sqlConnection);
                    adapter.Fill(table);
                    sqlConnection.Close();
                }
                dtgvNhanVien.Columns["MaNV"].DataPropertyName = "MaNV";
                dtgvNhanVien.Columns["ChucVu"].DataPropertyName = "ChucVu";
                dtgvNhanVien.Columns["HoTen"].DataPropertyName = "HoTen";
                dtgvNhanVien.Columns["SDT"].DataPropertyName = "SoDienThoai";
                dtgvNhanVien.Columns["Email"].DataPropertyName = "Email";
                dtgvNhanVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dtgvNhanVien.MultiSelect = false;
                dtgvNhanVien.AutoGenerateColumns = false;
                dtgvNhanVien.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cbChonTatCa.Checked == true)
            {
                                             
            }
            else
            {
                if (dtgvNhanVien.SelectedRows.Count > 0)
                {
                    string formTitle = this.Text;
                    int length = formTitle.Length;
                    string MaCV = formTitle.Substring(length - 8);
                    DataTable table = new DataTable();
                    DataGridViewRow selectedRow = dtgvNhanVien.SelectedRows[0];
                    string MaNV = selectedRow.Cells["MaNV"].Value.ToString();
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    string query = "insert into PhanCong (MaCV, MaNV) values ( N'"+ MaCV + "', N'"+MaNV+"');";
                    using (SqlConnection sqlConnection = ConnectDb.GetConnection())
                    {
                        sqlConnection.Open();
                        adapter = new SqlDataAdapter(query, sqlConnection);
                        adapter.Fill(table);
                        sqlConnection.Close();
                    }
                    MessageBox.Show("Thêm thành công!!");
                    FillTableNhanVien();
                   
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một hàng để xóa.");
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
