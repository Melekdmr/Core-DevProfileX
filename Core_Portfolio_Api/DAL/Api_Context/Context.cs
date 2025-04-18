using Core_Portfolio_Api.DAL.Entity;
using Microsoft.EntityFrameworkCore;

namespace Core_Portfolio_Api.DAL.Api_Context
{
	public class Context:DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) // bağlantı adresini tutacak olan metot
		{

			//optionsBuilder.UseSqlServer("server=MELEKDMR\\SQLEXPRESS;database=CorePortfolioDB;integrated security=true");
			optionsBuilder.UseSqlServer("server=MELEKDMR\\SQLEXPRESS;database=CorePortfolioApiDB;integrated security=true;TrustServerCertificate=True");


		}
		public DbSet<Category> Categories { get; set; }
	}
}
