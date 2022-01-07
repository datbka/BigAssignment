using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleManager.objectclass
{
    class Family
    {
        private string id;
        private string owner;
        private string address;
        private int amountmember;

        public string Id { get => id; set => id = value; }
        public string Owner { get => owner; set => owner = value; }
        public string Address { get => address; set => address = value; }
        public int Amountmember { get => amountmember; set => amountmember = value; }
    }
}
