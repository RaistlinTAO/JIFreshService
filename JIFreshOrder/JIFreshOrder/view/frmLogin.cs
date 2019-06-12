using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using JIFreshOrder.JIFreshService;

namespace JIFreshOrder.view
{
    public partial class frmLogin : Form
    {
        public string name;
        public string phone;
        public string rank;
        public string email;
        public string password;
        private JIFresherControlClient iServce = new JIFresherControlClient();
        public frmLogin()
        {
            InitializeComponent();
        }

        
        private void cmdLogin_Click(object sender, EventArgs e)
        {
            cmdLogin.Enabled = false;
            try
            {
                var iResult = iServce.Login(textBox1.Text, textBox2.Text);
                if (iResult.Success)
                {
                    iServce.Close();
                    var itemp = iResult.ResultValue.Split('|');
                    name = itemp[0];
                    phone= itemp[1];
                    rank = itemp[2];
                    email = textBox1.Text;
                    password = textBox2.Text;
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    //iServce.Close();
                    MessageBox.Show("登录失败! 原因:" + iResult.ResultValue);
                    cmdLogin.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                //iServce.Close();
                MessageBox.Show("登录失败! 原因:" + ex.Message);
                cmdLogin.Enabled = true;
            }
            
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
