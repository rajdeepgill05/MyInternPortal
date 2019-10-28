using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyInternPortal.Models.Classes
{
    public class Student: ApplicationUser
    {
        public string StudentId { get; set; }
        public string ProgramId { get; set; }
        public string Slug { get; set; }

        [AllowHtml]
        public string Body { get; set; }
        public string MediaURL { get; set; }
        public bool isVerified { get; set; }
    }
}