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
                dtgvCongViec.DataSource = table;
            }
            catch(Exception ex) {
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
                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
    }
}
