
namespace Cantina
{
    partial class F_DetalhesDoPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_DetalhesDoPedido));
            this.label1 = new System.Windows.Forms.Label();
            this.lb_numPedido = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_nomeCliente = new System.Windows.Forms.TextBox();
            this.tb_observacoes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lv_quentinhas = new System.Windows.Forms.ListView();
            this.cl_nomeProduto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_valor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tb_horario = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_endereco = new System.Windows.Forms.TextBox();
            this.lb = new System.Windows.Forms.Label();
            this.lb_valorTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(102, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pedido Numero:";
            // 
            // lb_numPedido
            // 
            this.lb_numPedido.AutoSize = true;
            this.lb_numPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_numPedido.Location = new System.Drawing.Point(220, 10);
            this.lb_numPedido.Name = "lb_numPedido";
            this.lb_numPedido.Size = new System.Drawing.Size(18, 20);
            this.lb_numPedido.TabIndex = 1;
            this.lb_numPedido.Text = "2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(240, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Horario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Observações:";
            // 
            // tb_nomeCliente
            // 
            this.tb_nomeCliente.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tb_nomeCliente.Location = new System.Drawing.Point(12, 59);
            this.tb_nomeCliente.Name = "tb_nomeCliente";
            this.tb_nomeCliente.Size = new System.Drawing.Size(221, 20);
            this.tb_nomeCliente.TabIndex = 5;
            // 
            // tb_observacoes
            // 
            this.tb_observacoes.Location = new System.Drawing.Point(7, 312);
            this.tb_observacoes.Multiline = true;
            this.tb_observacoes.Name = "tb_observacoes";
            this.tb_observacoes.Size = new System.Drawing.Size(343, 70);
            this.tb_observacoes.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Pedido:";
            // 
            // lv_quentinhas
            // 
            this.lv_quentinhas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cl_nomeProduto,
            this.cl_valor});
            this.lv_quentinhas.HideSelection = false;
            this.lv_quentinhas.Location = new System.Drawing.Point(12, 161);
            this.lv_quentinhas.Name = "lv_quentinhas";
            this.lv_quentinhas.Size = new System.Drawing.Size(343, 87);
            this.lv_quentinhas.TabIndex = 9;
            this.lv_quentinhas.UseCompatibleStateImageBehavior = false;
            this.lv_quentinhas.View = System.Windows.Forms.View.Details;
            // 
            // cl_nomeProduto
            // 
            this.cl_nomeProduto.Text = "Quentinha";
            this.cl_nomeProduto.Width = 265;
            // 
            // cl_valor
            // 
            this.cl_valor.Text = "Valor";
            this.cl_valor.Width = 68;
            // 
            // tb_horario
            // 
            this.tb_horario.Location = new System.Drawing.Point(244, 59);
            this.tb_horario.Name = "tb_horario";
            this.tb_horario.Size = new System.Drawing.Size(110, 20);
            this.tb_horario.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Endereço:";
            // 
            // tb_endereco
            // 
            this.tb_endereco.Location = new System.Drawing.Point(12, 105);
            this.tb_endereco.Name = "tb_endereco";
            this.tb_endereco.Size = new System.Drawing.Size(343, 20);
            this.tb_endereco.TabIndex = 12;
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.Location = new System.Drawing.Point(8, 260);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(89, 20);
            this.lb.TabIndex = 13;
            this.lb.Text = "Valor Total:";
            // 
            // lb_valorTotal
            // 
            this.lb_valorTotal.AutoSize = true;
            this.lb_valorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_valorTotal.Location = new System.Drawing.Point(92, 260);
            this.lb_valorTotal.Name = "lb_valorTotal";
            this.lb_valorTotal.Size = new System.Drawing.Size(0, 20);
            this.lb_valorTotal.TabIndex = 14;
            // 
            // F_DetalhesDoPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 393);
            this.Controls.Add(this.lb_valorTotal);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.tb_endereco);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_horario);
            this.Controls.Add(this.lv_quentinhas);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_observacoes);
            this.Controls.Add(this.tb_nomeCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_numPedido);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "F_DetalhesDoPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalhes do pedido";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_numPedido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_nomeCliente;
        private System.Windows.Forms.TextBox tb_observacoes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView lv_quentinhas;
        private System.Windows.Forms.ColumnHeader cl_nomeProduto;
        private System.Windows.Forms.ColumnHeader cl_valor;
        private System.Windows.Forms.TextBox tb_horario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_endereco;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label lb_valorTotal;
    }
}