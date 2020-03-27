using SistemaDeEstoque.ConfiguracaoAbstrada;
using SistemaDeEstoque.Dominio;
using System;

namespace SistemaDeEstoque.ConfiguracaoTabelas
{
    public class ConfiguracaoTabelaProdutos : ConfiguracaoAbstrada<Produtos>
    {
        protected override void ConfigurarCamposDaTabela()
        {
            Property(p => p.CodBarras)
                .HasColumnName("CODIGOBARRAS")
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None)
                .IsRequired();

            Property(p => p.NomeProduto)
                .IsRequired()
                .HasMaxLength(30)
                .HasColumnName("NOMEDOPRODUTO");

            Property(p => p.DataValidade)
                .IsRequired()
                .HasColumnName("DATADEVALIDADE");

            Property(p => p.IdentificacaoPrateleiraEstoque)
                .IsRequired()
                .HasColumnName("IDENTIFICACAOPRATELEIRAESTOQUE");

            Property(p => p.QuantidadePrateleiraEstoque)
                .HasColumnName("QUANTIDADEPRATELEIRAESTOQUE")
                .IsRequired();

            Property(p => p.IdentificacaoPrateleiraMercado)
                .IsRequired()
                .HasColumnName("IDENTIFICACAOPRATELEIRAMERCADO");

            Property(p => p.QuantidadePrateleiraMercado)
                .HasColumnName("QUANTIDADEPRATELEIRAMERCADO")
                .IsRequired();

            Property(p => p.ResponsavelSetor)
                .IsRequired()
                .HasColumnName("RESPONSAVELSETOR")
                .HasMaxLength(30);

            Property(p => p.IdentificacaoDeMarca)
                .IsRequired()
                .HasColumnName("IDENTIFICACAODEMARCAS");
        }

        protected override void ConfigurarChavePrimaria()
        {
            HasKey(k => k.CodBarras);
        }

        protected override void ConfigurarChavesEstrangeiras()
        {
            HasRequired(p => p.MarcaIdentificacao)
                .WithMany(p => p.Produtos)
                .HasForeignKey(fk => fk.IdentificacaoDeMarca);
        }

        protected override void ConfigurarNomeDaTabela()
        {
            ToTable("produtos");
        }
    }
}
