using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PeopleManager.objectclass;
namespace PeopleManager.service.DAO
{
    class FundDAO
    {
        private static FundDAO instance;

        public static FundDAO Instance 
        { 
            get 
            {
                if (instance == null) instance = new FundDAO(); return FundDAO.instance;
            } 
            set => instance = value; 
        }
        public int MinID()
        {
            SqlService sql = new SqlService();
            string query = $"SELECT id FROM FundTable";
            var res = sql.GetTable(query);
            int max = res.Rows.Count;
            int maxid = -1;
            for (int i = 0; i < max; i++)
            {

                int tmp = Convert.ToInt32(res.Rows[i][0]);
                maxid = maxid < tmp ? tmp : maxid;
            }
            if (maxid < 0) maxid = 0;
            maxid++;
            return maxid;
        }
        public bool Insert(Fund fund)
        {
            SqlService sql = new SqlService();
            string required = fund.Required ? "1" : "0";
            string forfamily = fund.Forfamily ? "1" : "0";
            sql.InsertRow("FundTable", new string[] {$"N'{fund.Name}'", $"N'{fund.Decript}'", $"{fund.Value}", $"N'{fund.Expired}'", $"{required}",
            $"{forfamily}",$"N'{fund.Updated}'",MinID().ToString()});
            return true;
        }
        public List<Fund> GetListFund()
        {
            SqlService sql = new SqlService();
            var table = sql.GetTable("select * from FundTable");
            int max = table.Rows.Count;
            List<Fund> res = new List<Fund>();
            for(int i = 0; i < max; i++)
            {
                var row = table.Rows[i];
                Fund tmp = new Fund();
                tmp.Name = row[0].ToString();
                tmp.Decript = row[1].ToString();
                tmp.Value =Convert.ToInt32( row[2].ToString());
                tmp.Expired =Convert.ToDateTime( row[3].ToString());
                tmp.Required =Convert.ToBoolean( row[4].ToString());
                tmp.Forfamily =Convert.ToBoolean( row[5].ToString());
                tmp.Iddatabase =Convert.ToInt32( row[7].ToString());
                res.Add(tmp);
            }
            return res;
        }
    }
}
