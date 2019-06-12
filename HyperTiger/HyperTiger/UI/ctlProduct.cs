#region

using System;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using VTigerApi;

#endregion

namespace HyperTiger.UI
{
    public partial class ctlProduct : XtraUserControl
    {
        private readonly string _Password;
        private readonly string _UserName;
        private readonly VTiger _VTigerApi;

        public ctlProduct(VTiger VTigerApi, string UserName, string Password)
        {
            _Password = Password;
            _UserName = UserName;
            _VTigerApi = VTigerApi;
            InitializeComponent();
        }

        private void ctlProduct_Load(object sender, EventArgs e)
        {
            cmbCat.SelectedIndex = 2;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            btnCheck.Enabled = false;
            lsvProduct.Items.Clear();
            _VTigerApi.Login(_UserName, _Password);
            //var dt2 = _VTigerApi.Query("productcategory");
            var dt = _VTigerApi.Query("SELECT * FROM Products WHERE productcategory = '" + cmbCat.SelectedItem + "';");
            foreach (DataRow item in dt.Rows)
            {
                var x = new ListViewItem {Text = item.ItemArray[1].ToString()};
                x.SubItems.Add(item.ItemArray[6].ToString());
                x.SubItems.Add(item.ItemArray[3].ToString());
                var tempNo = item.ItemArray[21].ToString().Split('.');
                x.SubItems.Add(tempNo[0]);
                //x.SubItems.Add(item.ItemArray[21].ToString());
                x.SubItems.Add(item.ItemArray[33].ToString());
                x.SubItems.Add(item.ItemArray[31].ToString());
                x.SubItems.Add(item.ItemArray[32].ToString());
                tempNo = item.ItemArray[26].ToString().Split('.');
                x.SubItems.Add(tempNo[0]);
                lsvProduct.Items.Add(x);
            }
            _VTigerApi.Logout();
            btnCheck.Enabled = true;
        }
    }
}