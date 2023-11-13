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
    public partial class frmSuathongTin : Form
    {
        public frmSuathongTin()
        {
            InitializeComponent();
        }

        public void QueryDB()
        {
            //SqlDataAdapter adapter = new SqlDataAdapter();
            //DataTable table = new DataTable();
            //string query = "";
            //using (SqlConnection sqlConnection = ConnectDb.GetConnection())
            //{
            //    sqlConnection.Open();
            //    adapter = new SqlDataAdapter(query, sqlConnection);
            //    adapter.Fill(table);
            //    sqlConnection.Close();
            //}
            //txtTenCv.Text = table.Rows[0]["TenCV"].ToString();
            //txtNoiDung.Text = table.Rows[0]["NoiDung"].ToString();
            //dtNgayBd.Value = DateTime.Parse(table.Rows[0]["NgayBatDau"].ToString());
            //dtNgayKT.Value = DateTime.Parse(table.Rows[0]["NgayKetThuc"].ToString());
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string MaCongViec = maCongViec.Text;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string query = "UPDATE CongViec " +
                "SET TenCV = N'" + txtTenCv.Text + "', NoiDung = N'" + txtNoiDung.Text + "',NgayBatDau = '" + dtNgayBd.Value + "', NgayKetThuc = '" + dtNgayKT.Value + "'"
                + " WHERE MaCV like N'" + MaCongViec + "'; ";
            using (SqlConnection sqlConnection = ConnectDb.GetConnection())
            {
                sqlConnection.Open();
                adapter = new SqlDataAdapter(query, sqlConnection);
                adapter.Fill(table);
                sqlConnection.Close();
            }
            QueryDB();
            MessageBox.Show("Cập nật thành công!!!");
        }
    }
}
