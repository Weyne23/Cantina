
namespace Cantina
{
    partial class F_AdicionarPedido
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_AdicionarPedido));
            this.label1 = new System.Windows.Forms.Label();
            this.tb_nomeCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_finalizarPedido = new System.Windows.Forms.Button();
            this.numericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.lv_itensPedido = new System.Windows.Forms.ListView();
            this.col_Pedido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_quantidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_remover = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.sqLiteCommand1 = new System.Data.SQLite.SQLiteCommand();
            this.tb_observacoes = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_endereco = new System.Windows.Forms.TextBox();
            this.lb_quentinhas = new System.Windows.Forms.ListBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Cliente";
            // 
            // tb_nomeCliente
            // 
            this.tb_nomeCliente.Location = new System.Drawing.Point(12, 24);
            this.tb_nomeCliente.Name = "tb_nomeCliente";
            this.tb_nomeCliente.Size = new System.Drawing.Size(340, 20);
            this.tb_nomeCliente.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Quentinhas";
            // 
            // btn_finalizarPedido
            // 
            this.btn_finalizarPedido.Location = new System.Drawing.Point(15, 465);
            this.btn_finalizarPedido.Name = "btn_finalizarPedido";
            this.btn_finalizarPedido.Size = new System.Drawing.Size(340, 23);
            this.btn_finalizarPedido.TabIndex = 7;
            this.btn_finalizarPedido.Text = "Finalizar Pedido";
            this.btn_finalizarPedido.UseVisualStyleBackColor = true;
            this.btn_finalizarPedido.Click += new System.EventHandler(this.btn_finalizarPedido_Click);
            // 
            // numericUpDown
            // 
            this.numericUpDown.Location = new System.Drawing.Point(206, 112);
            this.numericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown.Name = "numericUpDown";
            this.numericUpDown.Size = new System.Drawing.Size(149, 20);
            this.numericUpDown.TabIndex = 9;
            this.numericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Itens no pedido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Quantidade";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(353, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "*Clique em uma das opções, coloque a quantidade e clique em adicionar.";
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Location = new System.Drawing.Point(206, 139);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(149, 23);
            this.btn_adicionar.TabIndex = 14;
            this.btn_adicionar.Text = "Adicionar";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // lv_itensPedido
            // 
            this.lv_itensPedido.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_Pedido,
            this.col_quantidade});
            this.lv_itensPedido.FullRowSelect = true;
            this.lv_itensPedido.GridLines = true;
            this.lv_itensPedido.HideSelection = false;
            this.lv_itensPedido.Location = new System.Drawing.Point(15, 251);
            this.lv_itensPedido.MultiSelect = false;
            this.lv_itensPedido.Name = "lv_itensPedido";
            this.lv_itensPedido.Size = new System.Drawing.Size(185, 94);
            this.lv_itensPedido.TabIndex = 18;
            this.lv_itensPedido.UseCompatibleStateImageBehavior = false;
            this.lv_itensPedido.View = System.Windows.Forms.View.Details;
            // 
            // col_Pedido
            // 
            this.col_Pedido.Text = "Pedido";
            this.col_Pedido.Width = 139;
            // 
            // col_quantidade
            // 
            this.col_quantidade.Text = "Quat";
            this.col_quantidade.Width = 40;
            // 
            // btn_remover
            // 
            this.btn_remover.Location = new System.Drawing.Point(206, 251);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(149, 27);
            this.btn_remover.TabIndex = 19;
            this.btn_remover.Text = "Remover";
            this.btn_remover.UseVisualStyleBackColor = true;
            this.btn_remover.Click += new System.EventHandler(this.bet_remover_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(206, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Remover item do pedido";
            // 
            // sqLiteCommand1
            // 
            this.sqLiteCommand1.CommandText = null;
            // 
            // tb_observacoes
            // 
            this.tb_observacoes.Location = new System.Drawing.Point(15, 369);
            this.tb_observacoes.Multiline = true;
            this.tb_observacoes.Name = "tb_observacoes";
            this.tb_observacoes.Size = new System.Drawing.Size(340, 79);
            this.tb_observacoes.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 350);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Observações";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(276, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Endereço (Caso não seja para entrega deixar em branco)";
            // 
            // tb_endereco
            // 
            this.tb_endereco.Location = new System.Drawing.Point(12, 67);
            this.tb_endereco.Name = "tb_endereco";
            this.tb_endereco.Size = new System.Drawing.Size(340, 20);
            this.tb_endereco.TabIndex = 26;
            // 
            // lb_quentinhas
            // 
            this.lb_quentinhas.FormattingEnabled = true;
            this.lb_quentinhas.Location = new System.Drawing.Point(12, 112);
            this.lb_quentinhas.Name = "lb_quentinhas";
            this.lb_quentinhas.Size = new System.Drawing.Size(188, 95);
            this.lb_quentinhas.TabIndex = 27;
            // 
            // F_AdicionarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 499);
            this.Controls.Add(this.lb_quentinhas);
            this.Controls.Add(this.tb_endereco);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tb_observacoes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_remover);
            this.Controls.Add(this.lv_itensPedido);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown);
            this.Controls.Add(this.btn_finalizarPedido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_nomeCliente);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "F_AdicionarPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Pedido";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_nomeCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_finalizarPedido;
        private System.Windows.Forms.NumericUpDown numericUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.ListView lv_itensPedido;
        private System.Windows.Forms.ColumnHeader col_Pedido;
        private System.Windows.Forms.ColumnHeader col_quantidade;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.Label label7;
        private System.Data.SQLite.SQLiteCommand sqLiteCommand1;
        private System.Windows.Forms.TextBox tb_observacoes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_endereco;
        private System.Windows.Forms.ListBox lb_quentinhas;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}