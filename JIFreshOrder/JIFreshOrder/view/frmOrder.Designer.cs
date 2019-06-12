namespace JIFreshOrder.view
{
    partial class frmOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lsvCustomer = new System.Windows.Forms.ListView();
            this.姓名 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.电话 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.省份 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.市区 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.区县 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.地址 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.产品 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.数量 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.价格 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.备注 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.cbProduct = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.cbSection = new System.Windows.Forms.ComboBox();
            this.cbCity = new System.Windows.Forms.ComboBox();
            this.cbState = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdAddnew = new System.Windows.Forms.Button();
            this.cmdUpdate = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmdExcel = new System.Windows.Forms.Button();
            this.cmdSubmit = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPostcode = new System.Windows.Forms.TextBox();
            this.lblExit = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMemo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.邮编 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmdDelete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lsvCustomer);
            this.groupBox1.ForeColor = System.Drawing.Color.Ivory;
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(861, 284);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "客户列表";
            // 
            // lsvCustomer
            // 
            this.lsvCustomer.BackColor = System.Drawing.Color.GhostWhite;
            this.lsvCustomer.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.姓名,
            this.电话,
            this.省份,
            this.市区,
            this.区县,
            this.地址,
            this.邮编,
            this.产品,
            this.数量,
            this.价格,
            this.备注});
            this.lsvCustomer.FullRowSelect = true;
            this.lsvCustomer.GridLines = true;
            this.lsvCustomer.Location = new System.Drawing.Point(6, 24);
            this.lsvCustomer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lsvCustomer.MultiSelect = false;
            this.lsvCustomer.Name = "lsvCustomer";
            this.lsvCustomer.Size = new System.Drawing.Size(849, 252);
            this.lsvCustomer.TabIndex = 1;
            this.lsvCustomer.UseCompatibleStateImageBehavior = false;
            this.lsvCustomer.View = System.Windows.Forms.View.Details;
            // 
            // 姓名
            // 
            this.姓名.Text = "姓名";
            // 
            // 电话
            // 
            this.电话.Text = "电话";
            this.电话.Width = 80;
            // 
            // 省份
            // 
            this.省份.Text = "省份";
            // 
            // 市区
            // 
            this.市区.Text = "市区";
            this.市区.Width = 0;
            // 
            // 区县
            // 
            this.区县.Text = "区县";
            this.区县.Width = 0;
            // 
            // 地址
            // 
            this.地址.Text = "地址";
            this.地址.Width = 250;
            // 
            // 产品
            // 
            this.产品.Text = "产品";
            this.产品.Width = 100;
            // 
            // 数量
            // 
            this.数量.Text = "数量";
            this.数量.Width = 40;
            // 
            // 价格
            // 
            this.价格.Text = "价格";
            // 
            // 备注
            // 
            this.备注.Text = "备注";
            this.备注.Width = 150;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmdDelete);
            this.groupBox2.Controls.Add(this.lblprice);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtMemo);
            this.groupBox2.Controls.Add(this.txtPostcode);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtNumber);
            this.groupBox2.Controls.Add(this.cbProduct);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtPhone);
            this.groupBox2.Controls.Add(this.txtAddress);
            this.groupBox2.Controls.Add(this.cbSection);
            this.groupBox2.Controls.Add(this.cbCity);
            this.groupBox2.Controls.Add(this.cbState);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cmdAddnew);
            this.groupBox2.Controls.Add(this.cmdUpdate);
            this.groupBox2.Location = new System.Drawing.Point(12, 333);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(861, 162);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Ivory;
            this.label9.Location = new System.Drawing.Point(652, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "数量:";
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(718, 87);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(123, 23);
            this.txtNumber.TabIndex = 15;
            // 
            // cbProduct
            // 
            this.cbProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProduct.FormattingEnabled = true;
            this.cbProduct.Location = new System.Drawing.Point(92, 88);
            this.cbProduct.Name = "cbProduct";
            this.cbProduct.Size = new System.Drawing.Size(250, 25);
            this.cbProduct.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Ivory;
            this.label8.Location = new System.Drawing.Point(18, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "商品:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Ivory;
            this.label6.Location = new System.Drawing.Point(379, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "所在地址:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Ivory;
            this.label5.Location = new System.Drawing.Point(379, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "所在省:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Ivory;
            this.label4.Location = new System.Drawing.Point(18, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "客户电话:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(92, 55);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(250, 23);
            this.txtPhone.TabIndex = 9;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(468, 57);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(374, 23);
            this.txtAddress.TabIndex = 8;
            // 
            // cbSection
            // 
            this.cbSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSection.FormattingEnabled = true;
            this.cbSection.Location = new System.Drawing.Point(718, 24);
            this.cbSection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbSection.Name = "cbSection";
            this.cbSection.Size = new System.Drawing.Size(124, 25);
            this.cbSection.TabIndex = 7;
            this.cbSection.Visible = false;
            // 
            // cbCity
            // 
            this.cbCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCity.FormattingEnabled = true;
            this.cbCity.Location = new System.Drawing.Point(592, 24);
            this.cbCity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(120, 25);
            this.cbCity.TabIndex = 6;
            this.cbCity.Visible = false;
            // 
            // cbState
            // 
            this.cbState.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbState.FormattingEnabled = true;
            this.cbState.Items.AddRange(new object[] {
            "北京市",
            "天津市",
            "上海市",
            "重庆市",
            "香港特别行政区",
            "澳门特别行政区",
            "河北省",
            "山西省",
            "内蒙古自治区",
            "辽宁省",
            "吉林省",
            "黑龙江省",
            "江苏省",
            "浙江省",
            "安徽省",
            "福建省",
            "江西省",
            "山东省",
            "河南省",
            "湖北省",
            "湖南省",
            "广东省",
            "广西壮族自治区",
            "海南省",
            "四川省",
            "贵州省",
            "云南省",
            "西藏自治区",
            "陕西省",
            "甘肃省",
            "青海省",
            "宁夏回族自治区",
            "新疆维吾尔自治区",
            "台湾省"});
            this.cbState.Location = new System.Drawing.Point(468, 24);
            this.cbState.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbState.Name = "cbState";
            this.cbState.Size = new System.Drawing.Size(119, 25);
            this.cbState.TabIndex = 5;
            this.cbState.SelectedIndexChanged += new System.EventHandler(this.cbState_SelectedIndexChanged);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(92, 24);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(250, 23);
            this.txtName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Ivory;
            this.label3.Location = new System.Drawing.Point(18, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "客户姓名:";
            // 
            // cmdAddnew
            // 
            this.cmdAddnew.BackColor = System.Drawing.Color.SkyBlue;
            this.cmdAddnew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdAddnew.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAddnew.ForeColor = System.Drawing.Color.White;
            this.cmdAddnew.Location = new System.Drawing.Point(718, 120);
            this.cmdAddnew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdAddnew.Name = "cmdAddnew";
            this.cmdAddnew.Size = new System.Drawing.Size(124, 28);
            this.cmdAddnew.TabIndex = 2;
            this.cmdAddnew.Text = "添加客户";
            this.cmdAddnew.UseVisualStyleBackColor = false;
            this.cmdAddnew.Click += new System.EventHandler(this.cmdAddnew_Click);
            // 
            // cmdUpdate
            // 
            this.cmdUpdate.BackColor = System.Drawing.Color.SkyBlue;
            this.cmdUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdUpdate.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdUpdate.ForeColor = System.Drawing.Color.White;
            this.cmdUpdate.Location = new System.Drawing.Point(468, 120);
            this.cmdUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdUpdate.Name = "cmdUpdate";
            this.cmdUpdate.Size = new System.Drawing.Size(120, 28);
            this.cmdUpdate.TabIndex = 1;
            this.cmdUpdate.Text = "更新客户";
            this.cmdUpdate.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmdExcel);
            this.groupBox3.Controls.Add(this.cmdSubmit);
            this.groupBox3.Controls.Add(this.lblTotal);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.ForeColor = System.Drawing.Color.Ivory;
            this.groupBox3.Location = new System.Drawing.Point(12, 503);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(861, 68);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "控制面板";
            // 
            // cmdExcel
            // 
            this.cmdExcel.BackColor = System.Drawing.Color.SkyBlue;
            this.cmdExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdExcel.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdExcel.ForeColor = System.Drawing.Color.White;
            this.cmdExcel.Location = new System.Drawing.Point(592, 24);
            this.cmdExcel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdExcel.Name = "cmdExcel";
            this.cmdExcel.Size = new System.Drawing.Size(120, 30);
            this.cmdExcel.TabIndex = 3;
            this.cmdExcel.Text = "保存EXCEL表格";
            this.cmdExcel.UseVisualStyleBackColor = false;
            // 
            // cmdSubmit
            // 
            this.cmdSubmit.BackColor = System.Drawing.Color.SkyBlue;
            this.cmdSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdSubmit.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSubmit.ForeColor = System.Drawing.Color.White;
            this.cmdSubmit.Location = new System.Drawing.Point(718, 24);
            this.cmdSubmit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdSubmit.Name = "cmdSubmit";
            this.cmdSubmit.Size = new System.Drawing.Size(124, 30);
            this.cmdSubmit.TabIndex = 2;
            this.cmdSubmit.Text = "递交";
            this.cmdSubmit.UseVisualStyleBackColor = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Crimson;
            this.lblTotal.Location = new System.Drawing.Point(65, 29);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(15, 17);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Ivory;
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "总价:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Ivory;
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 19);
            this.label7.TabIndex = 4;
            this.label7.Text = "订单详情";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Ivory;
            this.label2.Location = new System.Drawing.Point(652, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "邮编:";
            // 
            // txtPostcode
            // 
            this.txtPostcode.Location = new System.Drawing.Point(718, 24);
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.Size = new System.Drawing.Size(124, 23);
            this.txtPostcode.TabIndex = 18;
            // 
            // lblExit
            // 
            this.lblExit.AutoSize = true;
            this.lblExit.Location = new System.Drawing.Point(868, 2);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(16, 17);
            this.lblExit.TabIndex = 5;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Ivory;
            this.label10.Location = new System.Drawing.Point(18, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 17);
            this.label10.TabIndex = 20;
            this.label10.Text = "备注:";
            // 
            // txtMemo
            // 
            this.txtMemo.Location = new System.Drawing.Point(92, 123);
            this.txtMemo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMemo.Name = "txtMemo";
            this.txtMemo.Size = new System.Drawing.Size(250, 23);
            this.txtMemo.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Ivory;
            this.label11.Location = new System.Drawing.Point(379, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 17);
            this.label11.TabIndex = 21;
            this.label11.Text = "商品单价:";
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprice.ForeColor = System.Drawing.Color.Gold;
            this.lblprice.Location = new System.Drawing.Point(465, 91);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(29, 17);
            this.lblprice.TabIndex = 22;
            this.lblprice.Text = "420";
            // 
            // 邮编
            // 
            this.邮编.Text = "邮编";
            // 
            // cmdDelete
            // 
            this.cmdDelete.BackColor = System.Drawing.Color.SkyBlue;
            this.cmdDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdDelete.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDelete.ForeColor = System.Drawing.Color.White;
            this.cmdDelete.Location = new System.Drawing.Point(594, 120);
            this.cmdDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(120, 28);
            this.cmdDelete.TabIndex = 23;
            this.cmdDelete.Text = "删除客户";
            this.cmdDelete.UseVisualStyleBackColor = false;
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(885, 584);
            this.ControlBox = false;
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lsvCustomer;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.ComboBox cbSection;
        private System.Windows.Forms.ComboBox cbCity;
        private System.Windows.Forms.ComboBox cbState;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button cmdAddnew;
        private System.Windows.Forms.Button cmdUpdate;
        private System.Windows.Forms.Button cmdExcel;
        private System.Windows.Forms.Button cmdSubmit;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ColumnHeader 姓名;
        private System.Windows.Forms.ColumnHeader 电话;
        private System.Windows.Forms.ColumnHeader 省份;
        private System.Windows.Forms.ColumnHeader 市区;
        private System.Windows.Forms.ColumnHeader 区县;
        private System.Windows.Forms.ColumnHeader 地址;
        private System.Windows.Forms.ColumnHeader 产品;
        private System.Windows.Forms.ColumnHeader 数量;
        private System.Windows.Forms.ColumnHeader 价格;
        private System.Windows.Forms.ColumnHeader 备注;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbProduct;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtPostcode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMemo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblprice;
        internal System.Windows.Forms.ColumnHeader 邮编;
        private System.Windows.Forms.Button cmdDelete;

    }
}