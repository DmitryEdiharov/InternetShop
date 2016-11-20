using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InternetShop.Models
{
    public class Account
    {
        public string Id;

        public string Login;

        public string PasswordHash;

        public int RoleId;

        public int AccountInfoId;
    }

}