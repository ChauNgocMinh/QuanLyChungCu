using QuanLyChungCu.QL_CanHo;
using QuanLyChungCu.QL_CongViec;
using QuanLyChungCu.QL_CuDan;
using QuanLyChungCu.QL_NhanVien;
using QuanLyChungCu.QL_ThongBao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyChungCu
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            FrmCuDan newFrm = new FrmCuDan();
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            newFrm.TopLevel = false;
            pnlControl.Controls.Add(newFrm);
            newFrm.BringToFront();
            newFrm.Show();
        }

        private void btnCuDan_Click(object sender, EventArgs e)
        {
            FrmCuDan newFrm = new FrmCuDan();
            newFrm.TopLevel = false;
            pnlControl.Controls.Add(newFrm);
            newFrm.BringToFront();
            newFrm.Show();
        }

        private void btnCanHo_Click(object sender, EventArgs e)
        {
            FrmCanHo newFrm = new FrmCanHo();
            newFrm.TopLevel = false;
            pnlControl.Controls.Add(newFrm);
            newFrm.BringToFront();
            newFrm.Show();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            FrmNhanVien newFrm = new FrmNhanVien();
            newFrm.TopLevel = false;
            pnlControl.Controls.Add(newFrm);
            newFrm.BringToFront();
            newFrm.Show();

        }

        private void btnThongBao_Click(object sender, EventArgs e)
        {
            FrmThongBao newFrm = new FrmThongBao();
            newFrm.TopLevel = false;
            pnlControl.Controls.Add(newFrm);
            newFrm.BringToFront();
            newFrm.Show();
        }

        private void btnCongViec_Click(object sender, EventArgs e)
        {
            FrmCongViec newFrm = new FrmCongViec();
            newFrm.TopLevel = false;
            pnlControl.Controls.Add(newFrm);
            newFrm.BringToFront();
            newFrm.Show();
        }
    }
}
