using Gaming.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gaming.Controllers
{
	public class RegisterController : Controller
	{
		//rv=RegisterVariables

		public static string rv_mail;
		public static string rv_password;
		public static string rv_password2;
		public static string rv_name;
		public static string rv_surname;
		public static string rv_user_name;
		public static DateTime rv_birth_date;
		public static string rv_gender;
		public static string rv_telephone_number;
		public static int rv_security_code;
		public static int rv_rg1;
		public static int rv_mc1; 
		public static int rv_roe;

		Context c = new Context();			
		
		[HttpGet]
		public IActionResult Register1()
		{

			return View();
		}

		[HttpPost]
		public IActionResult Register1(Check_Mail cm_model)
		{
			
			if (!ModelState.IsValid)
			{
				return View(cm_model);
			}		
			
			if (Check_Mail.CheckPassword(cm_model.check_PASSWORD, cm_model.check_PASSWORD2) == true)
			{
				Random rnd = new Random();
				rv_security_code = rnd.Next(100000, 1000000);
				Mail.MailSender(rv_security_code, cm_model.check_EMAIL);
				rv_rg1 = 1;
				rv_roe = 4;
				rv_mail = cm_model.check_EMAIL;
				rv_password = cm_model.check_PASSWORD;
				return RedirectToAction("Mail_Check");
			}
			else			
				rv_rg1 = 0;
				ViewBag.checkPassword = "*The passwords you entered are not the same. Please re-enter.";						
			return View();
		}

		[HttpGet]
		public IActionResult Mail_Check()
		{
			
			if (rv_rg1 == 1)
			{
				return View();
			}
			else
				return RedirectToAction("Register1");			
		}

		[HttpPost]
		public IActionResult Mail_Check(int code)
		{			
			if (code == rv_security_code && rv_roe > 0)
			{
				rv_mc1 = 1;
				return (RedirectToAction("Register2"));
			}

			if (rv_roe > 0)
			{
				rv_roe = rv_roe - 1;
				ViewBag.checkRightOfEnter = "Your right to login:" + (rv_roe);
				if (rv_roe==0)
				{
					ViewBag.checkRightOfEnter = "It's your last chance to enter the security code correctly. If you enter it incorrectly, you will be redirected to another page.";
				}
				return View();
			}

			if (rv_roe<=0)
			{		
				System.Threading.Thread.Sleep(5000);
				return RedirectToAction("Login", "Home");
			}
			return View();
			

		}

		[HttpGet]
		public IActionResult Register2()
		{
			if (rv_mc1==1)
			{
				return View();
			}
			else
				return RedirectToAction("Register1");
			//return View();	
		}

		[HttpPost]
		public IActionResult Register2(check_Informaiton cı_model)
		{
			
			if (!ModelState.IsValid)
			{
				return View(cı_model);
			}

			rv_name = cı_model.check_NAME;
			rv_surname = cı_model.check_SURNAME;
			rv_user_name = cı_model.check_USER_NAME;
			rv_telephone_number = cı_model.check_TELEPHONE_NUMBER;
			rv_gender = cı_model.check_GENDER;
			rv_birth_date = cı_model.check_BIRTH_DATE;
			
			return RedirectToAction("SaveUser");
		}

		public IActionResult SaveUser(Users u_model)
		{

			u_model.EMAIL = rv_mail;
			u_model.PASSWORD = rv_password;
			u_model.NAME = rv_name;
			u_model.SURNAME = rv_surname;
			u_model.USER_NAME = rv_user_name;
			u_model.TELEPHONE_NUMBER = rv_telephone_number;
			u_model.GENDER = rv_gender;
			u_model.BIRTH_DATE = rv_birth_date; 
			
			c.Userss.Add(u_model);
			c.SaveChanges();

			return RedirectToAction("Login", "Home");
		}

	}
}
