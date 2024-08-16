using Microsoft.AspNetCore.Mvc;
using MVC_Task2.Models;

namespace MVC_Task2.Controllers
{
	public class InstructorController : Controller
	{
		WebAppContext context = new WebAppContext();
		public IActionResult GetAllInstructors()
		{
			List<Instructor> InstructorList = context.Instructors.ToList();
			return View("GetAllInstructor",InstructorList);
		}

		public IActionResult Details(int id)
		{
			Instructor instructor = context.Instructors.FirstOrDefault(x=>x.Id == id);
			return View("Details", instructor);
		}
	}
}
