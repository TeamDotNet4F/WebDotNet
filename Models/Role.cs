using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Project.Models
{
    public class Role
    {
        [Key]
        public int idRole { get; set; }
        public string  roleName { get; set; }         
    }
}