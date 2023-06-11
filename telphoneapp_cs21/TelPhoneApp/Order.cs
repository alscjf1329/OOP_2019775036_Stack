using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelPhoneApp {
    public class Order : IComparable<Order>
    {
        private static int cnt = 0;
 
        public int OrderNum { get; private set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int Cost { get; set; }
        public Order(string n = "", string p = "", string a = "",int c=0)
        {
            OrderNum = ++cnt;
            Name = n;
            Phone = p;
            Address = a;
            Cost = c;
        }
        public override string ToString() {
            return $"{OrderNum} | Name: {Name}, Phone: {Phone}, Cost: {Cost} ";
        }
        public int CompareTo(Order other)
        {
            if (other == null)
                return 1;

            // Order 객체를 비교하는 논리를 구현합니다.
            // 예를 들어 Cost 값을 기준으로 비교하는 경우:
            return -this.Cost.CompareTo(other.Cost);
        }
    }
}
