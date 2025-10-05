using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DoAn
{
    
    class MUATHUE
    {
        Database db;
        public MUATHUE()
        {
            db = new Database();
        }
        public DataTable LayDS()
        {
            return db.Execute("select * from SACH");
        }
        public void ThemMua(string sMaSach)
        {
            string NgayHienTai = DateTime.Now.ToString("MM/dd/yyyy");
            string sql = string.Format("Insert into HOADONMUA (Masach,Ngaylap) values('{0}','{1}')", sMaSach, NgayHienTai);
            db.ExecuteNonQuery(sql);
        }
        public void ThemThue(string Masach, string GiaThue, string CMND)
        {
            string sql = string.Format("Insert into CHITIETDONTHUE (Masach,Giathue,CMND) values('{0}',{1},'{2}')", Masach, GiaThue, CMND);
            db.ExecuteNonQuery(sql);
        }
        public void PhieuThue(string cmnd,string ten, string sdt, string diachi, string ngaytra, string ngaymuon, string tinhtrang)
        {
            string sql = string.Format("Insert into DONTHUESACH (CMND,Ten,SDT,Diachi,Ngaytra,Ngaymuon,Tinhtrang) values('{0}',N'{1}','{2}',N'{3}','{4}','{5}',N'{6}')", cmnd, ten, sdt, diachi, ngaytra, ngaymuon, tinhtrang);
            db.ExecuteNonQuery(sql);
        }
        public void CapNhatPhieuThue(string index, string cmnd, string ten, string sdt, string diachi, string ngaytra, string ngaymuon, string tinhtrang)
        {
            string str = string.Format("update DONTHUESACH set CMND='{0}',Ten=N'{1}',SDT='{2}',Diachi=N'{3}',Ngaytra='{4}',Ngaymuon='{5}',Tinhtrang=N'{6}' where ID={7}", cmnd, ten, sdt, diachi, ngaytra, ngaymuon, tinhtrang,index);
            db.ExecuteNonQuery(str);
        }
        public DataTable Tim(string strValue)
        {
            return db.Execute("SELECT* FROM SACH WHERE Masach LIKE '%"+ strValue + "%' OR Tensach LIKE N'%" + strValue + "%' OR Manxb LIKE '%" + strValue + "%'");
        }
        public DataTable LayDanhSachDonThueSach()
        {
            return db.Execute("SELECT [CMND],[Ten],[SDT],[Diachi],[Ngaymuon],[Ngaytra],[Tinhtrang],[ID] FROM DONTHUESACH");
        }
        public DataTable LayDanhSachDonThueSach(string strTenNguoiThue)
        {
            return db.Execute("SELECT [CMND],[Ten],[SDT],[Diachi],[Ngaymuon],[Ngaytra],[Tinhtrang],[ID] FROM DONTHUESACH WHERE Ten LIKE '%" + strTenNguoiThue + "%' OR CMND LIKE N'%" + strTenNguoiThue + "%'");
        }
        public void UpdateThongTinKhachThue(string CMND)
        {
            string sql = string.Format("UPDATE DONTHUESACH SET Tinhtrang = '1' WHERE CMND = '{0}'",CMND);
            db.ExecuteNonQuery(sql);  
        }
    }
}
