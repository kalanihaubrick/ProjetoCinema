using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ProjetoCinema.Data;
using ProjetoCinema.Models;
using System.Data;
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
        private int SessaoId;
        private string? Assento;
        int Numero;

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
        private async Task<List<AssentoStatus>?> ListarAssentos(int SessaoId, int SalaId)
        {
            if (dbContext != null)
            {
                try
                {
                    List<AssentoStatus> assentos = new List<AssentoStatus>();

                    using (var connection = new SqlConnection(dbContext.Database.GetConnectionString()))
                    {
                        using (var command = new SqlCommand("sp_listar_assentos", connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@sessao_id", SessaoId);
                            command.Parameters.AddWithValue("@sala_id", SalaId);

                            connection.Open();

                            await using (var reader = command.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    string assento = reader.GetString(0);
                                    string status = reader.GetString(1);

                                    AssentoStatus assentoStatus = new AssentoStatus { Assento = assento, Status = status };
                                    assentos.Add(assentoStatus);
                                }
                            }
                        }
                    }

                    return assentos;
                }

                catch (Exception ex)
                {
                    Debug.WriteLine(ex);
                }
            }
            return null;
        }
        private void PopulaGridView(List<AssentoStatus> ListaDeAssentos)
        {
            DataGridAssentos.Columns.Clear();
            DataGridAssentos.Columns.Add(ColunaAssentos);
            DataGridAssentos.Columns.Add(ColunaStatus);
            DataGridAssentos.Columns.Add(ColunaSelecao);

            foreach (AssentoStatus assentoStatus in ListaDeAssentos)
            {
                DataGridViewRow row = new DataGridViewRow();

                DataGridViewTextBoxCell AssentoCell = new DataGridViewTextBoxCell();
                AssentoCell.Value = assentoStatus.Assento;
                row.Cells.Add(AssentoCell);

                DataGridViewTextBoxCell StatusCell = new DataGridViewTextBoxCell();
                StatusCell.Value = assentoStatus.Status;
                row.Cells.Add(StatusCell);

                DataGridViewButtonCell selecionarCell = new DataGridViewButtonCell();
                selecionarCell.Value = "Selecionar";
                row.Cells.Add(selecionarCell);

                DataGridAssentos.Rows.Add(row);
            }
        }
        private async Task ReservarAssento(int ClienteId, int SessaoId, char Fileira, int Numero)
        {
            try
            {
                if (dbContext != null)
                {

                    using (var connection = new SqlConnection(dbContext.Database.GetConnectionString()))
                    {
                        using (var command = new SqlCommand("sp_criar_reserva", connection))
                        {
                            command.CommandType = CommandType.StoredProcedure;
                            command.Parameters.AddWithValue("@cliente_id", ClienteId);
                            command.Parameters.AddWithValue("@sessao_id", SessaoId);
                            command.Parameters.AddWithValue("@fileira", Fileira);
                            command.Parameters.AddWithValue("@numero_assento", Numero);

                            connection.Open();

                            await command.ExecuteNonQueryAsync();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e) { }

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
            DataGridAssentos.Columns.Clear();
            BtnListar.Enabled = false;
            TextConfirmacaoAssento.Text = "";
            TextConfirmacaoHora.Text = "";
            TextConfirmacaoData.Text = "";
            BtnComprar.Enabled = false;


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
            DataGridAssentos.Columns.Clear();
            BtnListar.Enabled = false;
            TextConfirmacaoAssento.Text = "";
            TextConfirmacaoHora.Text = "";
            BtnComprar.Enabled = false;

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
            DataGridAssentos.Columns.Clear();
            TextConfirmacaoAssento.Text = "";
            BtnComprar.Enabled = false;


            if (ComboHora.SelectedItem != null)
            {
                HoraSessao = ComboHora.SelectedItem.ToString();
                TextConfirmacaoHora.Text = ComboHora.SelectedItem.ToString();
                BtnListar.Enabled = true;
            }

        }

        private async void BtnListar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dbContext != null)
                {
                    DateTime DataHora = DateTime.ParseExact(DataSessao + " " + HoraSessao, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

                    var sessao = await dbContext.sessao
                        .FirstOrDefaultAsync(s => s.filme_id == FilmeId && s.horario == DataHora);

                    if (sessao != null)
                    {
                        SessaoId = sessao.sessao_id;
                        int SalaId = sessao.sala_id;
                        List<AssentoStatus>? ListaDeAssentos = await ListarAssentos(SessaoId, SalaId);


                        if (ListaDeAssentos != null)
                        {
                            PopulaGridView(ListaDeAssentos);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        private void DataGridAssentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == ColunaSelecao.Index)
            {
                DataGridViewRow DataGrid = DataGridAssentos.Rows[e.RowIndex];

                Assento = DataGrid.Cells[ColunaAssentos.Index].Value.ToString();
                string? status = DataGrid.Cells[ColunaStatus.Index].Value.ToString();

                if (status != "Ocupado")
                {
                    TextConfirmacaoAssento.Text = Assento;
                    BtnComprar.Enabled = true;
                }
                if (status == "Ocupado")
                {
                    MessageBox.Show("Assento ocupado, por favor selecione outra opção");
                }


            }
        }

        private async void BtnComprar_Click(object sender, EventArgs e)
        {
            if (dbContext != null)
            {
                char Fileira = Assento[0];
                string StringNumero = Assento.Substring(1);

                if (int.TryParse(StringNumero, out int value))
                {
                    Numero = value;
                }
                try
                {
                    await ReservarAssento(client_id, SessaoId, Fileira, Numero);
                    MessageBox.Show($"Compra efetuada com sucesso! Assento:{Assento}");

                    DataGridAssentos.Columns.Clear();
                    BtnComprar.Enabled = false;
                    TextConfirmacaoAssento.Text = "";
                    TextConfirmacaoData.Text = "";
                    TextConfirmacaoFilme.Text = "";
                    TextConfirmacaoHora.Text = "";
                    comboFilme.SelectedIndex = -1;
                    ComboData.SelectedIndex = -1;
                    ComboHora.SelectedIndex = -1;
                }
                catch (Exception ex)
                {

                    Debug.WriteLine(ex);
                }
            }

        }
    }
}
