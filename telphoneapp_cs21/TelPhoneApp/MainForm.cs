using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelPhoneApp {
    public partial class MainForm : Form {
        Orders oList = new Orders();
        public MainForm() {
            InitializeComponent();
        }
        private void UpdateDisplay(Orders lt) {
            int sum= 0;
            int namesum = 0;
            lbDisplay.Items.Clear();
            for (int i = 0; i < lt.Count; ++i)
            {
                lbDisplay.Items.Add(lt[i].ToString());
                namesum = lt[i].cost;
            }
            for(int i=0; i<oList.Count; ++i)
            {
                sum += oList[i].cost;
            }
            sum_box.Text = sum.ToString() + "\\";
        }
        private void btnAdd_Click(object sender, EventArgs e) {
            if (txtName.Text != "" && txtPhone.Text != "") {
                Order o = new Order(txtName.Text, txtPhone.Text,txtAddress.Text);
                oList.Add(o);

                txtName.Text = "";
                txtPhone.Text = "";
                txtAddress.Text = "";
                txtName.Focus();
                UpdateDisplay(oList);
            }
        }
        private void btnSearch_Click(object sender, EventArgs e) {
            string name = txtSearch.Text;
            if (name == "" )
                return;


            txtSearch.Text = "";
            txtSearch.Focus();

            Orders tlist = new Orders();
            for(int i = 0; i < oList.Count; ++i)
            {
                if (oList[i].Name == name) tlist.Add(oList[i]);
            }
                
            UpdateDisplay(tlist);
        }
        private void btnRemove_Click(object sender, EventArgs e) {
            string phone = txtRemove.Text;
            if (phone == "")
                return;

            txtRemove.Text = "";
            txtRemove.Focus();
                        
            for (int i = 0; i < oList.Count; ++i)
                if (oList[i].Phone == phone) {
                    oList.Remove(i);
                }
            UpdateDisplay(oList);
        }
        private void btnPrint_Click(object sender, EventArgs e) {
            UpdateDisplay(oList);
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
