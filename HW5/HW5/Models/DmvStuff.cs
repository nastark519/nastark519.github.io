using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HW5.Models
{
    public class DmvStuff
    {

        [Display(Name = "Customer ID"), Required]
        public int ID { get; set; }

        [Display(Name = "Date of Birth:"), Required]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Address change to:"), Required]
        public string NewAddress { get; set; }

        [Display(Name = "County"), Required]
        public string County { get; set; }

        [Display(Name = "Full Name:"), Required]
        public string FullName { get; set; }

        [Display(Name = "City"), Required]
        public string City { get; set; }

        [Display(Name = "State:"), Required]
        public string NewState { get; set; }

        [Display(Name = "Zip:"), Required]
        public int Zip { get; set; }

        [Display(Name = "Date to begin processing:"), Required]
        public DateTime SignDate { get; set; }
    }
}