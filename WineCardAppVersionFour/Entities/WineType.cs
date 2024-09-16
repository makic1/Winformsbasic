using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WineCardAppVersionFour.Entities
{
    public class WineType
    {
        [Key]
        public int WineTypeId { get; set; }

        [Required, MaxLength(150), MinLength(2)]
        public string WineTypeName { get; set; }

        public ICollection<Wine> Wines { get; set; } = new List<Wine>();

        public override string ToString()
        {
            return WineTypeName;
        }
    }
}
