using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gaming.Model

{
	public class Users
	{
		[Key]
		public int ID { get; set; }


		[Required(ErrorMessage = "*This field is required. Please check the information you entered.")]
		[EmailAddress(ErrorMessage = "*This is not a E-Mail Adress. Please check the information you entered.")]
		[MaxLength(50,ErrorMessage = "*he maximum number of characters you can enter is 50. Please check the information you entered.")]
		public string EMAIL { get; set; }


		[Required(ErrorMessage = "*This field is required. Please check the information you entered.")]
		[MinLength(6,ErrorMessage = "*Your password must be at least 6 characters. Please check the information you entered.")]
		
		public string PASSWORD { get; set; }


		[Required(ErrorMessage = "*This field is required. Please check the information you entered.")]
		[MaxLength(20, ErrorMessage = "*The maximum number of characters you can enter is 20. Please check the information you entered.")]
		public string USER_NAME { get; set; }


		[Required(ErrorMessage = "*This field is required. Please check the information you entered.")]
		[MaxLength(30, ErrorMessage = "*The maximum number of characters you can enter is 50. Please check the information you entered.")]
		public string NAME { get; set; }


		[Required(ErrorMessage = "*This field is required. Please check the information you entered.")]
		[MaxLength(30, ErrorMessage = "*The maximum number of characters you can enter is 50. Please check the information you entered.")]
		public string SURNAME { get; set; }


		public DateTime BIRTH_DATE { get; set; }


		[Required(ErrorMessage = "*This field is required. Please check the information you entered.")]
		[MaxLength(30, ErrorMessage = "*The maximum number of characters you can enter is 50. Please check the information you entered.")]
		public string TELEPHONE_NUMBER { get; set; }


		[Required(ErrorMessage = "*This field is required. Please check the information you entered.")]
		[MaxLength(10, ErrorMessage = "*The maximum number of characters you can enter is 50. Please check the information you entered.")]
		public string GENDER { get; set; }
	}

	
}
