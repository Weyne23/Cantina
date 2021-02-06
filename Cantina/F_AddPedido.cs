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
    public partial class F_AddPedido : Form
    {
        public F_AddPedido()
        {
            InitializeComponent();
        }

        private void bt_adicionar_Click(object sender, EventArgs e)
        {
            RadioButton rb = new RadioButton();
            rb.Text = tb_adicionar.Text;
            int x = pn_painel.Controls.Count;
            pn_painel.ContextMenu.MenuItems.Add("Cachorro");
        }
    }
}
