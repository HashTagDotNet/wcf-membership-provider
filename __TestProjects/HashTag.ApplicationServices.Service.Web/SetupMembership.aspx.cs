using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HashTag.ApplicationServices.Service.Web
{
    public partial class SetupMembership : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            string server = "(LocalDB)\v11.0";
            var flags = System.Web.Management.SqlFeatures.Membership | System.Web.Management.SqlFeatures.Membership;
            var database = @"appServices";
           
            System.Web.Management.SqlServices.Install(database, flags, connectionString);

        }
    }
}