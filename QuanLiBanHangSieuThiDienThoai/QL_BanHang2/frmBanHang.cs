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
    public partial class frmBanHang : Form
    {
        public frmBanHang()
        {
            InitializeComponent();
        }

        public void btnGiamSL_Click(object sender, EventArgs e)
        {
               try
               {
                    lblDiaCHi.Text = "Địa chỉ";
                    lblGhichu.Text = "Ghi chú";
               }
               catch (Exception)
               {

                    throw;
               }

        }

        public void btnTangSL_Click(object sender, EventArgs e)
        {

               try
               {

               }
               catch (Exception)
               {

                    throw;
               }
          }

        public void btnLuu_Click_1(object sender, EventArgs e)
        {

               try
               {

               }
               catch (Exception)
               {

                    throw;
               }
          }


        public void HuyBo_Click_1(object sender, EventArgs e)
        {

        }


        public void btnOKKH_Click(object sender, EventArgs e)
        {

        }

        public void btnrefreshKH_Click(object sender, EventArgs e)
        {

        }

        public void dgvKhachHang_CellClick(object sender, EventArgs e)
        {

        }


        public void txttenKH_TextChanged(object sender, EventArgs e)
        {

        }


        public void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        public void txtTenNSX_TextChanged(object sender, EventArgs e)
        {

        }


        public void cmbTenLH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        public void txtTenSP_TextChanged(object sender, EventArgs e)
        {

        }


        public void dgvSanPham_CellClick(object sender, EventArgs e)
        {

        }

        public void btnChonSP_Click(object sender, EventArgs e)
        {

        }


        public void frmHoaDonBanHang_Load(object sender, EventArgs e)
        {
               try
               {
                    lblDiaCHi.Text = "Địa chỉ";
                    lblGhichu.Text = "Ghi chú";
               }
               catch (Exception)
               {

                    throw;
               }
          }

          private void lblSoLuong_Click(object sender, EventArgs e)
          {
               try
               {
                   
               }
               catch (Exception)
               {

                    throw;
               }
          }
     }

}
