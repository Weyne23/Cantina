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
    public partial class F_Cantina : Form
    {
        public F_Cantina()
        {
            InitializeComponent();
            exibirPedidos();
        }

        private void btn_adicionarPedido_Click(object sender, EventArgs e)
        {
            F_AdicionarPedido ad = new F_AdicionarPedido();
            ad.ShowDialog();
        }

        private void pedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_AdicionarPedido ad = new F_AdicionarPedido();
            ad.ShowDialog();
        }

        private void exibirPedidos()
        {
            lv_pedidos.Items.Clear();
           // double valor2 = 0; double valor = 0;
            using (var ctx = new ApplicationDBContext())
            {
                int x = -1;
                var pedidos = (from p in ctx.Pedidos
                               join ip in ctx.ItemPedidos on p.PedidoId equals ip.PedidoId
                               //join prod in ctx.Produtos on ip.ProdutoID equals prod.ProdutoId
                               select new
                               {
                                   idPedido = p.PedidoId,
                                   nomeCliente = p.Cliente.Nome,
                                   delivery = p.Cliente.Endereco == "" ? "Não" : "Sim",
                                   //quantidade = ip.Quantidade,
                                   valorTotal = p.ValorTotal,
                                   valorUni = ip.valorUnitario,
                               });
                foreach (var p in pedidos)
                {
                    if (p.idPedido != x)
                    {
                        ListViewItem lvi = new ListViewItem(p.idPedido.ToString());
                        lvi.SubItems.Add(p.nomeCliente);
                        lvi.SubItems.Add(p.delivery.ToString());
                        //valor += p.valorUni * p.quantidade;
                        lvi.SubItems.Add(p.valorTotal.ToString("C2"));
                        lv_pedidos.Items.Add(lvi);
                    }
                    x = p.idPedido;
                }
            }
        }

       

        private void btn_rev_Click(object sender, EventArgs e)
        {
            try
            {
                var resultado = MessageBox.Show("Deseja Remover esse pedido?", "Excluir", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    lv_pedidos.Items.RemoveAt(lv_pedidos.SelectedIndices[0]);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Nenhum pedido selecionado!", "Erro");
                return;
            }
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Produtos f_Produtos = new F_Produtos();
            f_Produtos.ShowDialog();
        }

        private void btn_detalhes_Click(object sender, EventArgs e)
        {
            F_DetalhesDoPedido f_DetalhesDoPedido = new F_DetalhesDoPedido();
            f_DetalhesDoPedido.ShowDialog();
        }
    }
}
