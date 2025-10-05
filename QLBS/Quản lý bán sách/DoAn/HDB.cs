using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DoAn
{
    class HDB
    {
        Database db;
        public HDB()
        {
            db = new Database();
        }
        public DataTable LayDS()
        {
            return db.Execute("SELECT * FROM HOADONMUA");
        }
        public DataTable GetMS()
        {
            return db.Execute("SELECT * from SACH");
        }
        public void Them(string ngaylap, int masach)
        {
            string sql = string.Format("Insert into KHO values('{0}','{1}')",ngaylap, masach);
            db.ExecuteNonQuery(sql);
        }
        public void Capnhap(string index, string ngaylap, string masach)
        {
            string str = string.Format("update HOADONMUA set Ngaylap='{0}',Masach='{1}' where Mahd={2}", ngaylap, masach,index);
            db.ExecuteNonQuery(str);
        }
        public DataTable get_Date_Report(string sDate)
        {
            string strQuery = "SELECT Mahd,FORMAT(Ngaylap,'dd/MM/yyyy') as Ngaylap ,Masach FROM HOADONMUA WHERE Ngaylap= '" + sDate + "'";
            return db.Execute(strQuery);
        }
    }
}
