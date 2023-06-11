using Microsoft.EntityFrameworkCore;
using ProjetoCinema.Data;
using ProjetoCinema.Models;
using ProjetoCinema.Service;
using System.ComponentModel;
using System.Diagnostics;

namespace ProjetoCinema
{
    public partial class Form1 : Form
    {
        private CinemaDbContext? dbContext;
        private ClienteService? clienteService;

        private int cliente_id;

        public Form1()
        {
            InitializeComponent();

        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.dbContext = new CinemaDbContext();
            this.dbContext.Database.EnsureCreated();
            clienteService = new ClienteService(dbContext);
        }

        private async void btnEntrar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;

            try
            {
                if (clienteService != null)
                {
                    int? clienteId = await clienteService.PegarClienteId(nome);

                    if (clienteId.HasValue)
                    {
                        cliente_id = clienteId.Value;
                        Form2 form2 = new Form2(cliente_id);
                        form2.Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            this.dbContext?.Dispose();
            this.dbContext = null;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            FormCadastro formCadastro = new FormCadastro();
            formCadastro.Show();
            this.Hide();
        }
    }
}