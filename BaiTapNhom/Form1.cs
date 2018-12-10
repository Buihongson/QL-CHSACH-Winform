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
    public partial class Form1 : Form
    {

        LopDungChung ldc = new LopDungChung();
        string UID = frmDangNhap.ID_TaiKhoan;
        List<string> listQuyen = null;

        public Form1()
        {
            InitializeComponent();
        }

        #region methods lay quyen id

        private string Quyen_ID()
        {
            string id = "";

            // cau lenh sql
            string sqlGetQuyenId = "SELECT * FROM TAIKHOAN_QUYEN WHERE TaiKhoan_ID = '" + UID + "'";
            // tra ve 1 datatable
            DataTable dt = ldc.layBang(sqlGetQuyenId);

            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["TrangThai"].ToString() == "False")
                    {
                        id = dr["Quyen_ID"].ToString();
                    }
                }
            }

            return id;
        }

        #endregion

        #region tao list luu ma quyen

        private List<string> List_Quyen()
        {
            string quyenID = Quyen_ID();
            List<string> termList = new List<string>();

            //cau lenh sql
            string sqlGetMaQuyen = "SELECT * FROM CHITIETQUYEN WHERE Quyen_ID = '" + quyenID + "'";
            // tra ve 1 datatable
            DataTable dt = ldc.layBang(sqlGetMaQuyen);

            if (dt != null)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    termList.Add(dr["MaChucNang"].ToString());
                }
            }

            return termList;
        }

        #endregion

        #region ham check quyen

        private Boolean checkQuyen(string code)
        {
            Boolean check = false;
            foreach (string item in listQuyen)
            {
                if (item == code)
                {
                    check = true;
                    break;
                }
                else
                {
                    check = false;
                }
            }
            return check;
        }

        #endregion

        #region tao MDIparten

        // kiem tra da co form nao trong form cha chua
        private bool CheckExistForm(string name)
        {
            bool check = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }

        // hien thi form da co, khong phai tao form moi
        private void ActiveChildform(string name)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    frm.Activate();
                    break;
                }
            }
        }

        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            listQuyen = List_Quyen();
        }

        private void sáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frmQLSach"))
            {
                if (checkQuyen("QLS_A               ") == true || checkQuyen("QLS_TK              ") == true)
                {
                    frmQLSach sach = new frmQLSach();
                    sach.MdiParent = this;
                    sach.Show();
                }
                else
                {
                    MessageBox.Show("Bạn không có quyền truy cập vào chức năng.");
                }
            }
            else
            {
                ActiveChildform("frmQLSach");
            }
        }

        private void nhậpSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frmNhanVien"))
            {
                if (checkQuyen("QLTTNV              ") == true)
                {
                    frmNhanVien nv = new frmNhanVien();
                    nv.MdiParent = this;
                    nv.Show();
                }
                else
                {
                    MessageBox.Show("Bạn không có quyền truy cập vào chức năng.");
                }
            }
            else
            {
                ActiveChildform("frmNhanVien");
            }
        }

        private void inHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nhậpSáchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frmNhaXB"))
            {
                if (checkQuyen("QLNXB_A             ") == true || checkQuyen("QLNXB_TK            ") == true)
                {
                    frmNhaXB nxb = new frmNhaXB();
                    nxb.MdiParent = this;
                    nxb.Show();
                }
                else
                {
                    MessageBox.Show("Bạn không có quyền truy cập vào chức năng.");
                }
            }
            else
            {
                ActiveChildform("frmNhaXB");
            }
        }

        private void nhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frmNhaCC"))
            {
                if (checkQuyen("QLNCC_A             ") == true || checkQuyen("QLNCC_TK            ") == true)
                {
                    frmNhaCC ncc = new frmNhaCC();
                    ncc.MdiParent = this;
                    ncc.Show();
                }
                else
                {
                    MessageBox.Show("Bạn không có quyền truy cập vào chức năng.");
                }
            }
            else
            {
                ActiveChildform("frmNhaCC");
            }
        }

        private void tínhTiềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frmBanSach"))
            {
                if (checkQuyen("TT_A                ") == true || checkQuyen("TT_BH               ") == true)
                {
                    frmBanSach bs = new frmBanSach();
                    bs.MdiParent = this;
                    bs.Show();
                }
                else
                {
                    MessageBox.Show("Bạn không có quyền truy cập vào chức năng.");
                }
            }
            else
            {
                ActiveChildform("frmBanSach");
            }
        }

        private void thôngTinToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void sáchToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frmTimKiemSach"))
            {
                frmTimKiemSach tks = new frmTimKiemSach();
                tks.MdiParent = this;
                tks.Show();
            }
            else
            {
                ActiveChildform("frmTimKiemSach");
            }
        }

        private void nhàXuấtBảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frmTimKiemNXB"))
            {
                frmTimKiemNXB tknxb = new frmTimKiemNXB();
                tknxb.MdiParent = this;
                tknxb.Show();
            }
            else
            {
                ActiveChildform("frmTimKiemNXB");
            }
        }

        private void nhàCungCấpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frmTimKiemNCC"))
            {
                frmTimKiemNCC tkncc = new frmTimKiemNCC();
                tkncc.MdiParent = this;
                tkncc.Show();
            }
            else
            {
                ActiveChildform("frmTimKiemNCC");
            }
        }

        private void sáchTrongKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frmKhachHang"))
            {
                if (checkQuyen("QLTTKH_A            ") == true || checkQuyen("QLTTKH_BH           ") == true)
                {
                    frmKhachHang kh = new frmKhachHang();
                    kh.MdiParent = this;
                    kh.Show();
                }
                else
                {
                    MessageBox.Show("Bạn không có quyền truy cập vào chức năng.");
                }
            }
            else
            {
                ActiveChildform("frmKhachHang");
            }
        }

        private void phiếuNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frmPhieuNhap"))
            {
                if (checkQuyen("QLPN_A              ") == true || checkQuyen("QLPN_TK             ") == true)
                {
                    frmPhieuNhap phieuNhap = new frmPhieuNhap();
                    phieuNhap.MdiParent = this;
                    phieuNhap.Show();
                }
                else
                {
                    MessageBox.Show("Bạn không có quyền truy cập vào chức năng.");
                }
            }
            else
            {
                ActiveChildform("frmPhieuNhap");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
