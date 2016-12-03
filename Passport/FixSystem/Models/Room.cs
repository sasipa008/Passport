using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FixSystem.Models
{
    public class Room
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
