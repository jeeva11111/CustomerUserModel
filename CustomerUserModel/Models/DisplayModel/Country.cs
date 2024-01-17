using System.ComponentModel.DataAnnotations;

namespace CustomerUserModel.Models.DisplayModel
{
    public class Country
    {
        [Key]
        public int CId { get; set; }
        public string? CountryName { get; set; }
    }
}
