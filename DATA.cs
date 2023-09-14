using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace QL_CUAHANG_THUCUNG
{
    public class DATA
    {
        SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-5LV03LQ\SQLEXPRESS;Initial Catalog=QLTHUCUNG;Integrated Security=True");
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        DataSet dt_QLThuCung = new DataSet();
        SqlDataAdapter da_ThuCung;
        SqlDataAdapter da_TaiKhoan;
        SqlDataAdapter da_HoaDon;
        SqlDataAdapter da_NhanVien;
        SqlDataAdapter da_KhachHang;
        SqlDataAdapter da_cntthd;
        string str;


        // NHÂN VIÊN

        
        public bool ThemNV(string MANV, string hoten, string TAIKHOAN, DateTime ngaysinh, string sdt, string diachi, string luong)
        {
            
            try
            {
                cnn.Open();
                string str = string.Format("EXEC THEM '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}'",
                    MANV, hoten, TAIKHOAN, ngaysinh.ToString("yyyy/MM/dd"), sdt, diachi, luong);
                SqlCommand cmd = new SqlCommand(str, cnn);
                cmd.ExecuteNonQuery();
                cnn.Close();
                return true;
            }
            catch
            {
                return false;
            }
            
        }
        public bool XoaNV(string MANV)
        {
            try
            {
                cnn.Open();
                string str = string.Format("EXEC XOANV '{0}'", MANV);
                SqlCommand cmd = new SqlCommand(str, cnn);
                cmd.ExecuteNonQuery();
                cnn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool SuaNV(string MANV, string hoten, string TAIKHOAN, DateTime ngaysinh, string sdt, string diachi, string luong)
        {
            try
            {
                cnn.Open();
                string str = string.Format("EXEC SUANV '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}'",
                    MANV, hoten, TAIKHOAN, ngaysinh.ToString("yyyy/MM/dd"), sdt, diachi, luong);
                SqlCommand cmd = new SqlCommand(str, cnn);
                cmd.ExecuteNonQuery();
                cnn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool TimMaNV(string MANV)
        {
            try
            {
                string str = string.Format("EXEC FINDNV '{0}'", MANV);
                SqlCommand cmd = new SqlCommand(str, cnn);
                da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                
                return true;
            }
            catch
            {
                return false;
            }
        }


        // THÚ CƯNG
        
            
        
        public bool ThemTC(string matc, string tentc, string gia, string chitiet, string trangthai, string maloai)
        {

            try
            {
                cnn.Open();
                string str = string.Format("EXEC THEMTC '{0}', '{1}', '{2}', '{3}', '{4}', '{5}'",
                    matc, tentc, gia, chitiet, trangthai, maloai);
                SqlCommand cmd = new SqlCommand(str, cnn);
                cmd.ExecuteNonQuery();
                cnn.Close();
                return true;
            }
            catch
            {
                return false;
            }

        }
        public bool XoaTC(string MATC)
        {
            try
            {
                cnn.Open();
                string str = string.Format("EXEC XOATC '{0}'", MATC);
                SqlCommand cmd = new SqlCommand(str, cnn);
                cmd.ExecuteNonQuery();
                cnn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool SuaTC(string matc, string tentc, string gia, string chitiet, string trangthai, string maloai)
        {
            try
            {
                cnn.Open();
                string str = string.Format("EXEC SUATC '{0}', '{1}', '{2}', '{3}', '{4}', '{5}'",
                    matc, tentc, gia, chitiet, trangthai, maloai);
                SqlCommand cmd = new SqlCommand(str, cnn);
                cmd.ExecuteNonQuery();
                cnn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool TimMaTC(string MATC)
        {
            try
            {
                string str = string.Format("EXEC FINDTC '{0}'", MATC);
                SqlCommand cmd = new SqlCommand(str, cnn);
                da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                return true;
            }
            catch
            {
                return false;
            }
        }

        // KHÁCH HÀNG

        public bool ThemKH(string makh, string tenkh, string matk, string sdt, string diachi, DateTime ngaysinh, string gioitinh)
        {
            try
            {
                cnn.Open();
                string str = string.Format("EXEC THEMKH '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', {6}",
                    makh, tenkh, matk, sdt, diachi, ngaysinh.ToString("yyyy/MM/dd"), gioitinh);
                SqlCommand cmd = new SqlCommand(str, cnn);
                cmd.ExecuteNonQuery();
                cnn.Close();
                return true;
            }
            catch
            {
                return false;
            }

        }
        public bool XoaKH(string MAKH)
        {
            try
            {
                cnn.Open();
                string str = string.Format("EXEC XOAKH '{0}'", MAKH);
                SqlCommand cmd = new SqlCommand(str, cnn);
                cmd.ExecuteNonQuery();
                cnn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool SuaKH(string makh, string tenkh, string matk, string sdt, string diachi, DateTime ngaysinh, string gioitinh)
        {
            try
            {
                cnn.Open();
                string str = string.Format("EXEC SUAKH '{0}', '{1}', '{2}', '{3}', '{4}', '{5}', {6}",
                    makh, tenkh, matk, sdt, diachi, ngaysinh.ToString("yyyy/MM/dd"), gioitinh);
                SqlCommand cmd = new SqlCommand(str, cnn);
                cmd.ExecuteNonQuery();
                cnn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool TimMaKH(string MAKH)
        {
            try
            {
                string str = string.Format("EXEC FINDKH '{0}'", MAKH);
                SqlCommand cmd = new SqlCommand(str, cnn);
                da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool ktraDangNhap(string tk, string mk)
        {
            foreach (DataRow r in ds.Tables["dbo.TAIKHOAN"].Rows)
            {
                if (r["EMAIL"].ToString() == tk && r["MATKHAU"].ToString() == mk)
                {
                    QUYEN.tk = r["USERNAME"].ToString();
                    QUYEN.mk = r["MATKHAU"].ToString();
                    QUYEN.loaiQuyen = r["QUYENHAN"].ToString();                   
                    return true;
                }

            }
            return false;
        }
        public DataTable LoadKH()
        {
            SqlCommand cmd = new SqlCommand("EXEC HIENTHIKHACHHANG", cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);           
            return dt;
        }
        //Hoa don
        public DataTable loadHoaDon()
        {
            string caulenh = "SELECT * FROM HOADON";
            da_HoaDon = new SqlDataAdapter(caulenh, cnn);
            da_HoaDon.Fill(dt_QLThuCung, "HOADON");
            DataColumn[] keys = new DataColumn[1];
            keys[0] = dt_QLThuCung.Tables["HOADON"].Columns[0];
            dt_QLThuCung.Tables["HOADON"].PrimaryKey = keys;
            return dt_QLThuCung.Tables["HOADON"];
        }
        public bool capNhatThanhTien()
        {
            try
            {
                SqlCommand cm = new SqlCommand("updatettHoaDon", cnn);
                cm.CommandType = CommandType.StoredProcedure;
                cnn.Open();
                cm.ExecuteNonQuery();
                cnn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        //Xóa hóa đơn có dùng thủ tục
        public bool xoaHoaDon(string maHD)
        {
            try
            {
                SqlCommand cm = new SqlCommand("DELHD", cnn);
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.AddWithValue("@MAHD", maHD);
                cnn.Open();
                cm.ExecuteNonQuery();
                cnn.Close();
                return true;
            }
            catch
            {
                return false;
            }

        }
        //Thêm hóa đơn
        public bool themHD(string maHD, string maKH, string maNV, DateTime ngayLap, DateTime ngayGiao, int thanhTien)
        {
            try
            {
                DataRow row = dt_QLThuCung.Tables["HOADON"].NewRow();
                row[0] = maHD;
                row[1] = maKH;
                row[2] = maNV;
                row[3] = ngayLap;
                row[4] = ngayGiao;
                row[5] = thanhTien;
                dt_QLThuCung.Tables["HOADON"].Rows.Add(row);
                return true;
            }
            catch
            {
                return false;
            }
        }
        //Lưu hóa đơn
        public bool Luu()
        {
            try
            {
                da_HoaDon = new SqlDataAdapter("select * from HOADON", cnn);
                SqlCommandBuilder build1 = new SqlCommandBuilder(da_HoaDon);
                da_HoaDon.Update(dt_QLThuCung, "HOADON");
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Hàm nhập vào mã nhân viên và trả về bảng các hóa đơn mà nhân viên đó đã lập
        public DataTable NHANVIENHD(string manv)
        {
            DataTable a = new DataTable();
            string cauLenh = "select * from NHANVIENHD ('" + manv + "')";
            SqlDataAdapter b = new SqlDataAdapter(cauLenh, cnn);
            b.Fill(a);
            return a;

        }
        public DataTable loadTTNV(string tk, string mk)
        {

            string cauLenh = "EXEC THONGTINNV '" + tk + "','" + mk + "'";
            SqlDataAdapter b = new SqlDataAdapter(cauLenh, cnn);
            DataTable a = new DataTable();
            b.Fill(a);
            return a;

        }
    }
}
