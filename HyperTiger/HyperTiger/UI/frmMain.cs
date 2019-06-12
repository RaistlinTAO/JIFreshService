#region

using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Xml;
using DevExpress.XtraBars.Navigation;
using DevExpress.XtraEditors;
using VTigerApi;

#endregion

namespace HyperTiger.UI
{
    public partial class frmMain : XtraForm
    {
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTCAPTION = 0x0002;
        private readonly XmlDocument _doc = new XmlDocument();
        private string _Password;
        private string _UserName;
        private VTiger _VTigerApi;

        public frmMain()
        {
            _doc.Load(AppDomain.CurrentDomain.BaseDirectory + @"\Configuration\Setting.xsd");

            InitializeComponent();
            LookAndFeel.SkinName = "Sharp Plus";
            btnTitle.Glyph = Image.FromFile(Application.StartupPath + @"\Configuration\logo_Small.png");
            //picLogo.Image = Image.FromFile(Application.StartupPath + @"\Configuration\logo_Small.png");
        }

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        private void frmMain_Load(object sender, EventArgs e)
        {
            //before start, popup login
            _VTigerApi = new VTiger(_doc.InnerText);
            var _frmLogin = new frmLogin(_VTigerApi, _doc.InnerText);
            if (_frmLogin.ShowDialog() == DialogResult.OK)
            {
                _UserName = _frmLogin.Username;
                _Password = _frmLogin.Password;
            }
            //如果这个命中 那么程序会自动打开
            //_VTigerApi = new VTiger(_doc.InnerText);
            //_VTigerApi.Login(_UserName, _Password);
            //MessageBox.Show(_VTigerApi.GetAccountID("admin"));
        }

        private void frmMain_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        private void navExit_ElementClick(object sender, NavElementEventArgs e)
        {
            Application.Exit();
        }

        private void tileNavPaneMain_MouseDown(object sender, MouseEventArgs e)
        {
            //ReleaseCapture();
            //SendMessage(this.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0);
        }

        private void titProduct_ItemClick(object sender, TileItemEventArgs e)
        {
            palMain.Controls.Clear();
            new ctlProduct(_VTigerApi, _UserName, _Password) {Parent = palMain};
        }

        private void titCustomer_ItemClick(object sender, TileItemEventArgs e)
        {
            palMain.Controls.Clear();
            new ctlCustomer {Parent = palMain};
        }

        private void tileCalendar_ItemClick(object sender, TileItemEventArgs e)
        {
            palMain.Controls.Clear();
            new ctlCalendar {Parent = palMain};
        }

        private void titInvoice_ItemClick(object sender, TileItemEventArgs e)
        {
            palMain.Controls.Clear();
            new ctlInvoice {Parent = palMain};
        }

        private void titDocuments_ItemClick(object sender, TileItemEventArgs e)
        {
            palMain.Controls.Clear();
            new ctlDocuments {Parent = palMain};
        }

        private void titAdvertisement_ItemClick(object sender, TileItemEventArgs e)
        {
            palMain.Controls.Clear();
            new ctlAdvertisement {Parent = palMain};
        }
    }
}