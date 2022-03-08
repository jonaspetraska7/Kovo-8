using System.ComponentModel.DataAnnotations;

namespace Kovo8.Models
{
    public class TulpeModel
    {
        [Key]
        public int Id { get; set; }
        public string? Vardas { get; set; }
        public string? Gele { get; set; }
        public int Balsai { get; set; } = 0;
    }
}
