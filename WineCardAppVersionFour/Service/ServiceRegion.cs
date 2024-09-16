using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WineCardAppVersionFour.Entities;

namespace WineCardAppVersionFour.Service
{
    public class ServiceRegion
    {
        private readonly DbContextWineCardApp _context;

        public ServiceRegion(DbContextWineCardApp context)
        {
            _context = context;
        }

        public List<WineRegion> GetAllRegions()
        {
            return _context.WineRegions.ToList();
        }
    }
}
