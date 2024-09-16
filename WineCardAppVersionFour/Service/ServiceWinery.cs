using WineCardAppVersionFour.Entities;

namespace WineCardAppVersionFour.Service
{
    public class ServiceWinery
    {
        private readonly DbContextWineCardApp _context;

        public ServiceWinery(DbContextWineCardApp context)
        {
            _context = context;
        }

        public List<Winery> GetAllWineries()
        {
            return _context.Wineries.ToList();
        }

        public void AddWinery(Winery winery)
        {
            _context.Wineries.Add(winery);
            _context.SaveChanges();
        }

        public void UpdateWinery(Winery wineryToUpdate)
        {
            var winery = FindWineryById(wineryToUpdate.WineryId);

            if (winery is not null)
            {
                winery.WineryId = wineryToUpdate.WineryId;
                winery.WineryName = wineryToUpdate.WineryName;
                winery.WineRegionId = wineryToUpdate.WineRegionId;

                _context.SaveChanges();
            }
        }

        public void RemoveWinery(int id)
        {
            _context.Wineries.Remove(FindWineryById(id));
            _context.SaveChanges();
        }

        public Winery FindWineryById(int id)
        {
            return _context.Wineries.Find(id);
        }

        public bool CheckForDuplicateWinery(Winery winery)
        {
            return _context.Wineries.Any(w => w.WineryName == winery.WineryName && w.WineRegionId == winery.WineRegionId);
        }
    }
}
