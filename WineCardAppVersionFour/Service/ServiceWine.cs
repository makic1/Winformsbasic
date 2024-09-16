using Microsoft.EntityFrameworkCore;
using WineCardAppVersionFour.Entities;

namespace WineCardAppVersionFour.Service
{
    public class ServiceWine
    {
        private readonly DbContextWineCardApp _context;

        public ServiceWine(DbContextWineCardApp context)
        {
            _context = context;
        }

        public List<Wine> GetAllWines()
        {
            var test = _context.Wines
                .Include(v => v.Vintage)
                .Include(g => g.GrapeVariety)
                .Include(wt => wt.WineType)
                .Include(w => w.Winery)
                .ThenInclude(wr => wr.WineRegion)
                .ThenInclude(wc => wc.WineCountry)
                .ToList();

            return test;
        }

        public void AddWine(Wine wine)
        {
            _context.Wines.Add(wine);
            _context.SaveChanges();
        }

        public void UpdateWine(Wine wineToUpdate)
        {
            var wine = FindWineById(wineToUpdate.WineId);

            if (wine is not null)
            {
                wine.WineryId = wineToUpdate.WineryId;
                wine.WineName = wineToUpdate.WineName;
                wine.Price = wineToUpdate.Price;
                wine.WineTypeId = wineToUpdate.WineTypeId;
                wine.GrapeVarietyId = wineToUpdate.GrapeVarietyId;
                wine.WineryId = wineToUpdate.WineryId;
                wine.VintageId = wineToUpdate.VintageId;

                _context.SaveChanges();
            }
        }

        public void RemoveWineById(int id)
        {
            _context.Wines.Remove(FindWineById(id));
            _context.SaveChanges();
        }

        public Wine FindWineById(int id)
        {
            return _context.Wines.FirstOrDefault(w => w.WineId == id);
        }
    }
}
