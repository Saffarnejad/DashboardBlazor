using System.ComponentModel.DataAnnotations;

namespace DashboardBlazor.Data
{
    public class Country
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
