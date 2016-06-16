using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Web;
using System.Web.Security;

namespace CNC.Core.Security
{
    public class SecurityContext
    {

        public static void CreateAuthenticationCookie(string userName, bool createPersistentCookie, int userId, string roles, string firsName, string lasName, bool isSLS)
        {
            if (string.IsNullOrEmpty(roles))
            {
                roles = "Everyone";
            }
            //var userData = string.Format("{0}|{1}", userId, roles);
            var userData = string.Format("{0}|{1}|{2}|{3}|{4}", userId, roles, firsName, lasName,isSLS);
            var ticket = new FormsAuthenticationTicket(1, userName, DateTime.Now, DateTime.Now.AddMinutes(120), createPersistentCookie, userData);
            var encryptedTicket = FormsAuthentication.Encrypt(ticket);
            var authCookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
            HttpContext.Current.Response.Cookies.Add(authCookie);
        }


        public static void ApplyNewPrincipal(HttpContext context)
        {
            // Get the authentication cookie
            var cookieName = FormsAuthentication.FormsCookieName;
            var authCookie = context.Request.Cookies[cookieName];

            // If the cookie can't be found, don't issue the ticket
            if (authCookie == null) return;

            // Get the authentication ticket and rebuild the principal 
            var authTicket = FormsAuthentication.Decrypt(authCookie.Value);

            var userData = authTicket.UserData.Split('|');
            var userId = int.Parse(userData[0]);
            var roles = userData[1];
            var firstName = userData[2];
            var lastName = userData[3];
            var isSLS = userData[4];
            var userIdentity = new UserIdentity(userId, Convert.ToBoolean(isSLS), authTicket.Name);
            var userPrincipal = new UserPrincipal(userIdentity, roles, firstName, lastName,Convert.ToBoolean(isSLS));

            //assign
            context.User = userPrincipal;
        }
    }
}
