using SistemaDeEstoque.Context;
using SistemaDeEstoque.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeEstoque.Repositorio
{
    public class RepositorioMarcas : RepositorioGeral<MarcaProdutos, int>
    {
        public RepositorioMarcas(GerenciamentoDeEstoqueDbContext contexto) : base(contexto)
        {

        }
    }
}
