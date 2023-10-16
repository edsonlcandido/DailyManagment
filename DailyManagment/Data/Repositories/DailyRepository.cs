using DailyManagment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyManagment.Data.Repositories
{
    public class DailyRepository
    {
        private readonly DailyContext _context;

        public DailyRepository(DailyContext context)
        {
            _context = context;
        }

        public List<Daily> GetAll()
        {
            return _context.Dailies.ToList();
        }

        public void Add(Daily daily)
        {
            _context.Dailies.Add(daily);
            _context.SaveChanges();
        }

        public void Update(Daily daily)
        {
            _context.Dailies.Update(daily);
            _context.SaveChanges();
        }

        public void Delete(Daily daily)
        {
            _context.Dailies.Remove(daily);
            _context.SaveChanges();
        }

    }
}
