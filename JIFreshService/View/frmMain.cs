using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JIFreshController;
using MySql.Data.MySqlClient;

namespace JIFreshService.View
{
    public partial class frmMain : Form
    {
        private ServiceHost IJIFreshControl;
        private BackgroundWorker _BGWorker;
        private JIFresherControl _service;

        string connStr = String.Format("server={0};uid={1};pwd={2};database={3}",
                "jifresh.com", "jifreshc_sa", "1qaz2wsx", "jifreshc_s");
        private MySqlConnection conn;
        private MySqlCommand cmd;

        public frmMain()
        {
            InitializeComponent();
        }

        private void cmdMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            if (IJIFreshControl != null)
            {
                IJIFreshControl.Abort();
                IJIFreshControl.Close();
                IJIFreshControl = null;
            }
            if (_BGWorker != null)
            {
                //_BGWorker.CancelAsync();
                _BGWorker.Dispose();
                _BGWorker = null;
            }


            //HQServer.StopServer();
            Application.Exit();
        }

        private void cmdStart_Click(object sender, EventArgs e)
        {
            WriteLog("Try to start JIFresh Service...");
            _BGWorker = new BackgroundWorker();
            _BGWorker.RunWorkerCompleted += _RunWorkerCompleted;
            _BGWorker.DoWork += _DoWork;

            if (!_BGWorker.IsBusy)
            {
                _BGWorker.RunWorkerAsync();
            }
        }

        private void _DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                IJIFreshControl = new ServiceHost(_service);
                //IStarGate = new ServiceHost(typeof(D.E.M.O.N.Catalyst.GalaxyService.Observer));
                if (IJIFreshControl.State != CommunicationState.Opened)
                {
                    IJIFreshControl.Open();
                }

                e.Result = "K";
            }
            catch (Exception ex)
            {
                e.Result = ex.Message;
            }
        }

        private void _RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Result != null)
            {
                if (e.Result.ToString() == "K")
                {
                    WriteLog("JIFresh TCP Binding Service started successfully");
                    cmdStart.Enabled = false;
                }
                else
                {
                    WriteLog("Service Failed! Error:" + e.Result);
                }
            }
        }
        private void WriteLog(string Log)
        {
            lstLog.Items.Add(DateTime.Now.Hour.ToString("00") + ":" + DateTime.Now.Minute.ToString("00") + ":" +
                             DateTime.Now.Second.ToString("00") + "   " + Log);
            lstLog.SelectedIndex += 1;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            _service = new JIFresherControl();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();

                string sql = "select * from pf_customer where customeremail=" + "\'" + "k9998@love.com" + "\'" + " AND customerpasswd=" + "'7ujm8ik,'";
                //cmd = new MySqlCommand(sql, conn);
                DataSet ds = new DataSet();
                MySqlDataAdapter command = new MySqlDataAdapter(sql, conn);
                command.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show(ds.Tables[0].Rows[0].ItemArray[2].ToString());
                }
                else
                {
                    
                }
                conn.Close();

            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Exception: " + ex.Message);
            }
        }
    }
}
