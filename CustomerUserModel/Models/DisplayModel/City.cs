using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CustomerUserModel.Models.DisplayModel
{
    public class City
    {
        [Key]
        public int CityId { get; set; }
        public string? CityName { get; set; }
        [ForeignKey("StateId")]
        public int StateId { get; set; }
        public State? State { get; set; }

    }
}
