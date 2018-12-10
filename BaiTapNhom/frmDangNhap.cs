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
    public partial class frmDangNhap : Form
    {
        LopDungChung ldc = new LopDungChung();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        public static string ID_TaiKhoan = "";

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            ID_TaiKhoan = getID();
            if(ID_TaiKhoan != null)
            {
                Form1 frm = new Form1();
                frm.Show();
                this.Hide();
            }
        }

        private string getID()
        {
            string id = "";

            // cau lech sql lay ten dang nhap va mat khau
            string sqlGetID = "SELECT * FROM TAIKHOAN WHERE TenDangNhap = '" + txt_TaiKhoan.Text + "' AND MatKhau = '" + txt_MatKhau.Text + "'";
            // tra ve 1 datatable
            DataTable dt = ldc.layBang(sqlGetID);

            if(dt != null)
            {
                foreach(DataRow dr in dt.Rows)
                {
                    id = dr["TaiKhoan_ID"].ToString();
                }
            }

            return id;
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            AcceptButton = btn_DangNhap;
            CancelButton = btn_Thoat;
            this.CenterToScreen();
        }

    }
}
