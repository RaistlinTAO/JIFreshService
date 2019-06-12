#region

using System;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using VTigerApi;

#endregion

namespace HyperTiger.UI
{
    public partial class frmLogin : XtraForm
    {
        private readonly String _URL;
        public string Password;
        public string Username;
        //private VTiger _vTiger;
        //public event EventHandler GetUserName;
        //public event EventHandler GetPassword;
        public frmLogin(VTiger iTiger, String URL)
        {
            //_vTiger = iTiger;
            _URL = URL;
            InitializeComponent();
            LookAndFeel.SkinName = "Sharp";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //_vTiger = new VTiger(_URL);
            try
            {
                //_vTiger.Login(txtUsername.Text, txtPassword.Text);
                //_vTiger.Logout();
                Username = txtUsername.Text;
                Password = txtPassword.Text;
                DialogResult = DialogResult.OK;
            }
            catch (Exception)
            {
                MessageBox.Show("UserName/ API Password Mismatch!");
            }
        }

        private void frmLogin_Shown(object sender, EventArgs e)
        {
            lblTitle.Text = _URL;
        }
    }
}