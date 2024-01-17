using System.ComponentModel.DataAnnotations;

namespace CustomerUserModel.Models
{
	public class TrainingLevel
	{
		[Key]
		public int TrainingLevelId { get; set; }
		public string? TrainingLevelName { get; set; }
		public virtual ICollection<GymTrainee>? GymTrainees { get; set; }
	}
}
