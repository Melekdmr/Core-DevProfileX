using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
	public class Context:DbContext

	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) // bağlantı adresini tutacak olan metot
		{
			
			optionsBuilder.UseSqlServer("server=MELEKDMR\\SQLEXPRESS;database=CorePortfolioDB;integrated security=true");

		}

		public int MyProperty { get; set; }


	}
}
