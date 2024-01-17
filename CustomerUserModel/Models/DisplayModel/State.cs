using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;

namespace CustomerUserModel.Models.DisplayModel
{
    public class State
    {
        [Key]
        public int SId { get; set; }
        public string? StateName { get; set; }
        [ForeignKey("Country")]
        public int CountryId { get; set; }
        public Country? Country { get; set; }
    }
}
