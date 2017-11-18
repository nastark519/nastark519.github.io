using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HW5.DAL
{
    public class DMVContext : DbContext
    {
        public DMVContext() : base("name=DbStuff") { }

        public virtual DbSet<DmvStuff> DmvStuff { get; set; }
    }
}