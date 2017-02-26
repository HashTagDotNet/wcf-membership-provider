using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace HashTag.ApplicationServices
{
    [DataContract(Namespace = ContractConfig.ContractVersion)]
    public class ServiceSessionRequestBase
    {
        public string ServiceSessionToken { get; set; }
        public string RequestorData { get; set; }
    }

    [DataContract(Namespace = ContractConfig.ContractVersion)]
    public class ServiceSessionReplyBase:ActionReply
    {
        public ServiceSessionReplyBase(){}
        public ServiceSessionReplyBase(ServiceSessionRequestBase request)
        {

        }
        public string RequestorData { get; set; }
        public string ServiceSessionToken { get; set; }
    }

}
