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

        //Função não terminada
        public void carregarTela()
        {
            /** lb_numPedido.Text = f_Cantina.lv_pedidos.SelectedItems[0].SubItems[0].Text;
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

                }
            **/
        }
    }
}