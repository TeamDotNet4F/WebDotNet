using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project.Models
{
    public class Resource
    {
        public int idResource { get; set; }
        public int idRole { get; set; }
        public String controller { get; set; }
        public String action { get; set; }
    }
}