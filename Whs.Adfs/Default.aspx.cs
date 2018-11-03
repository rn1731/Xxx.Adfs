using System;
using System.Collections.Generic;
using System.IdentityModel.Protocols.WSTrust;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Security;
using System.Web.UI;

namespace Whs.Adfs
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           var user = User.Identity;

        }
    }
}