using Microsoft.EntityFrameworkCore;
using ProjetoCinema.Data;
using ProjetoCinema.Models;
using System.ComponentModel;
using System.Diagnostics;

namespace ProjetoCinema
{
    public partial class Form1 : Form
    {
        private CinemaDbContext? dbContext;

        // Vari�vel para armazenar o cliente_id
        private int cliente_id;

        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.dbContext = new CinemaDbContext();

            // Uncomment the line below to start fresh with a new database.
            // this.dbContext.Database.EnsureDeleted();
            this.dbContext.Database.EnsureCreated();
        }

        private async void btnEntrar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;

            try
            {
                if (dbContext != null)
                {
                    Cliente? cliente = await dbContext.Clientes.FirstOrDefaultAsync(c => c.cliente_nome == nome);
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
    }
}