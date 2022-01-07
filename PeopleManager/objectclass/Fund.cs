using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleManager.objectclass
{
   public class Fund
    {
        private string name;
        private string decript;
        private int value;
        private DateTime expired;
        private bool required;
        private bool forfamily;
        private string updated;
        private bool iscycle;
        private int iddatabase;
        public Fund() { }
        public Fund(string name, string decript, int value, DateTime expired, bool required, bool forfamily, string updated)
        {
            this.name = name;
            this.decript = decript;
            this.value = value;
            this.expired = expired;
            this.required = required;
            this.forfamily = forfamily;
            this.updated = updated;
           
        }

        public string Name { get => name; set => name = value; }
        public string Decript { get => decript; set => decript = value; }
        public int Value { get => value; set => this.value = value; }
        public DateTime Expired { get => expired; set => expired = value; }
        public bool Required { get => required; set => required = value; }
        public bool Forfamily { get => forfamily; set => forfamily = value; }
        public string Updated { get => updated; set => updated = value; }
        public bool Iscycle { get => iscycle; set => iscycle = value; }
        public int Iddatabase { get => iddatabase; set => iddatabase = value; }
    }
}
