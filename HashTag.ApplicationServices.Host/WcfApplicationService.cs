using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HashTag.Diagnostics;

namespace HashTag.ApplicationServices
{
    public partial class WcfApplicationService:IWcfApplicationService 
    {
        private Log _log = Log.NewLog(typeof(WcfApplicationService));
    }
}
