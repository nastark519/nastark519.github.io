using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HW5.Models
{
    public class DmvStuff
    {
        [Required]
        public int ID { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public string NewAddress { get; set; }

        public string County { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        public string City { get; set; }

        public string NewState { get; set; }

        [Required]
        public string Zip { get; set; }

        [Required]
        public DateTime SignDate { get; set; }
    }
}