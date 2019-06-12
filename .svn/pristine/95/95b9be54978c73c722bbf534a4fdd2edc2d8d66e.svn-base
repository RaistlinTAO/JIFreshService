using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MySql.Data.MySqlClient;

namespace JIFreshController
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "JIFresherControl" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select JIFresherControl.svc or JIFresherControl.svc.cs at the Solution Explorer and start debugging.
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single, ConcurrencyMode = ConcurrencyMode.Reentrant)]
    public class JIFresherControl : IJIFresherControl
    {
        string connStr = String.Format("server={0};uid={1};pwd={2};database={3}",
                "jifresh.com", "jifreshc_sa", "1qaz2wsx", "jifreshc_s");
        private MySqlConnection conn;
        private MySqlCommand cmd;
        private MySqlDataReader reader = null;
        public ReturnInfomation Login(string UserName, string Password)
        {
            //check UserName Password From DB
            var iReturn = new ReturnInfomation();
            conn = new MySqlConnection(connStr);
            try
            {
                conn.Open();

                string sql = "select * from pf_customer where customeremail=" + "\'" + UserName + "\'" + " AND customerpasswd=\'" + Password+"\'";
                DataSet ds = new DataSet();
                MySqlDataAdapter command = new MySqlDataAdapter(sql, conn);
                command.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    iReturn.Success = true;

                    iReturn.ResultValue = ds.Tables[0].Rows[0].ItemArray[2].ToString() + "|" +
                                          ds.Tables[0].Rows[0].ItemArray[3].ToString() + "|" +
                                          ds.Tables[0].Rows[0].ItemArray[4].ToString();
                }
                else
                {
                    iReturn.Success = false;
                    iReturn.ResultValue = "EMAIL或密码不正确";
                }
                conn.Close();
                
            }
            catch (Exception ex)
            {
                conn.Close();
                OnTransimitMessage("Exception: " + ex.Message);
            }
            return iReturn;
        }

        public ReturnInfomation SubmitOrder(string orderlist)
        {
            throw new NotImplementedException();
        }

        public ReturnInfomation AlterOrder(string OrderID, string orderlist)
        {
            throw new NotImplementedException();
        }

        public ReturnInfomation GetProducts()
        {
            throw new NotImplementedException();
        }

        public delegate void TransimitMessage(string Message);
        public event TransimitMessage OnTransimitMessage;
    }
}
