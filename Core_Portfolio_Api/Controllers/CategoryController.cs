using Core_Portfolio_Api.DAL.Api_Context;
using Core_Portfolio_Api.DAL.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Core_Portfolio_Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CategoryController : ControllerBase
	{
		[HttpGet]
		public IActionResult CategoryList()
		{
			var c = new Context();
			return Ok(c.Categories.ToList());


		}
		[HttpGet("{id}")]
		public IActionResult Get(int id)
		{
			using var c = new Context();
			var values = new Context().Categories.Find(id);
			if (values == null) return NotFound();
			else return Ok(values);
		}

		[HttpPost]
		public IActionResult AddCategory(Category category)
		{
			using var c = new Context();
			c.Add(category);
			c.SaveChanges();

			return Created("", category);
		}
		[HttpDelete("{id}")]
		public IActionResult Delete(int id)
		{
			using var c = new Context();
			var values = c.Categories.Find(id);
			if (values == null) return NotFound();
			else
			{
				c.Remove(values);
				c.SaveChanges();
				return NoContent();
			}

		}
		[HttpPut]
		public IActionResult UpdateCategory(Category p)
		{
			using var c= new Context();
			var values = c.Categories.Find(p.CategoryID);
			if (values == null) return NotFound();
			else
			{
				values.CategoryName = p.CategoryName; 
				c.Update(values);
				c.SaveChanges();return NoContent();
			}

		}

	}
}

