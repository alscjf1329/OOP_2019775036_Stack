using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelPhoneApp {
    public class Orders {
        List<Order> oderList = new List<Order>();
        public void Add(Order oarr) {
            oderList.Add(oarr);
        }
        public void AddRange(Order[] oarr) {
            oderList.AddRange(oarr);
        }
        public void Remove(int idx) {
            oderList.RemoveAt(idx);
        }
        public Order this[int idx] {
            get { return oderList[idx]; }
        }
        public int Count {
            get { return oderList.Count; }
        }
    }
}
