using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace Core_Portfolio.ViewComponents.Dashboard
{
	public class ToDoListPanel : ViewComponent
	{
		ToDoListManager toDoListManager = new ToDoListManager(new EfToDoListDal());

		public IViewComponentResult Invoke()
		{
			var values = toDoListManager.Getlist();

			return View(values);
		}

	}
	
	}

