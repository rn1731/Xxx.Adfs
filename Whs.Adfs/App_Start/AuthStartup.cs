using System;
using System.Configuration;
using System.Threading.Tasks;
using Microsoft.Owin;
using Microsoft.Owin.Extensions;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.WsFederation;
using Owin;

namespace Whs.Adfs
{
    public partial class Startup
    {
        public void ConfigureAuth(IAppBuilder app)

        {
            app.SetDefaultSignInAsAuthenticationType(CookieAuthenticationDefaults.AuthenticationType);

            app.UseCookieAuthentication(new CookieAuthenticationOptions());

            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = "Application",
                AuthenticationMode = AuthenticationMode.Passive,
                LoginPath = new PathString("/Login"),
            });

            app.UseWsFederationAuthentication(new WsFederationAuthenticationOptions
            {
                MetadataAddress = ConfigurationManager.AppSettings["ida:ADFSMetadata"],
                Wtrealm = ConfigurationManager.AppSettings["ida:Wtrealm"]
            });

            app.UseStageMarker(PipelineStage.Authenticate);

        }
    }
}
