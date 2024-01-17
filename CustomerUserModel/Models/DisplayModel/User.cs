using System.ComponentModel.DataAnnotations;

namespace CustomerUserModel.Models.DisplayModel
{
	public class User
	{
		[Key]
		public int UserId { get; set; }
		public string? Name { get; set; }
		public string? LastName { get; set; }
		public string? Email { get; set; }
		public int CountryId { get; set; }
		public int StateId { get; set; }
		public int CityId { get; set; }
	}
}
