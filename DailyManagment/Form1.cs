using DailyManagment.Data.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace DailyManagment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = DailyRepository.GetAll();
        }
    }
}