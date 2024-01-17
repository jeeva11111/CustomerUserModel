using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerUserModel.Models
{
	public class GymTrainee
	{
		[Key]
		public int Id { get; set; }
		[Required]
		[DisplayName("First Name")]

		public string? FirstName { get; set; }
		[Required]
		[DisplayName("Last Name")]

		public string? LastName { get; set; }
		[Required]
		[DisplayName("Contact Name")]

		public string? ContactNo { get; set; }
		[Required]
		[DisplayName("Gender")]
		public string? Gender { get; set; }

		[Required]
		[DisplayName("Age")]

		public int Age { get; set; }
		[Required]
		[DisplayName("Height")]

		public string? Height { get; set; }
		[Required]
		[DisplayName("weight")]

		public int weight { get; set; }
		[Required]
		[DisplayName("Address")]

		public string? Address { get; set; }
		[DisplayName(displayName: "Image Name")]

		public string? ImageName { get; set; }


		public DateTime CreationDate { get; set; }
		[NotMapped]
		[DisplayName("Upload File")]

		public IFormFile? ImageFile { get; set; }

		public string _feePaid_status = "unknown";
		// property 001	
		public int BloodGroupId { get; set; }

		public virtual BloodGroup? BloodGroup { get; set; }
		// property 002
		public int TrainingLevelId { get; set; }
		public virtual TrainingLevel? TrainingLevel { get; set; }

		public int MonthlyFee { get; set; }

	}
}
