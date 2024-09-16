using System.ComponentModel.DataAnnotations;

namespace WineCardAppVersionFour.Entities
{
    public class WineCountry
    {
        [Key]
        public int WineCountryId { get; set; }

        [Required, MaxLength(100), MinLength(2)]
        public string WineCountryName { get; set; }

        public ICollection<WineRegion> WineRegions { get; set; } = new List<WineRegion>();

        public override string ToString()
        {
            return WineCountryName;
        }
    }
}
