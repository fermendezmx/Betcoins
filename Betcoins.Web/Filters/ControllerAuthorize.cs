using System;
using System.Net.Http;
using System.Security.Principal;
using System.Threading;
using System.Web.Mvc;

namespace Betcoins.Web.Filters
{
    public class ControllerAuthorize : AuthorizeAttribute
    {
        public override void OnAuthorization(AuthorizationContext authorizationContext)
        {
            string token = authorizationContext.HttpContext.Request.Headers["Authorization"];

            if (!string.IsNullOrEmpty(token))
            {
                using (HttpClient client = new HttpClient())
                {
                    token = token.Substring("Bearer ".Length).Trim();
                    Uri uri = new Uri("https://graph.facebook.com/me?access_token=" + token);
                    HttpResponseMessage response = client.GetAsync(uri).Result;

                    if (response.IsSuccessStatusCode)
                    {
                        string content = response.Content.ReadAsStringAsync().Result;
                        dynamic iObj = (Newtonsoft.Json.Linq.JObject)Newtonsoft.Json.JsonConvert.DeserializeObject(content);
                        // Create generic identity.
                        GenericIdentity Identity = new GenericIdentity("Identity");
                        // Create generic principal.
                        string[] roles = { "Manager", "Teller" };
                        GenericPrincipal User = new GenericPrincipal(Identity, roles);

                        // Attach the principal to the current thread.
                        // This is not required unless repeated validation must occur,
                        // other code in your application must validate, or the
                        // PrincipalPermisson object is used.
                        Thread.CurrentPrincipal = User;

                        // Print values to the console.
                        string Name = User.Identity.Name;
                        bool Auth = User.Identity.IsAuthenticated;
                        bool IsInRole = User.IsInRole("Manager");
                        // return;
                    }
                }
            }

            base.OnAuthorization(authorizationContext);
        }
    }
}