using Microsoft.EntityFrameworkCore;
using ProjetoCinema.Data;
using ProjetoCinema.Models;
using System.Diagnostics;

namespace ProjetoCinema
{
    public partial class Form2 : Form
    {
        private CinemaDbContext? dbContext;
        public int client_id;
        private int FilmeId;
        private DateTime? DataSessao;
        private TimeOnly? HoraSessao;
        public Form2(int ClienteId)
        {
            InitializeComponent();

            client_id = ClienteId;
            this.dbContext = new CinemaDbContext();
            this.dbContext.Database.EnsureCreated();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }

        private async Task CarregarFilmes()
        {
            try
            {
                if (dbContext != null)
                {

                    List<Filme> dados = await dbContext.filme.ToListAsync();
                    comboFilme.DataSource = dados;
                    comboFilme.DisplayMember = "nome_filme";
                    comboFilme.ValueMember = "filme_id";
                    comboFilme.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {

                Debug.WriteLine(ex);
            }
        }
        private async Task CarregarDatasSessao(int FilmeId)
        {
            try
            {
                if (dbContext != null)
                {
                    List<DateTime> DataSessao = await dbContext.sessao
                        .Where(s => s.filme_id == FilmeId)
                        .Select(s => s.horario.Date)
                        .Distinct()
                        .ToListAsync();
                    if (DataSessao.Count > 0)
                    {
                        ComboData.Items.Clear();
                        ComboData.Items.AddRange(DataSessao.Select(d => d.ToShortDateString()).ToArray());
                        ComboData.SelectedIndex = -1;
                    }
                    else
                    {
                        ComboData.Items.Clear();
                        ComboData.SelectedIndex = -1;

                    }


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

        private async void Form2_Load(object sender, EventArgs e)
        {
            await CarregarFilmes();

        }

        private async void comboFilme_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboFilme.SelectedValue != null)
            {
                if (int.TryParse(comboFilme.SelectedValue.ToString(), out int value))
                {
                    FilmeId = value;
                    await CarregarDatasSessao(FilmeId);

                }
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ComboData_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
