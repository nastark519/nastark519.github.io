using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW8.Models
{
    public class Artist
    {
        public int ArtistKey { get; set; }
        public string Name { get; set; }
        public string BirthDate { get; set; }
        public string BirthCity { get; set; }
    }
}