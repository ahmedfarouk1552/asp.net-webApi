using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LabD01API.Models
{
    public class Course
    {
        public int id { get; set; }
        public string name { get; set; }
        public int duration { get; set; }
        public string descreption { get; set; }

    }
}