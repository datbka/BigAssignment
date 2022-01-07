using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleManager.objectclass
{
    class User
    {
        private string username;
        private string password;
        private TypeUser type;
        public User(string username)
        {
            this.username = username;
        }
        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
        public User(string username, TypeUser type)
        {
            this.username = username;
            this.type = type;
        }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        internal TypeUser Type { get => type; set => type = value; }

        public enum TypeUser
        {
            CHIEF,
            DEPUTY,
            OFFICER_ADMIN,
            OFFICER_ACCOUNTANT
        }
        public static Dictionary<TypeUser, string> DType = new Dictionary<TypeUser, string>
        {
            {TypeUser.CHIEF,"tổ trưởng" },
             {TypeUser.DEPUTY,"tổ phó" },
              {TypeUser.OFFICER_ADMIN,"cán bộ hành chính" },
               {TypeUser.OFFICER_ACCOUNTANT,"cán bộ kế toán" },
        };
    }
}
