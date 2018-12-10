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
    public partial class frmNhaXB : Form
    {
        public frmNhaXB()
        {
            InitializeComponent();
        }

        LopDungChung ldc = new LopDungChung();

        public void loadData()
        {
            string sql = "Select * From NHAXUATBAN";
            dataGridView1.DataSource = ldc.layBang(sql);
        }

        private void frmNhaXB_Load(object sender, EventArgs e)
        {
            loadData();
            this.CenterToScreen();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string sqlThem = "Insert Into NHAXUATBAN Values('"+txt_maNXB.Text+"', N'"+txt_tenNXB.Text+"', N'"+txt_diaChi.Text+"', '"+txt_dienThoai.Text+"')";

            int kq = ldc.ExcutedNonQuery(sqlThem);
            if (kq >= 0)
            {
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
            loadData();
            txt_maNXB.Text = "";
            txt_tenNXB.Text = "";
            txt_diaChi.Text = "";
            txt_dienThoai.Text = "";
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string sqlSua = "Update NHAXUATBAN Set TenNXB = N'" + txt_tenNXB.Text + "', DiaChi = N'" + txt_diaChi.Text + "', DienThoai = '" + txt_dienThoai.Text + "' Where MaNXB = '"+txt_maNXB.Text+"'";

            int kq = ldc.ExcutedNonQuery(sqlSua);
            if (kq >= 0)
            {
                MessageBox.Show("Sửa thành công");
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
            loadData();
            txt_maNXB.Text = "";
            txt_tenNXB.Text = "";
            txt_diaChi.Text = "";
            txt_dienThoai.Text = "";
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string sqlXoa = "Delete NHAXUATBAN Where MaNXB = '"+txt_maNXB.Text+"'";

            int kq = ldc.ExcutedNonQuery(sqlXoa);
            if (kq >= 0)
            {
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
            loadData();
            txt_maNXB.Text = "";
            txt_tenNXB.Text = "";
            txt_diaChi.Text = "";
            txt_dienThoai.Text = "";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.Rows[e.RowIndex];
            txt_maNXB.Text = row.Cells[0].Value.ToString();
            txt_tenNXB.Text = row.Cells[1].Value.ToString();
            txt_diaChi.Text = row.Cells[2].Value.ToString();
            txt_dienThoai.Text = row.Cells[3].Value.ToString();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
