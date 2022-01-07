using PeopleManager.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeopleManager.objectclass
{
    public class Citizen
    {
        public enum Gender
        {
            MALE,
            FEMALE
        }
        private string name;
        private DateTime DoB;
        private Gender gender;
        private string nickname;
        private string bornplace;
        private string ethnic;
        private string job;
        private string jobplace;
        private string idcitizen;
        private string address;
        private string owerfamily;
        private string relationshipwithower;
        private string status;
        private string iddatabase;
        private string updated;
        public Citizen()
        {

        }
        public Citizen(string name, DateTime doB, Gender gender, string nickname, string bornplace, string ethnic, string job, string jobplace, string idcitizen, string address, string owerfamily, string relationshipwithower, string status)
        {
            this.name = name;
            DoB = doB;
            this.gender = gender;
            this.nickname = nickname;
            this.bornplace = bornplace;
            this.ethnic = ethnic;
            this.job = job;
            this.jobplace = jobplace;
            this.idcitizen = idcitizen;
            this.address = address;
            this.owerfamily = owerfamily;
            this.relationshipwithower = relationshipwithower;
            this.status = status;
        }

        public string Name { get => name; set => name = value; }
        public DateTime DoB1 { get => DoB; set => DoB = value; }
        internal Gender Gender1 { get => gender; set => gender = value; }
        public string Nickname { get => nickname; set => nickname = value; }
        public string Bornplace { get => bornplace; set => bornplace = value; }
        public string Ethnic { get => ethnic; set => ethnic = value; }
        public string Job { get => job; set => job = value; }
        public string Jobplace { get => jobplace; set => jobplace = value; }
        public string Idcitizen { get => idcitizen; set => idcitizen = value; }
        public string Owerfamily { get => owerfamily; set => owerfamily = value; }
        public string Relationshipwithower { get => relationshipwithower; set => relationshipwithower = value; }
        public string Status { get => status; set => status = value; }
        public string Address { get => address; set => address = value; }
        public string Iddatabase { get => iddatabase; set => iddatabase = value; }
        public string Updated { get => updated; set => updated = value; }

        public enum Estatus
        {
            NEW,
            ALIVE,
            DIE,
            LEAVE,
            STAY,
            EXPIRED_LEAVE,
            EXPIRED_STAY
        }
        public static Dictionary<Estatus, string> Dstatus = new Dictionary<Estatus, string>()
        {
             {Estatus.NEW,"mới sinh" },
            { Estatus.ALIVE,"sinh sống"},
            {Estatus.DIE,"đã qua đời" },
            {Estatus.LEAVE,"tạm vắng" },
            {Estatus.STAY,"tạm trú" },
            {Estatus.EXPIRED_LEAVE,"quá hạn tạm vắng" },
            {Estatus.EXPIRED_STAY,"quá hạn tạm trú" }
        };
    }
}
