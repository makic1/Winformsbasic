using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WineCardAppVersionFour.Entities;

namespace WineCardAppVersionFour.Service
{
    public class ServiceWineCard
    {
        private readonly DbContextWineCardApp _context;

        public ServiceWineCard(DbContextWineCardApp context)
        {
            _context = context;
        }

        public void SaveSelectedWines(List<int> selectedWineIds)
        {
            // Delete previous selection
            var previousSelection = _context.WineCards.ToList();
            _context.WineCards.RemoveRange(previousSelection);

            // Save new selection
            foreach (var wineId in selectedWineIds)
            {
                _context.WineCards.Add(new WineCard { WineId = wineId });
            }
            _context.SaveChanges();
        }

        public List<Wine> LoadSelectedWines(bool sortAlphabeticalWineType, bool sortAlphabeticalWineName)
        {
            var query = _context.WineCards
           .Include(sw => sw.Wine)
           .ThenInclude(w => w.WineType)
           .Include(w => w.Wine)
           .ThenInclude(v => v.Vintage)
           .Include(sw => sw.Wine)
           .ThenInclude(w => w.GrapeVariety)
           .Include(sw => sw.Wine)
           .ThenInclude(ww => ww.Winery)
           .ThenInclude(ww => ww.WineRegion)
           .ThenInclude(ww => ww.WineCountry)
           .Select(w => w.Wine);

            if (sortAlphabeticalWineType)
            {
                query = query.OrderBy(w => w.WineType.WineTypeName);
            }
            if (sortAlphabeticalWineName)
            {
                query = query.OrderBy(wn => wn.WineName);
            }

            return query.ToList();
        }

        public List<Wine> GetFilteredWines(string wineType = null, string country = null, int? year = null, string winery = null, string region = null, string grapeVariety = null)
        {
            // Verwende IQueryable, um Filter in der Datenbank anzuwenden
            var query = _context.Wines.AsQueryable();

            // Filter nach WineType (z.B. Rotwein, Weißwein)
            if (wineType is not null)
            {
                query = query.Where(w => w.WineType.WineTypeName.Contains(wineType));
            }
            if (country is not null)
            {
                query = query.Where(c => c.Winery.WineRegion.WineCountry.WineCountryName.Contains(country));
            }
            if (year is not null)
            {
                query = query.Where(y => y.Vintage.VintageYear ==  year);
            }
            if (winery is not null)
            {
                query = query.Where(w => w.Winery.WineryName.Contains(winery));
            }
            if (region is not null)
            {
                query = query.Where(r => r.Winery.WineRegion.RegionName.Contains(region));
            }
            if (grapeVariety is not null)
            {
                query = query.Where(gv => gv.GrapeVariety.GrapeVarietyName.Contains(grapeVariety));
            }

            return query.ToList();
        }
    }
}
