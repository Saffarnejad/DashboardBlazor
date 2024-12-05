using System.ComponentModel.DataAnnotations;

namespace DashboardBlazor.Data
{
    public class City
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public int ProvinceId { get; set; }
        public Province Province { get; set; }
    }
}
