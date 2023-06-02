using Microsoft.EntityFrameworkCore;
using ProjetoCinema.Data;
using ProjetoCinema.Models;
using System.Diagnostics;

namespace ProjetoCinema
{
    public partial class Form2 : Form
    {
        private CinemaDbContext? dbContext;

        public int cliente_id;
        public Form2()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.dbContext = new CinemaDbContext();
            this.dbContext.Database.EnsureCreated();
        }
        private async Task CarregarFilmes()
        {
            try
            {
                if (dbContext != null)
                {
                    List<string?> dados = await dbContext.filme.Select(f => f.nome_filme).ToListAsync();
                    comboFilmes.Items.AddRange(dados.ToArray());
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void comboFilmes_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private async void Form2_Load(object sender, EventArgs e)
        {
            await CarregarFilmes();
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {
        }
    }
}
