using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using JIFreshOrder.JIFreshService;

namespace JIFreshOrder.view
{
    public partial class frmOrderList : Form
    {
        private JIFresherControlClient iServce = new JIFresherControlClient();
        public frmOrderList()
        {
            InitializeComponent();
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdCheckPrice_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.jifresh.com");
        }


        private void cmdView_Click(object sender, EventArgs e)
        {
            frmOrder iOrder = new frmOrder(false);
            iOrder.ShowDialog();
        }

        private void cmdNew_Click(object sender, EventArgs e)
        {
            frmOrder iOrder = new frmOrder(true);
            iOrder.ShowDialog();
        }

        private void cmdExcel_Click(object sender, EventArgs e)
        {

        }

        private void frmOrderList_Load(object sender, EventArgs e)
        {

            frmLogin iLogin = new frmLogin();
            if (iLogin.ShowDialog() == DialogResult.OK)
            {
                lblUsername.Text = iLogin.name;
                lblPhone.Text = iLogin.phone;
                lblClass.Text = iLogin.rank;
            }
            else
            {
                Application.Exit();
            }
        }

        private void cmdHistory_Click(object sender, EventArgs e)
        {

        }

        private void cmdQQ_Click(object sender, EventArgs e)
        {
            Process.Start("tencent://message/?uin=43745399&site=www.jifresh.com&Menu=yes");
        }
    }
}
