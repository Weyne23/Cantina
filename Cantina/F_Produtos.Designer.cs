
namespace Cantina
{
    partial class F_Produtos
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_nomeProduto = new System.Windows.Forms.TextBox();
            this.btn_adicionar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_descricao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nud_valor = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.tabela_quentinha = new System.Windows.Forms.DataGridView();
            this.col_nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nud_valor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabela_quentinha)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Produto";
            // 
            // tb_nomeProduto
            // 
            this.tb_nomeProduto.Location = new System.Drawing.Point(12, 26);
            this.tb_nomeProduto.Name = "tb_nomeProduto";
            this.tb_nomeProduto.Size = new System.Drawing.Size(250, 20);
            this.tb_nomeProduto.TabIndex = 2;
            // 
            // btn_adicionar
            // 
            this.btn_adicionar.Location = new System.Drawing.Point(248, 127);
            this.btn_adicionar.Name = "btn_adicionar";
            this.btn_adicionar.Size = new System.Drawing.Size(89, 23);
            this.btn_adicionar.TabIndex = 4;
            this.btn_adicionar.Text = "Remover";
            this.btn_adicionar.UseVisualStyleBackColor = true;
            this.btn_adicionar.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Valor";
            // 
            // tb_descricao
            // 
            this.tb_descricao.Location = new System.Drawing.Point(12, 68);
            this.tb_descricao.Multiline = true;
            this.tb_descricao.Name = "tb_descricao";
            this.tb_descricao.Size = new System.Drawing.Size(325, 53);
            this.tb_descricao.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Descrição da quentinha";
            // 
            // nud_valor
            // 
            this.nud_valor.DecimalPlaces = 2;
            this.nud_valor.Location = new System.Drawing.Point(268, 26);
            this.nud_valor.Name = "nud_valor";
            this.nud_valor.Size = new System.Drawing.Size(69, 20);
            this.nud_valor.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(153, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_adicionar_Click);
            // 
            // tabela_quentinha
            // 
            this.tabela_quentinha.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabela_quentinha.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_nome,
            this.col_valor});
            this.tabela_quentinha.Location = new System.Drawing.Point(12, 187);
            this.tabela_quentinha.Name = "tabela_quentinha";
            this.tabela_quentinha.Size = new System.Drawing.Size(325, 169);
            this.tabela_quentinha.TabIndex = 11;
            // 
            // col_nome
            // 
            this.col_nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_nome.HeaderText = "Quentinha";
            this.col_nome.Name = "col_nome";
            // 
            // col_valor
            // 
            this.col_valor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.col_valor.HeaderText = "Valor";
            this.col_valor.Name = "col_valor";
            // 
            // F_Produtos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 368);
            this.Controls.Add(this.tabela_quentinha);
            this.Controls.Add(this.nud_valor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_descricao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_adicionar);
            this.Controls.Add(this.tb_nomeProduto);
            this.Controls.Add(this.label1);
            this.Name = "F_Produtos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos";
            this.Load += new System.EventHandler(this.F_Produtos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_valor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabela_quentinha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_nomeProduto;
        private System.Windows.Forms.Button btn_adicionar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_descricao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nud_valor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView tabela_quentinha;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_valor;
    }
}