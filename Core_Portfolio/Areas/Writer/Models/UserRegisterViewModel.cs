using System.ComponentModel.DataAnnotations;

namespace Core_Portfolio.Areas.Writer.Models
{
	public class UserRegisterViewModel
	{
		[Required(ErrorMessage ="Lütfen Kullanıcı Adını Girin")]
		public string UserName { get; set; }
		[Required(ErrorMessage = "Lütfen Şifreyi Girin")]
		public string Password { get; set; }
		[Required(ErrorMessage = "Lütfen Şifreyi Tekrar Girin")]
		[Compare("Password",ErrorMessage ="Şifreler uyumlu değil!")]
		public string ConfirmPassword { get; set; }

		[Required(ErrorMessage = "Lütfen Mail Girin")]
		public string  Mail { get; set; }
	
	}
}
