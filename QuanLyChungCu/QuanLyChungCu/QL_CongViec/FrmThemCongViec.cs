using QuanLyChungCu.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyChungCu.QL_CongViec
{
    public partial class FrmThemCongViec : Form
    {
        public string randomString = "";
        public FrmThemCongViec()
        {
            InitializeComponent();
            Random();
        }
        public void Random()
        {
            Random random = new Random();
            string characters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            for (int i = 0; i < 8; i++)
            {
                int index = random.Next(characters.Length);
                randomString += characters[index];
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)   
        {
            string tenCV = txtTenCv.Text;
            string Noidung = txtNoiDung.Text;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string query = "INSERT INTO CongViec (MaCV, TenCV, NoiDung, NgayBatDau, NgayKetThuc)" +
                           "VALUES (N'" + randomString + "', N'" + tenCV + "', N'" + Noidung + "', N'" + dtNgayBd.Value + "', N'" + dtNgayKT.Value + "');";
            using (SqlConnection sqlConnection = ConnectDb.GetConnection())
            {
                sqlConnection.Open();
                adapter = new SqlDataAdapter(query, sqlConnection);
                adapter.Fill(table);
                sqlConnection.Close();
            }
            Random();
            txtTenCv.Text = "";
            txtNoiDung.Text = "";
            dtNgayBd.Value = DateTime.Today;
            dtNgayKT.Value = DateTime.Today;
            MessageBox.Show("Lưu thành công");
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
