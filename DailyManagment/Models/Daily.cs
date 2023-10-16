using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyManagment.Models
{
    public class Daily
    {
        public int id { get; set; }
        public string Produto { get; set; }
        public string? Segmento { get; set; }
        public string? Tipo { get; set; }
        public string? Cliente { get; set; }
        public string? Rev { get; set; }
        public DateTime? DataDefinicao { get; set; }
        public DateTime? DataEntregaPrevista { get; set; }
        public DateTime? DataEntregaReal { get; set; }
        public string? Projeto_Aplicacao { get; set; }
        public string? Responsavel { get; set; }
        public string? CRM { get; set; }
        public string? Status { get; set; }
        public string? AnaliseCredito { get; set; }
        public DateTime? DataAprovacao { get; set; }
        public string? Pendencia { get; set; }
        public string? PV { get; set; }
    }
}
