namespace HW7.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("log")]
    public partial class log
    {
        public int id { get; set; }

        [Required]
        [StringLength(128)]
        public string IPAddress { get; set; }

        [Required]
        [StringLength(1024)]
        public string AgentString { get; set; }

        [Required]
        [StringLength(255)]
        public string SearchTerm { get; set; }
    }
}
