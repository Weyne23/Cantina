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
    public partial class F_Produtos : Form
    {
        public F_Produtos()
        {
            InitializeComponent();
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            if (tb_descricao.Text == "" || tb_nomeProduto.Text == "")
            {
                MessageBox.Show("Nenhum item selecionado!", "Erro");
                return;
            }
            else
            {
                using (var context = new ApplicationDBContext())
                {
                    var produto = context.Produtos;
                    foreach (var p in produto)
                    {
                        if(p.Nome.ToLower() == tb_nomeProduto.Text.ToLower())
                        {
                            MessageBox.Show("Produto Já Adicionado!", "Adicionar");
                            return;
                        }
                    }
                    Produto prod = new Produto();
                    prod.Nome = tb_nomeProduto.Text;
                    prod.Valor = Convert.ToDouble(nud_valor.Value);
                    prod.Descricao = tb_descricao.Text;
                    MessageBox.Show("Produto Adicionado", "Adicionar");
                    context.Add(prod);
                    context.SaveChanges();
                    lv_quentinhas.Items.Add(prod.Nome).SubItems.Add(prod.Valor.ToString("C2"));
                }
            }

        }

        private void F_Produtos_Load(object sender, EventArgs e)
        {
            Carregar_Quentinhas();
        }

        private void Carregar_Quentinhas()
        {
            using (var ctx = new ApplicationDBContext())
            {
                var quentinhas = ctx.Produtos.ToList();

                foreach (var x in quentinhas)
                    lv_quentinhas.Items.Add(x.Nome).SubItems.Add(x.Valor.ToString("C2"));
            }
        }

        private void btn_adicionar_Click_1(object sender, EventArgs e)
        {
            if (lv_quentinhas.SelectedItems == null)
            {
                MessageBox.Show("Para excluir escolha uma das opções na lista de quentinhas e clique em excluir!", "Erro");
                return;
            }
            else
            {
                using (var ctx = new ApplicationDBContext())
                {
                    var quentinhas = ctx.Produtos.ToList();

                    foreach (var x in quentinhas)
                    {
                        if(x.Nome == lv_quentinhas.SelectedItems[0].Text)
                        {
                            ctx.Remove(x);
                            ctx.SaveChanges();
                            MessageBox.Show("Quentinha foi excluida!", "Excluido");
                            lv_quentinhas.Items.Clear();
                            Carregar_Quentinhas();
                            return;
                        }
                    }      
                }
            }
        }
    }
}
