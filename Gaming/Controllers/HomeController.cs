using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gaming.Model;

namespace Gaming.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		[HttpGet]
		public IActionResult Login()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Login(CheckLogin cl_model)
		{
			if (CheckLogin.log_control(cl_model.login_mail,cl_model.login_password) == true)
			{
				return RedirectToAction("Index", "Home");
			}
			else
			{
				ViewBag.login = "Email or password is incorrect. Please check and try to login again.";
			}			
			return View();
		}


	}
}
