using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Gaming.Model;

namespace Gaming.Helpers
{
	public class CheckMailAttribute : ValidationAttribute
	{
		protected override ValidationResult IsValid(object value, ValidationContext validationContext)
		{
			if (value == null)
			{
				return new ValidationResult("*This field is required. Please check the information you entered.");
			}

			string mail = value.ToString();

			if (Check_Mail.CheckMail(mail) == false)
			{
				return ValidationResult.Success;
			}
			else
				return new ValidationResult("*The e-mail address you entered is registered in our system. Because of that, you are directing to the login page.");

		}

	}
}
