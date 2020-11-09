using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LayoutView.Models
{
    public class Student
    {
        [Key]
        public String Regno { get; set; }
        public String Name { get; set; }
        public String Course { get; set; }
        public double GPA { get; set; }
        public String ProfilePic { get; set; } = "sample.png"; //store the location or name, no need to store images
    }
}

