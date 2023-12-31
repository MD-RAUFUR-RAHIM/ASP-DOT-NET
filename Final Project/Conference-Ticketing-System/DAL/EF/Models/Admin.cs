﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string ContactNumber { get; set; }
        [Required]
        public string Password { get; set; }
        public virtual ICollection<Staff> Staffs { get; set; }

        public Admin()
        {
            Staffs = new List<Staff>();
        }
    }
}
