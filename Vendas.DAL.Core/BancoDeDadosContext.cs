using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Vendas.DAL {

    public class BancoDeDadosContext : DbContext {

         public DbSet<ProdutoService> varProduto { get; set; }

         public DbSet<VendaService> Venda { get; set; }

         public DbSet<ItemDaVendaService> Item { get; set; }

         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {

            optionsBuilder.UseMySQL("server=LOCALHOST;userid=root;password=root;database=DataBase_RafaelSouzaMoraes_MarianaTenorio;persistsecurityinfo=True");
         }

        protected override void OnModelCreating(ModelBuilder mb) {            
            
            mb.Entity<ItemDaVendaService>().HasKey(i => new { i.CodigoDoItem, i.CodigoDaVenda }); /* 𝐂𝐡𝐚𝐯𝐞 𝐜𝐨𝐦𝐩𝐨𝐬𝐭𝐚! */
        }
    }
}