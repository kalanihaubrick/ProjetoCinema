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

        public int cliente_id;

        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.dbContext = new CinemaDbContext();

            this.dbContext.Database.EnsureCreated();
        }

        private async void btnEntrar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;

            try
            {
                if (dbContext != null)
                {
                    Cliente? cliente = await dbContext.cliente.FirstOrDefaultAsync(c => c.nome_cliente == nome);
                    if (cliente == null)
                    {
                        MessageBox.Show("Cliente n�o encontrado.");
                        return;
                    }
                    cliente_id = cliente.cliente_id;

                    Form2 form2 = new Form2();
                    form2.cliente_id = cliente_id;
                    form2.Show();
                    this.Hide();
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
    }
}