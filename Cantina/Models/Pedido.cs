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
        public int Id { get; set; }
        public virtual Cliente Cli { get; set; }
        public bool Delivery { get; set; }
        public DateTime DataCompra { get; set; }
        public bool Finalizado { get; set; }
        [StringLength(200)]
        public string Descricao { get; set; }
        public Produto Prod { get; set; }
    }
}
