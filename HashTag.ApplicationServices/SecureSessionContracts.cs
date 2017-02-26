using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace HashTag.ApplicationServices
{
    [DataContract(Namespace=ContractConfig.ContractVersion)]
    public class SecureSessionRequestBase:ServiceSessionRequestBase
    {
        public SecureSessionRequestBase()
        {

        }
        public SecureSessionRequestBase(string sessionToken)
        {

        }

    }
    [DataContract(Namespace = ContractConfig.ContractVersion)]
    public class SecureSessionReplyBase:ServiceSessionReplyBase
    {
        public SecureSessionReplyBase()
        {
    
    }
        public SecureSessionReplyBase(SecureSessionRequestBase request)
        {

        }
        public SecureSessionReplyBase(Exception ex)
        {

        }
        public SecureSessionReplyBase(string sessionToken)
        {

        }
    }
}
