using DevExpress.XtraEditors;
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

        private void Tab_DanhSach_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FrmThemCongViec newFrm = new FrmThemCongViec();
            newFrm.ShowDialog();
        }
    }
}
