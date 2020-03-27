using SistemaDeEstoque.ConfiguracaoTabelas;
using SistemaDeEstoque.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeEstoque.Context
{
    public class GerenciamentoDeEstoqueDbContext : DbContext
    {
        public GerenciamentoDeEstoqueDbContext() :base("name=GerenciamentoDeEstoqueDbContext")
        {

        }
        public DbSet<Produtos> ProdutosEstoque { get; set; }
        public DbSet<MarcaProdutos> MarcaProdutos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ConfiguracaoTabelaMarcas());
            modelBuilder.Configurations.Add(new ConfiguracaoTabelaProdutos());
        }
    }
}
