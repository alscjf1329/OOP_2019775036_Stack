using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelPhoneApp {
    public static class Orders {
        //singleton
        private static List<Order> orderList = new List<Order>();
        public static List<Order> getInstance()
        {
            return orderList;
        }
        public static void Add(Order oarr) {
            orderList.Add(oarr);
        }
        public static void AddRange(Order[] oarr) {
            orderList.AddRange(oarr);
        }
        public static void Remove(int idx) {
            orderList.RemoveAt(idx);
        }
        public static int Count {
            get { return orderList.Count; }
        }
        
    }
}
