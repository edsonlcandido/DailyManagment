using System.ComponentModel;

namespace DailyManagment.Models
{
    public class AnaliseCredito
    {
        public int Id { get; set; }
        [DisplayName("Data Aprovação")]
        public DateTime? DataAprovacao { get; set; }
    }
}