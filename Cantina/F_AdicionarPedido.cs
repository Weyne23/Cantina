﻿using System;
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
        F_Cantina f_Cantina = new F_Cantina();
        public F_AdicionarPedido()
        {
            InitializeComponent();
            f_Cantina = Application.OpenForms["F_Cantina"] as F_Cantina;
            ExibirProdutos();
        }

        private void limparTela()
        {
            tb_endereco.Clear();
            lv_itensPedido.Items.Clear();
            tb_observacoes.Clear();
            cb_nomeCliente.Focus();
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
            if (lb_quentinhas.SelectedItem == null)
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
                if (cb_nomeCliente.Text == "")
                {
                    MessageBox.Show("Nome não selecionado!");
                    return;
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
                cliente.Nome = cb_nomeCliente.Text;
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
                    valor -= valor * 0.0215;
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

        private void F_AdicionarPedido_FormClosed(object sender, FormClosedEventArgs e)
        {
            f_Cantina.exibirPedidos();
        }

        private void F_AdicionarPedido_Load(object sender, EventArgs e)
        {
            List<Cliente> cliente;

            using (var ctx = new ApplicationDBContext())
            {
                cliente = ctx.Clientes.ToList();
            }
            foreach (var c in cliente)
                cb_nomeCliente.Items.Add(c.Nome);
        }
    }
}