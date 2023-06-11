using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelPhoneApp
{
    public partial class MainForm : Form
    {
        Orders oList = new Orders();
        public MainForm()
        {
            InitializeComponent();
        }
        private void UpdateDisplay(Orders lt)
        {
            int sum = 0;
            lbDisplay.Items.Clear();
            for (int i = 0; i < lt.Count; ++i)
            {
                lbDisplay.Items.Add(lt[i].ToString());
            }
            for (int i = 0; i < oList.Count; ++i)
            {
                sum += oList[i].Cost;
            }
            sum_box.Text = sum.ToString() + "\\";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtPhone.Text != "" && txtAddress.Text != "" && int.TryParse(txtCost.Text, out _))
            {
                Order o = new Order(txtName.Text, txtPhone.Text, txtAddress.Text, int.Parse(txtCost.Text));
                oList.Add(o);

                txtName.Text = "";
                txtPhone.Text = "";
                txtAddress.Text = "";
                txtCost.Text = "";
                txtName.Focus();
                UpdateDisplay(oList);
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name = txtSearch.Text;
            if (name == "")
                return;
            int nameSum = 0;
            namesum_groupbox.Text = name + "의 총 매출액";
            for (int i = 0; i < oList.Count; i++)
            {
                if (name == oList[i].Name) nameSum += oList[i].Cost;
            }
            namesum_box.Text = nameSum.ToString() + "\\";
            txtSearch.Text = "";
            txtSearch.Focus();

            Orders tlist = new Orders();
            for (int i = 0; i < oList.Count; ++i)
            {
                if (oList[i].Name == name) tlist.Add(oList[i]);
            }

            UpdateDisplay(tlist);
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            string on = txtRemove.Text;
            if (on == "" || !int.TryParse(on, out _)) return;
            txtRemove.Text = "";
            txtRemove.Focus();

            for (int i = 0; i < oList.Count; ++i)
                if (oList[i].OrderNum == int.Parse(on))
                {
                    oList.Remove(i);
                }
            UpdateDisplay(oList);
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
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

        private void btnBill_Click(object sender, EventArgs e)
        {
            DateTime localTime = DateTime.Now;
            string fileName = localTime.ToString("yyyyMMdd_HHmmss") + ".txt"; // 파일 이름을 현재 시간으로 생성

            // 텍스트 파일 경로
            string directoryPath = Path.GetDirectoryName(Application.StartupPath);
            directoryPath = Path.GetDirectoryName(directoryPath);
            directoryPath = Path.Combine(directoryPath, "bill");
            string filePath = Path.Combine(directoryPath, fileName);

            string inputText = "";
            for (int i = 0; i < lbDisplay.Items.Count; i++)
            {
                inputText += lbDisplay.Items[i].ToString() + "\n";
            }
            txtName.Text = inputText;
            try
            {
                // 텍스트 파일 생성 및 텍스트 입력
                File.WriteAllText(filePath, inputText);

                MessageBox.Show("파일이 저장되었습니다.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("오류가 발생했습니다: " + ex.Message);
            }
        }

        private void txtRemove_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
