using DailyManagment.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System.ComponentModel;
using System.Data;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using DailyManagment.Models;

namespace DailyManagment
{
    public partial class Form1 : Form
    {
        private DailyMainView _dailyMainView;
        public Form1(DailyMainView mainView)
        {
            InitializeComponent();
            _dailyMainView = mainView;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //create a datatable to show only nethis columns using the displayname for column caption
            //produto, Segmento, Tipo, Cliente, Rev, DataDefinicao, DataEntregaPrevista, DataEntregaReal, Projeto_Aplicacao, Responsavel, CRM, Status, AnaliseCredito, DataAprovacao, Pendencia, PV
            DataTable dt = new DataTable();

            dt = _dailyMainView.ListDailyModelViews.ToDataTable();

            //dt.Columns.Add();
            //dt.Columns.Add("Segmento");
            //dt.Columns.Add("Tipo");
            //dt.Columns.Add("Cliente");
            //dt.Columns.Add("Rev");
            //dt.Columns.Add("DataDefinicao");

            dataGridView1.DataSource = dt;

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
                return;
            Daily daily = DailyRepository.Get((int)dataGridView1.SelectedRows[0].Cells["#"].Value);
        }
    }

    //create a extension class with method to convert list to datatable
    public static class ExtensionMethods
    {
        public static DataTable ToDataTable(this List<DailyViewModel> data)
        {
            DataTable dt = new DataTable();
            //create a datatable to show only nethis columns using the displayname for column caption
            //produto, Segmento, Tipo, Cliente, Rev, DataDefinicao, DataEntregaPrevista, DataEntregaReal, Projeto_Aplicacao, Responsavel, CRM, Status, AnaliseCredito, DataAprovacao, Pendencia, PV
            //get data displayname from properties of DailyViewModel            
            dt.Columns.Add("#");
            //hide column #
            dt.Columns["#"].ColumnMapping = MappingType.Hidden;
            string labelProduto = typeof(DailyViewModel).GetProperty("Produto").GetCustomAttribute<DisplayNameAttribute>().DisplayName;
            dt.Columns.Add(labelProduto);
            string labelSegmento = typeof(DailyViewModel).GetProperty("Segmento").GetCustomAttribute<DisplayNameAttribute>().DisplayName;
            dt.Columns.Add(labelSegmento);
            string labelTipo = typeof(DailyViewModel).GetProperty("Tipo").GetCustomAttribute<DisplayNameAttribute>().DisplayName;
            dt.Columns.Add(labelTipo);
            string labelCliente = typeof(DailyViewModel).GetProperty("Cliente").GetCustomAttribute<DisplayNameAttribute>().DisplayName;
            dt.Columns.Add(labelCliente);
            string labelRev = typeof(DailyViewModel).GetProperty("Rev").GetCustomAttribute<DisplayNameAttribute>().DisplayName;
            dt.Columns.Add(labelRev);
            string labelDataDefinicao = typeof(DailyViewModel).GetProperty("DataDefinicao").GetCustomAttribute<DisplayNameAttribute>().DisplayName;
            dt.Columns.Add(labelDataDefinicao);
            string labelDataEntregaPrevista = typeof(DailyViewModel).GetProperty("DataEntregaPrevista").GetCustomAttribute<DisplayNameAttribute>().DisplayName;
            dt.Columns.Add(labelDataEntregaPrevista);
            string labelDataEntregaReal = typeof(DailyViewModel).GetProperty("DataEntregaReal").GetCustomAttribute<DisplayNameAttribute>().DisplayName;
            dt.Columns.Add(labelDataEntregaReal);
            string labelProjeto_Aplicacao = typeof(DailyViewModel).GetProperty("Projeto_Aplicacao").GetCustomAttribute<DisplayNameAttribute>().DisplayName;
            dt.Columns.Add(labelProjeto_Aplicacao);
            string labelResponsavel = typeof(DailyViewModel).GetProperty("Responsavel").GetCustomAttribute<DisplayNameAttribute>().DisplayName;
            dt.Columns.Add(labelResponsavel);
            string labelCRM = typeof(DailyViewModel).GetProperty("CRM").GetCustomAttribute<DisplayNameAttribute>().DisplayName;
            dt.Columns.Add(labelCRM);
            string labelStatus = typeof(DailyViewModel).GetProperty("Status").GetCustomAttribute<DisplayNameAttribute>().DisplayName;
            dt.Columns.Add(labelStatus);
            string labelAnaliseCredito = typeof(DailyViewModel).GetProperty("AnaliseCredito").GetCustomAttribute<DisplayNameAttribute>().DisplayName;
            dt.Columns.Add(labelAnaliseCredito);
            string labelDataAprovacao = typeof(DailyViewModel).GetProperty("DataAprovacao").GetCustomAttribute<DisplayNameAttribute>().DisplayName;
            dt.Columns.Add(labelDataAprovacao);
            string labelPendencia = typeof(DailyViewModel).GetProperty("Pendencia").GetCustomAttribute<DisplayNameAttribute>().DisplayName;
            dt.Columns.Add(labelPendencia);
            string labelPV = typeof(DailyViewModel).GetProperty("PV").GetCustomAttribute<DisplayNameAttribute>().DisplayName;
            dt.Columns.Add(labelPV);
            foreach (DailyViewModel item in data)
            {
                DataRow row = dt.NewRow();
                row["#"] = item.Id;
                row[labelProduto] = item.Produto;
                row[labelSegmento] = item.Segmento;
                row[labelTipo] = item.Tipo;
                row[labelCliente] = item.Cliente;
                row[labelRev] = item.Rev;
                row[labelDataDefinicao] = item.DataDefinicao;
                row[labelDataEntregaPrevista] = item.DataEntregaPrevista;
                row[labelDataEntregaReal] = item.DataEntregaReal;
                row[labelProjeto_Aplicacao] = item.Projeto_Aplicacao;
                row[labelResponsavel] = item.Responsavel;
                row[labelCRM] = item.CRM;
                row[labelStatus] = item.Status;
                row[labelAnaliseCredito] = item.AnaliseCredito;
                row[labelDataAprovacao] = item.DataAprovacao;
                row[labelPendencia] = item.Pendencia;
                row[labelPV] = item.PV;
                dt.Rows.Add(row);
            }
            return dt;
        }
    }
}