using System;
using System.Configuration;
using System.Threading.Tasks;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.WsFederation;
using Owin;

[assembly: OwinStartup(typeof(Whs.Adfs.Startup))]

namespace Whs.Adfs
{
    public partial class Startup

    {

        public void Configuration(IAppBuilder app)

        {

            ConfigureAuth(app);

        }

    }
}
