using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cantina
{
    public partial class F_Cantina : Form
    {
        public F_Cantina()
        {
            InitializeComponent();
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

        private void limpar()
        {
            tb_cliente.Clear();
            tb_pedido.Clear();
            tb_valor.Clear();
        }

        private void btn_test_Click(object sender, EventArgs e)
        {
            if(tb_cliente.Text == "" || tb_pedido.Text == "" || tb_valor.Text == "")
            {
                MessageBox.Show("1 ou mais Campo(s) não preenchido(s)!");
                return;
            }

            string[] pr = new string[4];
            pr[0] = tb_cliente.Text;
            pr[1] = tb_pedido.Text;
            if(cb_delivery.Checked)
                pr[2] = "Sim";
            else
                pr[2] = "Não";
            pr[3] = tb_valor.Text;

            ListViewItem l = new ListViewItem(pr);
            lv_pedidos.Items.Add(l);
            limpar();
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

        private void btn_obter_Click(object sender, EventArgs e)
        {
            tb_cliente.Text = lv_pedidos.SelectedItems[0].SubItems[0].Text;
            tb_pedido.Text = lv_pedidos.SelectedItems[0].SubItems[1].Text;
            tb_valor.Text = lv_pedidos.SelectedItems[0].SubItems[3].Text;
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_Produtos f_Produtos = new F_Produtos();
            f_Produtos.ShowDialog();
        }
    }
}
