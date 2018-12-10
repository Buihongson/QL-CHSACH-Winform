using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapNhom
{
    public partial class frmTimKiemNXB : Form
    {
        public frmTimKiemNXB()
        {
            InitializeComponent();
        }

        LopDungChung ldc = new LopDungChung();

        public void loadData()
        {
            string sql = "Select * From NHAXUATBAN";
            dataGridView1.DataSource = ldc.layBang(sql);
        }

        private void frmTimKiemNXB_Load(object sender, EventArgs e)
        {
            loadData();
            this.CenterToScreen();
        }

        private void txt_timKiem_TextChanged(object sender, EventArgs e)
        {
            if (cbb_timKiem.Text == "Mã NXB")
            {
                string sqlTim = "Select * From NHAXUATBAN Where MaNXB Like '%" + txt_timKiem.Text + "%'";
                dataGridView1.DataSource = ldc.layBang(sqlTim);
            }
            else
            {
                string sqlTim = "Select * From NHAXUATBAN Where TenNXB Like '%" + txt_timKiem.Text + "%'";
                dataGridView1.DataSource = ldc.layBang(sqlTim);
            }
        }

        private void btn_timKiem_Click(object sender, EventArgs e)
        {
            loadData();
            txt_timKiem.Text = "";
        }
    }
}
