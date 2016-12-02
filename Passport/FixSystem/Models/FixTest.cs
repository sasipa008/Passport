using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FixSystem.Models
{
    public class FixTest
    {
        [Key]
        public int id { get; set; }

        public string Building { get; set; }
        public int Floor { get; set; }
        public string Room { get; set; }
        public string Details { get; set; }
    }
}