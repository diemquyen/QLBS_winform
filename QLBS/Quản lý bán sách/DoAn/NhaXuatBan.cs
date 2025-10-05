using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DoAn
{
    class NhaXuatBan
    {
        Database db;
        public NhaXuatBan()
        {
            db = new Database();
        }
        public DataTable LayDSNXB()
        {
            return db.Execute("select * from NHAXUATBAN");
        }
        public void ThemNXB(string ma, string ten, string diachi, string sdt)
        {
            string sql = string.Format("Insert into NHAXUATBAN values('{0}',N'{1}',N'{2}','{3}')", ma, ten, diachi, sdt);
            db.ExecuteNonQuery(sql);
        }
        public void XoaNXB(string index_dg)
        {
            string sql = "delete from NHAXUATBAN where ID="+index_dg;
            db.ExecuteNonQuery(sql);
        }
        public void CapnhapNXB(string index_dg, string ma,string ten,string diachi,string sdt)
        {
            string str = string.Format("update NHAXUATBAN set Manxb='{0}',Tennxb=N'{1}',Diachi=N'{2}',SDT='{3}' where ID={4}", ma, ten, diachi, sdt, index_dg);
            db.ExecuteNonQuery(str);
        }
    }
}
