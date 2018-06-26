using Auth0.Owin;
using Microsoft.Owin.Cors;
using Microsoft.Owin.Security;
using Microsoft.Owin.Security.Jwt;
using Owin;
using System.Configuration;
using System.IdentityModel.Tokens;

namespace Betcoins.Web.Bootstrap
{
    public static class AuthenticationFactory
    {
        public static void Configure(IAppBuilder app)
        {
            string domain = $"https://{ConfigurationManager.AppSettings["auth0:Domain"]}/";
            string audience = ConfigurationManager.AppSettings["auth0:Audience"];
            OpenIdConnectSigningKeyResolver keyResolver = new OpenIdConnectSigningKeyResolver(domain);

            app.UseJwtBearerAuthentication(
                new JwtBearerAuthenticationOptions
                {
                    AuthenticationMode = AuthenticationMode.Active,
                    TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidAudience = audience,
                        ValidIssuer = domain,
                        IssuerSigningKeyResolver = (token, securityToken, identifier, parameters) => keyResolver.GetSigningKey(identifier)
                    }
                });

            // Enable cors
            app.UseCors(CorsOptions.AllowAll);
        }
    }
}