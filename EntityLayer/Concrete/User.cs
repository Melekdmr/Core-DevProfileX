using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class User
	{
		[Key]
		public int UserId { get; set; }
		public string Name { get; set; }
		public string SurName { get; set; }
		public string UserName { get; set; }
		public string Mail { get; set; }
		public int Pasword { get; set; }
		public string ImageUrl { get; set; }
		public bool Status { get; set; }
		public List<UserMessage> userMessages{ get; set; }
	}
}
