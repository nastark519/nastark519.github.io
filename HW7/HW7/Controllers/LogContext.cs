namespace HW7.Controllers
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class LogContext : DbContext
    {
        public LogContext()
            : base("name=LogContext")
        {
        }

        public virtual DbSet<log> logs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
