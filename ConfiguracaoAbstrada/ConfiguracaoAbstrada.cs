using System.Data.Entity.ModelConfiguration;

namespace SistemaDeEstoque.ConfiguracaoAbstrada
{
    public abstract class ConfiguracaoAbstrada<TTipo> : EntityTypeConfiguration<TTipo> where TTipo : class
    {
        public ConfiguracaoAbstrada()
        {
            ConfigurarNomeDaTabela();
            ConfigurarCamposDaTabela();
            ConfigurarChavePrimaria();
            ConfigurarChavesEstrangeiras();
        }

        protected abstract void ConfigurarChavesEstrangeiras();

        protected abstract void ConfigurarChavePrimaria();

        protected abstract void ConfigurarCamposDaTabela();

        protected abstract void ConfigurarNomeDaTabela();
    }
}
