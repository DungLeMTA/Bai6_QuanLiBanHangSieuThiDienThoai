﻿using System;
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
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }
        void loadListKhachHang()
          {
               string sql = "select t.id,t.name,t.birthday,t.sex,s.subject_name from Teachers as t join Subject as s on s.id = t.subject_id";
               dataGridView1.DataSource = null;
               DataTable dt = DAO.DataProvider.Instance.Get(sql);
               dataGridView1.DataSource = dt;
          }
          void searchKhachHang(string sql)
          {
               dataGridView1.DataSource = null;
               DataTable dt = DAO.DataProvider.Instance.Get(sql);
               dataGridView1.DataSource = dt;
          }
    }
}
