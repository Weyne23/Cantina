using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantina
{
    public class ItemPedido
    {
        public int ItemPedidoId { get; set; }
        public int ProdutoID { get; set; }
        public virtual Produto Produto { get; set; }
        public int PedidoId { get; set; }
        public virtual Pedido Pedido { get; set; }
        public int Quantidade { get; set; }
        public double valorUnitario { get; set; }
    }
}
