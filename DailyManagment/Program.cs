using DailyManagment.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace DailyManagment
{
    internal static class Program
    {
        public static IServiceProvider ServiceProvider { get; set; }

        static void ConfigureServices()
        {
            var services = new ServiceCollection();
            // Add your services here
            services.AddTransient<DailyContext>();
            ServiceProvider = services.BuildServiceProvider();
        }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ConfigureServices();
            using (var dataContext = ServiceProvider.GetService<DailyContext>())
            {
                //dataContext.Database.Migrate();
                //dataContext.Dailies.Add(new Daily { Produto = "Produto 1" });
                //dataContext.Dailies.Add(new Daily { Produto = "Produto 2" });
                //dataContext.Dailies.Add(new Daily { Produto = "Produto 3" });
                //dataContext.SaveChanges();
            }

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }

    //create a dbcontext for entityframework
    public class DailyContext : DbContext
    {
        private static bool _created = false;
        public DbSet<Daily> Dailies { get; set; }
        public DailyContext() {
            if (!_created)
            {
                _created = true;
                Database.Migrate();
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=daily.db");
        }
    }
}