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
    public partial class F_AdicionarPedido : Form
    {
        public DataTable dt = new DataTable();
        public F_AdicionarPedido()
        {
            InitializeComponent();
            ExibirProdutos();
        }

        private void limparTela()
        {
            tb_nomeCliente.Clear();
            tb_endereco.Clear();
            lv_itensPedido.Items.Clear();
            tb_observacoes.Clear();
            tb_nomeCliente.Focus();
        }
        private void ExibirProdutos()
        {
            List<Produto> produtos;
            lb_quentinhas.Items.Clear();

            using (var ctx = new ApplicationDBContext())
            {
                produtos = ctx.Produtos.ToList();
            }
            foreach (var produto in produtos)
                lb_quentinhas.Items.Add(produto.Nome);
        }

        private void bet_remover_Click(object sender, EventArgs e)
        {
            try
            {
                var resultado = MessageBox.Show("Deseja Remover esse item do pedido?", "Excluir", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    lv_itensPedido.Items.RemoveAt(lv_itensPedido.SelectedIndices[0]);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Para excluir escolha uma das opções na lista de pedidos e clique em excluir!", "Erro");
                return;
            }
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            if(lb_quentinhas.SelectedItem == null)
            {
                MessageBox.Show("Nenhum item selecionado!", "Erro");
                return;
            }
            else
            {
                ListViewItem lvi = new ListViewItem(lb_quentinhas.SelectedItem.ToString());
                lvi.SubItems.Add(numericUpDown.Value.ToString());
                lv_itensPedido.Items.Add(lvi);
                numericUpDown.Value = 1;
            }
        }

        private void btn_finalizarPedido_Click(object sender, EventArgs e)
        {
            using (var ctx = new ApplicationDBContext())
            {
                var cliente2 = ctx.Clientes.ToList();
                foreach (var cli in cliente2)
                {
                    if (cli.Nome == tb_nomeCliente.Text)
                    {
                        MessageBox.Show("Nome ja cadastrado!", "Erro");
                        return;
                    }
                }
                Pedido pedido = new Pedido();
                Cliente cliente = new Cliente();
                Produto produto = new Produto();
                List<Produto> produtos = new List<Produto>();
                List<ItemPedido> itemPedidos = new List<ItemPedido>();
                int y = 0;
                double valor = 0;
                produtos = ctx.Produtos.ToList();
                cliente.Endereco = tb_endereco.Text;
                cliente.Nome = tb_nomeCliente.Text;
                pedido.Cliente = cliente;
                pedido.Descricao = tb_observacoes.Text;
                pedido.DataCompra = DateTime.Now;
                if (tb_endereco.Text == "")
                {
                    pedido.Viagem = true;
                }
                else
                {
                    pedido.Viagem = false;
                }
                for (int i = 0; i < lv_itensPedido.Items.Count; i++)
                {
                    foreach (var prod in produtos)
                    {
                        ItemPedido itemPedido = new ItemPedido();
                        if (prod.Nome == lv_itensPedido.Items[i].SubItems[0].Text)
                        {
                            itemPedido.Produto = prod;
                            itemPedido.Pedido = pedido;
                            Console.WriteLine(lv_itensPedido.Items[i].SubItems[1].Text);
                            itemPedido.Quantidade = Convert.ToInt32(lv_itensPedido.Items[i].SubItems[1].Text);
                            itemPedido.valorUnitario = prod.Valor;
                            valor += (prod.Valor * itemPedido.Quantidade);
                            y += itemPedido.Quantidade;
                            ctx.Add(itemPedido);
                        }
                        itemPedidos.Add(itemPedido);
                    }

                }
                if (y >= 5)
                {
                    valor -= valor * 0.215;
                }
                pedido.ValorTotal = valor;
                var resultado = MessageBox.Show("Desejá finalizar o pedido? total = " + valor, "Mensagem", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    ctx.Add(pedido);
                    ctx.Add(cliente);
                    ctx.SaveChanges();
                    limparTela();
                }
                else
                {
                    return;
                }
                
            }
        }
    }
}

/*
 * x++;
                            y += Convert.ToInt32(lv_itensPedido.Items[x].SubItems[1]);
                            valor = prod.Valor * Convert.ToInt32(lv_itensPedido.Items[x].SubItems[1]);
                            itemPedido.Quantidade = Convert.ToInt32(lv_itensPedido.Items[x].SubItems[1]);
                            itemPedido.valorUnitario = prod.Valor;


 for (int i = 0; i < lv_itensPedido.Items.Count; i++)
                {
                    foreach (Produto prod in produtos)
                    {
                        if (prod.Nome == lv_itensPedido.Items[x].Text)
                        {
                            itemPedido.Produto = prod;
                            itemPedido.Quantidade = Convert.ToInt32(lv_itensPedido.Items[x].SubItems[1]);
                            itemPedido.valorUnitario = prod.Valor;
                            itemPedido.Pedido
                            itemPedido.
                            y = y + prod
                        }
                        itemPedidos.Add(itemPedido);
                    }
                    if (y >= 5)
                    {
                        valor -= valor * 0.215;
                    }
                    pedido.ValorTotal = valor;
                }
                itemPedido.Quantidade;
                pedido.ItensPedido.Add();

                aluno.Nome = txtNome.Text;
                aluno.Email = txtEmail.Text;
                context.Add(aluno);
                context.SaveChanges();
 */