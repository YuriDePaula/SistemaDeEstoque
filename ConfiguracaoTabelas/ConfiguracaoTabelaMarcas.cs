using SistemaDeEstoque.ConfiguracaoAbstrada;
using SistemaDeEstoque.Dominio;

namespace SistemaDeEstoque.ConfiguracaoTabelas
{
    public class ConfiguracaoTabelaMarcas : ConfiguracaoAbstrada<MarcaProdutos>
    {
        protected override void ConfigurarCamposDaTabela()
        {
            Property(p => p.IdentificacaoDeMarca)
                .HasColumnName("IDENTIFICACAODEMARCA")
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)
                .IsRequired();

            Property(p => p.NomeMarca)
                .IsRequired()
                .HasMaxLength(30)
                .HasColumnName("NOMEDAMARCA");
        }

        protected override void ConfigurarChavePrimaria()
        {
            HasKey(pk => pk.IdentificacaoDeMarca);
        }

        protected override void ConfigurarChavesEstrangeiras()
        {

        }

        protected override void ConfigurarNomeDaTabela()
        {
            ToTable("marcas_produtos");
        }
    }
}
