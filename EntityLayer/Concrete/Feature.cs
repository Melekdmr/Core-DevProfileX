using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class Feature
	{
		[Key]
		public int FeatureId{ get; set; } 
		public int Header{ get; set; } 
		public int Name{ get; set; } 
		public int Title{ get; set; } 
	}
}
