using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.Facebook;
using Microsoft.Owin.Security.OAuth;
using Microsoft.Owin.Security.WsFederation;
using Owin;
using System.Security.Claims;

namespace Betcoins.Web.Bootstrap
{
    public static class AuthenticationFactory
    {
        public static void Configure(IAppBuilder app)
        {
            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = DefaultAuthenticationTypes.ExternalBearer,
                LoginPath = new PathString("/Shared/Login")
            });

            //app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions
            //{
            //    AuthenticationType = DefaultAuthenticationTypes.ExternalBearer
            //});

            // Use a cookie to temporarily store information about a user logging in with a third party login provider
            app.UseExternalSignInCookie(DefaultAuthenticationTypes.ExternalBearer);

            //app.UseFacebookAuthentication(
            //    appId: "164256900930430",
            //    appSecret: "4025a540de693fb90ace8ddb2326339c"
            //    );

            //app.SetDefaultSignInAsAuthenticationType(WsFederationAuthenticationDefaults.AuthenticationType);

            //app.UseCookieAuthentication(new CookieAuthenticationOptions
            //{
            //    AuthenticationType = WsFederationAuthenticationDefaults.AuthenticationType,
            //    LoginPath = new PathString("/Shared/Login")
            //});

            app.UseFacebookAuthentication(new FacebookAuthenticationOptions
            {
                AppId = "164256900930430",
                AppSecret = "4025a540de693fb90ace8ddb2326339c",
                SignInAsAuthenticationType = "ExternalBearer",
                Provider = new FacebookAuthenticationProvider
                {
                    OnAuthenticated = async context =>
                    {
                        var access_token = context.AccessToken;
                        context.Identity.AddClaim(new Claim("access_token", access_token));
                    }
                }
            });
        }
    }
}