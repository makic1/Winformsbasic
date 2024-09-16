using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WineCardAppVersionFour.Entities
{
    public class WineRegion
    {
        [Key]
        public int WineRegionId { get; set; }

        [Required, MaxLength(100), MinLength(2)]
        public string RegionName { get; set; }

        public int WineCountryId { get; set; }
        public WineCountry WineCountry { get; set; }

        public ICollection<Winery> Wineries { get; set; } = new List<Winery>();


        public override string ToString()
        {
            return RegionName;
        }
    }
}
