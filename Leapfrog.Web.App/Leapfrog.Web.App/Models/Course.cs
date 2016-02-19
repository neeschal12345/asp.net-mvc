using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Leapfrog.Web.App.Models
{
    public class Course
    {
         
    
        public int Id { get; set; }
        public string CourseName { get; set;}
        public string Description { get; set; }
        public string Duration { get; set; }
        public string DurationType { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool status { get; set; }
    
    }
}