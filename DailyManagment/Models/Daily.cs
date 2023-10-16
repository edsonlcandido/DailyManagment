using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyManagment.Models
{
    public class Daily
    {
        [DisplayName("#")]
        public int id { get; set; }
        public string Produto { get; set; }
        public string? Segmento { get; set; }
        public string? Tipo { get; set; }
        public string? Cliente { get; set; }
        public string? Rev { get; set; }
        [DisplayName("Data Definição")]
        public DateTime? DataDefinicao { get; set; }
        [DisplayName("Data Entrega Prevista")]
        public DateTime? DataEntregaPrevista { get; set; }
        [DisplayName("Data Entrega Real")]
        public DateTime? DataEntregaReal { get; set; }
        [DisplayName("Projeto / Aplicação")]
        public string? Projeto_Aplicacao { get; set; }
        [DisplayName("Responsável")]
        public string? Responsavel { get; set; }
        public string? CRM { get; set; }
        public string? Status { get; set; }
        [DisplayName("Analise de Crédito")]
        public string? AnaliseCredito { get; set; }
        [DisplayName("Data Aprovação")]
        public DateTime? DataAprovacao { get; set; }
        [DisplayName("Pendência")]
        public string? Pendencia { get; set; }
        public string? PV { get; set; }
    }
}
