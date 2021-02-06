using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantina
{
    public class Pedido
    {
        public Pedido(List<Produto> produtos, Cliente cliente)
        {
            Prod = produtos;
            Cli = cliente;
            Id++;
        }
        public int Id { get; set; }
        public Cliente Cli { get; set; }
        public List<Produto> Prod { get; set; }
    }
}
