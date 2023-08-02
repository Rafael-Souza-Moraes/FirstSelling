using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace Vendas.DAL.Core.Migrations {
    
    public partial class CRIACAO_VENDA_ITEMVENDA : Migration {
        
        protected override void Up(MigrationBuilder migrationBuilder) {
            
            migrationBuilder.CreateTable(
                name: "Venda",
                columns: table => new {
                    
                    Codigo = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    DataDaVenda = table.Column<DateTime>(nullable: false)
                },
                constraints: table => {
                    
                    table.PrimaryKey("PK_Venda", x => x.Codigo);
                });

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new {
                    
                    CodigoDaVenda = table.Column<int>(nullable: false),
                    CodigoDoItem = table.Column<int>(nullable: false),
                    ProdutoCodigo = table.Column<int>(nullable: true),
                    ValorTotal = table.Column<double>(nullable: false),
                    Quantidade = table.Column<int>(nullable: false),
                    VendaServiceCodigo = table.Column<int>(nullable: true)
                },
                constraints: table => {
                    
                    table.PrimaryKey("PK_Item", x => new { x.CodigoDoItem, x.CodigoDaVenda });
                    table.ForeignKey(
                        name: "FK_Item_varProduto_ProdutoCodigo",
                        column: x => x.ProdutoCodigo,
                        principalTable: "varProduto",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Item_Venda_VendaServiceCodigo",
                        column: x => x.VendaServiceCodigo,
                        principalTable: "Venda",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Item_ProdutoCodigo",
                table: "Item",
                column: "ProdutoCodigo");

            migrationBuilder.CreateIndex(
                name: "IX_Item_VendaServiceCodigo",
                table: "Item",
                column: "VendaServiceCodigo");
        }

        protected override void Down(MigrationBuilder migrationBuilder) {
            
            migrationBuilder.DropTable(name: "Item");
            migrationBuilder.DropTable(name: "Venda");
        }
    }
}