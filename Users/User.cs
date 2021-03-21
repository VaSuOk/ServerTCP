using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Users
{
    enum UserType
    {
        Unregistered,
        Reseller,
        Manufacture,
        Moderator
    }
    class User
    {
        protected uint id;
        protected UserType userType;
        protected string PIB;

        public User()
        {
            this.id = 0;
            this.userType = UserType.Unregistered;
            this.PIB = "";
        }
        public UserType GetUserType() { return this.userType; }
    }
}
