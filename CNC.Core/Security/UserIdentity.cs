using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security;
using System.Text;
using System.Security.Principal;
using System.Web.Security;

namespace CNC.Core.Security
{
    //[Serializable]
    public class UserIdentity : GenericIdentity //IIdentity,  ISerializable
    {
        private int _userId;
        private bool _isSLS;

        public UserIdentity(int userId,bool isSLS, string name)
            : base(name)
        {
            _userId = userId;
            _isSLS = isSLS;
        }

        public int UserId { get { return _userId; } }
        public bool IsSLS { get { return _isSLS; } }
       
    }
}
