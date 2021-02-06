using Cantina;
using Microsoft.EntityFrameworkCore;
namespace WF_Aluno_EFCore.Models
{
    public class ApplicationDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-9FAFID2\\SQLEXPRESS;Initial Catalog=db_cantina;Integrated Security=True");
        }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
    }
}