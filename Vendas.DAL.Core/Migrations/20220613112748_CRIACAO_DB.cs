using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace Vendas.DAL.Core.Migrations {
    
    public partial class CRIACAO_DB : Migration {
        
        protected override void Up(MigrationBuilder migrationBuilder) {
            
            migrationBuilder.CreateTable(
                name: "varProduto",
                columns: table => new {
                    
                    Codigo = table.Column<int> (nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string> (nullable: true),
                    ValorUnitario = table.Column<double> (nullable: false)
                },
                constraints: table => {
                    
                    table.PrimaryKey("PK_varProduto", x => x.Codigo);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder) {
            
            migrationBuilder.DropTable(name: "varProduto");
        }
    }
}