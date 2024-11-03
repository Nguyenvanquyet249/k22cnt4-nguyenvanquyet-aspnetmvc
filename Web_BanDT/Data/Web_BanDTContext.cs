using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Web_BanDT.Data
{
    public class Web_BanDTContext : DbContext
    {
        
    
        public Web_BanDTContext() : base("name=Web_BanDTContext")
        {
        }

        public System.Data.Entity.DbSet<Web_BanDT.Models.Product> Products { get; set; }

        public System.Data.Entity.DbSet<Web_BanDT.Models.Category> Categories { get; set; }
    }
}
