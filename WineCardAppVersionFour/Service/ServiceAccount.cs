using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WineCardAppVersionFour.Entities;

namespace WineCardAppVersionFour.Service
{
    public class ServiceAccount
    {
        private readonly DbContextWineCardApp _context;

        public ServiceAccount(DbContextWineCardApp context)
        {
            _context = context;
        }

        public Account FindAccount(string username)
        {
            return _context.Accounts.AsNoTracking().FirstOrDefault(a => a.Username == username);
        }
    }
}
