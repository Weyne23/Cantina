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

        public void exibirPedidos()
        {
            lv_pedidos.Items.Clear();
            using (var ctx = new ApplicationDBContext())
            {
                int x = -1;
                var pedidos = (from p in ctx.Pedidos
                               join ip in ctx.ItemPedidos on p.PedidoId equals ip.PedidoId
                               select new
                               {
                                   idPedido = p.PedidoId,
                                   nomeCliente = p.Cliente.Nome,
                                   delivery = p.Cliente.Endereco == "" ? "Não" : "Sim",
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
                var resultado = MessageBox.Show("Deseja Remover esse produto do pedido?", "Excluir", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    using (var ctx = new ApplicationDBContext())
                    {
                        var pedidos = ctx.Pedidos;
                        foreach (var p in pedidos)
                        {
                            if (p.PedidoId == Convert.ToInt32(lv_pedidos.SelectedItems[0].SubItems[0].Text))
                            {
                                ctx.Remove(p);
;                           }
                        }
                        ctx.SaveChanges();
                        exibirPedidos();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Para remover um pedido escolha uma das opções na lista de pedidos e clique em Remover Entregue!", "Erro");
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

        private void btn_entregue_Click(object sender, EventArgs e)
        {
            try
            {
                var resultado = MessageBox.Show("Esse pedido já foi entregue?", "Mensagem", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    using (var ctx = new ApplicationDBContext())
                    {
                        var pedidos = ctx.Pedidos;
                        foreach (var p in pedidos)
                        {
                            if (p.PedidoId == Convert.ToInt32(lv_pedidos.SelectedItems[0].SubItems[0].Text))
                            {
                                p.Finalizado = true;
                                ctx.Remove(p);
                            }
                        }
                        ctx.SaveChanges();
                        exibirPedidos();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Para dizer que o pedido foi entregue escolha uma das opções na lista de pedidos e clique em Pedido Entregue!", "Erro");
                return;
            }
        }
    }
}