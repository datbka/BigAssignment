using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PeopleManager.service;
using PeopleManager.objectclass;

namespace PeopleManager.service.DAO
{
    class FamilyDAO
    {

        SqlService sql;
        public FamilyDAO()
        {
            this.sql = new SqlService();
        }

    
        public string GetMember(string idfamily)
        {
            var res = sql.GetTable($"select count(*) from Citizen where idfamily =N'{idfamily}'");
            return res.Rows[0][0].ToString();
        }
        public bool Exist(string idfamily)
        {
            var res = sql.GetTable($"select * from Citizen where idfamily =N'{idfamily}'");
            return res.Rows.Count>0;
        }
        public List<Citizen> GetListMembers(string idfamily)
        {
            var table = sql.GetTable($"SELECT * FROM Citizen WHERE idfamily =N'{idfamily}'");
            int max = table.Rows.Count;
            
            List<Citizen> res = new List<Citizen>();
            for(int i = 0; i < max; i++)
            {
                var row = table.Rows[i];
                if (string.Compare(row[11].ToString(), "chủ hộ") == 0) continue;
                var temp = new Citizen();
                temp.Name = row[0].ToString();
                temp.Nickname = row[1].ToString();
                temp.Gender1 = Convert.ToBoolean(row[2])?Citizen.Gender.MALE: Citizen.Gender.FEMALE;
                temp.Idcitizen = row[3].ToString();
                temp.DoB1 = Convert.ToDateTime(row[4]);
                temp.Bornplace = row[5].ToString();
                temp.Ethnic = row[6].ToString();
                temp.Address = row[7].ToString();
                temp.Job = row[8].ToString();
                temp.Jobplace = row[9].ToString();
                temp.Owerfamily = row[10].ToString();
                temp.Relationshipwithower = row[11].ToString();
                temp.Status = row[12].ToString();
               
                temp.Iddatabase = row[14].ToString();
                res.Add(temp);
            }
            return res;
        }
        public List<Citizen> GetAllMembers(string idfamily)
        {
            var table = sql.GetTable($"SELECT * FROM Citizen WHERE idfamily =N'{idfamily}'");
            int max = table.Rows.Count;

            List<Citizen> res = new List<Citizen>();
            for (int i = 0; i < max; i++)
            {
                
                var row = table.Rows[i];
                
                var temp = new Citizen();
                temp.Name = row[0].ToString();
                temp.Nickname = row[1].ToString();
                temp.Gender1 = Convert.ToBoolean(row[2]) ? Citizen.Gender.MALE : Citizen.Gender.FEMALE;
                temp.Idcitizen = row[3].ToString();
                temp.DoB1 = Convert.ToDateTime(row[4]);
                temp.Bornplace = row[5].ToString();
                temp.Ethnic = row[6].ToString();
                temp.Address = row[7].ToString();
                temp.Job = row[8].ToString();
                temp.Jobplace = row[9].ToString();
                temp.Owerfamily = row[10].ToString();
                temp.Relationshipwithower = row[11].ToString();
                temp.Status = row[12].ToString();

                temp.Iddatabase = row[14].ToString();
                res.Add(temp);
            }
            return res;
        }
        public bool AlterFamily(string idcitizen,string newfamily)
        {
            var res = sql.Query($"UPDATE Citizen SET relationshipowner =N'chủ hộ',idfamily =N'{newfamily}' WHERE id = {idcitizen}");
            return res > 0;
        }
        public string GetOwnerFamily(string idfamily)
        {
            var res = sql.GetTable($"Select id From Citizen Where relationshipowner =N'chủ hộ' and idfamily =N'{idfamily}'");
            if (res.Rows.Count > 0)
                return res.Rows[0][0].ToString();
            else return "";
        }
        public bool AlterNewRelationship(string idcitizen,string newrelationship)
        {
           
            var resupdate = sql.Query($"UPDATE Citizen SET relationshipowner =N'{newrelationship}' WHERE id = {idcitizen}");
           return resupdate >0;
        }
        public bool RemoveFamily(string idfamily)
        {

            var resupdate = sql.Query($"DELETE FROM Citizen WHERE idfamily = N'{idfamily}'");
            return resupdate > 0;
        }
    }
}
