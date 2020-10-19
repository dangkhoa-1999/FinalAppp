using asm8.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace asm8.Models
{
	public class User
	{
		public int UserId { get; set; }

		[Required]
		public int RoleId { get; set; }
		public Role Role { get; set; }
	}
}