using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiBanHang
{
    public partial class frmSanPham : Form
    {
        public frmSanPham()
        {
            InitializeComponent();
        }
        private void frmSanPham_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = sp.HienThiSanPham();
            dgvNhanVien.DataSource = dt;
            KhoaDieuKhien();
            KhoiTao();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            MoDieuKhien();
            chon = 2 ;
        }
    }
}
