using Microsoft.Owin.Cors;
using Microsoft.Owin.Security.ActiveDirectory;
using Owin;
using System.Configuration;
using System.IdentityModel.Tokens;
using System.Linq;

namespace Betcoins.Web.Bootstrap
{
    public static class AuthenticationFactory
    {
        public static void Configure(IAppBuilder app)
        {
            string domain = $"https://{ConfigurationManager.AppSettings["auth0:Domain"]}/";
            string clientId = ConfigurationManager.AppSettings["auth0:ClientId"];

            app.UseActiveDirectoryFederationServicesBearerAuthentication(
                new ActiveDirectoryFederationServicesBearerAuthenticationOptions
                {
                    TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidAudience = clientId,
                        ValidIssuer = domain,
                        IssuerSigningKeyResolver = (token, securityToken, identifier, parameters) => parameters.IssuerSigningTokens.FirstOrDefault()?.SecurityKeys?.FirstOrDefault()
                    },
                    MetadataEndpoint = $"{domain.TrimEnd('/')}/wsfed/{clientId}/FederationMetadata/2007-06/FederationMetadata.xml"
                });

            // Enable cors
            app.UseCors(CorsOptions.AllowAll);
        }
    }
}