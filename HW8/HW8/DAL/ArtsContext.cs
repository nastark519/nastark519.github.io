using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using HW8.Models;

namespace HW8.DAL
{
    public class ArtsContext : DbContext
    {
        public ArtsContext() : base("name=ArtsContext")
        {

        }

        public virtual DbSet<Artist> Artists { get; set; }

        public virtual DbSet<ArtWork> ArtWorks { get; set; }

        public virtual DbSet<Classification> Classifications { get; set; }

        public virtual DbSet<Genre> Genres { get; set; }
    }
}