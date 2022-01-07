using PeopleManager.objectclass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleManager.service.DAO
{
    class ContributionDAO
    {

        private static ContributionDAO instance;

        public static ContributionDAO Instance
        {
            get
            {
                if (instance == null) instance = new ContributionDAO(); return ContributionDAO.instance;
            }
            set => instance = value;
        }
        public int MinIDFamily()
        {
            SqlService sql = new SqlService();
            string query = $"SELECT id FROM FamilyContribution";
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
        public int MinIDPerson()
        {
            SqlService sql = new SqlService();
            string query = $"SELECT MAX(id) FROM PersonContribution";
            var res = sql.GetTable(query);
            int maxid =1;
            if(!string.IsNullOrEmpty(res.Rows[0][0].ToString()))
            maxid= Convert.ToInt32(res.Rows[0][0].ToString()) + 1;

            return maxid;
        }
        string GetValue(Contribution contribution)
        {
            SqlService sql = new SqlService();
            var table = sql.GetTable($"select Contribution.Value from Contribution where idfamily ='HK02' and id = {contribution.Id}");
            return "";
        }
        public bool FamilyInsert(Contribution contribution,bool required =true)
        {
            SqlService sql = new SqlService();
            
           
            sql.InsertRow("FamilyContribution", new string[] {$"{contribution.Value}", $"N'{contribution.Updated}'", $"{contribution.Idfund}", $"N'{contribution.Idfamily}'",
            MinIDFamily().ToString()});
            
            return true;
        }
        public bool PersonInsert(Contribution contribution, bool required = true)
        {
            SqlService sql = new SqlService();


            sql.InsertRow("PersonContribution", new string[] {$"{contribution.Value}", $"N'{contribution.Updated}'", $"{contribution.Idfund}", $"{contribution.Idcitizen}",
            MinIDPerson().ToString()});

            return true;
        }
    }
}
