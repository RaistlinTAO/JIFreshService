namespace HyperTiger.UI
{
    partial class ctlProduct
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsvProduct = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmbCat = new System.Windows.Forms.ComboBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.cmdPostGumTree = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmdPostYeeyi = new System.Windows.Forms.Button();
            this.cmdPostFreeoz = new System.Windows.Forms.Button();
            this.cmdPostEbay = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Product Name";
            this.columnHeader1.Width = 180;
            // 
            // lsvProduct
            // 
            this.lsvProduct.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lsvProduct.FullRowSelect = true;
            this.lsvProduct.GridLines = true;
            this.lsvProduct.Location = new System.Drawing.Point(6, 20);
            this.lsvProduct.MultiSelect = false;
            this.lsvProduct.Name = "lsvProduct";
            this.lsvProduct.Size = new System.Drawing.Size(808, 338);
            this.lsvProduct.TabIndex = 0;
            this.lsvProduct.UseCompatibleStateImageBehavior = false;
            this.lsvProduct.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Product Category";
            this.columnHeader2.Width = 180;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Part Number";
            this.columnHeader3.Width = 93;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Unit Price($)";
            this.columnHeader4.Width = 75;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Height (mm)";
            this.columnHeader5.Width = 70;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Length (mm)";
            this.columnHeader6.Width = 70;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Width (mm)";
            this.columnHeader7.Width = 70;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Stock";
            this.columnHeader8.Width = 40;
            // 
            // cmbCat
            // 
            this.cmbCat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCat.FormattingEnabled = true;
            this.cmbCat.Items.AddRange(new object[] {
            "10 - Mattresses",
            "11 - Bed frames",
            "12 - Fridges & freezers",
            "13 - Laundry & cleaning",
            "14 - Dining tables/Sets",
            "15 - Chairs",
            "16 - Sofas & armchairs",
            "17 - Living room storage(w/o drawers or doors)",
            "18 - Bedroom storage",
            "19 - Living room storage(with drawers or doors)",
            "20 - Coffee & side tables",
            "21 - Shoe cabinet/rack",
            "22 - Lighting",
            "23 - Microwave ovens",
            "24 - Clothes rack",
            "25 - TV & media furniture"});
            this.cmbCat.Location = new System.Drawing.Point(6, 22);
            this.cmbCat.Name = "cmbCat";
            this.cmbCat.Size = new System.Drawing.Size(315, 21);
            this.cmbCat.TabIndex = 1;
            // 
            // btnCheck
            // 
            this.btnCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCheck.Location = new System.Drawing.Point(327, 20);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 2;
            this.btnCheck.Text = "&List";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // cmdPostGumTree
            // 
            this.cmdPostGumTree.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cmdPostGumTree.Location = new System.Drawing.Point(696, 20);
            this.cmdPostGumTree.Name = "cmdPostGumTree";
            this.cmdPostGumTree.Size = new System.Drawing.Size(118, 23);
            this.cmdPostGumTree.TabIndex = 3;
            this.cmdPostGumTree.Text = "Post to &Gumtree";
            this.cmdPostGumTree.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lsvProduct);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(820, 364);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Products";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmdPostEbay);
            this.groupBox2.Controls.Add(this.cmdPostFreeoz);
            this.groupBox2.Controls.Add(this.cmdPostYeeyi);
            this.groupBox2.Controls.Add(this.cmdPostGumTree);
            this.groupBox2.Controls.Add(this.btnCheck);
            this.groupBox2.Controls.Add(this.cmbCat);
            this.groupBox2.Location = new System.Drawing.Point(3, 373);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(820, 77);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Process";
            // 
            // cmdPostYeeyi
            // 
            this.cmdPostYeeyi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cmdPostYeeyi.Location = new System.Drawing.Point(696, 49);
            this.cmdPostYeeyi.Name = "cmdPostYeeyi";
            this.cmdPostYeeyi.Size = new System.Drawing.Size(118, 23);
            this.cmdPostYeeyi.TabIndex = 4;
            this.cmdPostYeeyi.Text = "Post to &yeeyi";
            this.cmdPostYeeyi.UseVisualStyleBackColor = true;
            // 
            // cmdPostFreeoz
            // 
            this.cmdPostFreeoz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cmdPostFreeoz.Location = new System.Drawing.Point(572, 20);
            this.cmdPostFreeoz.Name = "cmdPostFreeoz";
            this.cmdPostFreeoz.Size = new System.Drawing.Size(118, 23);
            this.cmdPostFreeoz.TabIndex = 5;
            this.cmdPostFreeoz.Text = "Post to &FreeOZ";
            this.cmdPostFreeoz.UseVisualStyleBackColor = true;
            // 
            // cmdPostEbay
            // 
            this.cmdPostEbay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.cmdPostEbay.Location = new System.Drawing.Point(572, 49);
            this.cmdPostEbay.Name = "cmdPostEbay";
            this.cmdPostEbay.Size = new System.Drawing.Size(118, 23);
            this.cmdPostEbay.TabIndex = 6;
            this.cmdPostEbay.Text = "Post to &Ebay";
            this.cmdPostEbay.UseVisualStyleBackColor = true;
            // 
            // ctlProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.LookAndFeel.SkinName = "Metropolis Dark";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "ctlProduct";
            this.Size = new System.Drawing.Size(826, 453);
            this.Load += new System.EventHandler(this.ctlProduct_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ListView lsvProduct;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ComboBox cmbCat;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button cmdPostGumTree;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cmdPostYeeyi;
        private System.Windows.Forms.Button cmdPostFreeoz;
        private System.Windows.Forms.Button cmdPostEbay;


    }
}
