using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Vendas {
    
    public partial class frmCadastroProduto : Form {

        public frmCadastroProduto() => InitializeComponent();

        double ValorUnitario;
        string varProduto;

        private void btnIncluir_Click(object sender, EventArgs e) {

            try {
                
                if (!string.IsNullOrWhiteSpace(txtNomeProduto.Text) && !string.IsNullOrWhiteSpace(txtValorUnitarioProduto.Text)) {

                    if (double.TryParse(txtValorUnitarioProduto.Text, out ValorUnitario)) {

                        DAL.ProdutoService Produto = new DAL.ProdutoService();

                        Produto.Nome = txtNomeProduto.Text;
                        varProduto = Produto.Nome;
                        Produto.ValorUnitario = double.Parse(txtValorUnitarioProduto.Text);
                        Produto.Incluir();

                        dgvRelatorio.DataSource = Produto.Listar();

                        txtCodigoProduto.Clear();
                        txtNomeProduto.Clear();
                        txtValorUnitarioProduto.Clear();

                        MessageBox.Show("Produto incluído com sucesso!", "O Produto “" + varProduto + "”, já foi adicionado no Banco de Dados!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtCodigoProduto.Text = "Campo de numeração automática!";
                        txtNomeProduto.Focus();
                    }
                    else {

                        MessageBox.Show("Informe apenas números no campo de Valor Unitário (o valor pode ser inteiro ou com centavos, nesse caso, separar com vírgula “,”)!", "Erro de incompatibilidade de Dados...", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    }
                }
                else {

                    MessageBox.Show("Digite todos os campos!", "O Formulário possui campos que não foram informados...", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }
            catch (Exception) {

                MessageBox.Show("Verifique se você não fez algo de errado!", "Erro inesperado...", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e) {

            try {
                
                btnIncluirProduto.Enabled = false;
                btnExcluirProduto.Enabled = true;

                if (!string.IsNullOrWhiteSpace(txtNomeProduto.Text) && !string.IsNullOrWhiteSpace(txtValorUnitarioProduto.Text)) {

                    if (double.TryParse(txtValorUnitarioProduto.Text, out ValorUnitario)) {

                        DAL.ProdutoService Produto = new DAL.ProdutoService();
                        DAL.ProdutoService ProdutoObtido = Produto.Obter(int.Parse(txtCodigoProduto.Text));

                        ProdutoObtido.Nome = txtNomeProduto.Text;
                        varProduto = ProdutoObtido.Nome;
                        ProdutoObtido.ValorUnitario = double.Parse(txtValorUnitarioProduto.Text);
                        ProdutoObtido.Alterar();

                        txtCodigoProduto.Clear();
                        txtNomeProduto.Clear();
                        txtValorUnitarioProduto.Clear();

                        MessageBox.Show("Produto alterado com sucesso!", "O Produto “" + varProduto + "”, já foi renomeado no Banco de Dados!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtCodigoProduto.Text = "Campo de numeração automática!";

                        btnAlterarProduto.Enabled = false;
                        btnExcluirProduto.Enabled = false;
                        btnIncluirProduto.Enabled = true;

                        dgvRelatorio.DataSource = ProdutoObtido.Listar();
                        txtNomeProduto.Focus();
                    }
                    else {

                        MessageBox.Show("Informe apenas números no campo de Valor Unitário (o valor pode ser inteiro ou com centavos, nesse caso, separar com vírgula “,”)!", "Erro de incompatibilidade de Dados...", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    }
                }
                else {

                    MessageBox.Show("Digite todos os campos!", "O Formulário possui campos que não foram informados...", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }
            catch (Exception) {
                
                MessageBox.Show("Verifique anteriormente se existe um Produto cadastrado!", "Atenção!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                btnAlterarProduto.Enabled = false;
                btnExcluirProduto.Enabled = false;
                btnIncluirProduto.Enabled = true;

                txtNomeProduto.Clear();
                txtValorUnitarioProduto.Clear();
                txtCodigoProduto.Text = "Campo de numeração automática!";
                txtNomeProduto.Focus();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e) {

            try {

                DAL.ProdutoService Produto = new DAL.ProdutoService();
                DAL.ProdutoService ProdutoExcluido = Produto.Obter(int.Parse(txtCodigoProduto.Text));

                ProdutoExcluido.Nome = txtNomeProduto.Text;
                varProduto = ProdutoExcluido.Nome;
                ProdutoExcluido.ValorUnitario = double.Parse(txtValorUnitarioProduto.Text);
                ProdutoExcluido.Excluir();

                txtCodigoProduto.Clear();
                txtNomeProduto.Clear();
                txtValorUnitarioProduto.Clear();

                MessageBox.Show("Produto removido com sucesso!", "O Produto “" + varProduto + "”, já foi excluído no Banco de Dados!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dgvRelatorio.DataSource = ProdutoExcluido.Listar();
            }
            catch (Exception) {

                MessageBox.Show("Verifique anteriormente se existe um Produto cadastrado!", "Atenção!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                
                btnAlterarProduto.Enabled = false;
                btnExcluirProduto.Enabled = false;
                btnIncluirProduto.Enabled = true;

                txtNomeProduto.Clear();
                txtValorUnitarioProduto.Clear();
                txtCodigoProduto.Text = "Campo de numeração automática!";
                txtNomeProduto.Focus();
            }
        }

        private void frmCadastroProduto_Load(object sender, EventArgs e) {

            txtCodigoProduto.Text = "Campo de numeração automática!";

            DAL.ProdutoService Produto = new DAL.ProdutoService();
            dgvRelatorio.DataSource = Produto.Listar();           
        }

        private void dgvRelatorio_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e) {

            try {
                
                btnIncluirProduto.Enabled = false;
                btnAlterarProduto.Enabled = true;
                btnExcluirProduto.Enabled = true;

                txtCodigoProduto.Text = dgvRelatorio["cCodigo", e.RowIndex].Value.ToString();
                txtNomeProduto.Text = dgvRelatorio["cNome", e.RowIndex].Value.ToString();
                txtValorUnitarioProduto.Text = dgvRelatorio["cValorUnitario", e.RowIndex].Value.ToString();
            }
            catch (Exception) {
                
                btnAlterarProduto.Enabled = false;
                btnExcluirProduto.Enabled = false;
                btnIncluirProduto.Enabled = true;

                txtCodigoProduto.Clear();
                txtNomeProduto.Clear();
                txtValorUnitarioProduto.Clear();

                MessageBox.Show("Procure não clicar nas células de nomenclatura!", "Erro de conversão de dados...", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                
                txtCodigoProduto.Text = "Campo de numeração automática!";
                txtNomeProduto.Focus();
            }
        }

        private void btnFecharTela_Click(object sender, EventArgs e) => Close();
    }
}