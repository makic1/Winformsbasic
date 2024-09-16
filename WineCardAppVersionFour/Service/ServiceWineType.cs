using WineCardAppVersionFour.Entities;

namespace WineCardAppVersionFour.Service
{
    public class ServiceWineType
    {
        private readonly DbContextWineCardApp _context;

        public ServiceWineType(DbContextWineCardApp context)
        {
            _context = context;
        }

        public List<WineType> GetAllWineTypes()
        {
            return _context.WineTypes.ToList();
        }

    }
}
