using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelPhoneApp
{
    public partial class BestDeliveryManForm : Form
    {
        public BestDeliveryManForm(List<Order> oList)
        {
            InitializeComponent();
            oList.Sort();
            for(int i = 0; i < oList.Count; i++)
            {
                costRangking.Rows.Add(i + 1, oList[i].Name,oList[i].Cost) ;
            }
            
        }
        
    }
}
