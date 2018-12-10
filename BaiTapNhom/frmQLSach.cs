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
    public partial class frmQLSach : Form
    {
        public frmQLSach()
        {
            InitializeComponent();
        }

        LopDungChung ldc = new LopDungChung();

        public void loadCombo()
        {
            string sql = "SELECT * FROM THELOAI";
            cbb_maTL.DataSource = ldc.layBang(sql);
            cbb_maTL.DisplayMember = "TenTL";
            cbb_maTL.ValueMember = "MaTL";
        }

        public void loadComboNXB()
        {
            string sql = "SELECT * FROM NHAXUATBAN";
            cbb_nxb.DataSource = ldc.layBang(sql);
            cbb_nxb.DisplayMember = "TenNXB";
            cbb_nxb.ValueMember = "MaNXB";
        }

        public void loadData()
        {
            string sql = "Select * from SACH";
            dataGridView1.DataSource = ldc.layBang(sql);
        }

        private void frmQLSach_Load(object sender, EventArgs e)
        {
            loadData();
            loadCombo();
            loadComboNXB();
            this.CenterToScreen();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dataGridView1.Rows[e.RowIndex];
                txt_maSach.Text = row.Cells[0].Value.ToString();
                cbb_maTL.Text = row.Cells[1].Value.ToString();
                txt_tenSach.Text = row.Cells[2].Value.ToString();
                txt_tacGia.Text = row.Cells[3].Value.ToString();
                cbb_nxb.Text = row.Cells[4].Value.ToString();
                txt_soLuong.Text = row.Cells[5].Value.ToString();
                txt_gia.Text = row.Cells[6].Value.ToString();
            }
            catch
            {

            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            if (txt_maSach.Text != "" && cbb_maTL.Text != "" && txt_tenSach.Text != "" && txt_tacGia.Text != "" && cbb_nxb.Text != "" && txt_soLuong.Text != "" && txt_gia.Text != "")
            {
                DialogResult dlr = MessageBox.Show("Bạn có chắc chắn muốn thêm không?", "Thông báo", MessageBoxButtons.YesNo);
                if (dlr == DialogResult.Yes)
                {
                    string sqlThem = "Insert into SACH values (N'" + txt_maSach.Text + "', N'" + cbb_maTL.SelectedValue.ToString() + "', N'" + txt_tenSach.Text + "', N'" + txt_tacGia.Text + "', N'" + cbb_nxb.SelectedValue.ToString() + "', N'" + txt_soLuong.Text + "', N'" + txt_gia.Text + "')";
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
                    txt_maSach.Text = "";
                    cbb_maTL.Text = "";
                    txt_tenSach.Text = "";
                    txt_tacGia.Text = "";
                    cbb_nxb.Text = "";
                    txt_soLuong.Text = "";
                    txt_gia.Text = "";
                }
                else
                {

                }
            }
            else
            {
                MessageBox.Show("Dữ liệu không hợp lệ");
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (txt_maSach.Text == "")
            {
                MessageBox.Show("Mã sách không hợp lệ");
            }
            else
            {
                DialogResult dlr = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo);
                if (dlr == DialogResult.Yes)
                {
                    string sqlXoa = "Delete SACH where MaSach = '" + txt_maSach.Text + "'";

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
                    txt_maSach.Text = "";
                    cbb_maTL.Text = "";
                    txt_tenSach.Text = "";
                    txt_tacGia.Text = "";
                    cbb_nxb.Text = "";
                    txt_soLuong.Text = "";
                    txt_gia.Text = "";
                }
                else
                {

                }
            }
        }

        private void btn_capNhap_Click(object sender, EventArgs e)
        {
            if (txt_maSach.Text == "")
            {
                MessageBox.Show("Mã sách không hợp lệ");
            }
            else
            {
                DialogResult dlr = MessageBox.Show("Bạn có chắc chắn muốn sửa không?", "Thông báo", MessageBoxButtons.YesNo);
                if (dlr == DialogResult.Yes)
                {
                    string sqlSua = "Update SACH Set MaTL = '" + cbb_maTL.SelectedValue.ToString() + "' , TenSach = N'" + txt_tenSach.Text + "' , TacGia = N'" + txt_tacGia.Text + "' , NXB = N'" + cbb_nxb.SelectedValue.ToString() + "' , SoLuong = '" + txt_soLuong.Text + "' , Gia = '" + txt_gia.Text + "' Where MaSach = '" + txt_maSach.Text + "' ";

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
                    txt_maSach.Text = "";
                    cbb_maTL.Text = "";
                    txt_tenSach.Text = "";
                    txt_tacGia.Text = "";
                    cbb_nxb.Text = "";
                    txt_soLuong.Text = "";
                    txt_gia.Text = "";
                }
                else
                {

                }
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {

            DialogResult dlr = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo);
            if (dlr == DialogResult.Yes)
            {
                this.Close();
            }
            else { }
        }

        private void btn_timKiem_Click(object sender, EventArgs e)
        {
            loadData();
        }

    }
}
