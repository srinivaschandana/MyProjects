using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SampleProject.Models
{
    public class Student
    {
        [Key]
        public int StdId { get; set; }
        public string StudentName { get; set; }
        public string Branch { get; set; }
        public int Fee { get; set; }

    }
}