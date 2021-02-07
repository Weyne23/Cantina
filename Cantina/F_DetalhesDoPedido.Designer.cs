
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
            this.mtb_dataTime = new System.Windows.Forms.MaskedTextBox();
            this.tb_observacoes = new System.Windows.Forms.TextBox();
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
            this.lb_numPedido.Location = new System.Drawing.Point(220, 9);
            this.lb_numPedido.Name = "lb_numPedido";
            this.lb_numPedido.Size = new System.Drawing.Size(18, 20);
            this.lb_numPedido.TabIndex = 1;
            this.lb_numPedido.Text = "2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Horario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Observações:";
            // 
            // tb_nomeCliente
            // 
            this.tb_nomeCliente.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tb_nomeCliente.Location = new System.Drawing.Point(80, 53);
            this.tb_nomeCliente.Name = "tb_nomeCliente";
            this.tb_nomeCliente.Size = new System.Drawing.Size(280, 20);
            this.tb_nomeCliente.TabIndex = 5;
            // 
            // mtb_dataTime
            // 
            this.mtb_dataTime.Location = new System.Drawing.Point(83, 86);
            this.mtb_dataTime.Mask = "00/00/0000 90:00";
            this.mtb_dataTime.Name = "mtb_dataTime";
            this.mtb_dataTime.Size = new System.Drawing.Size(98, 20);
            this.mtb_dataTime.TabIndex = 6;
            this.mtb_dataTime.ValidatingType = typeof(System.DateTime);
            // 
            // tb_observacoes
            // 
            this.tb_observacoes.Location = new System.Drawing.Point(17, 139);
            this.tb_observacoes.Multiline = true;
            this.tb_observacoes.Name = "tb_observacoes";
            this.tb_observacoes.Size = new System.Drawing.Size(343, 103);
            this.tb_observacoes.TabIndex = 7;
            // 
            // F_DetalhesDoPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 258);
            this.Controls.Add(this.tb_observacoes);
            this.Controls.Add(this.mtb_dataTime);
            this.Controls.Add(this.tb_nomeCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_numPedido);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "F_DetalhesDoPedido";
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
        private System.Windows.Forms.MaskedTextBox mtb_dataTime;
        private System.Windows.Forms.TextBox tb_observacoes;
    }
}