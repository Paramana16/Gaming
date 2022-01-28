using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Gaming.Model;
using Gaming.Helpers;

namespace Gaming.Model
{	
		public class Check_Mail
		{
			[Required(ErrorMessage = "*This field is required. Please check the information you entered.")]
			[EmailAddress(ErrorMessage = "*This is not a E-Mail Adress. Please check the information you entered.")]
			[MaxLength(50, ErrorMessage = "*he maximum number of characters you can enter is 50. Please check the information you entered.")]
			[CheckMail]
			public string check_EMAIL { get; set; }


			[Required(ErrorMessage = "*This field is required. Please check the information you entered.")]
			[MinLength(6, ErrorMessage = "*Your password must be at least 6 characters. Please check the information you entered.")]
			public string check_PASSWORD { get; set; }

			[Required(ErrorMessage = "*This field is required. Please check the information you entered.")]
			[MinLength(6, ErrorMessage = "*Your password must be at least 6 characters. Please check the information you entered.")]
			public string check_PASSWORD2 { get; set; }



			public static bool CheckPassword(string Password1, string Password2)
			{

				if (Password1 == Password2)
				{
					return true;
				}
				else
					return false;
			}

			public static bool CheckMail(string E_Mail_Adress)
			{
				Context cntx = new Context();
				
				var mails = cntx.Userss.Select(i => i.EMAIL).ToList();

				foreach ( string mail in mails)
				{
					if (E_Mail_Adress == mail)
					{
						return true;
						break;
					}					
				}
				return false;
			}

		}

		public class check_Informaiton
		{
			[Required(ErrorMessage = "*This field is required. Please check the information you entered.")]
			[MaxLength(20, ErrorMessage = "*The maximum number of characters you can enter is 20. Please check the information you entered.")]
			[CheckUserName]
			public string check_USER_NAME { get; set; }


			[Required(ErrorMessage = "*This field is required. Please check the information you entered.")]
			[MaxLength(30, ErrorMessage = "*The maximum number of characters you can enter is 50. Please check the information you entered.")]
			public string check_NAME { get; set; }


			[Required(ErrorMessage = "*This field is required. Please check the information you entered.")]
			[MaxLength(30, ErrorMessage = "*The maximum number of characters you can enter is 50. Please check the information you entered.")]
			public string check_SURNAME { get; set; }


			public DateTime check_BIRTH_DATE { get; set; }


			[Required(ErrorMessage = "*This field is required. Please check the information you entered.")]
			[MaxLength(30, ErrorMessage = "*The maximum number of characters you can enter is 50. Please check the information you entered.")]
			public string check_TELEPHONE_NUMBER { get; set; }


			[Required(ErrorMessage = "*This field is required. Please check the information you entered.")]
			[MaxLength(10, ErrorMessage = "*The maximum number of characters you can enter is 50. Please check the information you entered.")]
			public string check_GENDER { get; set; }

		public static bool CheckUserName(string User_Name)
		{
			Context cntx = new Context();

			var user_names = cntx.Userss.Select(i => i.USER_NAME).ToList();

			foreach (string user_name in user_names)
			{
				if (User_Name == user_name)
				{
					return true;
					break;
				}
			}
			return false;
		}

	}
	
}
