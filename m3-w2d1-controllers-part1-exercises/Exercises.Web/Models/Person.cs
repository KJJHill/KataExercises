using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exercises.Web.Models
{
    public class Person
    {
        public string FirstName { get; set; }
        public string Middle { get; set; }
        public string LastName { get; set; }
        public List<string> ColorsForName { get; set; }
        public string OrderedName { get; set; }
    }
}