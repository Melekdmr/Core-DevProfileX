using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public  class Portfolio
	{
		[Key]
		public  int  PortfolioId { get; set; }
		public  string  Name { get; set; }
		public string ImageUrl { get; set; }
		public string ProjectUrl { get; set; }
		public string ImageUrl2 { get; set; }
		public string Platform { get; set; }
		public string Status { get; set; }
		public string image1 { get; set; }
		public string image2 { get; set; }
		public string image3 { get; set; }
		public int Value { get; set; }
	}
}
