using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelPhoneApp {
    public class Orders {
        List<Order> orderList = new List<Order>();
        public void Add(Order oarr) {
            orderList.Add(oarr);
        }
        public void AddRange(Order[] oarr) {
            orderList.AddRange(oarr);
        }
        public void Remove(int idx) {
            orderList.RemoveAt(idx);
        }
        public Order this[int idx] {
            get { return orderList[idx]; }
        }
        public int Count {
            get { return orderList.Count; }
        }
    }
}
