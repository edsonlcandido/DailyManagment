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
        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }
        public int SegmentoId { get; set; }
        public Segmento Segmento { get; set; }
        public int TipoId { get; set; }
        public Tipo Tipo { get; set; }
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
        public int ResponsavelId { get; set; }
        [DisplayName("Responsável")]
        public Responsavel Responsavel { get; set; }
        public string? CRM { get; set; }
        public int StatusId { get; set; }
        public Status Status { get; set; }
        public int AnaliseCreditoId { get; set; }
        [DisplayName("Analise de Crédito")]
        public AnaliseCredito AnaliseCredito { get; set; }
        [DisplayName("Data Aprovação")]
        public DateTime? DataAprovacao { get ; set; }
        [DisplayName("Pendência")]
        public string? Pendencia { get; set; }
        public string? PV { get; set; }
    }
}
