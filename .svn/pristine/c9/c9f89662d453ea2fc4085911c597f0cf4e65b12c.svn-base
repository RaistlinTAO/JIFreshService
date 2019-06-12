using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace JIFreshController
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IJIFresherControl" in both code and config file together.
    [ServiceContract]
    public interface IJIFresherControl
    {
        [OperationContract]
        ReturnInfomation Login(string UserName, string Password);

        [OperationContract]
        ReturnInfomation SubmitOrder(string orderlist);

        [OperationContract]
        ReturnInfomation AlterOrder(string OrderID, string orderlist);

        [OperationContract]
        ReturnInfomation GetProducts();

    }

    [DataContract]
        public class ReturnInfomation
        {
            bool isSuccess;
            string Result;

            [DataMember]
            public bool Success
            {
                get { return isSuccess; }
                set { isSuccess = value; }
            }

            [DataMember]
            public string ResultValue
            {
                get { return Result; }
                set { Result = value; }
            }
        }
    
}
