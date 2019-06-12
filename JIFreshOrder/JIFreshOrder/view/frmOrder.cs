using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace JIFreshOrder.view
{
    public partial class frmOrder : Form
    {
        
        public frmOrder(bool isNew)
        {
            InitializeComponent();
        }

        private void cbState_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdAddnew_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("需要填写客户姓名");
                return;
            }
            if (txtAddress.Text == "")
            {
                MessageBox.Show("需要填写客户地址");
                return;
            }
            if (txtPhone.Text == "")
            {
                MessageBox.Show("需要填写客户电话");
                return;
            }
            if (txtNumber.Text == "")
            {
                MessageBox.Show("需要填写商品数量");
                return;
            }
            if (txtPostcode.Text == "")
            {
                MessageBox.Show("需要填写客户邮编");
                return;
            }
            //cbstate, cbproduct
            var itemp = new ListViewItem();
            itemp.Text = txtName.Text;
            itemp.SubItems.Add(txtPhone.Text);
            itemp.SubItems.Add(cbState.SelectedItem.ToString());
            itemp.SubItems.Add("");
            itemp.SubItems.Add("");
            itemp.SubItems.Add(txtAddress.Text);
            itemp.SubItems.Add(txtPostcode.Text);
            itemp.SubItems.Add(cbProduct.SelectedItem.ToString());
            itemp.SubItems.Add(txtNumber.Text);
            itemp.SubItems.Add("价格");
            itemp.SubItems.Add(txtMemo.Text);
            lsvCustomer.Items.Add(itemp);

            txtName.Text = "";
            txtPhone.Text = "";
            cbState.SelectedIndex = -1;
            txtAddress.Text = "";
            cbProduct.SelectedIndex = -1;
            txtNumber.Text = "";
            txtMemo.Text = "";
            txtPostcode.Text = "";
        }
    }
}
