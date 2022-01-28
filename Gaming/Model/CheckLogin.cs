using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gaming.Model
{
	public class CheckLogin
	{
		public string login_mail { get; set; }
		public string login_password { get; set; }

		public static bool log_control(string E_Mail_Adress, string Password)
		{
			Context cntx = new Context();

			var mails = cntx.Userss.Select(i => i.EMAIL).ToList();
			var passwords = cntx.Userss.Select(i => i.PASSWORD).ToArray();

			int index = 0;			

			foreach (string mail in mails )
			{
				if (E_Mail_Adress == mail && Password == passwords[index])
				{
					return true;
				}
				else
					index = index + 1;
			}
			return false;
		}

	}
}
