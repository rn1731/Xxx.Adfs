using System;
using System.Collections.Generic;
using System.IdentityModel.Protocols.WSTrust;
using System.IdentityModel.Tokens;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.ServiceModel.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Xml;
using Thinktecture.IdentityModel.WSTrust;
using static Whs.Adfs._Default;

namespace Whs.Adfs
{
    /// <summary>
    /// Summary description for AuthenticationHandler
    /// </summary>
    public class AuthenticationHandler : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            var user = context.User;
            context.Response.Write(user.Identity.Name);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}