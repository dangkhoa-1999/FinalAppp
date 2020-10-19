using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace asm8.Models
{
    public class Role
    {
        public int RoleId { get; set; }

        [Required]
        public int UserId { get; set; }
        public User User{ get; set; }
    }
}