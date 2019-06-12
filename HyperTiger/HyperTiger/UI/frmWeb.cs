using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace HyperTiger.UI
{
    public partial class frmWeb : DevExpress.XtraEditors.XtraForm
    {
        public enum WebSite
        {
            Yeeyi,
            FreeOZ,
            Ebay,
            Gumtree
        }
        public frmWeb(WebSite URI)
        {
            InitializeComponent();
            string PostUrl = "about:Blank";
            switch (URI)
            {
                case WebSite.Ebay:
                    PostUrl = File.ReadAllText(Application.StartupPath + "\\Configuration\\yeeyi.sys");
                    break;
                case WebSite.FreeOZ:
                    PostUrl = File.ReadAllText(Application.StartupPath + "\\Configuration\\yeeyi.sys");
                    break;
                case WebSite.Gumtree:
                    PostUrl = File.ReadAllText(Application.StartupPath + "\\Configuration\\yeeyi.sys");
                    break;
                default:
                    PostUrl = File.ReadAllText(Application.StartupPath + "\\Configuration\\yeeyi.sys");
                    break;
            }
            webB.Navigate(PostUrl);
        }

        private void frmWeb_Load(object sender, EventArgs e)
        {

        }
    }
}