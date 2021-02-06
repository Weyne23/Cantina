using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Cantina
{
    public class Cliente
    {
        public Cliente(string nome, Pedido pedido)
        {
            Nome = nome;
            Ped = pedido;
        }
        public int Id { get; set; }
        [StringLength(100)]
        public string Nome { get; set; }
        public Pedido Ped { get; set; }
        public override string ToString() => $"{Nome}".Trim();
    }
}
