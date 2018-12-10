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
    public partial class frmBanSach : Form
    {
        List<CTHD> lst;
        BindingSource bindingSource;
        public frmBanSach()
        {
            InitializeComponent();
            
            //gọi đến list và bindingsource
            lst = new List<CTHD>();
            bindingSource = new BindingSource();
            dataGridView2.DataSource = cTHDBindingSource;
        }

        LopDungChung ldc = new LopDungChung();

        // load combobox cho mã nhân viên
        public void loadComboBox()
        {
            string sql = "Select * From NHANVIEN Where MaVT = 2";
            cbb_tenNV.DataSource = ldc.layBang(sql);
            cbb_tenNV.ValueMember = "MaNV";
            cbb_tenNV.DisplayMember = "HoTen";
        }

        // load combobox cho mã sách
        public void loadComboBoxMaSach()
        {
            string sql = "Select * From SACH ";
            cbb_maSach.DataSource = ldc.layBang(sql);
            cbb_maSach.ValueMember = "MaSach";
            cbb_maSach.DisplayMember = "MaSach";
        }

        private void frmBanSach_Load(object sender, EventArgs e)
        {

            loadComboBox();
            loadComboBoxMaSach();
            this.CenterToScreen();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string chuoiketnoi = @"Data Source=DESKTOP-F0HK0I7;Initial Catalog=QLBanSach;Integrated Security=True;Pooling=False";
            SqlConnection con = new SqlConnection(chuoiketnoi);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM SACH WHERE MaSach = '" + cbb_maSach.SelectedValue.ToString() + "'";
            //cmd.CommandText = "SELECT * FROM SACH WHERE MaSach = '" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                txt_TenSach.Text = dr["TenSach"].ToString();
                txt_gia.Text = dr["Gia"].ToString();
            }
        }

        private void btn_themTTKH_Click(object sender, EventArgs e)
        {
            frmKhachHang fkh = new frmKhachHang();
            fkh.Show();
        }

        // load tổng tiền
        public string loadTongTien()
        {
            double tong = 0.0;
            foreach (var item in lst)
            {
                tong += item.thanhTien;
            }
            return tong.ToString();
        }

        private void btn_mua_Click(object sender, EventArgs e)
        {
            if (txt_soHD.Text == "")
            {
                MessageBox.Show("Số hóa đơn không được để trống");
            }
            else
            {
                if (int.Parse(txt_soLuong.Text) >= 1)
                {
                    // add sách cần mua vào list lst
                    CTHD newItem = new CTHD(cbb_maSach.SelectedValue.ToString(), txt_TenSach.Text, Convert.ToInt32(txt_soLuong.Text), Convert.ToDouble(txt_gia.Text) * Convert.ToInt32(txt_soLuong.Text));
                    lst.Add(newItem);
                    // add vào databinding
                    cTHDBindingSource.Add(newItem);
                    // set tổng tiền
                    txt_tongTien.Text = this.loadTongTien();
                }
                else
                {
                    MessageBox.Show("Số lượng không phù hợp");
                }
            }
        }

        public void addHoaDonToDatabase(string idHoaDon)
        {
            //MessageBox.Show(idHoaDon.ToString())
            foreach (CTHD item in lst)
            {
                //MessageBox.Show(item.tenSach);
                // add từng cái vô database
                string sqlThemShd = "Insert Into CTHOADON(SoHD, MaSach, SoLuongMua) Values('" + idHoaDon + "','" + item.maSach + "' ,'" + item.soLuongMua + "' )";
                ldc.ExcutedNonQuery(sqlThemShd);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Tạo hóa đơn mới lấy mã hóa đơn
            string shd = txt_soHD.Text;
            string sqlThem = "Insert Into HOADON (SoHD, NgayLap, MaNV) Values('" + shd + "', '" + txt_ngayLap.Text + "' , '" + cbb_tenNV.SelectedValue.ToString() + "')";
            int kq = ldc.ExcutedNonQuery(sqlThem);
            if (kq >= 1)
            {
                this.addHoaDonToDatabase(shd);
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Không thể tạo hóa đơn");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Tạo hóa đơn mới lấy mã hóa đơn
            string shd = txt_soHD.Text;
            string sqlThem = "Insert Into HOADON (SoHD, NgayLap, MaNV) Values('" + shd + "', '" + txt_ngayLap.Text + "' , '" + cbb_tenNV.SelectedValue.ToString() + "')";
            int kq = 1; // = ldc.ExcutedNonQuery(sqlThem);
            if (kq >= 1)
            {
                this.addHoaDonToDatabase(shd);
                //Thao tác in hóa đơn ở đây
                MessageBox.Show("Thêm thành công");
            }
            else
            {
                MessageBox.Show("Không thể tạo hóa đơn");
            }
        }
    }
}
