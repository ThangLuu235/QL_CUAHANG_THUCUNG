using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace QL_CUAHANG_THUCUNG
{
    class KNCSDL
    {
        SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-5LV03LQ\\SQLEXPRESS;Initial Catalog=QLTHUCUNG;Integrated Security=True");
       
        ///*===============================LOAD DỮ LIỆU================================*/


        //Load Hóa Đơn và CTHD
       
        ////Load Nhan Vien

        //Load KhachHang

        //// Load loai thú cưng
        //public DataTable loadLoaiTC()
        //{
        //    string caulenh = "select * from LOAITHUCUNG";
        //    da_KhachHang = new SqlDataAdapter(caulenh, cnn);
        //    da_KhachHang.Fill(dt_QLThuCung, "LOAITHUCUNG");
        //    DataColumn[] keys = new DataColumn[1];
        //    keys[0] = dt_QLThuCung.Tables["LOAITHUCUNG"].Columns[0];
        //    dt_QLThuCung.Tables["LOAITHUCUNG"].PrimaryKey = keys;
        //    return dt_QLThuCung.Tables["LOAITHUCUNG"];
        //}

        /*=============================== HÀM XỬ LÝ ================================*/
        //public bool ktraDangNhap(string tk, string mk)
        //{
        //    foreach (DataRow r in dt_QLThuCung.Tables["TAIKHOAN"].Rows)
        //    {
        //        if (r["EMAIL"].ToString() == tk && r["MATKHAU"].ToString() == mk)
        //        {
        //            QUYEN.loaiQuyen = r["QUYENHAN"].ToString();
        //            QUYEN.tk = r["USERNAME"].ToString();
        //            QUYEN.mk = r["MATKHAU"].ToString();
        //            return true;
        //        }

        //    }
        //    return false;
        //}



        // Thủ tục cập nhật THANHTIEN trên bảng hóa đơn dựa vào bảng CHITIETHD
        //Làm cái này để cập nhật thành tiền rồi mới in ra tổng doanh thu
        

        //Tìm kiếm Thú Cưng theo Mã Loại
        //public DataTable TimThuCung(string maloai)
        //{
        //    DataTable a = new DataTable();
        //    SqlDataAdapter tk = new SqlDataAdapter("EXEC TENTC_ML '" + maloai + "'", cnn);
        //    tk.Fill(a);
        //    return a;
        //}

        //xuat thong tin nv dang dang nhap vao
        

        //public DataTable themNV(string MANV, string TENNV, string MATK, DateTime NGSINH, string SDT, string DIACHI, float LUONG)
        //{
        //    DataTable a = new DataTable();
        //    string cauLenh = "EXEC NHANVIEN '" + MANV + "','" + TENNV + "','" + MATK + "','" + NGSINH + "','" + SDT + "','" + DIACHI + "','" + LUONG + "'";
        //    SqlDataAdapter b = new SqlDataAdapter(cauLenh, cnn);
        //    b.Fill(a);
        //    return a;

        //}

        


    }
}
