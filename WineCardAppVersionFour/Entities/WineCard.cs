using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WineCardAppVersionFour.Entities
{
    public class WineCard
    {
        [Key]
        public int WineCardId { get; set; }

        //public ICollection<Wine> Wines { get; set; } = new List<Wine>();

        public int WineId { get; set; }
        public Wine Wine { get; set; }
    }
}
