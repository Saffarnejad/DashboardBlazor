using System.ComponentModel.DataAnnotations;

namespace DashboardBlazor.Data
{
    public class Province
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public int CountryId { get; set; }
        public Country Country { get; set; }
    }
}
