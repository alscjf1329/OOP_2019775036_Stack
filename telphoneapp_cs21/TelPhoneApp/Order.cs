using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelPhoneApp {
    public class Order {
        private static int cnt = 0;
 
        public int OrderNum { get; private set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int cost { get; set; }

        public Order(string n = "", string p = "", string a = "",int c=0)
        {
            OrderNum = ++cnt;
            Name = n;
            Phone = p;
            Address = a;
            cost = c;
        }
        public override string ToString() {
            return $"{OrderNum} | Name: {Name}, Phone: {Phone}";
        }
    }
}
