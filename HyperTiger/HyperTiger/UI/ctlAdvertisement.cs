#region

using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Mime;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using DevExpress.XtraEditors;

#endregion

namespace HyperTiger.UI
{
    public partial class ctlAdvertisement : XtraUserControl
    {
        public ctlAdvertisement()
        {
            InitializeComponent();
        }

        private void ctlAdvertisement_Load(object sender, EventArgs e)
        {
        }

        private string GetHtml(string url)
        {
            string str = string.Empty;
            try
            {
                WebRequest request = WebRequest.Create(url);
                request.Timeout = 30000;
                request.Headers.Set("Pragma", "no-cache");
                WebResponse response = request.GetResponse();
                Stream streamReceive = response.GetResponseStream();
                Encoding encoding = Encoding.GetEncoding("GBK");
                if (streamReceive != null)
                {
                    var streamReader = new StreamReader(streamReceive, encoding);
                    str = streamReader.ReadToEnd();
                    streamReader.Close();
                }
                return str;
            }
            catch (Exception ex)
            {
                return "";
            }
        }

        private void cmdAnalysis_Click(object sender, EventArgs e)
        {
            var BZClean = GetHtml("http://ajax.googleapis.com/ajax/services/search/web?v=1.0&q=bzbest+cleaning");
            string resultString = Regex.Match(BZClean, "estimatedResultCount\":.+?\"").Value;
            var BZrate = (resultString.Replace("estimatedResultCount\":", "")).Replace("\"", "");
            BZClean = GetHtml("http://ajax.googleapis.com/ajax/services/search/web?v=1.0&q=melbourne+cleaning");
            resultString = Regex.Match(BZClean, "estimatedResultCount\":.+?\"").Value;
            var Allrate = (resultString.Replace("estimatedResultCount\":", "")).Replace("\"", "");
            lblMCMS.Text = (double.Parse(BZrate)/double.Parse(Allrate)*100).ToString("N6") + "%";

            var BZMoving = GetHtml("http://ajax.googleapis.com/ajax/services/search/web?v=1.0&q=bzbest+moving");
            resultString = Regex.Match(BZMoving, "estimatedResultCount\":.+?\"").Value;
            BZrate = (resultString.Replace("estimatedResultCount\":", "")).Replace("\"", "");
            BZMoving = GetHtml("http://ajax.googleapis.com/ajax/services/search/web?v=1.0&q=melbourne+moving");
            resultString = Regex.Match(BZMoving, "estimatedResultCount\":.+?\"").Value;
            Allrate = (resultString.Replace("estimatedResultCount\":", "")).Replace("\"", "");
            lblMMMS.Text = (double.Parse(BZrate)/double.Parse(Allrate)*100).ToString("N6") + "%";
        }

        private void cmdPostYeeyi_Click(object sender, EventArgs e)
        {
            var x = new frmWeb(frmWeb.WebSite.Yeeyi);
            x.ShowDialog();
        }
    }
}