using Microsoft.EntityFrameworkCore;
using ProjetoCinema.Data;
using ProjetoCinema.Models;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjetoCinema
{
    public partial class Form1 : Form
    {
        // String de conexão com o banco de dados
        private string connectionString = @"Data Source=LAPTOP-VFC28UJV\SQLEXPRESS;Initial Catalog=Cinema;Integrated Security=True";

        // Variável para armazenar o cliente_id
        private int cliente_id;

        public Form1()
        {
            InitializeComponent();
            private CinemaDbContext _dbContext;



        private async void btnEntrar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            using (_dbContext) {

                try
                {
                    Cliente cliente = await _dbContext.clientes.FindAsync(c => c.nome_cliente == nome);
                }
            }
        }
     }
 }


