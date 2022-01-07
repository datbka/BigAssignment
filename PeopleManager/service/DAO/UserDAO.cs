using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PeopleManager.service;
using PeopleManager.objectclass;

namespace PeopleManager.service.DAO
{
    class UserDAO
    {
        SqlService sql;
        public UserDAO()
        {
            this.sql = new SqlService();
        }
        private static UserDAO instance;

        public static UserDAO Instance { get
            {
                if (instance == null) instance = new UserDAO(); return UserDAO.instance;
            }
            set => instance = value; }

        public bool Exist(string username, string hashpass)
        {
            var table = sql.GetTable($"SELECT * FROM [User] WHERE Username=N'{username}' AND Pass =N'{hashpass}'");
            return table.Rows.Count > 0;
        }
        public User GetUser(string username)
        {
            var table = sql.GetTable($"SELECT * FROM [User] WHERE Username=N'{username}'");
           
            int typeid = Convert.ToInt32(table.Rows[0][3]);
            var tabletype = sql.GetTable($"Select * from UserType where ID ={typeid}");
            string type = tabletype.Rows[0][1].ToString();
            User user = new User(username);
            switch (type.ToLower())
            {
                case ("tổ trưởng"):
                    user.Type = User.TypeUser.CHIEF;
                    break;
                case ("tổ phó"):
                    user.Type = User.TypeUser.DEPUTY;
                    break;
                case ("cán bộ hành chính"):
                    user.Type = User.TypeUser.OFFICER_ADMIN;
                    break;
                case ("cán bộ kế toán"):
                    user.Type = User.TypeUser.OFFICER_ACCOUNTANT;
                    break;
            }
            return user;
        }
    }
}
