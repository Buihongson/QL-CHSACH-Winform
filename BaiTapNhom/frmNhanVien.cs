using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapNhom
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        LopDungChung ldc = new LopDungChung();

        public void loadData()
        {
            string sql = "Select * From NHANVIEN";
            dataGridView1.DataSource = ldc.layBang(sql);
        }

        public void loadComboBox()
        {
            String sql = "Select * From VAITRO";
            cbb_vaiTro.DataSource = ldc.layBang(sql);
            cbb_vaiTro.ValueMember = "MaVT";
            cbb_vaiTro.DisplayMember = "TenVT";
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            loadData();
            loadComboBox();
            this.CenterToScreen();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dataGridView1.Rows[e.RowIndex];
                txt_maNhanVien.Text = row.Cells[0].Value.ToString();
                txt_hoTen.Text = row.Cells[1].Value.ToString();
                txt_diaChi.Text = row.Cells[2].Value.ToString();
                txt_soDienThoai.Text = row.Cells[3].Value.ToString();
                cbb_vaiTro.SelectedValue = row.Cells[4].Value.ToString();
            }
            catch
            {

            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            string sqlThem = "Insert Into NHANVIEN Values('" + txt_maNhanVien.Text + "', N'" + txt_hoTen.Text + "', N'" + txt_diaChi.Text + "', N'" + txt_soDienThoai.Text + "', N'" + cbb_vaiTro.SelectedValue.ToString() + "')";

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
            txt_maNhanVien.Text = "";
            txt_hoTen.Text = "";
            txt_diaChi.Text = "";
            txt_soDienThoai.Text = "";
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string sqlSua = "Update NHANVIEN Set HoTen = N'" + txt_hoTen.Text + "', DiaChi = N'" + txt_diaChi.Text + "', SoDT = N'" + txt_soDienThoai.Text + "', VaiTro = N'" + cbb_vaiTro.Text + "' Where MaNV = '" + txt_maNhanVien.Text + "'";

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
            txt_maNhanVien.Text = "";
            txt_hoTen.Text = "";
            txt_diaChi.Text = "";
            txt_soDienThoai.Text = "";
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo);
            if(dlr == DialogResult.Yes)
            {
                string sqlXoa = "Delete NHANVIEN Where MaNV = '" + txt_maNhanVien.Text + "'";
                int kq = (int)ldc.ExcutedNonQuery(sqlXoa);
                if (kq > 0)
                {
                    MessageBox.Show("Xóa thành công");
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                }
                loadData();
                txt_maNhanVien.Text = "";
                txt_hoTen.Text = "";
                txt_diaChi.Text = "";
                txt_soDienThoai.Text = "";
            }
            else
            {

            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo);
            if (dlr == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {

            }
        }

        private void txt_timKiem_TextChanged(object sender, EventArgs e)
        {
            if (cbb_timKiem.Text == "Mã Nhân Viên")
            {
                string sqlTim = "Select * From NhanVien Where MaNV Like '%" + txt_timKiem.Text + "%'";
                dataGridView1.DataSource = ldc.layBang(sqlTim);
            }
            else
            {
                string sqlTimTNV = "Select * From NhanVien Where HoTen Like '%" + txt_timKiem.Text + "%'";
                dataGridView1.DataSource = ldc.layBang(sqlTimTNV);
            }
        }

        private void btn_timKiem_Click(object sender, EventArgs e)
        {
            loadData();
        }


    }
}
