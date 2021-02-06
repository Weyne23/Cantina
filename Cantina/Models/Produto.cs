using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Cantina
{
    public class Produto
    {
        public Produto(string nome, Decimal valor)
        {
            Nome = nome;
            Valor = valor;
        }
        public int Id { get; set; }
        [StringLength(100)]
        public string Nome { get; set; }
        public Decimal Valor { get; set; }
    }
}
