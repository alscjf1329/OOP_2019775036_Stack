
namespace TelPhoneApp {
    partial class MainForm {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent() {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbDisplay = new System.Windows.Forms.ListBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRemove = new System.Windows.Forms.TextBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.sum_box = new System.Windows.Forms.TextBox();
            this.namesum_groupbox = new System.Windows.Forms.GroupBox();
            this.namesum_box = new System.Windows.Forms.TextBox();
            this.btnBill = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.namesum_groupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtCost);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtAddress);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(217, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 141);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "입력을 위한 창";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "금액 :";
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(85, 101);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(143, 21);
            this.txtCost.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 12);
            this.label5.TabIndex = 3;
            this.label5.Text = "주소 :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(85, 74);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(143, 21);
            this.txtAddress.TabIndex = 2;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(85, 47);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(143, 21);
            this.txtPhone.TabIndex = 1;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "전화 :";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(234, 20);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 102);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "추가";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtName.Location = new System.Drawing.Point(85, 20);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(143, 20);
            this.txtName.TabIndex = 0;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "이름 :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbDisplay);
            this.groupBox2.Location = new System.Drawing.Point(57, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(621, 330);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "출력을 위한 창";
            // 
            // lbDisplay
            // 
            this.lbDisplay.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbDisplay.FormattingEnabled = true;
            this.lbDisplay.ItemHeight = 24;
            this.lbDisplay.Location = new System.Drawing.Point(6, 20);
            this.lbDisplay.Name = "lbDisplay";
            this.lbDisplay.ScrollAlwaysVisible = true;
            this.lbDisplay.Size = new System.Drawing.Size(609, 268);
            this.lbDisplay.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(168, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(48, 21);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(168, 20);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(45, 21);
            this.btnRemove.TabIndex = 1;
            this.btnRemove.Text = "삭제";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtSearch);
            this.groupBox3.Controls.Add(this.btnSearch);
            this.groupBox3.Location = new System.Drawing.Point(564, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(221, 58);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "이름으로 검색";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "이름 :";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(61, 20);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(101, 21);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txtRemove);
            this.groupBox4.Controls.Add(this.btnRemove);
            this.groupBox4.Location = new System.Drawing.Point(564, 98);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(221, 55);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "주문 번호로 삭제";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "주문 번호 :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtRemove
            // 
            this.txtRemove.Location = new System.Drawing.Point(81, 20);
            this.txtRemove.Name = "txtRemove";
            this.txtRemove.Size = new System.Drawing.Size(81, 21);
            this.txtRemove.TabIndex = 0;
            this.txtRemove.TextChanged += new System.EventHandler(this.txtRemove_TextChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPrint.Location = new System.Drawing.Point(684, 159);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(107, 160);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "출력";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.sum_box);
            this.groupBox5.Location = new System.Drawing.Point(57, 495);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(221, 80);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "총 매출액";
            // 
            // sum_box
            // 
            this.sum_box.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sum_box.Location = new System.Drawing.Point(6, 20);
            this.sum_box.Name = "sum_box";
            this.sum_box.Size = new System.Drawing.Size(209, 35);
            this.sum_box.TabIndex = 0;
            this.sum_box.Text = "\\";
            this.sum_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.sum_box.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // namesum_groupbox
            // 
            this.namesum_groupbox.Controls.Add(this.namesum_box);
            this.namesum_groupbox.Location = new System.Drawing.Point(284, 495);
            this.namesum_groupbox.Name = "namesum_groupbox";
            this.namesum_groupbox.Size = new System.Drawing.Size(221, 80);
            this.namesum_groupbox.TabIndex = 7;
            this.namesum_groupbox.TabStop = false;
            this.namesum_groupbox.Text = "검색한 매출액";
            // 
            // namesum_box
            // 
            this.namesum_box.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.namesum_box.Location = new System.Drawing.Point(6, 20);
            this.namesum_box.Name = "namesum_box";
            this.namesum_box.Size = new System.Drawing.Size(209, 35);
            this.namesum_box.TabIndex = 0;
            this.namesum_box.Text = "\\";
            this.namesum_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnBill
            // 
            this.btnBill.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnBill.Location = new System.Drawing.Point(684, 329);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(107, 160);
            this.btnBill.TabIndex = 8;
            this.btnBill.Text = "배달건 출력";
            this.btnBill.UseVisualStyleBackColor = true;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TelPhoneApp.Properties.Resources.img_baemin;
            this.pictureBox1.Location = new System.Drawing.Point(57, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(849, 587);
            this.Controls.Add(this.btnBill);
            this.Controls.Add(this.namesum_groupbox);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "배달 대행";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.namesum_groupbox.ResumeLayout(false);
            this.namesum_groupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbDisplay;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRemove;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox sum_box;
        private System.Windows.Forms.GroupBox namesum_groupbox;
        private System.Windows.Forms.TextBox namesum_box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Button btnBill;
    }
}

