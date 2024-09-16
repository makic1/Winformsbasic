using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WineCardAppVersionFour.Entities;

namespace WineCardAppVersionFour.Service
{
    public class ServiceGrapeVarieties
    {
        private readonly DbContextWineCardApp _context;

        public ServiceGrapeVarieties(DbContextWineCardApp context)
        {
            _context = context;
        }

        public List<GrapeVariety> GetAllGrapeVarieties()
        {
            return _context.GrapeVarieties.ToList();
        }
    }
}
