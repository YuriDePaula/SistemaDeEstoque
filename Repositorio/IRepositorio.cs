using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeEstoque.Repositorio
{
    public interface IRepositorio<TTipo, TKey> where TTipo : class
    {
        List<TTipo> Selecionar();
        TTipo SelecionarPorId(TKey id);
        void Inserir(TTipo entidade);
        void Alterar(TTipo entidade);
        void Excluir(TTipo entidade);
        void ExcluirPorId(TKey entidade);
    }
}
