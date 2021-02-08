
namespace Cantina
{
    partial class F_Cantina
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "Augusto Cesar",
            "Não",
            "10.00"}, -1);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "2",
            "Andrey Gomes",
            "Sim",
            "20,00"}, -1);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
            "3",
            "Caio Andrade",
            "Não",
            "10.00"}, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Cantina));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relatorioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lv_pedidos = new System.Windows.Forms.ListView();
            this.cl_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_cliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_delivery = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_valor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_adicionarPedido = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_rev = new System.Windows.Forms.Button();
            this.btn_entregue = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btn_detalhes = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pedidosToolStripMenuItem,
            this.produtosToolStripMenuItem,
            this.relatorioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(678, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.pedidosToolStripMenuItem.Text = "Pedidos";
            this.pedidosToolStripMenuItem.Click += new System.EventHandler(this.pedidosToolStripMenuItem_Click);
            // 
            // produtosToolStripMenuItem
            // 
            this.produtosToolStripMenuItem.Name = "produtosToolStripMenuItem";
            this.produtosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.produtosToolStripMenuItem.Text = "Produtos";
            this.produtosToolStripMenuItem.Click += new System.EventHandler(this.produtosToolStripMenuItem_Click);
            // 
            // relatorioToolStripMenuItem
            // 
            this.relatorioToolStripMenuItem.Name = "relatorioToolStripMenuItem";
            this.relatorioToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.relatorioToolStripMenuItem.Text = "Relatorio";
            // 
            // lv_pedidos
            // 
            this.lv_pedidos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cl_id,
            this.cl_cliente,
            this.cl_delivery,
            this.cl_valor});
            this.lv_pedidos.FullRowSelect = true;
            this.lv_pedidos.GridLines = true;
            this.lv_pedidos.HideSelection = false;
            listViewItem4.StateImageIndex = 0;
            this.lv_pedidos.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem4,
            listViewItem5,
            listViewItem6});
            this.lv_pedidos.Location = new System.Drawing.Point(12, 75);
            this.lv_pedidos.MultiSelect = false;
            this.lv_pedidos.Name = "lv_pedidos";
            this.lv_pedidos.Size = new System.Drawing.Size(649, 303);
            this.lv_pedidos.TabIndex = 1;
            this.lv_pedidos.UseCompatibleStateImageBehavior = false;
            this.lv_pedidos.View = System.Windows.Forms.View.Details;
            // 
            // cl_id
            // 
            this.cl_id.Text = "Num. do Pedido";
            this.cl_id.Width = 93;
            // 
            // cl_cliente
            // 
            this.cl_cliente.Text = "Cliente";
            this.cl_cliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cl_cliente.Width = 406;
            // 
            // cl_delivery
            // 
            this.cl_delivery.Text = "Delivery";
            this.cl_delivery.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cl_delivery.Width = 79;
            // 
            // cl_valor
            // 
            this.cl_valor.Text = "Valor";
            this.cl_valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cl_valor.Width = 67;
            // 
            // btn_adicionarPedido
            // 
            this.btn_adicionarPedido.Location = new System.Drawing.Point(12, 397);
            this.btn_adicionarPedido.Name = "btn_adicionarPedido";
            this.btn_adicionarPedido.Size = new System.Drawing.Size(334, 23);
            this.btn_adicionarPedido.TabIndex = 2;
            this.btn_adicionarPedido.Text = "Adicionar Pedido";
            this.btn_adicionarPedido.UseVisualStyleBackColor = true;
            this.btn_adicionarPedido.Click += new System.EventHandler(this.btn_adicionarPedido_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 44);
            this.label1.TabIndex = 3;
            this.label1.Text = "Meus Pedidos";
            // 
            // btn_rev
            // 
            this.btn_rev.Location = new System.Drawing.Point(352, 397);
            this.btn_rev.Name = "btn_rev";
            this.btn_rev.Size = new System.Drawing.Size(309, 23);
            this.btn_rev.TabIndex = 9;
            this.btn_rev.Text = "Remover Pedido";
            this.btn_rev.UseVisualStyleBackColor = true;
            this.btn_rev.Click += new System.EventHandler(this.btn_rev_Click);
            // 
            // btn_entregue
            // 
            this.btn_entregue.Location = new System.Drawing.Point(12, 426);
            this.btn_entregue.Name = "btn_entregue";
            this.btn_entregue.Size = new System.Drawing.Size(334, 23);
            this.btn_entregue.TabIndex = 11;
            this.btn_entregue.Text = "Pedido Entregue";
            this.btn_entregue.UseVisualStyleBackColor = true;
            this.btn_entregue.Click += new System.EventHandler(this.btn_entregue_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Tio Bill";
            this.notifyIcon1.Visible = true;
            // 
            // btn_detalhes
            // 
            this.btn_detalhes.Location = new System.Drawing.Point(352, 426);
            this.btn_detalhes.Name = "btn_detalhes";
            this.btn_detalhes.Size = new System.Drawing.Size(309, 23);
            this.btn_detalhes.TabIndex = 12;
            this.btn_detalhes.Text = "Detalhes do Pedido";
            this.btn_detalhes.UseVisualStyleBackColor = true;
            this.btn_detalhes.Click += new System.EventHandler(this.btn_detalhes_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 381);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(620, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "*Para remover, olhar os detalhes ou colocar o pedido como entregue selecione um d" +
    "os pedidos na lista acima e execute sua ação";
            // 
            // F_Cantina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 458);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_detalhes);
            this.Controls.Add(this.btn_entregue);
            this.Controls.Add(this.btn_rev);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_adicionarPedido);
            this.Controls.Add(this.lv_pedidos);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "F_Cantina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedidos";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relatorioToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader cl_cliente;
        private System.Windows.Forms.ColumnHeader cl_delivery;
        private System.Windows.Forms.Button btn_adicionarPedido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader cl_valor;
        private System.Windows.Forms.Button btn_rev;
        private System.Windows.Forms.Button btn_entregue;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button btn_detalhes;
        private System.Windows.Forms.ColumnHeader cl_id;
        public System.Windows.Forms.ListView lv_pedidos;
        private System.Windows.Forms.Label label2;
    }
}

