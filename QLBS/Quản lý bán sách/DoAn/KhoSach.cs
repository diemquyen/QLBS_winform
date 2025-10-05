using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DoAn
{
    class KhoSach
    {
        Database db;
        public KhoSach()
        {
            db = new Database();
        }
        public DataTable LayDS()
        {
            return db.Execute("SELECT * FROM KHO");
        }
        public void Them(string masach, int soluong, string ngaynhap)
        {
            string sql = string.Format("Insert into KHO values('{0}',{1},'{2}')",masach,soluong,ngaynhap);
            db.ExecuteNonQuery(sql);
        }
        public void Xoa(string index)
        {
            string sql= "delete from KHO where Mahd=" + index;
            db.ExecuteNonQuery(sql);
        }
        public void Capnhap(string index, string masach, int soluong, string ngaynhap)
        {
            string str = string.Format("update KHO set Masach='{0}',Soluong={1},Ngaynhap='{2}' where Mahd={3}", masach, soluong, ngaynhap,index);
            db.ExecuteNonQuery(str);
        }
        public DataTable LayDSMaSach()
        {
            return db.Execute("select * from SACH");
        }
    }
}
