using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Course
    {  [Key]
        public int Crs_ID { get; set; }
        public string Crs_Name { get; set; }
    }
}