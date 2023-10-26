using DailyManagment.Data.Repositories;
using DailyManagment.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel;

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
            Application.Run(new Form1(new DailyMainView()));
        }
    }

    public class DailyMainView
    {
        private DailyContext _dailyContext;
        private List<Daily> _dailies
        {
            get
            {
                return DailyRepository.GetAll();
            }
        }
        public List<DailyViewModel> ListDailyModelViews
        {
            get
            {
                List<DailyViewModel> listModelViews = new List<DailyViewModel>();
                foreach (Daily daily in _dailies)
                {
                    DailyViewModel dailyModelView = new DailyViewModel
                    {
                        Id = daily.id,
                        Cliente = daily.Cliente,
                        Rev = daily.Rev,
                        CRM = daily.CRM,
                        DataAprovacao = daily.DataAprovacao,
                        DataDefinicao = daily.DataDefinicao,
                        DataEntregaPrevista = daily.DataEntregaPrevista,
                        DataEntregaReal = daily.DataEntregaReal,
                        Pendencia = daily.Pendencia,
                        Produto = daily.Produto.Nome,
                        Projeto_Aplicacao = daily.Projeto_Aplicacao,
                        PV = daily.PV,
                        Responsavel = daily.Responsavel.Nome,
                        Segmento = daily.Segmento.Nome,
                        Status = daily.Status.Nome,
                        Tipo = daily.Tipo.Nome,
                        AnaliseCredito = daily.AnaliseCredito.Nome
                    };

                    listModelViews.Add(dailyModelView);
                }
                return listModelViews;
            }
        }

        public DailyMainView()
        {
            _dailyContext = (DailyContext)Program.ServiceProvider.GetService(typeof(DailyContext));
        }

        public DailyMainView(DailyContext dailyContext)
        {
            _dailyContext = dailyContext;
        }
    }

    public class DailyViewModel
    {
        [DisplayName("#")]
        public int Id { get; set; }
        [DisplayName("Cliente")]
        public string? Cliente { get; set; }
        [DisplayName("Rev")]
        public string Rev { get; set; }
        [DisplayName("CRM")]
        public string? CRM { get; set; }
        [DisplayName("Data de aprovação")]
        public DateTime? DataAprovacao { get; set; }
        [DisplayName("Data de entrega prev.")]
        public DateTime? DataEntregaPrevista { get; set; }
        [DisplayName("Data de definição")]
        public DateTime? DataDefinicao { get; set; }
        [DisplayName("Data de entrega real")]
        public DateTime? DataEntregaReal { get; set; }
        [DisplayName("Pendência")]
        public string? Pendencia { get; set; }
        [DisplayName("Produto")]
        public string Produto { get; set; }
        [DisplayName("Projeto / Aplicação")]
        public string? Projeto_Aplicacao { get; set; }
        [DisplayName("PV")]
        public string? PV { get; set; }
        [DisplayName("Responsável")]
        public string Responsavel { get; set; }
        [DisplayName("Segmento")]
        public string Segmento { get; set; }
        [DisplayName("Status")]
        public string Status { get; set; }
        [DisplayName("Tipo")]
        public string Tipo { get; set; }
        [DisplayName("Análise de crédito")]
        public string AnaliseCredito { get; set; }
    }


    //create a dbcontext for entityframework
    public class DailyContext : DbContext
    {
        private static bool _created = false;
        public DbSet<Daily> Dailies { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Segmento> Segmentos { get; set; }
        public DbSet<Tipo> Tipos { get; set; }
        public DbSet<Responsavel> Responsaveis { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<AnaliseCredito> AnaliseCredito { get; set; }

        public DailyContext()
        {
            //verify if database exists and create it if not
            if (!Database.CanConnect())
            {
                //_created = true;
                //Database.EnsureCreated();

                Database.Migrate();
                Produtos.Add(new Produto() { Nome = "Compressores" });
                Produtos.Add(new Produto() { Nome = "Ventiladores" });
                Produtos.Add(new Produto() { Nome = "Pré-aquecedores" });
                Produtos.Add(new Produto() { Nome = "Outros" });
                Segmentos.Add(new Segmento() { Nome = "Administrativo" });
                Segmentos.Add(new Segmento() { Nome = "Aluminium" });
                Segmentos.Add(new Segmento() { Nome = "Cement" });
                Segmentos.Add(new Segmento() { Nome = "Ethanol" });
                Segmentos.Add(new Segmento() { Nome = "Food & Beverage" });
                Segmentos.Add(new Segmento() { Nome = "Foundry" });
                Segmentos.Add(new Segmento() { Nome = "Oil & Gas" });
                Segmentos.Add(new Segmento() { Nome = "Other Industries" });
                Segmentos.Add(new Segmento() { Nome = "Pellets" });
                Segmentos.Add(new Segmento() { Nome = "Power" });
                Segmentos.Add(new Segmento() { Nome = "Pulp & Paper" });
                Segmentos.Add(new Segmento() { Nome = "Steel" });
                Segmentos.Add(new Segmento() { Nome = "Tunnel & Metro" });
                Segmentos.Add(new Segmento() { Nome = "Underground Mining" });
                Segmentos.Add(new Segmento() { Nome = "Water" });
                Tipos.Add(new Tipo() { Nome = "NB" });
                Tipos.Add(new Tipo() { Nome = "AFM - Peças" });
                Tipos.Add(new Tipo() { Nome = "AFM - Reformas" });
                Tipos.Add(new Tipo() { Nome = "AFM - Retrofit" });
                Tipos.Add(new Tipo() { Nome = "AFM - Serviços" });
                Responsaveis.Add(new Responsavel() { Nome = "Edson" });
                Responsaveis.Add(new Responsavel() { Nome = "Rafael" });
                Responsaveis.Add(new Responsavel() { Nome = "Ricardo" });
                Responsaveis.Add(new Responsavel() { Nome = "Rodrigo" });
                Responsaveis.Add(new Responsavel() { Nome = "Thiago" });
                Statuses.Add(new Status() { Nome = "Aberto" });
                Statuses.Add(new Status() { Nome = "Não registrado" });
                Statuses.Add(new Status() { Nome = "Declinado" });
                Statuses.Add(new Status() { Nome = "Aguardando" });
                Statuses.Add(new Status() { Nome = "Finalizado" });
                AnaliseCredito.Add(new AnaliseCredito() { Nome = "Em análise" });
                AnaliseCredito.Add(new AnaliseCredito() { Nome = "Aprovado" });
                AnaliseCredito.Add(new AnaliseCredito() { Nome = "Reprovado" });
                this.SaveChanges();
            }

            //Dailies.Add(new Daily()
            //{
            //    Cliente = "Cliente 1",
            //    CRM = "CRM 1",
            //    DataAprovacao = DateTime.Now,
            //    DataDefinicao = DateTime.Now,
            //    DataEntregaPrevista = DateTime.Now,
            //    DataEntregaReal = DateTime.Now,
            //    Pendencia = "Pendencia 1",
            //    //findasync produto nome = "ventiladores"
            //    Produto = Produtos.First(p => p.Nome == "Ventiladores"),
            //    Projeto_Aplicacao = "Projeto_Aplicacao 1",
            //    PV = "",
            //    Responsavel = Responsaveis.First(r => r.Nome == "Edson"),
            //    Segmento = Segmentos.First(s => s.Nome == "Underground Mining"),
            //    Status = Statuses.First(s => s.Nome == "Aberto"),
            //    Tipo = Tipos.First(t => t.Nome == "NB"),
            //    AnaliseCredito = AnaliseCredito.First(a => a.Nome == "Em análise")
            //});

            //this.SaveChanges();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Produto>().HasData(
                new Produto() { Id = 1, Nome = "Compressores" },
                new Produto() { Id = 2, Nome = "Ventiladores" },
                new Produto() { Id = 3, Nome = "Pré-aquecedores" },
                new Produto() { Id = 4, Nome = "Outros" }
                );
            modelBuilder.Entity<Segmento>().HasData(
                new Segmento() { Id = 1, Nome = "Administrativo" },
                new Segmento() { Id = 2, Nome = "Aluminium" },
                new Segmento() { Id = 3, Nome = "Cement" },
                new Segmento() { Id = 4, Nome = "Ethanol" },
                new Segmento() { Id = 5, Nome = "Food & Beverage" },
                new Segmento() { Id = 6, Nome = "Foundry" },
                new Segmento() { Id = 7, Nome = "Oil & Gas" },
                new Segmento() { Id = 8, Nome = "Other Industries" },
                new Segmento() { Id = 9, Nome = "Pellets" },
                new Segmento() { Id = 10, Nome = "Power" },
                new Segmento() { Id = 11, Nome = "Pulp & Paper" },
                new Segmento() { Id = 12, Nome = "Steel" },
                new Segmento() { Id = 13, Nome = "Tunnel & Metro" },
                new Segmento() { Id = 14, Nome = "Underground Mining" },
                new Segmento() { Id = 15, Nome = "Water" }
                );
            //Tipo tem os seguintes tipos dados: NB, AFM - Peças, AFM - Reformas, AFM - Retrofit, AFM - Serviços
            modelBuilder.Entity<Tipo>().HasData(
                    new Tipo() { Id = 1, Nome = "NB" },
                    new Tipo() { Id = 2, Nome = "AFM - Peças" },
                    new Tipo() { Id = 3, Nome = "AFM - Reformas" },
                    new Tipo() { Id = 4, Nome = "AFM - Retrofit" },
                    new Tipo() { Id = 5, Nome = "AFM - Serviços" }
                );
            modelBuilder.Entity<Responsavel>().HasData(
                    new Responsavel() { Id = 1, Nome = "Edson" },
                    new Responsavel() { Id = 2, Nome = "Rafael" },
                    new Responsavel() { Id = 3, Nome = "Ricardo" },
                    new Responsavel() { Id = 4, Nome = "Rodrigo" },
                    new Responsavel() { Id = 5, Nome = "Thiago" }
                );
            modelBuilder.Entity<Status>().HasData(
                    new Status() { Id = 1, Nome = "Aberto" },
                    new Status() { Id = 2, Nome = "Não registrado" },
                    new Status() { Id = 3, Nome = "Declinado" },
                    new Status() { Id = 4, Nome = "Aguardando" },
                    new Status() { Id = 5, Nome = "Finalizado" }
                );
            modelBuilder.Entity<AnaliseCredito>().HasData(
                    new AnaliseCredito() { Id = 1, Nome = "Em análise" },
                    new AnaliseCredito() { Id = 2, Nome = "Aprovado" },
                    new AnaliseCredito() { Id = 3, Nome = "Reprovado" }
                );
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlite("Data Source=daily.db");
        }
    }
}