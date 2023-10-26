using DailyManagment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DailyManagment.Data.Repositories
{
    public class DailyRepository
    {
        private readonly static DailyContext _context;

        static DailyRepository()
        {
            DailyContext context = (DailyContext)Program.ServiceProvider.GetService(typeof(DailyContext));
            _context = context;
        }

        public static Daily Get(int id)
        {
            return _context.Dailies.Find(id);
        }

        public static List<Daily> GetAll()
        {
            return _context.Dailies.Include(e=>e.Produto)
                .Include(e=>e.Segmento)
                .Include(e=>e.Tipo)
                .Include(e=>e.Responsavel)
                .Include(e=>e.Status)
                .Include(e=>e.AnaliseCredito)
                .ToList();
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
