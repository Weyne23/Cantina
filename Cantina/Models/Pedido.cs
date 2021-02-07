using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Cantina
{
    public class Pedido
    {
        public int PedidoId { get; set; }
        public int ClienteID { get; set; }
        public virtual Cliente Cliente { get; set; }
        public DateTime DataCompra { get; set; }
        public bool Finalizado { get; set; }
        [StringLength(200)]
        public string Descricao { get; set; }
        public double ValorTotal { get; set; }
        public bool Viagem { get; set; }
        public virtual List<ItemPedido> ItensPedido { get; set; }
    }
}
