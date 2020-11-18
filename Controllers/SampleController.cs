using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Controllers
{
    public class SampleController : Controller
    {
		[HttpGet]
		public ActionResult Index()
		{
			return View(new SampleController());
		}


		[HttpPost]
		public JsonResult GetAnswer(string question)
		{
			int index = _rnd.Next(_db.Count);
			var answer = _db[index];
			return Json(answer);
		}

		private static Random _rnd = new Random();

		private static List<string> _db = new List<string> { "Yes", "No", "Definitely, yes", "I don't know", "Looks like, yes" };
	}
}

