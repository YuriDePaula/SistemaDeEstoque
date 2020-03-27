using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeEstoque.Repositorio
{
    public class RepositorioGeral<TTipo, TKey> : IRepositorio<TTipo, TKey> where TTipo : class
    {
        private DbContext _contexto;

        public RepositorioGeral(DbContext contexto)
        {
            _contexto = contexto;
        }

        public void Alterar(TTipo entidade)
        {
            _contexto.Set<TTipo>().Attach(entidade);
            _contexto.Entry(entidade).State = EntityState.Modified;
            _contexto.SaveChanges();
        }

        public void Excluir(TTipo entidade)
        {
            _contexto.Set<TTipo>().Attach(entidade);
            _contexto.Entry(entidade).State = EntityState.Deleted;
            _contexto.SaveChanges();
        }

        public void ExcluirPorId(TKey entidade)
        {
            TTipo _entidade = _contexto.Set<TTipo>().Find(entidade);
            Excluir(_entidade);
            _contexto.SaveChanges();
        }

        public void Inserir(TTipo entidade)
        {
            _contexto.Set<TTipo>().Add(entidade);
            _contexto.SaveChanges();
        }

        public List<TTipo> Selecionar()
        {
            return _contexto.Set<TTipo>().ToList();
        }

        public TTipo SelecionarPorId(TKey id)
        {
            return _contexto.Set<TTipo>().Find(id);
        }
    }
}
