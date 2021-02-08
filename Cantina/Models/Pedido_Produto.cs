using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantina
{
    public class Pedido_Produto
    {
        public int Id { get; set; }
        public Pedido Pedido { get; set; }
        public Produto Produto { get; set; }
    }
}
