using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.WsFederation;
using Owin;

namespace Betcoins.Web.Bootstrap
{
    public static class AuthenticationFactory
    {
        public static void Configure(IAppBuilder app)
        {
            app.UseFacebookAuthentication(
                appId: "164256900930430",
                appSecret: "4025a540de693fb90ace8ddb2326339c"
                );

            app.SetDefaultSignInAsAuthenticationType(WsFederationAuthenticationDefaults.AuthenticationType);

            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = WsFederationAuthenticationDefaults.AuthenticationType
            });
        }
    }
}