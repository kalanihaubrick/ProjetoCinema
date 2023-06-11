using ProjetoCinema.Data;
using ProjetoCinema.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCinema
{
    public partial class FormCadastro : Form
    {
        CinemaDbContext? dbContext;
        ClienteService? clienteService;
        int clienteId;
        public FormCadastro()
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

        private async void btnCadastrar_Click(object sender, EventArgs e)
        {
            string? nome = textCadastro.Text;
            if (nome != "")
            {
            if (clienteService != null)
            {
                await clienteService.CadastrarCliente(nome);
                int? cliente = await clienteService.PegarClienteId(nome);
                if (cliente.HasValue)
                {
                    clienteId = cliente.Value;
                    Form2 form2 = new Form2(clienteId);
                    form2.Show();
                    this.Hide();
                }
            }
            } else
            {
                MessageBox.Show("Digite um nome, por favor.");
            }



        }
    }
}
