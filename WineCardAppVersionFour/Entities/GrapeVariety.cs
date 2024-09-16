using System.ComponentModel.DataAnnotations;

namespace WineCardAppVersionFour.Entities
{
    public class GrapeVariety
    {
        [Key]
        public int GrapeVarietyId { get; set; }
        [Required, MaxLength(150), MinLength(2)]
        public string GrapeVarietyName { get; set; }

        public ICollection<Wine> Wines { get; set; } = new List<Wine>();

        public override string ToString()
        {
            return GrapeVarietyName;
        }
    }
}
