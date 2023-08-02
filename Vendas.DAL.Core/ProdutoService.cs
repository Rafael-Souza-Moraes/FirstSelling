using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendas.DAL {

    public class ProdutoService {

        /* 𝙿𝚛𝚒𝚖𝚊𝚛𝚢 𝙺𝚎𝚢 */
        [Key]
        public int Codigo { get; set; }

        public string Nome { get; set; }

        public double ValorUnitario { get; set; }

        public bool Incluir() {
            
            using (var db = new BancoDeDadosContext()) {
                
                db.varProduto.Add(this);
                db.SaveChanges();
                return true;
            }           
        }

        public ProdutoService Obter (int CodigoProd) {
            
            using (var Db = new BancoDeDadosContext()) {
                
                return Db.varProduto.Find(CodigoProd);
            }
        }

        public bool Alterar() {
            
            using (var Db = new BancoDeDadosContext()) {
                
                Db.varProduto.Update(this);
                Db.SaveChanges();
                return true;
            }
        }

        public bool Excluir() {

            using (var Db = new BancoDeDadosContext()) {

                Db.varProduto.Remove(this);
                Db.SaveChanges();
                return true;
            }
        }

        public List<ProdutoService> Listar() {
            
            using (var Db = new BancoDeDadosContext()) {
                
                return Db.varProduto.ToList();
            }
        }
    }
}