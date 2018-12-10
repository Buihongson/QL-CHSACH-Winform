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
    public partial class frmTimKiemSach : Form
    {
        public frmTimKiemSach()
        {
            InitializeComponent();
        }

        LopDungChung ldc = new LopDungChung();

        public void loadData()
        {
            string sql = "Select * from SACH";
            dataGridView1.DataSource = ldc.layBang(sql);
        }

        private void frmTimKiemSach_Load(object sender, EventArgs e)
        {
            loadData();
            this.CenterToScreen();
        }

        private void txt_timKiem_TextChanged(object sender, EventArgs e)
        {
            if (cbb_timKiem.Text == "Mã Sách")
            {
                string sqlTim = "Select * From SACH Where MaSach Like '%" + txt_timKiem.Text + "%' ";
                dataGridView1.DataSource = ldc.layBang(sqlTim);
            }
            else if (cbb_timKiem.Text == "Mã Thể Loại")
            {
                string sqlTimTL = "Select * From SACH Where MaTL Like '%" + txt_timKiem.Text + "%' ";
                dataGridView1.DataSource = ldc.layBang(sqlTimTL);
            }
            else if (cbb_timKiem.Text == "Tên Sách")
            {
                string sqlTimTS = "Select * From SACH Where TenSach Like '%" + txt_timKiem.Text + "%' ";
                dataGridView1.DataSource = ldc.layBang(sqlTimTS);
            }
            else if (cbb_timKiem.Text == "Tác Giả")
            {
                string sqlTimTG = "Select * From SACH Where TacGia Like '%" + txt_timKiem.Text + "%' ";
                dataGridView1.DataSource = ldc.layBang(sqlTimTG);
            }
            else
            {
                string sqlTimNXB = "Select * From SACH Where NXB Like '%" + txt_timKiem.Text + "%' ";
                dataGridView1.DataSource = ldc.layBang(sqlTimNXB);
            }
        }

        private void btn_timKiem_Click(object sender, EventArgs e)
        {
            loadData();
            txt_timKiem.Text = "";
        }
    }
}
