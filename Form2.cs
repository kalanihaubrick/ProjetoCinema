using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ProjetoCinema.Data;
using ProjetoCinema.Models;
using System.Diagnostics;
using System.Globalization;

namespace ProjetoCinema
{
    public partial class Form2 : Form
    {
        private CinemaDbContext? dbContext;
        public int client_id;
        private int FilmeId;
        private string? DataSessao;
        private string? HoraSessao;
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
        private async Task CarregarDatasSessoes(int FilmeId)
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
        private async Task CarregarHorariosSessao(int FilmeId)
        {
            try
            {
                if (dbContext != null)
                {
                    List<DateTime> DataEHora = await dbContext.sessao
                        .Where(s => s.filme_id == FilmeId)
                        .Select(s => s.horario)
                        .ToListAsync();

                    List<string> HorariosSessao = DataEHora
                        .Select(h => h.ToString("HH:mm"))
                        .ToList();

                    if (HorariosSessao.Count > 0)
                    {
                        ComboHora.Items.Clear();
                        ComboHora.Items.AddRange(HorariosSessao.ToArray());
                        ComboHora.SelectedIndex = -1;
                    }
                    else
                    {
                        ComboHora.Items.Clear();
                        ComboHora.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }
        private async Task ListarAssentos(int SessaoId, int SalaId)
        {
            try
            {
                if (dbContext != null)
                {
                                           
                    var SessaoIdParam = new SqlParameter("@sessao_id", SessaoId);
                    var SalaIdParam = new SqlParameter("@sala_id", SalaId);

                    var Assentos = await dbContext.Database
                         .SqlQueryRaw<Assento>("Exec sp_listar_assentos @sessao_id, @sala_id", SessaoIdParam, SalaIdParam)
                         .ToListAsync();

                    if (Assentos.Count > 0)
                    {
                        ListViewAssentos.Items.Clear();
                        foreach (var Assento in Assentos)
                        {
                            var item = new ListViewItem(Assento.assento);
                            item.SubItems.Add(Assento.Status);
                            item.Checked = false;

                            ListViewAssentos.Items.Add(item);

                        }
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
            ComboHora.Items.Clear();
            ComboHora.Enabled = false;
            ComboData.Items.Clear();
            ComboData.Enabled = false;  
            TextConfirmacaoHora.Text = "";
            TextConfirmacaoData.Text = "";
            try
            {
                if (comboFilme.SelectedValue != null)
                {
                    if (int.TryParse(comboFilme.SelectedValue.ToString(), out int value))
                    {
                        FilmeId = value;
                        await CarregarDatasSessoes(FilmeId);
                        ComboData.Enabled = true;
                        Filme FilmeSelecionado = (Filme)comboFilme.SelectedItem;
                        TextConfirmacaoFilme.Text = FilmeSelecionado.nome_filme;
                    }
                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }

        }

        private async void ComboData_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboHora.Items.Clear();
            ComboHora.Enabled = false;
            TextConfirmacaoHora.Text = "";

            if (ComboData.SelectedItem != null)
            {
                DataSessao = ComboData.SelectedItem.ToString();
                await CarregarHorariosSessao(FilmeId);
                ComboHora.Enabled = true;
                TextConfirmacaoData.Text = ComboData.SelectedItem.ToString();
            }

        }

        private void ComboHora_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboHora.SelectedItem != null) 
            { 
            HoraSessao = ComboHora.SelectedItem.ToString();
            TextConfirmacaoHora.Text = ComboHora.SelectedItem.ToString();
            BtnListar.Enabled = true;
            }

        }

        private async void BtnListar_Click(object sender, EventArgs e)
        {
            DateTime DataHora = DateTime.ParseExact(DataSessao + " " + HoraSessao, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
            try
            {
                if (dbContext != null)
                {
                    var sessao = await dbContext.sessao
                        .FirstOrDefaultAsync(s => s.filme_id == FilmeId && s.horario == DataHora);

                    if (sessao != null)
                    {
                        int SessaoId = sessao.sessao_id;
                        int SalaId = sessao.sala_id;
                        await ListarAssentos(SessaoId, SalaId);
                    }

                }
            }
            catch (Exception ex)
            {

                Debug.WriteLine(ex);
            }
        }

    }
}
