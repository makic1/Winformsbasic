using WineCardAppVersionFour.Entities;

namespace WineCardAppVersionFour.Service
{
    public class ServiceVintage
    {
        private readonly DbContextWineCardApp _context;

        public ServiceVintage(DbContextWineCardApp context)
        {
            _context = context;
        }

        public List<Vintage> GetAllVintages()
        {
            return _context.Vintages.ToList();
        }

        public void AddVintage(Vintage vintage)
        {
            _context.Vintages.Add(vintage);
            _context.SaveChanges();
        }

        public void UpdateVintage(Vintage vintageToUpdate)
        {
            var vintage = FindVintageById(vintageToUpdate.VintageId);

            if (vintage != null)
            {
                vintage.VintageId = vintageToUpdate.VintageId;
                vintage.VintageYear = vintageToUpdate.VintageYear;

                _context.SaveChanges();
            }
        }

        public void RemoveVintageById(int id)
        {
            var vintage = FindVintageById(id);

            var winesUsingVintage = _context.Wines.Where(w => w.VintageId == id).ToList();
            if (winesUsingVintage.Any())
            {
                MessageBox.Show("Dieser Jahrgang wird noch von Weinen verwendet und kann nicht gelöscht werden.");
                return;
            }
            _context.Vintages.Remove(vintage);
            _context.SaveChanges();
        }

        public bool CheckDuplicateVintage(Vintage vintage)
        {
            return _context.Vintages.Any(v => v.VintageYear == vintage.VintageYear);
        }

        public Vintage FindVintageById(int id)
        {
            return _context.Vintages.Find(id);
        }
    }
}
