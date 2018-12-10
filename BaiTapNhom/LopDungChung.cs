using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BaiTapNhom
{
    class LopDungChung
    {
        string chuoiketnoi = @"Data Source=DESKTOP-F0HK0I7;Initial Catalog=QLBanSach;Integrated Security=True;Pooling=False";
        SqlConnection con;

        public LopDungChung()
        {
            con = new SqlConnection(chuoiketnoi);
        }

        public DataTable layBang(String sql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(dt);
            return dt;
        }

        public int ExcutedNonQuery(String sql)
        {
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            int kq = cmd.ExecuteNonQuery();
            con.Close();
            return kq;
        }

        public SqlDataReader ExcutedRender(String sql)
        {
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        //public int ExcutedScalar(String sql)
        //{
        //    SqlCommand cmd = new SqlCommand(sql, con);
        //    con.Open();
        //    var kq = cmd.ExecuteScalar();
        //    con.Close();
        //    //return kq;
        //}
    }
}
