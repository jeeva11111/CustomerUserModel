using System.ComponentModel.DataAnnotations;

namespace CustomerUserModel.Models
{
	public class BloodGroup
	{
		[Key]
		public int BloodGroupID { get; set; }
		public string? BloodGroupName { get; set; }
		public virtual ICollection<GymTrainee> GymTrainee { get; set; }
	}
}
