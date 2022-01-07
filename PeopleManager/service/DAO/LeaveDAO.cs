using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PeopleManager.objectclass;
using PeopleManager.service;

namespace PeopleManager.service.DAO
{
    class LeaveDAO
    {
       
        private static LeaveDAO instance;

        public static LeaveDAO Instance { get {
                if (instance == null) instance = new LeaveDAO(); return LeaveDAO.instance;
            
            } set => instance = value; }

        public int GetNewID()
        {
            SqlService sql = new SqlService();
            var res = sql.GetTable("select id from Leave");
                
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
        public void Insert(string idcitizen,string des,string note, string expired,string update)
        {
            SqlService sql = new SqlService();
            
            sql.InsertRow("Leave", new string[] {$"{idcitizen}",$"N'{des}'",$"N'{note}'",$"'{expired}'",$"'{update}'",GetNewID().ToString() });
        }
        public bool Remove(string idcitizen, string id)
        {
            SqlService sql = new SqlService();
            var delete =sql.Query("DELETE FROM Leave where id ="+id);
            if (delete == 0) return false;
            CitizenDAO citizenDao = new CitizenDAO();
            string newstatus = citizenDao.ExistCMND(idcitizen) ? Citizen.Dstatus[Citizen.Estatus.ALIVE] : Citizen.Dstatus[Citizen.Estatus.NEW];


            if (citizenDao.UpdateStatus(idcitizen, newstatus))
            {
                return true;
            }
            return false;
        }
    }
}
