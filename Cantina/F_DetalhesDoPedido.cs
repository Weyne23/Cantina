using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WF_Aluno_EFCore.Models;

namespace Cantina
{
    public partial class F_DetalhesDoPedido : Form
    {
        F_Cantina f_Cantina;
        public F_DetalhesDoPedido()
        {
            InitializeComponent();
            f_Cantina = Application.OpenForms["F_Cantina"] as F_Cantina;
            carregarTela();
        }

        public void carregarTela()
        {
            lb_numPedido.Text = f_Cantina.lv_pedidos.SelectedItems[0].SubItems[0].Text;
            using (var ctx = new ApplicationDBContext())
            {
                var pedidos = ctx.Pedidos.Where(p => p.ClienteID == Convert.ToInt32(f_Cantina.lv_pedidos.SelectedItems[0].SubItems[0].Text));
                foreach (var p in pedidos)
                {
                    Console.WriteLine(p.ValorTotal);
                    tb_nomeCliente.Text = f_Cantina.lv_pedidos.SelectedItems[0].SubItems[1].Text;
                    tb_horario.Text = p.DataCompra.ToString();
                    tb_observacoes.Text = p.Descricao;
                    lb_valorTotal.Text = p.ValorTotal.ToString("C2");
                    //tb_endereco.Text = p.Cliente.Endereco;
                }
                //tb_observacoes.Text = pedido.Descricao;
                
                //tb_endereco.Text = pedido.Cliente.Endereco;
                //tb_observacoes.Text = pedido.ItensPedido[0].Produto.Nome;
            }
        }
    }
}
/*
 * var pedidos = (from p in ctx.Pedidos
                               join c in ctx.Clientes on p.ClienteID equals c.Id
                               join prod in ctx.Produtos on c. equals prod.ProdutoId
                               select new
                               {
                                   nomeCliente = c.Nome,
                                   data = p.DataCompra,
                                   endereco = c.Endereco,
                                   observacoes = p.Descricao,
                                   valorTotal = p.ValorTotal,
                               });
*/
