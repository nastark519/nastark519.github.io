using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using HW5.Models;

namespace HW5.DAL
{
    public class DMVContext : DbContext
    {
        public DMVContext() : base("name=DMVContext")
        {

        }

        /**
         * Use of the Model is accessed in the type def. for DbSet<>
         **/
        public virtual DbSet<DmvStuff> DmvStuffs { get; set; }
    }
}