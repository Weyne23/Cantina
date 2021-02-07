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
                    tabela_quentinha.Rows.Add(prod.Nome, prod.Valor.ToString());
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
                    tabela_quentinha.Rows.Add(x.Nome, x.Valor);
            }
        }
    }
}
