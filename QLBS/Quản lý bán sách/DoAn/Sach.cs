using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DoAn
{
    class Sach
    {
        Database db;
        public Sach()
        {
            db = new Database();
        }
        public DataTable LayDS()
        {
            return db.Execute("SELECT * FROM SACH");
        }
        public void Them(string masach, string tensach, string manxb, int giaban, string hinhanh)
        {
            string sql = string.Format("Insert into SACH values('{0}',N'{1}','{2}',{3},'{4}')", masach, tensach, manxb,giaban,hinhanh);
            db.ExecuteNonQuery(sql);
        }
        public void Xoa(string index)
        {
            string sql = "delete from SACH where ID=" + index;
            db.ExecuteNonQuery(sql);
        }
        public void Capnhap(string index, string masach, string tensach, string manxb, int giaban, string hinhanh)
        {
            string str = string.Format("update SACH set Masach='{0}',Tensach=N'{1}',Manxb='{2}',Giaban={3},Hinhanh='{4}' where ID={5}", masach, tensach, manxb, giaban, hinhanh, index);
            db.ExecuteNonQuery(str);
        }
        public DataTable LayDSManxb()
        {
            return db.Execute("SELECT Manxb FROM NHAXUATBAN");
        }
    }
}
