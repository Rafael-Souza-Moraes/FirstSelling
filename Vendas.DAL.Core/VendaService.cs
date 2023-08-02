using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vendas.DAL {

    public class VendaService {

        [Key]
        public int Codigo { get; set; }

        public DateTime DataDaVenda { get; set; }

        public List<ItemDaVendaService> ItensDaLista { get; set; }

        public bool Inserir() {

            using (var db = new BancoDeDadosContext()) {

                db.Venda.Add(this);
                db.SaveChanges(); 
                return true;
            }
        }
    }
}