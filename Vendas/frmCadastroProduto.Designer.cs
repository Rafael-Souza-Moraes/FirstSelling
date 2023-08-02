
namespace Vendas
{
    partial class frmCadastroProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroProduto));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigoProduto = new System.Windows.Forms.TextBox();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.txtValorUnitarioProduto = new System.Windows.Forms.TextBox();
            this.btnIncluirProduto = new System.Windows.Forms.Button();
            this.btnAlterarProduto = new System.Windows.Forms.Button();
            this.btnExcluirProduto = new System.Windows.Forms.Button();
            this.dgvRelatorio = new System.Windows.Forms.DataGridView();
            this.cCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cValorUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnFecharTela = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorio)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(-2, 1);
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
            this.label2.Location = new System.Drawing.Point(-2, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome do Produto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(-2, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor Unitário (R$) do Produto:";
            // 
            // txtCodigoProduto
            // 
            this.txtCodigoProduto.Enabled = false;
            this.txtCodigoProduto.Location = new System.Drawing.Point(195, 1);
            this.txtCodigoProduto.Name = "txtCodigoProduto";
            this.txtCodigoProduto.Size = new System.Drawing.Size(210, 23);
            this.txtCodigoProduto.TabIndex = 3;
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(195, 34);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(233, 23);
            this.txtNomeProduto.TabIndex = 4;
            // 
            // txtValorUnitarioProduto
            // 
            this.txtValorUnitarioProduto.Location = new System.Drawing.Point(195, 66);
            this.txtValorUnitarioProduto.Name = "txtValorUnitarioProduto";
            this.txtValorUnitarioProduto.Size = new System.Drawing.Size(78, 23);
            this.txtValorUnitarioProduto.TabIndex = 5;
            // 
            // btnIncluirProduto
            // 
            this.btnIncluirProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIncluirProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnIncluirProduto.Location = new System.Drawing.Point(462, 3);
            this.btnIncluirProduto.Name = "btnIncluirProduto";
            this.btnIncluirProduto.Size = new System.Drawing.Size(166, 59);
            this.btnIncluirProduto.TabIndex = 6;
            this.btnIncluirProduto.Text = "Incluir Produto";
            this.btnIncluirProduto.UseVisualStyleBackColor = true;
            this.btnIncluirProduto.Click += new System.EventHandler(this.btnIncluir_Click);
            // 
            // btnAlterarProduto
            // 
            this.btnAlterarProduto.Enabled = false;
            this.btnAlterarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlterarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAlterarProduto.Location = new System.Drawing.Point(462, 82);
            this.btnAlterarProduto.Name = "btnAlterarProduto";
            this.btnAlterarProduto.Size = new System.Drawing.Size(166, 59);
            this.btnAlterarProduto.TabIndex = 7;
            this.btnAlterarProduto.Text = "Alterar dados do Produto";
            this.btnAlterarProduto.UseVisualStyleBackColor = true;
            this.btnAlterarProduto.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluirProduto
            // 
            this.btnExcluirProduto.Enabled = false;
            this.btnExcluirProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluirProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnExcluirProduto.Location = new System.Drawing.Point(462, 161);
            this.btnExcluirProduto.Name = "btnExcluirProduto";
            this.btnExcluirProduto.Size = new System.Drawing.Size(166, 59);
            this.btnExcluirProduto.TabIndex = 8;
            this.btnExcluirProduto.Text = "Excluir Produto";
            this.btnExcluirProduto.UseVisualStyleBackColor = true;
            this.btnExcluirProduto.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // dgvRelatorio
            // 
            this.dgvRelatorio.AllowUserToAddRows = false;
            this.dgvRelatorio.AllowUserToDeleteRows = false;
            this.dgvRelatorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRelatorio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cCodigo,
            this.cNome,
            this.cValorUnitario});
            this.dgvRelatorio.Location = new System.Drawing.Point(3, 108);
            this.dgvRelatorio.Name = "dgvRelatorio";
            this.dgvRelatorio.ReadOnly = true;
            this.dgvRelatorio.RowTemplate.Height = 25;
            this.dgvRelatorio.Size = new System.Drawing.Size(402, 314);
            this.dgvRelatorio.TabIndex = 9;
            this.dgvRelatorio.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvRelatorio_CellMouseClick);
            // 
            // cCodigo
            // 
            this.cCodigo.DataPropertyName = "Codigo";
            this.cCodigo.Frozen = true;
            this.cCodigo.HeaderText = "Código";
            this.cCodigo.Name = "cCodigo";
            this.cCodigo.ReadOnly = true;
            // 
            // cNome
            // 
            this.cNome.DataPropertyName = "Nome";
            this.cNome.Frozen = true;
            this.cNome.HeaderText = "Nome";
            this.cNome.Name = "cNome";
            this.cNome.ReadOnly = true;
            // 
            // cValorUnitario
            // 
            this.cValorUnitario.DataPropertyName = "ValorUnitario";
            this.cValorUnitario.Frozen = true;
            this.cValorUnitario.HeaderText = "Valor Unitário (R$)";
            this.cValorUnitario.Name = "cValorUnitario";
            this.cValorUnitario.ReadOnly = true;
            // 
            // btnFecharTela
            // 
            this.btnFecharTela.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFecharTela.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFecharTela.Location = new System.Drawing.Point(415, 361);
            this.btnFecharTela.Name = "btnFecharTela";
            this.btnFecharTela.Size = new System.Drawing.Size(213, 59);
            this.btnFecharTela.TabIndex = 10;
            this.btnFecharTela.Text = "Fechar este formulário";
            this.btnFecharTela.UseVisualStyleBackColor = true;
            this.btnFecharTela.Click += new System.EventHandler(this.btnFecharTela_Click);
            // 
            // frmCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 425);
            this.Controls.Add(this.btnFecharTela);
            this.Controls.Add(this.dgvRelatorio);
            this.Controls.Add(this.btnExcluirProduto);
            this.Controls.Add(this.btnAlterarProduto);
            this.Controls.Add(this.btnIncluirProduto);
            this.Controls.Add(this.txtValorUnitarioProduto);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.txtCodigoProduto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadastroProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "𝘼𝙧𝙦𝙪𝙞𝙫𝙤 𝙧𝙚𝙡𝙖𝙘𝙞𝙤𝙣𝙖𝙙𝙤 𝙘𝙤𝙢 𝙤 𝙥𝙧𝙤𝙘𝙚𝙨𝙨𝙤 𝙙𝙚 𝘾𝙖𝙙𝙖𝙨𝙩" +
    "𝙧𝙤 𝙙𝙤 𝙥𝙧𝙤𝙙𝙪𝙩𝙤:";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCadastroProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRelatorio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigoProduto;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.TextBox txtValorUnitarioProduto;
        private System.Windows.Forms.Button btnIncluirProduto;
        private System.Windows.Forms.Button btnAlterarProduto;
        private System.Windows.Forms.Button btnExcluirProduto;
        private System.Windows.Forms.DataGridView dgvRelatorio;
        private System.Windows.Forms.Button btnFecharTela;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn cValorUnitario;
    }
}