using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Users
{
    public enum UserType
    {
        Unregistered,
        Reseller,
        Manufacture,
        Moderator
    }
    public class User
    {
        protected uint id;
        protected UserType userType;
        protected string PIB;
        protected string Email;
        protected string Phone;

        public User(uint id, UserType userType, string PIB, string Email, string Phone)
        {
            this.id = id;
            this.userType = userType;
            this.PIB = PIB;
            this.Email = Email;
            this.Phone = Phone;
        }
        public User(uint id, UserType userType, string PIB)
        {
            this.id = id;
            this.userType = userType;
            this.PIB = PIB;
            this.Email = "";
            this.Phone = "";
        }
        public User()
        {
            this.id = 0;
            this.userType = UserType.Unregistered;
            this.PIB = "";
            this.Email = "";
            this.Phone = "";
        }
        public User(User user)
        {
            this.id = user.id;
            this.userType = user.userType;
            this.PIB = user.PIB;
            this.Email = user.Email;
            this.Phone = user.Phone;
        }
        public UserType GetUserType() { return this.userType; }
        public static UserType ConvertToEnum(string UEnum)
        {
            switch (UEnum)
            {
                case "Reseller":
                    {
                        return UserType.Reseller;
                    }
                case "Manufacture":
                    {
                        return UserType.Manufacture;
                    }
                case "Moderator":
                    {
                        return UserType.Moderator;
                    }
                default: return UserType.Unregistered;
            }
        }
    }
}
