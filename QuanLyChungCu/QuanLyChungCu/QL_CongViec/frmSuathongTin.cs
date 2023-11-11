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

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string MaCongViec = maCongViec.Text;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string query = "update * from CongViec";
            using (SqlConnection sqlConnection = ConnectDb.GetConnection())
            {
                sqlConnection.Open();
                adapter = new SqlDataAdapter(query, sqlConnection);
                adapter.Fill(table);
                sqlConnection.Close();
            }
        }
    }
}
