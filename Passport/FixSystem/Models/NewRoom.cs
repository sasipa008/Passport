using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FixSystem.Models
{
    public class NewRoom
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string room { get; set; }

        [Required]
        public string NameBuild { get; set; }

        [Required]
        public int Floor { get; set; }
    }
}