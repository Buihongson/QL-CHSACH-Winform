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
    public partial class frmTimKiemNCC : Form
    {
        public frmTimKiemNCC()
        {
            InitializeComponent();
        }

        LopDungChung ldc = new LopDungChung();

        public void loadData()
        {
            string sql = "Select * From NHACUNGCAP";
            dataGridView1.DataSource = ldc.layBang(sql);
        }

        private void frmTimKiemNCC_Load(object sender, EventArgs e)
        {
            loadData();
            this.CenterToScreen();
        }

        private void btn_timKiem_Click(object sender, EventArgs e)
        {
            loadData();
            txt_timKiem.Text = "";
        }

        private void txt_timKiem_TextChanged_1(object sender, EventArgs e)
        {
            if (cbb_timKiem.Text == "Mã NCC")
            {
                string sqlTim = "Select * From NHACUNGCAP Where MaNCC Like '%" + txt_timKiem.Text + "%'";
                dataGridView1.DataSource = ldc.layBang(sqlTim);
            }
            else
            {
                string sqlTim = "Select * From NHACUNGCAP Where TenNCC Like '%" + txt_timKiem.Text + "%'";
                dataGridView1.DataSource = ldc.layBang(sqlTim);
            }
        }
    }
}
