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
    public partial class F_Produtos : Form
    {
        public F_Produtos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Produto produtos = new Produto(tb_nomeProduto.Text, nup_valor.DecimalPlaces);

        }
    }
}
