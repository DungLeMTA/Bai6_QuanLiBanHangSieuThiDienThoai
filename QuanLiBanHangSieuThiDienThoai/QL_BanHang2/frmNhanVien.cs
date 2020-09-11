using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogic;
namespace QuanLyBanHang
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }
        NhanVien nv = new NhanVien();
        int chon = 0;
        void KhoaDieuKhien()
        {
            txtTenDn.Enabled = txtMatKhau.Enabled = txtTenNV.Enabled = txtDiaChi.Enabled = txtSDT.Enabled = cbGT.Enabled = false;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = true;
            btnLuu.Enabled = false;
        }
        void MoDieuKhien()
        {
            txtTenDn.Enabled = txtMatKhau.Enabled = txtTenNV.Enabled = txtDiaChi.Enabled = txtSDT.Enabled = cbGT.Enabled = true;
            btnThem.Enabled = btnSua.Enabled = btnXoa.Enabled = false;
            btnLuu.Enabled = true;
        }
        void SetNull()
        {
            txtTenDn.Text = txtMatKhau.Text = txtTenNV.Text = txtSDT.Text = txtDiaChi.Text = cbGT.Text = "";
            tscbGT.Text = tstxtDiaChi.Text = tstxtMa.Text = tstxtTen.Text = "";
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = nv.HienThiNhanVien();
            dgvNhanVien.DataSource = dt;
            KhoaDieuKhien();
        }

    
