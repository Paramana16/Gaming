using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Gaming.Model;

namespace Gaming.Helpers
{
	public class CheckUserNameAttribute : ValidationAttribute
	{
		protected override ValidationResult IsValid(object value, ValidationContext validationContext)
		{
			 
			if (value==null)
			{
				return new ValidationResult("*This field is required. Please check the information you entered.");
			}				
			
			string username = value.ToString();

			if (check_Informaiton.CheckUserName(username)==false)
			{
				return ValidationResult.Success;
			}
			else
				return new ValidationResult("*This Username is used. Please choose another username.");				
		}
	}
}
