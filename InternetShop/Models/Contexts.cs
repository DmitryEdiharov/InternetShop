using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace InternetShop.Models
{
    public class Contexts: DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountInfo> AccountInfos { get; set; }
        public DbSet<RoleModel> Roles { get; set; }


        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> Categories { get; set; }
        public DbSet<ProductInfo> ProductInfos { get; set; }
    }
}