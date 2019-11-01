using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyInternPortal.Models.Classes
{
    public class Employer :ApplicationUser
    {
        public string EmployerId { get; set; }
        public Employer()
        {
            Postings = new HashSet<Posting>();  
        }
        public virtual ICollection<Posting> Postings { get; set; }

    }
}