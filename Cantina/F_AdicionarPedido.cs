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
    }
}
