
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ProjetoCinema.Data;
using ProjetoCinema.Models;
using System.Data;

namespace ProjetoCinema.Service
{
    public class ClienteService
    {
        private CinemaDbContext dbContext;

        public ClienteService(CinemaDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<int?> PegarClienteId(string? nomeCliente)
        {
            try
            {
                if (dbContext != null)
                {
                   Cliente? cliente = await dbContext.cliente.FirstOrDefaultAsync(c => c.nome_cliente == nomeCliente);
                    if (cliente == null) {
                        MessageBox.Show("Cliente não encontrado");
                        return null;
                    }
                    return cliente.cliente_id;
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        public async Task CadastrarCliente(string? nomeCliente)
        {
            try
            {
                if (dbContext != null)
                {
                    var cliente = await dbContext.cliente.FirstOrDefaultAsync(c => c.nome_cliente == nomeCliente);

                    if (cliente == null)
                    {
                        using (var connection = new SqlConnection(dbContext.Database.GetConnectionString()))
                        {
                            using (var command = new SqlCommand("sp_criar_cliente", connection))
                            {
                                command.CommandType = CommandType.StoredProcedure;
                                command.Parameters.AddWithValue("@nome_cliente", nomeCliente);

                                connection.Open();

                                await command.ExecuteNonQueryAsync();
                                }
                            }
                        MessageBox.Show("Cliente cadastrado com sucesso!");
                    } else
                    {
                        MessageBox.Show("Cliente cadastrado com sucesso!");
                    }

                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }

   
}
