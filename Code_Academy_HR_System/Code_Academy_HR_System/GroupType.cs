using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Academy_HR_System
{
    class GroupType
    {
        private static int ID;
        public string Type { get; set; }
        public float Price { get; internal set; }

        public GroupType(string type, float price) {
            ID++;
            Type = type;
            Price = price;
        }
    }
}
