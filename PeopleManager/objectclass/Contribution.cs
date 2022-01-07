using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleManager.objectclass
{
    class Contribution
    {
        private string value;
        private string updated;
        private string idfund;
        private string idcitizen;
        private string idfamily;
        private string id;

        public Contribution(string value, string updated, string idfund, string idcitizen, string idfamily, string id)
        {
            this.value = value;
            this.updated = updated;
            this.idfund = idfund;
            this.idcitizen = idcitizen;
            this.idfamily = idfamily;
            this.id = id;
        }

        public string Value { get => value; set => this.value = value; }
        public string Updated { get => updated; set => updated = value; }
        public string Idfund { get => idfund; set => idfund = value; }
        public string Idcitizen { get => idcitizen; set => idcitizen = value; }
        public string Idfamily { get => idfamily; set => idfamily = value; }
        public string Id { get => id; set => id = value; }
    }
}
