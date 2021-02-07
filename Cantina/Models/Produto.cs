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
        public int Id { get; set; }
        [StringLength(100)]
        public string Nome { get; set; }
        [StringLength(200)]
        public string Descricao { get; set; }
        public double Valor { get; set; }
    }
}
