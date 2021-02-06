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
    public partial class F_AdicionarPedido : Form
    {
        public DataTable dt = new DataTable();
        public F_AdicionarPedido()
        {
            InitializeComponent();
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
                MessageBox.Show("Nenhum item selecionado!", "Erro");
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void F_AdicionarPedido_Load(object sender, EventArgs e)
        {
           
        }
    }
}
