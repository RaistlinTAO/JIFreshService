namespace HyperTiger.UI
{
    partial class frmMain
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
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement5 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement6 = new DevExpress.XtraEditors.TileItemElement();
            this.tileNavPaneMain = new DevExpress.XtraBars.Navigation.TileNavPane();
            this.btnTitle = new DevExpress.XtraBars.Navigation.NavButton();
            this.navExit = new DevExpress.XtraBars.Navigation.NavButton();
            this.tileBar1 = new DevExpress.XtraBars.Navigation.TileBar();
            this.tileBarGroup2 = new DevExpress.XtraBars.Navigation.TileBarGroup();
            this.titProduct = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.titAdvertisement = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.titCustomer = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.tileCalendar = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.titInvoice = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.titDocuments = new DevExpress.XtraBars.Navigation.TileBarItem();
            this.palMain = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // tileNavPaneMain
            // 
            this.tileNavPaneMain.ButtonPadding = new System.Windows.Forms.Padding(12);
            this.tileNavPaneMain.Buttons.Add(this.btnTitle);
            this.tileNavPaneMain.Buttons.Add(this.navExit);
            // 
            // tileNavCategory1
            // 
            this.tileNavPaneMain.DefaultCategory.Name = "tileNavCategory1";
            this.tileNavPaneMain.DefaultCategory.OptionsDropDown.BackColor = System.Drawing.Color.Empty;
            this.tileNavPaneMain.DefaultCategory.OwnerCollection = null;
            // 
            // 
            // 
            this.tileNavPaneMain.DefaultCategory.Tile.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileNavPaneMain.DefaultCategory.Tile.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Default;
            this.tileNavPaneMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tileNavPaneMain.Location = new System.Drawing.Point(0, 0);
            this.tileNavPaneMain.LookAndFeel.SkinName = "Office 2013 Dark Gray";
            this.tileNavPaneMain.LookAndFeel.UseDefaultLookAndFeel = false;
            this.tileNavPaneMain.Name = "tileNavPaneMain";
            this.tileNavPaneMain.OptionsPrimaryDropDown.BackColor = System.Drawing.Color.Empty;
            this.tileNavPaneMain.OptionsSecondaryDropDown.BackColor = System.Drawing.Color.Empty;
            this.tileNavPaneMain.Size = new System.Drawing.Size(850, 35);
            this.tileNavPaneMain.TabIndex = 1;
            this.tileNavPaneMain.Text = "tileNavPaneMain";
            this.tileNavPaneMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tileNavPaneMain_MouseDown);
            // 
            // btnTitle
            // 
            this.btnTitle.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Left;
            this.btnTitle.Caption = "";
            this.btnTitle.GlyphAlignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Left;
            this.btnTitle.Name = "btnTitle";
            // 
            // navExit
            // 
            this.navExit.Alignment = DevExpress.XtraBars.Navigation.NavButtonAlignment.Right;
            this.navExit.Caption = "Exit";
            this.navExit.Name = "navExit";
            this.navExit.ElementClick += new DevExpress.XtraBars.Navigation.NavElementClickEventHandler(this.navExit_ElementClick);
            // 
            // tileBar1
            // 
            this.tileBar1.AllowDrag = false;
            this.tileBar1.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileBar1.Groups.Add(this.tileBarGroup2);
            this.tileBar1.Location = new System.Drawing.Point(0, 39);
            this.tileBar1.MaxId = 8;
            this.tileBar1.Name = "tileBar1";
            this.tileBar1.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons;
            this.tileBar1.Size = new System.Drawing.Size(850, 90);
            this.tileBar1.TabIndex = 4;
            this.tileBar1.Text = "tileBar1";
            // 
            // tileBarGroup2
            // 
            this.tileBarGroup2.Items.Add(this.titProduct);
            this.tileBarGroup2.Items.Add(this.titAdvertisement);
            this.tileBarGroup2.Items.Add(this.titCustomer);
            this.tileBarGroup2.Items.Add(this.tileCalendar);
            this.tileBarGroup2.Items.Add(this.titInvoice);
            this.tileBarGroup2.Items.Add(this.titDocuments);
            this.tileBarGroup2.Name = "tileBarGroup2";
            // 
            // titProduct
            // 
            this.titProduct.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.True;
            this.titProduct.AppearanceItem.Normal.BackColor = System.Drawing.Color.OrangeRed;
            this.titProduct.AppearanceItem.Normal.Options.UseBackColor = true;
            this.titProduct.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement1.Image = global::HyperTiger.Properties.Resources._1403689775_product;
            tileItemElement1.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopRight;
            tileItemElement1.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileItemElement1.Text = "Product";
            this.titProduct.Elements.Add(tileItemElement1);
            this.titProduct.Id = 1;
            this.titProduct.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.titProduct.Name = "titProduct";
            this.titProduct.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.titProduct_ItemClick);
            // 
            // titAdvertisement
            // 
            this.titAdvertisement.AppearanceItem.Normal.BackColor = System.Drawing.Color.DarkViolet;
            this.titAdvertisement.AppearanceItem.Normal.Options.UseBackColor = true;
            this.titAdvertisement.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement2.Image = global::HyperTiger.Properties.Resources._1403724766_black75;
            tileItemElement2.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopRight;
            tileItemElement2.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileItemElement2.Text = "Advertisement";
            this.titAdvertisement.Elements.Add(tileItemElement2);
            this.titAdvertisement.Id = 7;
            this.titAdvertisement.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.titAdvertisement.Name = "titAdvertisement";
            this.titAdvertisement.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.titAdvertisement_ItemClick);
            // 
            // titCustomer
            // 
            this.titCustomer.AppearanceItem.Normal.BackColor = System.Drawing.Color.Firebrick;
            this.titCustomer.AppearanceItem.Normal.Options.UseBackColor = true;
            this.titCustomer.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement3.Image = global::HyperTiger.Properties.Resources._1403689851_home;
            tileItemElement3.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopRight;
            tileItemElement3.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileItemElement3.Text = "Customer";
            this.titCustomer.Elements.Add(tileItemElement3);
            this.titCustomer.Id = 2;
            this.titCustomer.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.titCustomer.Name = "titCustomer";
            this.titCustomer.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.titCustomer_ItemClick);
            // 
            // tileCalendar
            // 
            this.tileCalendar.AppearanceItem.Normal.BackColor = System.Drawing.Color.Orchid;
            this.tileCalendar.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileCalendar.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement4.Image = global::HyperTiger.Properties.Resources._1403691049_delivery_food;
            tileItemElement4.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopRight;
            tileItemElement4.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileItemElement4.Text = "Calendar";
            this.tileCalendar.Elements.Add(tileItemElement4);
            this.tileCalendar.Id = 6;
            this.tileCalendar.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.tileCalendar.Name = "tileCalendar";
            this.tileCalendar.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.tileCalendar_ItemClick);
            // 
            // titInvoice
            // 
            this.titInvoice.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement5.Image = global::HyperTiger.Properties.Resources._1403690158_View_Details;
            tileItemElement5.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopRight;
            tileItemElement5.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileItemElement5.Text = "Invoice";
            this.titInvoice.Elements.Add(tileItemElement5);
            this.titInvoice.Id = 4;
            this.titInvoice.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.titInvoice.Name = "titInvoice";
            this.titInvoice.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.titInvoice_ItemClick);
            // 
            // titDocuments
            // 
            this.titDocuments.AppearanceItem.Normal.BackColor = System.Drawing.Color.DodgerBlue;
            this.titDocuments.AppearanceItem.Normal.Options.UseBackColor = true;
            this.titDocuments.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            tileItemElement6.Image = global::HyperTiger.Properties.Resources._1403689995_purchase_order;
            tileItemElement6.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopRight;
            tileItemElement6.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileItemElement6.Text = "Documents";
            this.titDocuments.Elements.Add(tileItemElement6);
            this.titDocuments.Id = 3;
            this.titDocuments.ItemSize = DevExpress.XtraBars.Navigation.TileBarItemSize.Wide;
            this.titDocuments.Name = "titDocuments";
            this.titDocuments.ItemClick += new DevExpress.XtraEditors.TileItemClickEventHandler(this.titDocuments_ItemClick);
            // 
            // palMain
            // 
            this.palMain.Location = new System.Drawing.Point(12, 135);
            this.palMain.Name = "palMain";
            this.palMain.Size = new System.Drawing.Size(826, 453);
            this.palMain.TabIndex = 5;
            // 
            // frmMain
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 600);
            this.Controls.Add(this.palMain);
            this.Controls.Add(this.tileBar1);
            this.Controls.Add(this.tileNavPaneMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseDown);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TileNavPane tileNavPaneMain;
        private DevExpress.XtraBars.Navigation.NavButton btnTitle;
        private DevExpress.XtraBars.Navigation.TileBar tileBar1;
        private DevExpress.XtraBars.Navigation.NavButton navExit;
        private DevExpress.XtraBars.Navigation.TileBarGroup tileBarGroup2;
        private DevExpress.XtraBars.Navigation.TileBarItem titProduct;
        private DevExpress.XtraBars.Navigation.TileBarItem titCustomer;
        private DevExpress.XtraBars.Navigation.TileBarItem titDocuments;
        private DevExpress.XtraBars.Navigation.TileBarItem titInvoice;
        private DevExpress.XtraBars.Navigation.TileBarItem tileCalendar;
        private System.Windows.Forms.Panel palMain;
        private DevExpress.XtraBars.Navigation.TileBarItem titAdvertisement;
    }
}