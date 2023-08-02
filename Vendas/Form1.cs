using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* .𝙿𝙳𝙵'𝚜 𝚎𝚡𝚙𝚕𝚒𝚌𝚊𝚝𝚒𝚟𝚘𝚜: https://bit.ly/3GKlVoW, https://bit.ly/3NFL2fo, https://bit.ly/3ynE2yB, https://bit.ly/3bvBZzn! */

namespace Vendas {
    
    public partial class frmVendas : Form {

        public frmVendas() => InitializeComponent();

        private void sairDoSistemaToolStripMenuItem_Click(object sender, EventArgs e) => Application.Exit();

        private void cadastroDeProdutoToolStripMenuItem_Click(object sender, EventArgs e) {
            
            frmCadastroProduto Form = new frmCadastroProduto {
                
                IsMdiContainer = true
            };
            Form.Show();
        }

        private void vendaToolStripMenuItem_Click(object sender, EventArgs e) {

            frmVendasProduto Form = new frmVendasProduto {
                
                IsMdiContainer = true
            };
            Form.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e) => MessageBox.Show("Olá! Este Projeto de Vendas foi desenvolvido pelos estudantes Rafael Souza Moraes e Mariana Tenorio, da instituição de ensino Escola Professor Luiz Rosa, do 2° ano do Ensino Médio integrado ao curso técnico de Informática. O mesmo possui como objetivos, a validação do conhecimento adquirido no 3° semestre do curso e a possível aplicação no mundo corporativo.", "Quem somos nós?", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}