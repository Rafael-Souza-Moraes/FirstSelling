using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vendas {
    
    public partial class frmVendasProduto : Form {
        
        public frmVendasProduto() => InitializeComponent();

        int QTD;

        List<DAL.ItemDaVendaService> InstanciaItem = new List<DAL.ItemDaVendaService>();
        
        private void btnAdicionarProduto_Click(object sender, EventArgs e) {

            try {
                
                if (cboCódigoProduto.SelectedItem != null) {

                    if (!string.IsNullOrWhiteSpace(txtQuantidadeDesejadaProduto.Text) && int.TryParse(txtQuantidadeDesejadaProduto.Text, out QTD)) {

                        DAL.ItemDaVendaService Itens = new DAL.ItemDaVendaService();
                        DAL.ProdutoService Produto = (DAL.ProdutoService)cboCódigoProduto.SelectedItem;

                        Itens.CodigoDoItem = Produto.Codigo;
                        Itens.Quantidade = int.Parse(txtQuantidadeDesejadaProduto.Text);
                        Itens.ValorTotal = Itens.Quantidade * double.Parse(txtValorUnitárioProduto.Text);

                        lblValorTotalDaCompra.Text = (double.Parse(lblValorTotalDaCompra.Text) + Itens.ValorTotal).ToString();
                        InstanciaItem.Add(Itens);

                        /* Para resolver o erro do DGV de criar novas colunas... */
                        var NovaLista = InstanciaItem.Select (i =>

                           new {

                               CCodigo = i.CodigoDoItem,
                               CValorUnit = i.ValorTotal,
                               CQuantidade = i.Quantidade

                           }).ToList();

                        dgvRelVendas.DataSource = NovaLista;

                        txtQuantidadeDesejadaProduto.Clear();
                        btnConcluirVenda.Enabled = true;
                    }
                    else {

                        MessageBox.Show("Verifique se a Quantidade foi digitada e se foi digitada com valores numéricos!", "Erro de incompatibilidade de Dados...", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    }
                }
                else {

                    MessageBox.Show("Selecione o código de um produto!", "Caixa de seleção de itens vazia...", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }
            catch (Exception) {

                throw;
            }
        }

        private void btnCancelarVenda_Click(object sender, EventArgs e) => Close();

        private void btnConcluirVenda_Click(object sender, EventArgs e) {

            try {
                
                DAL.VendaService Venda = new DAL.VendaService();

                Venda.Codigo = new Random().Next();
                Venda.DataDaVenda = DateTime.Now;
                Venda.Inserir();

                foreach (DAL.ItemDaVendaService Itens in InstanciaItem) {

                    Itens.CodigoDaVenda = Venda.Codigo;
                    Itens.Inserir();
                }

                MessageBox.Show("Venda concluída com sucesso!", "Agradecemos pela escolha de nosso Sistema!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception) {

                MessageBox.Show("Caso queira realizar novamente a compra de um mesmo Produto, cancele a compra e selecionar a quantidade final desejada!", "A compra não consegue ser finalizada com um mesmo Produto repetido!", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                MessageBox.Show("Ocorreu um erro inesperado, cancele a compra e tente novamente!", "A compra não pôde ser finalizada!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void frmVendasProduto_Load(object sender, EventArgs e) {
            
            cboCódigoProduto.DisplayMember = "Nome";
            cboCódigoProduto.DataSource = new DAL.ProdutoService().Listar();
        }

        private void cboCódigoProduto_SelectedIndexChanged(object sender, EventArgs e) {
            
            DAL.ProdutoService Produto = (DAL.ProdutoService)cboCódigoProduto.SelectedItem;
            txtValorUnitárioProduto.Text = Produto.ValorUnitario.ToString();
        }
    }
}