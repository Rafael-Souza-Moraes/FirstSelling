using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendas.DAL {

    public class ItemDaVendaService {

        /* 𝙵𝚘𝚛𝚎𝚒𝚐𝚗 𝙺𝚎𝚢 - Chave que está em uma tabela que faz referência à outra! */
        [Key]
        public int CodigoDaVenda { get; set; }

        [Key]
        public int CodigoDoItem { get; set; }

        public ProdutoService Produto { get; set; }        

        public double ValorTotal { get; set; }
        
        public int Quantidade { get; set; }

        public bool Inserir() {

            using (var db = new BancoDeDadosContext()) {

                db.Item.Add(this);
                db.SaveChanges();
                return true;
            }
        }
    }
}