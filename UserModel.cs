using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Milestone1.Models
{
	public class UserModel
	{
		[Required]
		[DisplayName("First Name")]
		[StringLength(50)]
		public string FirstName { get; set; }

		[Required]
		[DisplayName("Last Name")]
		[StringLength(50)]
		public string LastName { get; set; }

		[Required]
		[DisplayName("Sex")]
		public string Sex { get; set; } // Can also be implemented as an Enum

		[Required]
		[Range(1, 150)]
		[DisplayName("Age")]
		public int Age { get; set; }

		[Required]
		[DisplayName("State")]
		public string State { get; set; } // Can use a predefined list or Enum

		[Required]
		[EmailAddress]
		[DisplayName("Email Address")]
		public string Email { get; set; }

		[Required]
		[DisplayName("Username")]
		[StringLength(20, MinimumLength = 4)]
		public string Username { get; set; }

		[Required]
		[DataType(DataType.Password)]
		[DisplayName("Password")]
		[StringLength(100, MinimumLength = 6, ErrorMessage = "Password must be at least 6 characters long")]
		public string Password { get; set; }
	}
}
