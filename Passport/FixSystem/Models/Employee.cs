using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FixSystem.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Fullname { get; set; }

        [Required]
        public string Email { get; set; }

        [MinLength(10)]
        [MaxLength(10)]
        public string Phone { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(2)]
        public string build { get; set; }

    }
}