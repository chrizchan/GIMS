using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Web.Security;

namespace CNC.Core.Security
{

    public class UserPrincipal : IPrincipal
    {
        public UserPrincipal(IIdentity identity, string roles, string firstName, string lastName, bool isSLS)
        {
            this.Identity = identity;
            this._roles = roles;
            this._firstName = firstName;
            this._lastName = lastName;
            this._isSLS = isSLS;
        }

        private readonly string _roles;
        private string _firstName;
        private string _lastName;
        private bool _isSLS;

        public IIdentity Identity { get; set; }

        public string FirstName { get { return _firstName; } }

        public string LastName { get { return _lastName; } }

        public bool IsSLS { get { return _isSLS; } }

        public bool IsInRole(string role)
        {
            string[] values = role.Split(',');

            return values.Any(value => _roles.Contains(value));

            // return _roles.Contains(role);
        }

        //public bool IsInAnyRole(IPrincipal user, List<string> roles)
        //{
        //    var userRoles = Roles.GetRolesForUser(user.Identity.Name);

        //    return userRoles.Any(u => roles.Contains(u));
        //}

        public bool HasRole()
        {
            return _roles != "Everyone";
        }

    }
}
