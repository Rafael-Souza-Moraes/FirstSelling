
namespace Vendas
{
    partial class frmVendasProduto
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboCódigoProduto = new System.Windows.Forms.ComboBox();
            this.txtValorUnitárioProduto = new System.Windows.Forms.TextBox();
            this.txtQuantidadeDesejadaProduto = new System.Windows.Forms.TextBox();
            this.btnAdicionarProduto = new System.Windows.Forms.Button();
            this.dgvRelVendas = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.lblValorTotalDaCompra = new System.Windows.Forms.Label();
            this.btnConcluirVenda = new System.Windows.Forms.Button();
            this.btnCancelarVenda = new System.Windows.Forms.Button();
            this.CodigoDaVenda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValorUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelVendas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(-1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código do Produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(-1, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor Unitário (R$) do Produto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(-1, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantidade desejada:";
            // 
            // cboCódigoProduto
            // 
            this.cboCódigoProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCódigoProduto.FormattingEnabled = true;
            this.cboCódigoProduto.Location = new System.Drawing.Point(197, 3);
            this.cboCódigoProduto.Name = "cboCódigoProduto";
            this.cboCódigoProduto.Size = new System.Drawing.Size(303, 23);
            this.cboCódigoProduto.TabIndex = 3;
            this.cboCódigoProduto.SelectedIndexChanged += new System.EventHandler(this.cboCódigoProduto_SelectedIndexChanged);
            // 
            // txtValorUnitárioProduto
            // 
            this.txtValorUnitárioProduto.Enabled = false;
            this.txtValorUnitárioProduto.Location = new System.Drawing.Point(197, 45);
            this.txtValorUnitárioProduto.Name = "txtValorUnitárioProduto";
            this.txtValorUnitárioProduto.Size = new System.Drawing.Size(101, 23);
            this.txtValorUnitárioProduto.TabIndex = 4;
            // 
            // txtQuantidadeDesejadaProduto
            // 
            this.txtQuantidadeDesejadaProduto.Location = new System.Drawing.Point(197, 87);
            this.txtQuantidadeDesejadaProduto.Name = "txtQuantidadeDesejadaProduto";
            this.txtQuantidadeDesejadaProduto.Size = new System.Drawing.Size(51, 23);
            this.txtQuantidadeDesejadaProduto.TabIndex = 5;
            // 
            // btnAdicionarProduto
            // 
            this.btnAdicionarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdicionarProduto.Location = new System.Drawing.Point(329, 47);
            this.btnAdicionarProduto.Name = "btnAdicionarProduto";
            this.btnAdicionarProduto.Size = new System.Drawing.Size(171, 62);
            this.btnAdicionarProduto.TabIndex = 6;
            this.btnAdicionarProduto.Text = "Adicionar Produto";
            this.btnAdicionarProduto.UseVisualStyleBackColor = true;
            this.btnAdicionarProduto.Click += new System.EventHandler(this.btnAdicionarProduto_Click);
            // 
            // dgvRelVendas
            // 
            this.dgvRelVendas.AllowUserToAddRows = false;
            this.dgvRelVendas.AllowUserToDeleteRows = false;
            this.dgvRelVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRelVendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoDaVenda,
            this.ValorUnitario,
            this.Quantidade});
            this.dgvRelVendas.Location = new System.Drawing.Point(2, 116);
            this.dgvRelVendas.Name = "dgvRelVendas";
            this.dgvRelVendas.ReadOnly = true;
            this.dgvRelVendas.RowTemplate.Height = 25;
            this.dgvRelVendas.Size = new System.Drawing.Size(498, 161);
            this.dgvRelVendas.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(2, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(352, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Valor total da compra efetuada (R$):";
            // 
            // lblValorTotalDaCompra
            // 
            this.lblValorTotalDaCompra.AutoSize = true;
            this.lblValorTotalDaCompra.BackColor = System.Drawing.Color.Transparent;
            this.lblValorTotalDaCompra.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblValorTotalDaCompra.Location = new System.Drawing.Point(439, 280);
            this.lblValorTotalDaCompra.Name = "lblValorTotalDaCompra";
            this.lblValorTotalDaCompra.Size = new System.Drawing.Size(71, 32);
            this.lblValorTotalDaCompra.TabIndex = 9;
            this.lblValorTotalDaCompra.Text = "00,00";
            // 
            // btnConcluirVenda
            // 
            this.btnConcluirVenda.Enabled = false;
            this.btnConcluirVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConcluirVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.btnConcluirVenda.Location = new System.Drawing.Point(38, 323);
            this.btnConcluirVenda.Name = "btnConcluirVenda";
            this.btnConcluirVenda.Size = new System.Drawing.Size(160, 76);
            this.btnConcluirVenda.TabIndex = 10;
            this.btnConcluirVenda.Text = "Concluir Venda";
            this.btnConcluirVenda.UseVisualStyleBackColor = true;
            this.btnConcluirVenda.Click += new System.EventHandler(this.btnConcluirVenda_Click);
            // 
            // btnCancelarVenda
            // 
            this.btnCancelarVenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.btnCancelarVenda.Location = new System.Drawing.Point(302, 323);
            this.btnCancelarVenda.Name = "btnCancelarVenda";
            this.btnCancelarVenda.Size = new System.Drawing.Size(160, 76);
            this.btnCancelarVenda.TabIndex = 11;
            this.btnCancelarVenda.Text = "Cancelar Venda";
            this.btnCancelarVenda.UseVisualStyleBackColor = true;
            this.btnCancelarVenda.Click += new System.EventHandler(this.btnCancelarVenda_Click);
            // 
            // CodigoDaVenda
            // 
            this.CodigoDaVenda.DataPropertyName = "CCodigo";
            this.CodigoDaVenda.Frozen = true;
            this.CodigoDaVenda.HeaderText = "Código";
            this.CodigoDaVenda.Name = "CodigoDaVenda";
            this.CodigoDaVenda.ReadOnly = true;
            // 
            // ValorUnitario
            // 
            this.ValorUnitario.DataPropertyName = "CValorUnit";
            this.ValorUnitario.Frozen = true;
            this.ValorUnitario.HeaderText = "Valor Total do Produto";
            this.ValorUnitario.Name = "ValorUnitario";
            this.ValorUnitario.ReadOnly = true;
            // 
            // Quantidade
            // 
            this.Quantidade.DataPropertyName = "CQuantidade";
            this.Quantidade.Frozen = true;
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.ReadOnly = true;
            // 
            // frmVendasProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(503, 402);
            this.Controls.Add(this.btnCancelarVenda);
            this.Controls.Add(this.btnConcluirVenda);
            this.Controls.Add(this.lblValorTotalDaCompra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvRelVendas);
            this.Controls.Add(this.btnAdicionarProduto);
            this.Controls.Add(this.txtQuantidadeDesejadaProduto);
            this.Controls.Add(this.txtValorUnitárioProduto);
            this.Controls.Add(this.cboCódigoProduto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmVendasProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "𝘼𝙧𝙦𝙪𝙞𝙫𝙤 𝙧𝙚𝙡𝙖𝙘𝙞𝙤𝙣𝙖𝙙𝙤 𝙘𝙤𝙢 𝙤 𝙥𝙧𝙤𝙘𝙚𝙨𝙨𝙤 𝙙𝙚 𝙑𝙚𝙣𝙙𝙖 " +
    "𝙛𝙞𝙣𝙖𝙡 𝙙𝙤 𝙥𝙧𝙤𝙙𝙪𝙩𝙤:";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmVendasProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelVendas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboCódigoProduto;
        private System.Windows.Forms.TextBox txtValorUnitárioProduto;
        private System.Windows.Forms.TextBox txtQuantidadeDesejadaProduto;
        private System.Windows.Forms.Button btnAdicionarProduto;
        private System.Windows.Forms.DataGridView dgvRelVendas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblValorTotalDaCompra;
        private System.Windows.Forms.Button btnConcluirVenda;
        private System.Windows.Forms.Button btnCancelarVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoDaVenda;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValorUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
    }
}