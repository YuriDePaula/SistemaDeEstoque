namespace SistemaDeEstoque.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ConfiguracaoInicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.marcas_produtos",
                c => new
                    {
                        IDENTIFICACAODEMARCA = c.Int(nullable: false, identity: true),
                        NOMEDAMARCA = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.IDENTIFICACAODEMARCA);
            
            CreateTable(
                "dbo.produtos",
                c => new
                    {
                        CODIGOBARRAS = c.Long(nullable: false),
                        NOMEDOPRODUTO = c.String(nullable: false, maxLength: 30),
                        DATADEVALIDADE = c.DateTime(nullable: false),
                        IDENTIFICACAOPRATELEIRAESTOQUE = c.Int(nullable: false),
                        QUANTIDADEPRATELEIRAESTOQUE = c.Int(nullable: false),
                        IDENTIFICACAOPRATELEIRAMERCADO = c.Int(nullable: false),
                        QUANTIDADEPRATELEIRAMERCADO = c.Int(nullable: false),
                        RESPONSAVELSETOR = c.String(nullable: false, maxLength: 30),
                        IDENTIFICACAODEMARCAS = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CODIGOBARRAS)
                .ForeignKey("dbo.marcas_produtos", t => t.IDENTIFICACAODEMARCAS, cascadeDelete: false)
                .Index(t => t.IDENTIFICACAODEMARCAS);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.produtos", "IDENTIFICACAODEMARCAS", "dbo.marcas_produtos");
            DropIndex("dbo.produtos", new[] { "IDENTIFICACAODEMARCAS" });
            DropTable("dbo.produtos");
            DropTable("dbo.marcas_produtos");
        }
    }
}
