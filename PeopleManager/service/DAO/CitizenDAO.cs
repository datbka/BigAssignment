using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PeopleManager.objectclass;
using PeopleManager.service;
using System.Data;
using System.Data.Sql;

namespace PeopleManager.service.DAO
{
 public   class CitizenDAO
    {
        SqlService sql;
        string table = "Citizen";
        public CitizenDAO()
        {
            sql = new SqlService();
        }
        
        public bool InsertCitizen(Citizen citizen,int iddatabase =-1)
        {
            if (iddatabase < 0) iddatabase = MaxId();
            int gender = citizen.Gender1 == Citizen.Gender.MALE ? 1 : 0;
            sql.InsertRow(table, new string[] { $"N'{citizen.Name}'", $"N'{citizen.Nickname}'", $"{gender}",$"'{citizen.Idcitizen}'", $"'{citizen.DoB1.ToString("yyyy-MM-dd")}'", $"N'{citizen.Bornplace}'",
                $"N'{citizen.Ethnic}'",$"N'{citizen.Address}'",$"N'{citizen.Job}'",$"N'{citizen.Jobplace}'",$"N'{citizen.Owerfamily}'",$"N'{citizen.Relationshipwithower}'",
                $"N'{citizen.Status}'",$"'{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}'",iddatabase.ToString() });
            return true;
        }
        public bool Exist(string CMND)
        {
          var res =  sql.GetTable($"SELECT CMND FROM {table} where CMND='{CMND}'");
            return res.Rows.Count > 0;
        }
        public int MinCMND()
        {
            string query = $"SELECT CMND FROM {table}";
            var res = sql.GetTable(query);
            int max = res.Rows.Count;
            int min = 0;
            for(int i = 0; i < max; i++)
            {
                
                int tmp = Convert.ToInt32( res.Rows[i][0]);
                min = min > tmp ? tmp : min;
            }
            if (min >= 0) min =0;
            min--;
            return min;
        }
        public int MaxId()
        {
            string query = $"SELECT id FROM {table}";
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
        public bool UpdateStatus(string id, string newstatus)
        {
            var res = sql.Query($"UPDATE Citizen SET status =N'{newstatus}' WHERE id = {id}");
            return res > 0;
           
        }
        public bool IsValidUpdateCMND(string cmnd,string id)
        {
            var table = sql.GetTable($"select * from Citizen where id !={id} and CMND ='{cmnd}'");
            return table.Rows.Count == 0;
        }
        public bool RemoveCitizen(string id)
        {
            var res = sql.Query("Delete from  Citizen where id =" + id);
            return res >0;
        }
        public bool ExistCMND(string id)
        {
            var res = sql.GetTable("select CMND from Citizen where id =" + id);
            
            return !string.IsNullOrEmpty(res.Rows[0][0].ToString());
        }
        public bool Leave(string id,string des, string note, string expired,string update)
        {
            if (!UpdateStatus(id, Citizen.Dstatus[Citizen.Estatus.LEAVE])) return false;
            try
            {
                LeaveDAO.Instance.Insert(id, des, note, expired, update);
                return true;
            }
            catch
            {
                return false;

            }
        }
        public void Updated(string id,string updated ="")
        {
            if (string.IsNullOrEmpty(updated)) updated = DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss");
            sql.Query($"UPDATE Citizen SET Updated =N'{updated}' WHERE id = {id}");
        }
    }
}
