using QuanLyChungCu.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
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
            //ConnectDb dbManager = new ConnectDb();
            //CongViecModel newCongViec = new CongViecModel {
            //    MaCV = randomString,
            //    TenCV = txtTenCv.Text,
            //    NgayBd = dtNgayBd.Value,
            //    NgayKT = dtNgayKT.Value,
            //    NoiDung = txtNoiDung.Text
            //};
            //DataContext context = new DataContext(dbManager.GetConnection());
            //context.GetTable<CongViecModel>().InsertOnSubmit(newCongViec);
            //context.SubmitChanges();


        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
