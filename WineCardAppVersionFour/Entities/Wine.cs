using System.ComponentModel.DataAnnotations;

namespace WineCardAppVersionFour.Entities
{
    public class Wine
    {
        [Key]
        public int WineId { get; set; }

        [Required]
        public string WineName { get; set; }
        [Required]
        public decimal Price { get; set; }

        public int WineTypeId { get; set; }
        public WineType WineType { get; set; }

        public int GrapeVarietyId { get; set; }
        public GrapeVariety GrapeVariety { get; set; }

        public int WineryId { get; set; }
        public Winery Winery { get; set; }

        public int VintageId {  get; set; }
        public Vintage Vintage { get; set; }

        //public int? WineCardId {  get; set; }
        //public WineCard WineCard { get; set; }

        public ICollection<WineCard> WineCards { get; set; } = new List<WineCard>();

        public override string ToString()
        {
            return WineName;
        }
    }
}
