using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleManager.service.DAO
{
    class StayDAO
    {
        private static StayDAO instance;

        public static StayDAO Instance
        {
            get
            {
                if (instance == null) instance = new StayDAO(); return StayDAO.instance;

            }
            set => instance = value;
        }

        public int GetNewID()
        {
            SqlService sql = new SqlService();
            var res = sql.GetTable("select id from Stay");

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
        public void Insert(string idcitizen, string des, string note, string expired, string update)
        {
            SqlService sql = new SqlService();

            sql.InsertRow("Stay", new string[] { $"{idcitizen}", $"N'{des}'", $"N'{note}'", $"'{expired}'", $"'{update}'", GetNewID().ToString() });
        }
        public bool Remove(string id,string idCitizen)
        {
            SqlService sql = new SqlService();
            var res = sql.Query("Delete from  Citizen where id =" + idCitizen);
            if (res == 0) return false;
          var res1=  sql.Query("Delete from  Stay where id =" + id);
            return res1 > 0;
        }
    }
}
