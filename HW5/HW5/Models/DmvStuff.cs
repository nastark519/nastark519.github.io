using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HW5.Models
{
    public class DmvStuff
    {
        [Display(Name = "")Required]
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

        /**
         * This will be my only none required field in my table and here
         * this is made just for my knowledge to expand.
         **/
        public string NewState { get; set; }

        [Required]
        public string Zip { get; set; }

        [Required]
        public DateTime SignDate { get; set; }
    }
}